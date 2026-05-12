// Decompiled with JetBrains decompiler
// Type: MauliModule7.DataSet1
// Assembly: MauliModule7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F045263-56C9-469F-9585-90776CDB702C
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\MauliModule7.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

#nullable disable
namespace MauliModule7;

[ToolboxItem(true)]
[XmlRoot("DataSet1")]
[DesignerCategory("code")]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class DataSet1 : DataSet
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private DataSet1.Sink_FundDataTable tableSink_Fund;
  private DataSet1.J_RegDataTable tableJ_Reg;
  private DataSet1.ShareDataTable tableShare;
  private DataSet1.NomineeDataTable tableNominee;
  private DataSet1.DataTable4DataTable tableDataTable4;
  private DataSet1.I_RegDataTable tableI_Reg;
  private DataSet1.InvestDataTable tableInvest;
  private DataSet1.IRDataTable tableIR;
  private DataSet1.DATATABLE1DataTable tableDATATABLE1;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  static DataSet1()
  {
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (DataSet1.__ENCList)
    {
      if (DataSet1.__ENCList.Count == DataSet1.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (DataSet1.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (DataSet1.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              DataSet1.__ENCList[index1] = DataSet1.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        DataSet1.__ENCList.RemoveRange(index1, checked (DataSet1.__ENCList.Count - index1));
        DataSet1.__ENCList.Capacity = DataSet1.__ENCList.Count;
      }
      DataSet1.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [DebuggerNonUserCode]
  public DataSet1()
  {
    DataSet1.__ENCAddToList((object) this);
    this._schemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.BeginInit();
    this.InitClass();
    CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
    base.Tables.CollectionChanged += changeEventHandler;
    base.Relations.CollectionChanged += changeEventHandler;
    this.EndInit();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  protected DataSet1(SerializationInfo info, StreamingContext context)
    : base(info, context, false)
  {
    DataSet1.__ENCAddToList((object) this);
    this._schemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    if (this.IsBinarySerialized(info, context))
    {
      this.InitVars(false);
      CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
      this.Tables.CollectionChanged += changeEventHandler;
      this.Relations.CollectionChanged += changeEventHandler;
    }
    else
    {
      string s = Conversions.ToString(info.GetValue("XmlSchema", typeof (string)));
      if (this.DetermineSchemaSerializationMode(info, context) == SchemaSerializationMode.IncludeSchema)
      {
        DataSet dataSet = new DataSet();
        dataSet.ReadXmlSchema((XmlReader) new XmlTextReader((TextReader) new StringReader(s)));
        if (dataSet.Tables["Sink Fund"] != null)
          base.Tables.Add((DataTable) new DataSet1.Sink_FundDataTable(dataSet.Tables["Sink Fund"]));
        if (dataSet.Tables["J Reg"] != null)
          base.Tables.Add((DataTable) new DataSet1.J_RegDataTable(dataSet.Tables["J Reg"]));
        if (dataSet.Tables[nameof (Share)] != null)
          base.Tables.Add((DataTable) new DataSet1.ShareDataTable(dataSet.Tables[nameof (Share)]));
        if (dataSet.Tables[nameof (Nominee)] != null)
          base.Tables.Add((DataTable) new DataSet1.NomineeDataTable(dataSet.Tables[nameof (Nominee)]));
        if (dataSet.Tables[nameof (DataTable4)] != null)
          base.Tables.Add((DataTable) new DataSet1.DataTable4DataTable(dataSet.Tables[nameof (DataTable4)]));
        if (dataSet.Tables["I Reg"] != null)
          base.Tables.Add((DataTable) new DataSet1.I_RegDataTable(dataSet.Tables["I Reg"]));
        if (dataSet.Tables[nameof (Invest)] != null)
          base.Tables.Add((DataTable) new DataSet1.InvestDataTable(dataSet.Tables[nameof (Invest)]));
        if (dataSet.Tables[nameof (IR)] != null)
          base.Tables.Add((DataTable) new DataSet1.IRDataTable(dataSet.Tables[nameof (IR)]));
        if (dataSet.Tables["DataTable1"] != null)
          base.Tables.Add((DataTable) new DataSet1.DATATABLE1DataTable(dataSet.Tables["DataTable1"]));
        this.DataSetName = dataSet.DataSetName;
        this.Prefix = dataSet.Prefix;
        this.Namespace = dataSet.Namespace;
        this.Locale = dataSet.Locale;
        this.CaseSensitive = dataSet.CaseSensitive;
        this.EnforceConstraints = dataSet.EnforceConstraints;
        this.Merge(dataSet, false, MissingSchemaAction.Add);
        this.InitVars();
      }
      else
        this.ReadXmlSchema((XmlReader) new XmlTextReader((TextReader) new StringReader(s)));
      this.GetSerializationData(info, context);
      CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
      base.Tables.CollectionChanged += changeEventHandler;
      this.Relations.CollectionChanged += changeEventHandler;
    }
  }

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  [Browsable(false)]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [DebuggerNonUserCode]
  public DataSet1.Sink_FundDataTable Sink_Fund => this.tableSink_Fund;

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  [DebuggerNonUserCode]
  [Browsable(false)]
  public DataSet1.J_RegDataTable J_Reg => this.tableJ_Reg;

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [DebuggerNonUserCode]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public DataSet1.ShareDataTable Share => this.tableShare;

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  [Browsable(false)]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [DebuggerNonUserCode]
  public DataSet1.NomineeDataTable Nominee => this.tableNominee;

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  [DebuggerNonUserCode]
  [Browsable(false)]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public DataSet1.DataTable4DataTable DataTable4 => this.tableDataTable4;

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  [DebuggerNonUserCode]
  public DataSet1.I_RegDataTable I_Reg => this.tableI_Reg;

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  [DebuggerNonUserCode]
  [Browsable(false)]
  public DataSet1.InvestDataTable Invest => this.tableInvest;

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [DebuggerNonUserCode]
  [Browsable(false)]
  public DataSet1.IRDataTable IR => this.tableIR;

  [DebuggerNonUserCode]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public DataSet1.DATATABLE1DataTable DATATABLE1 => this.tableDATATABLE1;

  [Browsable(true)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [DebuggerNonUserCode]
  public override SchemaSerializationMode SchemaSerializationMode
  {
    get => this._schemaSerializationMode;
    set => this._schemaSerializationMode = value;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public new DataTableCollection Tables => base.Tables;

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public new DataRelationCollection Relations => base.Relations;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  protected override void InitializeDerivedDataSet()
  {
    this.BeginInit();
    this.InitClass();
    this.EndInit();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public override DataSet Clone()
  {
    DataSet1 dataSet1 = (DataSet1) base.Clone();
    dataSet1.InitVars();
    dataSet1.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) dataSet1;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  protected override bool ShouldSerializeTables() => false;

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [DebuggerNonUserCode]
  protected override bool ShouldSerializeRelations() => false;

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [DebuggerNonUserCode]
  protected override void ReadXmlSerializable(XmlReader reader)
  {
    if (this.DetermineSchemaSerializationMode(reader) == SchemaSerializationMode.IncludeSchema)
    {
      this.Reset();
      DataSet dataSet = new DataSet();
      int num = (int) dataSet.ReadXml(reader);
      if (dataSet.Tables["Sink Fund"] != null)
        base.Tables.Add((DataTable) new DataSet1.Sink_FundDataTable(dataSet.Tables["Sink Fund"]));
      if (dataSet.Tables["J Reg"] != null)
        base.Tables.Add((DataTable) new DataSet1.J_RegDataTable(dataSet.Tables["J Reg"]));
      if (dataSet.Tables["Share"] != null)
        base.Tables.Add((DataTable) new DataSet1.ShareDataTable(dataSet.Tables["Share"]));
      if (dataSet.Tables["Nominee"] != null)
        base.Tables.Add((DataTable) new DataSet1.NomineeDataTable(dataSet.Tables["Nominee"]));
      if (dataSet.Tables["DataTable4"] != null)
        base.Tables.Add((DataTable) new DataSet1.DataTable4DataTable(dataSet.Tables["DataTable4"]));
      if (dataSet.Tables["I Reg"] != null)
        base.Tables.Add((DataTable) new DataSet1.I_RegDataTable(dataSet.Tables["I Reg"]));
      if (dataSet.Tables["Invest"] != null)
        base.Tables.Add((DataTable) new DataSet1.InvestDataTable(dataSet.Tables["Invest"]));
      if (dataSet.Tables["IR"] != null)
        base.Tables.Add((DataTable) new DataSet1.IRDataTable(dataSet.Tables["IR"]));
      if (dataSet.Tables["DataTable1"] != null)
        base.Tables.Add((DataTable) new DataSet1.DATATABLE1DataTable(dataSet.Tables["DataTable1"]));
      this.DataSetName = dataSet.DataSetName;
      this.Prefix = dataSet.Prefix;
      this.Namespace = dataSet.Namespace;
      this.Locale = dataSet.Locale;
      this.CaseSensitive = dataSet.CaseSensitive;
      this.EnforceConstraints = dataSet.EnforceConstraints;
      this.Merge(dataSet, false, MissingSchemaAction.Add);
      this.InitVars();
    }
    else
    {
      int num = (int) this.ReadXml(reader);
      this.InitVars();
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [DebuggerNonUserCode]
  protected override XmlSchema GetSchemaSerializable()
  {
    MemoryStream memoryStream = new MemoryStream();
    this.WriteXmlSchema((XmlWriter) new XmlTextWriter((Stream) memoryStream, (Encoding) null));
    memoryStream.Position = 0L;
    return XmlSchema.Read((XmlReader) new XmlTextReader((Stream) memoryStream), (ValidationEventHandler) null);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  internal void InitVars() => this.InitVars(true);

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  internal void InitVars(bool initTable)
  {
    this.tableSink_Fund = (DataSet1.Sink_FundDataTable) base.Tables["Sink Fund"];
    if (initTable && this.tableSink_Fund != null)
      this.tableSink_Fund.InitVars();
    this.tableJ_Reg = (DataSet1.J_RegDataTable) base.Tables["J Reg"];
    if (initTable && this.tableJ_Reg != null)
      this.tableJ_Reg.InitVars();
    this.tableShare = (DataSet1.ShareDataTable) base.Tables["Share"];
    if (initTable && this.tableShare != null)
      this.tableShare.InitVars();
    this.tableNominee = (DataSet1.NomineeDataTable) base.Tables["Nominee"];
    if (initTable && this.tableNominee != null)
      this.tableNominee.InitVars();
    this.tableDataTable4 = (DataSet1.DataTable4DataTable) base.Tables["DataTable4"];
    if (initTable && this.tableDataTable4 != null)
      this.tableDataTable4.InitVars();
    this.tableI_Reg = (DataSet1.I_RegDataTable) base.Tables["I Reg"];
    if (initTable && this.tableI_Reg != null)
      this.tableI_Reg.InitVars();
    this.tableInvest = (DataSet1.InvestDataTable) base.Tables["Invest"];
    if (initTable && this.tableInvest != null)
      this.tableInvest.InitVars();
    this.tableIR = (DataSet1.IRDataTable) base.Tables["IR"];
    if (initTable && this.tableIR != null)
      this.tableIR.InitVars();
    this.tableDATATABLE1 = (DataSet1.DATATABLE1DataTable) base.Tables["DataTable1"];
    if (!initTable || this.tableDATATABLE1 == null)
      return;
    this.tableDATATABLE1.InitVars();
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [DebuggerNonUserCode]
  private void InitClass()
  {
    this.DataSetName = nameof (DataSet1);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/DataSet1.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tableSink_Fund = new DataSet1.Sink_FundDataTable();
    base.Tables.Add((DataTable) this.tableSink_Fund);
    this.tableJ_Reg = new DataSet1.J_RegDataTable();
    base.Tables.Add((DataTable) this.tableJ_Reg);
    this.tableShare = new DataSet1.ShareDataTable();
    base.Tables.Add((DataTable) this.tableShare);
    this.tableNominee = new DataSet1.NomineeDataTable();
    base.Tables.Add((DataTable) this.tableNominee);
    this.tableDataTable4 = new DataSet1.DataTable4DataTable();
    base.Tables.Add((DataTable) this.tableDataTable4);
    this.tableI_Reg = new DataSet1.I_RegDataTable();
    base.Tables.Add((DataTable) this.tableI_Reg);
    this.tableInvest = new DataSet1.InvestDataTable();
    base.Tables.Add((DataTable) this.tableInvest);
    this.tableIR = new DataSet1.IRDataTable();
    base.Tables.Add((DataTable) this.tableIR);
    this.tableDATATABLE1 = new DataSet1.DATATABLE1DataTable();
    base.Tables.Add((DataTable) this.tableDATATABLE1);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializeSink_Fund() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializeJ_Reg() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializeShare() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializeNominee() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializeDataTable4() => false;

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [DebuggerNonUserCode]
  private bool ShouldSerializeI_Reg() => false;

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [DebuggerNonUserCode]
  private bool ShouldSerializeInvest() => false;

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [DebuggerNonUserCode]
  private bool ShouldSerializeIR() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializeDATATABLE1() => false;

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [DebuggerNonUserCode]
  private void SchemaChanged(object sender, CollectionChangeEventArgs e)
  {
    if (e.Action != CollectionChangeAction.Remove)
      return;
    this.InitVars();
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [DebuggerNonUserCode]
  public static XmlSchemaComplexType GetTypedDataSetSchema(XmlSchemaSet xs)
  {
    DataSet1 dataSet1 = new DataSet1();
    XmlSchemaComplexType typedDataSetSchema = new XmlSchemaComplexType();
    typedDataSetSchema.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = dataSet1.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = dataSet1.GetSchemaSerializable();
    if (xs.Contains(schemaSerializable.TargetNamespace))
    {
      MemoryStream memoryStream1 = new MemoryStream();
      MemoryStream memoryStream2 = new MemoryStream();
      try
      {
        schemaSerializable.Write((Stream) memoryStream1);
        IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
        while (enumerator.MoveNext())
        {
          XmlSchema current = (XmlSchema) enumerator.Current;
          memoryStream2.SetLength(0L);
          current.Write((Stream) memoryStream2);
          if (memoryStream1.Length == memoryStream2.Length)
          {
            memoryStream1.Position = 0L;
            memoryStream2.Position = 0L;
            do
              ;
            while (memoryStream1.Position != memoryStream1.Length && memoryStream1.ReadByte() == memoryStream2.ReadByte());
            if (memoryStream1.Position == memoryStream1.Length)
              return typedDataSetSchema;
          }
        }
      }
      finally
      {
        memoryStream1?.Close();
        memoryStream2?.Close();
      }
    }
    xs.Add(schemaSerializable);
    return typedDataSetSchema;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void Sink_FundRowChangeEventHandler(
    object sender,
    DataSet1.Sink_FundRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void J_RegRowChangeEventHandler(object sender, DataSet1.J_RegRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void ShareRowChangeEventHandler(object sender, DataSet1.ShareRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void NomineeRowChangeEventHandler(object sender, DataSet1.NomineeRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void DataTable4RowChangeEventHandler(
    object sender,
    DataSet1.DataTable4RowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void I_RegRowChangeEventHandler(object sender, DataSet1.I_RegRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void InvestRowChangeEventHandler(object sender, DataSet1.InvestRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void IRRowChangeEventHandler(object sender, DataSet1.IRRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void DATATABLE1RowChangeEventHandler(
    object sender,
    DataSet1.DATATABLE1RowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class Sink_FundDataTable : TypedTableBase<DataSet1.Sink_FundRow>
  {
    private static List<WeakReference> __ENCList = new List<WeakReference>();
    private DataColumn columnMemId;
    private DataColumn columnSFDate;
    private DataColumn columnSFno;
    private DataColumn columnCont;
    private DataColumn columnSFTotal;
    private DataColumn columnCDOI;
    private DataColumn columnCSRNO;
    private DataColumn columnCamount;
    private DataColumn columnRemark;
    private DataColumn columnMemName;
    private DataColumn columnMemRegn;
    private DataColumn columnFlatNo;
    private DataColumn _columnMember_CostofFlat;
    private DataColumn _columnMember_Constcost;
    private DataColumn columnSFCont;

    [DebuggerNonUserCode]
    static Sink_FundDataTable()
    {
    }

    [DebuggerNonUserCode]
    private static void __ENCAddToList(object value)
    {
      lock (DataSet1.Sink_FundDataTable.__ENCList)
      {
        if (DataSet1.Sink_FundDataTable.__ENCList.Count == DataSet1.Sink_FundDataTable.__ENCList.Capacity)
        {
          int index1 = 0;
          int num = checked (DataSet1.Sink_FundDataTable.__ENCList.Count - 1);
          int index2 = 0;
          while (index2 <= num)
          {
            if (DataSet1.Sink_FundDataTable.__ENCList[index2].IsAlive)
            {
              if (index2 != index1)
                DataSet1.Sink_FundDataTable.__ENCList[index1] = DataSet1.Sink_FundDataTable.__ENCList[index2];
              checked { ++index1; }
            }
            checked { ++index2; }
          }
          DataSet1.Sink_FundDataTable.__ENCList.RemoveRange(index1, checked (DataSet1.Sink_FundDataTable.__ENCList.Count - index1));
          DataSet1.Sink_FundDataTable.__ENCList.Capacity = DataSet1.Sink_FundDataTable.__ENCList.Count;
        }
        DataSet1.Sink_FundDataTable.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Sink_FundDataTable()
    {
      DataSet1.Sink_FundDataTable.__ENCAddToList((object) this);
      this.TableName = "Sink Fund";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal Sink_FundDataTable(DataTable table)
    {
      DataSet1.Sink_FundDataTable.__ENCAddToList((object) this);
      this.TableName = table.TableName;
      if (table.CaseSensitive != table.DataSet.CaseSensitive)
        this.CaseSensitive = table.CaseSensitive;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), false) != 0)
        this.Locale = table.Locale;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(table.Namespace, table.DataSet.Namespace, false) != 0)
        this.Namespace = table.Namespace;
      this.Prefix = table.Prefix;
      this.MinimumCapacity = table.MinimumCapacity;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected Sink_FundDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      DataSet1.Sink_FundDataTable.__ENCAddToList((object) this);
      this.InitVars();
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn MemIdColumn => this.columnMemId;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn SFDateColumn => this.columnSFDate;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn SFnoColumn => this.columnSFno;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ContColumn => this.columnCont;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn SFTotalColumn => this.columnSFTotal;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CDOIColumn => this.columnCDOI;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn CSRNOColumn => this.columnCSRNO;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn CamountColumn => this.columnCamount;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn RemarkColumn => this.columnRemark;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn MemNameColumn => this.columnMemName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn MemRegnColumn => this.columnMemRegn;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn FlatNoColumn => this.columnFlatNo;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn _Member_CostofFlatColumn => this._columnMember_CostofFlat;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn _Member_ConstcostColumn => this._columnMember_Constcost;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn SFContColumn => this.columnSFCont;

    [DebuggerNonUserCode]
    [Browsable(false)]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataSet1.Sink_FundRow this[int index] => (DataSet1.Sink_FundRow) this.Rows[index];

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event DataSet1.Sink_FundRowChangeEventHandler Sink_FundRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event DataSet1.Sink_FundRowChangeEventHandler Sink_FundRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event DataSet1.Sink_FundRowChangeEventHandler Sink_FundRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event DataSet1.Sink_FundRowChangeEventHandler Sink_FundRowDeleted;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void AddSink_FundRow(DataSet1.Sink_FundRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataSet1.Sink_FundRow AddSink_FundRow(
      string MemId,
      string SFDate,
      string SFno,
      string Cont,
      string SFTotal,
      string CDOI,
      string CSRNO,
      string Camount,
      string Remark,
      string MemName,
      string MemRegn,
      string FlatNo,
      string _Member_CostofFlat,
      string _Member_Constcost,
      string SFCont)
    {
      DataSet1.Sink_FundRow row = (DataSet1.Sink_FundRow) this.NewRow();
      object[] objArray = new object[15]
      {
        (object) MemId,
        (object) SFDate,
        (object) SFno,
        (object) Cont,
        (object) SFTotal,
        (object) CDOI,
        (object) CSRNO,
        (object) Camount,
        (object) Remark,
        (object) MemName,
        (object) MemRegn,
        (object) FlatNo,
        (object) _Member_CostofFlat,
        (object) _Member_Constcost,
        (object) SFCont
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      DataSet1.Sink_FundDataTable sinkFundDataTable = (DataSet1.Sink_FundDataTable) base.Clone();
      sinkFundDataTable.InitVars();
      return (DataTable) sinkFundDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance() => (DataTable) new DataSet1.Sink_FundDataTable();

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    internal void InitVars()
    {
      this.columnMemId = this.Columns["MemId"];
      this.columnSFDate = this.Columns["SFDate"];
      this.columnSFno = this.Columns["SFno"];
      this.columnCont = this.Columns["Cont"];
      this.columnSFTotal = this.Columns["SFTotal"];
      this.columnCDOI = this.Columns["CDOI"];
      this.columnCSRNO = this.Columns["CSRNO"];
      this.columnCamount = this.Columns["Camount"];
      this.columnRemark = this.Columns["Remark"];
      this.columnMemName = this.Columns["MemName"];
      this.columnMemRegn = this.Columns["MemRegn"];
      this.columnFlatNo = this.Columns["FlatNo"];
      this._columnMember_CostofFlat = this.Columns["Member.CostofFlat"];
      this._columnMember_Constcost = this.Columns["Member.Constcost"];
      this.columnSFCont = this.Columns["SFCont"];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    private void InitClass()
    {
      this.columnMemId = new DataColumn("MemId", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMemId);
      this.columnSFDate = new DataColumn("SFDate", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSFDate);
      this.columnSFno = new DataColumn("SFno", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSFno);
      this.columnCont = new DataColumn("Cont", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCont);
      this.columnSFTotal = new DataColumn("SFTotal", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSFTotal);
      this.columnCDOI = new DataColumn("CDOI", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCDOI);
      this.columnCSRNO = new DataColumn("CSRNO", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCSRNO);
      this.columnCamount = new DataColumn("Camount", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCamount);
      this.columnRemark = new DataColumn("Remark", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRemark);
      this.columnMemName = new DataColumn("MemName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMemName);
      this.columnMemRegn = new DataColumn("MemRegn", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMemRegn);
      this.columnFlatNo = new DataColumn("FlatNo", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFlatNo);
      this._columnMember_CostofFlat = new DataColumn("Member.CostofFlat", typeof (string), (string) null, MappingType.Element);
      this._columnMember_CostofFlat.ExtendedProperties.Add((object) "Generator_ColumnVarNameInTable", (object) "_columnMember_CostofFlat");
      this._columnMember_CostofFlat.ExtendedProperties.Add((object) "Generator_UserColumnName", (object) "Member.CostofFlat");
      this.Columns.Add(this._columnMember_CostofFlat);
      this._columnMember_Constcost = new DataColumn("Member.Constcost", typeof (string), (string) null, MappingType.Element);
      this._columnMember_Constcost.ExtendedProperties.Add((object) "Generator_ColumnVarNameInTable", (object) "_columnMember_Constcost");
      this._columnMember_Constcost.ExtendedProperties.Add((object) "Generator_UserColumnName", (object) "Member.Constcost");
      this.Columns.Add(this._columnMember_Constcost);
      this.columnSFCont = new DataColumn("SFCont", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSFCont);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataSet1.Sink_FundRow NewSink_FundRow() => (DataSet1.Sink_FundRow) this.NewRow();

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new DataSet1.Sink_FundRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (DataSet1.Sink_FundRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      if (this.Sink_FundRowChangedEvent == null)
        return;
      DataSet1.Sink_FundRowChangeEventHandler fundRowChangedEvent = this.Sink_FundRowChangedEvent;
      if (fundRowChangedEvent == null)
        return;
      fundRowChangedEvent((object) this, new DataSet1.Sink_FundRowChangeEvent((DataSet1.Sink_FundRow) e.Row, e.Action));
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      if (this.Sink_FundRowChangingEvent == null)
        return;
      DataSet1.Sink_FundRowChangeEventHandler rowChangingEvent = this.Sink_FundRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new DataSet1.Sink_FundRowChangeEvent((DataSet1.Sink_FundRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      if (this.Sink_FundRowDeletedEvent == null)
        return;
      DataSet1.Sink_FundRowChangeEventHandler fundRowDeletedEvent = this.Sink_FundRowDeletedEvent;
      if (fundRowDeletedEvent == null)
        return;
      fundRowDeletedEvent((object) this, new DataSet1.Sink_FundRowChangeEvent((DataSet1.Sink_FundRow) e.Row, e.Action));
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      if (this.Sink_FundRowDeletingEvent == null)
        return;
      DataSet1.Sink_FundRowChangeEventHandler rowDeletingEvent = this.Sink_FundRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new DataSet1.Sink_FundRowChangeEvent((DataSet1.Sink_FundRow) e.Row, e.Action));
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void RemoveSink_FundRow(DataSet1.Sink_FundRow row) => this.Rows.Remove((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      DataSet1 dataSet1 = new DataSet1();
      XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny();
      xmlSchemaAny1.Namespace = "http://www.w3.org/2001/XMLSchema";
      XmlSchemaAny xmlSchemaAny2 = xmlSchemaAny1;
      Decimal num1 = 0M;
      Decimal num2 = num1;
      xmlSchemaAny2.MinOccurs = num2;
      xmlSchemaAny1.MaxOccurs = Decimal.MaxValue;
      xmlSchemaAny1.ProcessContents = XmlSchemaContentProcessing.Lax;
      xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny1);
      XmlSchemaAny xmlSchemaAny3 = new XmlSchemaAny();
      xmlSchemaAny3.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
      XmlSchemaAny xmlSchemaAny4 = xmlSchemaAny3;
      num1 = 1M;
      Decimal num3 = num1;
      xmlSchemaAny4.MinOccurs = num3;
      xmlSchemaAny3.ProcessContents = XmlSchemaContentProcessing.Lax;
      xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny3);
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "namespace",
        FixedValue = dataSet1.Namespace
      });
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (Sink_FundDataTable)
      });
      typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dataSet1.GetSchemaSerializable();
      if (xs.Contains(schemaSerializable.TargetNamespace))
      {
        MemoryStream memoryStream1 = new MemoryStream();
        MemoryStream memoryStream2 = new MemoryStream();
        try
        {
          schemaSerializable.Write((Stream) memoryStream1);
          IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
          while (enumerator.MoveNext())
          {
            XmlSchema current = (XmlSchema) enumerator.Current;
            memoryStream2.SetLength(0L);
            current.Write((Stream) memoryStream2);
            if (memoryStream1.Length == memoryStream2.Length)
            {
              memoryStream1.Position = 0L;
              memoryStream2.Position = 0L;
              do
                ;
              while (memoryStream1.Position != memoryStream1.Length && memoryStream1.ReadByte() == memoryStream2.ReadByte());
              if (memoryStream1.Position == memoryStream1.Length)
                return typedTableSchema;
            }
          }
        }
        finally
        {
          memoryStream1?.Close();
          memoryStream2?.Close();
        }
      }
      xs.Add(schemaSerializable);
      return typedTableSchema;
    }
  }

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class J_RegDataTable : TypedTableBase<DataSet1.J_RegRow>
  {
    private static List<WeakReference> __ENCList = new List<WeakReference>();
    private DataColumn columnId;
    private DataColumn columnMemId;
    private DataColumn columnJSrno;
    private DataColumn columnMClass;
    private DataColumn columnMemName;
    private DataColumn columnRAddress;
    private DataColumn columnISrno;
    private DataColumn columnPAddress;
    private DataColumn columnMemName1;
    private DataColumn columnMemName2;
    private DataColumn columnMemName3;

    [DebuggerNonUserCode]
    static J_RegDataTable()
    {
    }

    [DebuggerNonUserCode]
    private static void __ENCAddToList(object value)
    {
      lock (DataSet1.J_RegDataTable.__ENCList)
      {
        if (DataSet1.J_RegDataTable.__ENCList.Count == DataSet1.J_RegDataTable.__ENCList.Capacity)
        {
          int index1 = 0;
          int num = checked (DataSet1.J_RegDataTable.__ENCList.Count - 1);
          int index2 = 0;
          while (index2 <= num)
          {
            if (DataSet1.J_RegDataTable.__ENCList[index2].IsAlive)
            {
              if (index2 != index1)
                DataSet1.J_RegDataTable.__ENCList[index1] = DataSet1.J_RegDataTable.__ENCList[index2];
              checked { ++index1; }
            }
            checked { ++index2; }
          }
          DataSet1.J_RegDataTable.__ENCList.RemoveRange(index1, checked (DataSet1.J_RegDataTable.__ENCList.Count - index1));
          DataSet1.J_RegDataTable.__ENCList.Capacity = DataSet1.J_RegDataTable.__ENCList.Count;
        }
        DataSet1.J_RegDataTable.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
      }
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public J_RegDataTable()
    {
      DataSet1.J_RegDataTable.__ENCAddToList((object) this);
      this.TableName = "J Reg";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal J_RegDataTable(DataTable table)
    {
      DataSet1.J_RegDataTable.__ENCAddToList((object) this);
      this.TableName = table.TableName;
      if (table.CaseSensitive != table.DataSet.CaseSensitive)
        this.CaseSensitive = table.CaseSensitive;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), false) != 0)
        this.Locale = table.Locale;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(table.Namespace, table.DataSet.Namespace, false) != 0)
        this.Namespace = table.Namespace;
      this.Prefix = table.Prefix;
      this.MinimumCapacity = table.MinimumCapacity;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected J_RegDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      DataSet1.J_RegDataTable.__ENCAddToList((object) this);
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn IdColumn => this.columnId;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn MemIdColumn => this.columnMemId;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn JSrnoColumn => this.columnJSrno;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn MClassColumn => this.columnMClass;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn MemNameColumn => this.columnMemName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn RAddressColumn => this.columnRAddress;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn ISrnoColumn => this.columnISrno;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn PAddressColumn => this.columnPAddress;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn MemName1Column => this.columnMemName1;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn MemName2Column => this.columnMemName2;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn MemName3Column => this.columnMemName3;

    [Browsable(false)]
    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataSet1.J_RegRow this[int index] => (DataSet1.J_RegRow) this.Rows[index];

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event DataSet1.J_RegRowChangeEventHandler J_RegRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event DataSet1.J_RegRowChangeEventHandler J_RegRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event DataSet1.J_RegRowChangeEventHandler J_RegRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event DataSet1.J_RegRowChangeEventHandler J_RegRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddJ_RegRow(DataSet1.J_RegRow row) => this.Rows.Add((DataRow) row);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataSet1.J_RegRow AddJ_RegRow(
      string Id,
      string MemId,
      string JSrno,
      string MClass,
      string MemName,
      string RAddress,
      string ISrno,
      string PAddress,
      string MemName1,
      string MemName2,
      string MemName3)
    {
      DataSet1.J_RegRow row = (DataSet1.J_RegRow) this.NewRow();
      object[] objArray = new object[11]
      {
        (object) Id,
        (object) MemId,
        (object) JSrno,
        (object) MClass,
        (object) MemName,
        (object) RAddress,
        (object) ISrno,
        (object) PAddress,
        (object) MemName1,
        (object) MemName2,
        (object) MemName3
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public override DataTable Clone()
    {
      DataSet1.J_RegDataTable jRegDataTable = (DataSet1.J_RegDataTable) base.Clone();
      jRegDataTable.InitVars();
      return (DataTable) jRegDataTable;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    protected override DataTable CreateInstance() => (DataTable) new DataSet1.J_RegDataTable();

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnId = this.Columns["Id"];
      this.columnMemId = this.Columns["MemId"];
      this.columnJSrno = this.Columns["JSrno"];
      this.columnMClass = this.Columns["MClass"];
      this.columnMemName = this.Columns["MemName"];
      this.columnRAddress = this.Columns["RAddress"];
      this.columnISrno = this.Columns["ISrno"];
      this.columnPAddress = this.Columns["PAddress"];
      this.columnMemName1 = this.Columns["MemName1"];
      this.columnMemName2 = this.Columns["MemName2"];
      this.columnMemName3 = this.Columns["MemName3"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnId = new DataColumn("Id", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnId);
      this.columnMemId = new DataColumn("MemId", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMemId);
      this.columnJSrno = new DataColumn("JSrno", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnJSrno);
      this.columnMClass = new DataColumn("MClass", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMClass);
      this.columnMemName = new DataColumn("MemName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMemName);
      this.columnRAddress = new DataColumn("RAddress", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRAddress);
      this.columnISrno = new DataColumn("ISrno", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnISrno);
      this.columnPAddress = new DataColumn("PAddress", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPAddress);
      this.columnMemName1 = new DataColumn("MemName1", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMemName1);
      this.columnMemName2 = new DataColumn("MemName2", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMemName2);
      this.columnMemName3 = new DataColumn("MemName3", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMemName3);
      this.columnId.AllowDBNull = false;
      this.columnMemId.AllowDBNull = false;
      this.columnJSrno.AllowDBNull = false;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataSet1.J_RegRow NewJ_RegRow() => (DataSet1.J_RegRow) this.NewRow();

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new DataSet1.J_RegRow(builder);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    protected override Type GetRowType() => typeof (DataSet1.J_RegRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      if (this.J_RegRowChangedEvent == null)
        return;
      DataSet1.J_RegRowChangeEventHandler regRowChangedEvent = this.J_RegRowChangedEvent;
      if (regRowChangedEvent == null)
        return;
      regRowChangedEvent((object) this, new DataSet1.J_RegRowChangeEvent((DataSet1.J_RegRow) e.Row, e.Action));
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      if (this.J_RegRowChangingEvent == null)
        return;
      DataSet1.J_RegRowChangeEventHandler rowChangingEvent = this.J_RegRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new DataSet1.J_RegRowChangeEvent((DataSet1.J_RegRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      if (this.J_RegRowDeletedEvent == null)
        return;
      DataSet1.J_RegRowChangeEventHandler regRowDeletedEvent = this.J_RegRowDeletedEvent;
      if (regRowDeletedEvent == null)
        return;
      regRowDeletedEvent((object) this, new DataSet1.J_RegRowChangeEvent((DataSet1.J_RegRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      if (this.J_RegRowDeletingEvent == null)
        return;
      DataSet1.J_RegRowChangeEventHandler rowDeletingEvent = this.J_RegRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new DataSet1.J_RegRowChangeEvent((DataSet1.J_RegRow) e.Row, e.Action));
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void RemoveJ_RegRow(DataSet1.J_RegRow row) => this.Rows.Remove((DataRow) row);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      DataSet1 dataSet1 = new DataSet1();
      XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny();
      xmlSchemaAny1.Namespace = "http://www.w3.org/2001/XMLSchema";
      XmlSchemaAny xmlSchemaAny2 = xmlSchemaAny1;
      Decimal num1 = 0M;
      Decimal num2 = num1;
      xmlSchemaAny2.MinOccurs = num2;
      xmlSchemaAny1.MaxOccurs = Decimal.MaxValue;
      xmlSchemaAny1.ProcessContents = XmlSchemaContentProcessing.Lax;
      xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny1);
      XmlSchemaAny xmlSchemaAny3 = new XmlSchemaAny();
      xmlSchemaAny3.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
      XmlSchemaAny xmlSchemaAny4 = xmlSchemaAny3;
      num1 = 1M;
      Decimal num3 = num1;
      xmlSchemaAny4.MinOccurs = num3;
      xmlSchemaAny3.ProcessContents = XmlSchemaContentProcessing.Lax;
      xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny3);
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "namespace",
        FixedValue = dataSet1.Namespace
      });
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (J_RegDataTable)
      });
      typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dataSet1.GetSchemaSerializable();
      if (xs.Contains(schemaSerializable.TargetNamespace))
      {
        MemoryStream memoryStream1 = new MemoryStream();
        MemoryStream memoryStream2 = new MemoryStream();
        try
        {
          schemaSerializable.Write((Stream) memoryStream1);
          IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
          while (enumerator.MoveNext())
          {
            XmlSchema current = (XmlSchema) enumerator.Current;
            memoryStream2.SetLength(0L);
            current.Write((Stream) memoryStream2);
            if (memoryStream1.Length == memoryStream2.Length)
            {
              memoryStream1.Position = 0L;
              memoryStream2.Position = 0L;
              do
                ;
              while (memoryStream1.Position != memoryStream1.Length && memoryStream1.ReadByte() == memoryStream2.ReadByte());
              if (memoryStream1.Position == memoryStream1.Length)
                return typedTableSchema;
            }
          }
        }
        finally
        {
          memoryStream1?.Close();
          memoryStream2?.Close();
        }
      }
      xs.Add(schemaSerializable);
      return typedTableSchema;
    }
  }

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class ShareDataTable : TypedTableBase<DataSet1.ShareRow>
  {
    private static List<WeakReference> __ENCList = new List<WeakReference>();
    private DataColumn columnId;
    private DataColumn columnMemId;
    private DataColumn columnSsrno;
    private DataColumn columnScertno;
    private DataColumn columnSDOI;
    private DataColumn columnSharefrom;
    private DataColumn columnShareto;
    private DataColumn columnSdop;
    private DataColumn columnSamount;
    private DataColumn columnSharetrf;
    private DataColumn columnsamountbal;
    private DataColumn columnsrnotrf;
    private DataColumn columnMemRegn;
    private DataColumn columnMemName;
    private DataColumn columnRAddress;
    private DataColumn columnSpart;
    private DataColumn columnMemName1;
    private DataColumn columnMemName2;
    private DataColumn columnMemName3;

    [DebuggerNonUserCode]
    static ShareDataTable()
    {
    }

    [DebuggerNonUserCode]
    private static void __ENCAddToList(object value)
    {
      lock (DataSet1.ShareDataTable.__ENCList)
      {
        if (DataSet1.ShareDataTable.__ENCList.Count == DataSet1.ShareDataTable.__ENCList.Capacity)
        {
          int index1 = 0;
          int num = checked (DataSet1.ShareDataTable.__ENCList.Count - 1);
          int index2 = 0;
          while (index2 <= num)
          {
            if (DataSet1.ShareDataTable.__ENCList[index2].IsAlive)
            {
              if (index2 != index1)
                DataSet1.ShareDataTable.__ENCList[index1] = DataSet1.ShareDataTable.__ENCList[index2];
              checked { ++index1; }
            }
            checked { ++index2; }
          }
          DataSet1.ShareDataTable.__ENCList.RemoveRange(index1, checked (DataSet1.ShareDataTable.__ENCList.Count - index1));
          DataSet1.ShareDataTable.__ENCList.Capacity = DataSet1.ShareDataTable.__ENCList.Count;
        }
        DataSet1.ShareDataTable.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
      }
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public ShareDataTable()
    {
      DataSet1.ShareDataTable.__ENCAddToList((object) this);
      this.TableName = "Share";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    internal ShareDataTable(DataTable table)
    {
      DataSet1.ShareDataTable.__ENCAddToList((object) this);
      this.TableName = table.TableName;
      if (table.CaseSensitive != table.DataSet.CaseSensitive)
        this.CaseSensitive = table.CaseSensitive;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), false) != 0)
        this.Locale = table.Locale;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(table.Namespace, table.DataSet.Namespace, false) != 0)
        this.Namespace = table.Namespace;
      this.Prefix = table.Prefix;
      this.MinimumCapacity = table.MinimumCapacity;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    protected ShareDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      DataSet1.ShareDataTable.__ENCAddToList((object) this);
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn IdColumn => this.columnId;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn MemIdColumn => this.columnMemId;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn SsrnoColumn => this.columnSsrno;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn ScertnoColumn => this.columnScertno;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn SDOIColumn => this.columnSDOI;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn SharefromColumn => this.columnSharefrom;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn SharetoColumn => this.columnShareto;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn SdopColumn => this.columnSdop;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn SamountColumn => this.columnSamount;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn SharetrfColumn => this.columnSharetrf;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn samountbalColumn => this.columnsamountbal;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn srnotrfColumn => this.columnsrnotrf;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn MemRegnColumn => this.columnMemRegn;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn MemNameColumn => this.columnMemName;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn RAddressColumn => this.columnRAddress;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn SpartColumn => this.columnSpart;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn MemName1Column => this.columnMemName1;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn MemName2Column => this.columnMemName2;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn MemName3Column => this.columnMemName3;

    [Browsable(false)]
    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataSet1.ShareRow this[int index] => (DataSet1.ShareRow) this.Rows[index];

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event DataSet1.ShareRowChangeEventHandler ShareRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event DataSet1.ShareRowChangeEventHandler ShareRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event DataSet1.ShareRowChangeEventHandler ShareRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event DataSet1.ShareRowChangeEventHandler ShareRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddShareRow(DataSet1.ShareRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataSet1.ShareRow AddShareRow(
      string Id,
      string MemId,
      string Ssrno,
      string Scertno,
      string SDOI,
      string Sharefrom,
      string Shareto,
      string Sdop,
      string Samount,
      string Sharetrf,
      string samountbal,
      string srnotrf,
      string MemRegn,
      string MemName,
      string RAddress,
      string Spart,
      string MemName1,
      string MemName2,
      string MemName3)
    {
      DataSet1.ShareRow row = (DataSet1.ShareRow) this.NewRow();
      object[] objArray = new object[19]
      {
        (object) Id,
        (object) MemId,
        (object) Ssrno,
        (object) Scertno,
        (object) SDOI,
        (object) Sharefrom,
        (object) Shareto,
        (object) Sdop,
        (object) Samount,
        (object) Sharetrf,
        (object) samountbal,
        (object) srnotrf,
        (object) MemRegn,
        (object) MemName,
        (object) RAddress,
        (object) Spart,
        (object) MemName1,
        (object) MemName2,
        (object) MemName3
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      DataSet1.ShareDataTable shareDataTable = (DataSet1.ShareDataTable) base.Clone();
      shareDataTable.InitVars();
      return (DataTable) shareDataTable;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    protected override DataTable CreateInstance() => (DataTable) new DataSet1.ShareDataTable();

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    internal void InitVars()
    {
      this.columnId = this.Columns["Id"];
      this.columnMemId = this.Columns["MemId"];
      this.columnSsrno = this.Columns["Ssrno"];
      this.columnScertno = this.Columns["Scertno"];
      this.columnSDOI = this.Columns["SDOI"];
      this.columnSharefrom = this.Columns["Sharefrom"];
      this.columnShareto = this.Columns["Shareto"];
      this.columnSdop = this.Columns["Sdop"];
      this.columnSamount = this.Columns["Samount"];
      this.columnSharetrf = this.Columns["Sharetrf"];
      this.columnsamountbal = this.Columns["samountbal"];
      this.columnsrnotrf = this.Columns["srnotrf"];
      this.columnMemRegn = this.Columns["MemRegn"];
      this.columnMemName = this.Columns["MemName"];
      this.columnRAddress = this.Columns["RAddress"];
      this.columnSpart = this.Columns["Spart"];
      this.columnMemName1 = this.Columns["MemName1"];
      this.columnMemName2 = this.Columns["MemName2"];
      this.columnMemName3 = this.Columns["MemName3"];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    private void InitClass()
    {
      this.columnId = new DataColumn("Id", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnId);
      this.columnMemId = new DataColumn("MemId", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMemId);
      this.columnSsrno = new DataColumn("Ssrno", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSsrno);
      this.columnScertno = new DataColumn("Scertno", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnScertno);
      this.columnSDOI = new DataColumn("SDOI", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSDOI);
      this.columnSharefrom = new DataColumn("Sharefrom", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSharefrom);
      this.columnShareto = new DataColumn("Shareto", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnShareto);
      this.columnSdop = new DataColumn("Sdop", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSdop);
      this.columnSamount = new DataColumn("Samount", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSamount);
      this.columnSharetrf = new DataColumn("Sharetrf", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSharetrf);
      this.columnsamountbal = new DataColumn("samountbal", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnsamountbal);
      this.columnsrnotrf = new DataColumn("srnotrf", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnsrnotrf);
      this.columnMemRegn = new DataColumn("MemRegn", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMemRegn);
      this.columnMemName = new DataColumn("MemName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMemName);
      this.columnRAddress = new DataColumn("RAddress", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRAddress);
      this.columnSpart = new DataColumn("Spart", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSpart);
      this.columnMemName1 = new DataColumn("MemName1", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMemName1);
      this.columnMemName2 = new DataColumn("MemName2", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMemName2);
      this.columnMemName3 = new DataColumn("MemName3", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMemName3);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataSet1.ShareRow NewShareRow() => (DataSet1.ShareRow) this.NewRow();

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new DataSet1.ShareRow(builder);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    protected override Type GetRowType() => typeof (DataSet1.ShareRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      if (this.ShareRowChangedEvent == null)
        return;
      DataSet1.ShareRowChangeEventHandler shareRowChangedEvent = this.ShareRowChangedEvent;
      if (shareRowChangedEvent == null)
        return;
      shareRowChangedEvent((object) this, new DataSet1.ShareRowChangeEvent((DataSet1.ShareRow) e.Row, e.Action));
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      if (this.ShareRowChangingEvent == null)
        return;
      DataSet1.ShareRowChangeEventHandler rowChangingEvent = this.ShareRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new DataSet1.ShareRowChangeEvent((DataSet1.ShareRow) e.Row, e.Action));
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      if (this.ShareRowDeletedEvent == null)
        return;
      DataSet1.ShareRowChangeEventHandler shareRowDeletedEvent = this.ShareRowDeletedEvent;
      if (shareRowDeletedEvent == null)
        return;
      shareRowDeletedEvent((object) this, new DataSet1.ShareRowChangeEvent((DataSet1.ShareRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      if (this.ShareRowDeletingEvent == null)
        return;
      DataSet1.ShareRowChangeEventHandler rowDeletingEvent = this.ShareRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new DataSet1.ShareRowChangeEvent((DataSet1.ShareRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemoveShareRow(DataSet1.ShareRow row) => this.Rows.Remove((DataRow) row);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      DataSet1 dataSet1 = new DataSet1();
      XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny();
      xmlSchemaAny1.Namespace = "http://www.w3.org/2001/XMLSchema";
      XmlSchemaAny xmlSchemaAny2 = xmlSchemaAny1;
      Decimal num1 = 0M;
      Decimal num2 = num1;
      xmlSchemaAny2.MinOccurs = num2;
      xmlSchemaAny1.MaxOccurs = Decimal.MaxValue;
      xmlSchemaAny1.ProcessContents = XmlSchemaContentProcessing.Lax;
      xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny1);
      XmlSchemaAny xmlSchemaAny3 = new XmlSchemaAny();
      xmlSchemaAny3.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
      XmlSchemaAny xmlSchemaAny4 = xmlSchemaAny3;
      num1 = 1M;
      Decimal num3 = num1;
      xmlSchemaAny4.MinOccurs = num3;
      xmlSchemaAny3.ProcessContents = XmlSchemaContentProcessing.Lax;
      xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny3);
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "namespace",
        FixedValue = dataSet1.Namespace
      });
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (ShareDataTable)
      });
      typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dataSet1.GetSchemaSerializable();
      if (xs.Contains(schemaSerializable.TargetNamespace))
      {
        MemoryStream memoryStream1 = new MemoryStream();
        MemoryStream memoryStream2 = new MemoryStream();
        try
        {
          schemaSerializable.Write((Stream) memoryStream1);
          IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
          while (enumerator.MoveNext())
          {
            XmlSchema current = (XmlSchema) enumerator.Current;
            memoryStream2.SetLength(0L);
            current.Write((Stream) memoryStream2);
            if (memoryStream1.Length == memoryStream2.Length)
            {
              memoryStream1.Position = 0L;
              memoryStream2.Position = 0L;
              do
                ;
              while (memoryStream1.Position != memoryStream1.Length && memoryStream1.ReadByte() == memoryStream2.ReadByte());
              if (memoryStream1.Position == memoryStream1.Length)
                return typedTableSchema;
            }
          }
        }
        finally
        {
          memoryStream1?.Close();
          memoryStream2?.Close();
        }
      }
      xs.Add(schemaSerializable);
      return typedTableSchema;
    }
  }

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class NomineeDataTable : TypedTableBase<DataSet1.NomineeRow>
  {
    private static List<WeakReference> __ENCList = new List<WeakReference>();
    private DataColumn columnNsrno;
    private DataColumn columnNDOR;
    private DataColumn columnMemName;
    private DataColumn columnMemName1;
    private DataColumn columnMemName2;
    private DataColumn columnMemName3;
    private DataColumn columnRAddress;
    private DataColumn columnMemRegn;
    private DataColumn columnNName;
    private DataColumn columnNaddress;
    private DataColumn columnNage;
    private DataColumn columnNDOP;
    private DataColumn columnNDOC;
    private DataColumn columnNDOE;
    private DataColumn columnNPART;

    [DebuggerNonUserCode]
    static NomineeDataTable()
    {
    }

    [DebuggerNonUserCode]
    private static void __ENCAddToList(object value)
    {
      lock (DataSet1.NomineeDataTable.__ENCList)
      {
        if (DataSet1.NomineeDataTable.__ENCList.Count == DataSet1.NomineeDataTable.__ENCList.Capacity)
        {
          int index1 = 0;
          int num = checked (DataSet1.NomineeDataTable.__ENCList.Count - 1);
          int index2 = 0;
          while (index2 <= num)
          {
            if (DataSet1.NomineeDataTable.__ENCList[index2].IsAlive)
            {
              if (index2 != index1)
                DataSet1.NomineeDataTable.__ENCList[index1] = DataSet1.NomineeDataTable.__ENCList[index2];
              checked { ++index1; }
            }
            checked { ++index2; }
          }
          DataSet1.NomineeDataTable.__ENCList.RemoveRange(index1, checked (DataSet1.NomineeDataTable.__ENCList.Count - index1));
          DataSet1.NomineeDataTable.__ENCList.Capacity = DataSet1.NomineeDataTable.__ENCList.Count;
        }
        DataSet1.NomineeDataTable.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
      }
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public NomineeDataTable()
    {
      DataSet1.NomineeDataTable.__ENCAddToList((object) this);
      this.TableName = "Nominee";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    internal NomineeDataTable(DataTable table)
    {
      DataSet1.NomineeDataTable.__ENCAddToList((object) this);
      this.TableName = table.TableName;
      if (table.CaseSensitive != table.DataSet.CaseSensitive)
        this.CaseSensitive = table.CaseSensitive;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), false) != 0)
        this.Locale = table.Locale;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(table.Namespace, table.DataSet.Namespace, false) != 0)
        this.Namespace = table.Namespace;
      this.Prefix = table.Prefix;
      this.MinimumCapacity = table.MinimumCapacity;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    protected NomineeDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      DataSet1.NomineeDataTable.__ENCAddToList((object) this);
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn NsrnoColumn => this.columnNsrno;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn NDORColumn => this.columnNDOR;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn MemNameColumn => this.columnMemName;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn MemName1Column => this.columnMemName1;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn MemName2Column => this.columnMemName2;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn MemName3Column => this.columnMemName3;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn RAddressColumn => this.columnRAddress;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn MemRegnColumn => this.columnMemRegn;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn NNameColumn => this.columnNName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn NaddressColumn => this.columnNaddress;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn NageColumn => this.columnNage;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn NDOPColumn => this.columnNDOP;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn NDOCColumn => this.columnNDOC;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn NDOEColumn => this.columnNDOE;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn NPARTColumn => this.columnNPART;

    [DebuggerNonUserCode]
    [Browsable(false)]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int Count => this.Rows.Count;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataSet1.NomineeRow this[int index] => (DataSet1.NomineeRow) this.Rows[index];

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event DataSet1.NomineeRowChangeEventHandler NomineeRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event DataSet1.NomineeRowChangeEventHandler NomineeRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event DataSet1.NomineeRowChangeEventHandler NomineeRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event DataSet1.NomineeRowChangeEventHandler NomineeRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddNomineeRow(DataSet1.NomineeRow row) => this.Rows.Add((DataRow) row);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataSet1.NomineeRow AddNomineeRow(
      string Nsrno,
      string NDOR,
      string MemName,
      string MemName1,
      string MemName2,
      string MemName3,
      string RAddress,
      string MemRegn,
      string NName,
      string Naddress,
      string Nage,
      string NDOP,
      string NDOC,
      string NDOE,
      string NPART)
    {
      DataSet1.NomineeRow row = (DataSet1.NomineeRow) this.NewRow();
      object[] objArray = new object[15]
      {
        (object) Nsrno,
        (object) NDOR,
        (object) MemName,
        (object) MemName1,
        (object) MemName2,
        (object) MemName3,
        (object) RAddress,
        (object) MemRegn,
        (object) NName,
        (object) Naddress,
        (object) Nage,
        (object) NDOP,
        (object) NDOC,
        (object) NDOE,
        (object) NPART
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public override DataTable Clone()
    {
      DataSet1.NomineeDataTable nomineeDataTable = (DataSet1.NomineeDataTable) base.Clone();
      nomineeDataTable.InitVars();
      return (DataTable) nomineeDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance() => (DataTable) new DataSet1.NomineeDataTable();

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    internal void InitVars()
    {
      this.columnNsrno = this.Columns["Nsrno"];
      this.columnNDOR = this.Columns["NDOR"];
      this.columnMemName = this.Columns["MemName"];
      this.columnMemName1 = this.Columns["MemName1"];
      this.columnMemName2 = this.Columns["MemName2"];
      this.columnMemName3 = this.Columns["MemName3"];
      this.columnRAddress = this.Columns["RAddress"];
      this.columnMemRegn = this.Columns["MemRegn"];
      this.columnNName = this.Columns["NName"];
      this.columnNaddress = this.Columns["Naddress"];
      this.columnNage = this.Columns["Nage"];
      this.columnNDOP = this.Columns["NDOP"];
      this.columnNDOC = this.Columns["NDOC"];
      this.columnNDOE = this.Columns["NDOE"];
      this.columnNPART = this.Columns["NPART"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnNsrno = new DataColumn("Nsrno", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNsrno);
      this.columnNDOR = new DataColumn("NDOR", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNDOR);
      this.columnMemName = new DataColumn("MemName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMemName);
      this.columnMemName1 = new DataColumn("MemName1", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMemName1);
      this.columnMemName2 = new DataColumn("MemName2", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMemName2);
      this.columnMemName3 = new DataColumn("MemName3", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMemName3);
      this.columnRAddress = new DataColumn("RAddress", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRAddress);
      this.columnMemRegn = new DataColumn("MemRegn", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMemRegn);
      this.columnNName = new DataColumn("NName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNName);
      this.columnNaddress = new DataColumn("Naddress", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNaddress);
      this.columnNage = new DataColumn("Nage", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNage);
      this.columnNDOP = new DataColumn("NDOP", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNDOP);
      this.columnNDOC = new DataColumn("NDOC", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNDOC);
      this.columnNDOE = new DataColumn("NDOE", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNDOE);
      this.columnNPART = new DataColumn("NPART", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNPART);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataSet1.NomineeRow NewNomineeRow() => (DataSet1.NomineeRow) this.NewRow();

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new DataSet1.NomineeRow(builder);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    protected override Type GetRowType() => typeof (DataSet1.NomineeRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      if (this.NomineeRowChangedEvent == null)
        return;
      DataSet1.NomineeRowChangeEventHandler nomineeRowChangedEvent = this.NomineeRowChangedEvent;
      if (nomineeRowChangedEvent == null)
        return;
      nomineeRowChangedEvent((object) this, new DataSet1.NomineeRowChangeEvent((DataSet1.NomineeRow) e.Row, e.Action));
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      if (this.NomineeRowChangingEvent == null)
        return;
      DataSet1.NomineeRowChangeEventHandler rowChangingEvent = this.NomineeRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new DataSet1.NomineeRowChangeEvent((DataSet1.NomineeRow) e.Row, e.Action));
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      if (this.NomineeRowDeletedEvent == null)
        return;
      DataSet1.NomineeRowChangeEventHandler nomineeRowDeletedEvent = this.NomineeRowDeletedEvent;
      if (nomineeRowDeletedEvent == null)
        return;
      nomineeRowDeletedEvent((object) this, new DataSet1.NomineeRowChangeEvent((DataSet1.NomineeRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      if (this.NomineeRowDeletingEvent == null)
        return;
      DataSet1.NomineeRowChangeEventHandler rowDeletingEvent = this.NomineeRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new DataSet1.NomineeRowChangeEvent((DataSet1.NomineeRow) e.Row, e.Action));
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void RemoveNomineeRow(DataSet1.NomineeRow row) => this.Rows.Remove((DataRow) row);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      DataSet1 dataSet1 = new DataSet1();
      XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny();
      xmlSchemaAny1.Namespace = "http://www.w3.org/2001/XMLSchema";
      XmlSchemaAny xmlSchemaAny2 = xmlSchemaAny1;
      Decimal num1 = 0M;
      Decimal num2 = num1;
      xmlSchemaAny2.MinOccurs = num2;
      xmlSchemaAny1.MaxOccurs = Decimal.MaxValue;
      xmlSchemaAny1.ProcessContents = XmlSchemaContentProcessing.Lax;
      xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny1);
      XmlSchemaAny xmlSchemaAny3 = new XmlSchemaAny();
      xmlSchemaAny3.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
      XmlSchemaAny xmlSchemaAny4 = xmlSchemaAny3;
      num1 = 1M;
      Decimal num3 = num1;
      xmlSchemaAny4.MinOccurs = num3;
      xmlSchemaAny3.ProcessContents = XmlSchemaContentProcessing.Lax;
      xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny3);
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "namespace",
        FixedValue = dataSet1.Namespace
      });
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (NomineeDataTable)
      });
      typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dataSet1.GetSchemaSerializable();
      if (xs.Contains(schemaSerializable.TargetNamespace))
      {
        MemoryStream memoryStream1 = new MemoryStream();
        MemoryStream memoryStream2 = new MemoryStream();
        try
        {
          schemaSerializable.Write((Stream) memoryStream1);
          IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
          while (enumerator.MoveNext())
          {
            XmlSchema current = (XmlSchema) enumerator.Current;
            memoryStream2.SetLength(0L);
            current.Write((Stream) memoryStream2);
            if (memoryStream1.Length == memoryStream2.Length)
            {
              memoryStream1.Position = 0L;
              memoryStream2.Position = 0L;
              do
                ;
              while (memoryStream1.Position != memoryStream1.Length && memoryStream1.ReadByte() == memoryStream2.ReadByte());
              if (memoryStream1.Position == memoryStream1.Length)
                return typedTableSchema;
            }
          }
        }
        finally
        {
          memoryStream1?.Close();
          memoryStream2?.Close();
        }
      }
      xs.Add(schemaSerializable);
      return typedTableSchema;
    }
  }

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class DataTable4DataTable : TypedTableBase<DataSet1.DataTable4Row>
  {
    private static List<WeakReference> __ENCList = new List<WeakReference>();
    private DataColumn columnPsrno;
    private DataColumn columnsurveyno;
    private DataColumn columncitySurveno;
    private DataColumn columnTenure;
    private DataColumn columnrentpaidyear;
    private DataColumn columnAnnualgrrent;
    private DataColumn columnDisNo;
    private DataColumn columnDisFloor;
    private DataColumn columnOccupancy;
    private DataColumn columnTitalOccupancy;
    private DataColumn columnAnnualRent;
    private DataColumn columncostbldg;
    private DataColumn columncostsize;
    private DataColumn columnDOC;
    private DataColumn columnDOM;
    private DataColumn columnRemark;
    private DataColumn columnMemName;
    private DataColumn columnMemName1;
    private DataColumn columnMemName2;
    private DataColumn columnMemName3;

    [DebuggerNonUserCode]
    static DataTable4DataTable()
    {
    }

    [DebuggerNonUserCode]
    private static void __ENCAddToList(object value)
    {
      lock (DataSet1.DataTable4DataTable.__ENCList)
      {
        if (DataSet1.DataTable4DataTable.__ENCList.Count == DataSet1.DataTable4DataTable.__ENCList.Capacity)
        {
          int index1 = 0;
          int num = checked (DataSet1.DataTable4DataTable.__ENCList.Count - 1);
          int index2 = 0;
          while (index2 <= num)
          {
            if (DataSet1.DataTable4DataTable.__ENCList[index2].IsAlive)
            {
              if (index2 != index1)
                DataSet1.DataTable4DataTable.__ENCList[index1] = DataSet1.DataTable4DataTable.__ENCList[index2];
              checked { ++index1; }
            }
            checked { ++index2; }
          }
          DataSet1.DataTable4DataTable.__ENCList.RemoveRange(index1, checked (DataSet1.DataTable4DataTable.__ENCList.Count - index1));
          DataSet1.DataTable4DataTable.__ENCList.Capacity = DataSet1.DataTable4DataTable.__ENCList.Count;
        }
        DataSet1.DataTable4DataTable.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
      }
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataTable4DataTable()
    {
      DataSet1.DataTable4DataTable.__ENCAddToList((object) this);
      this.TableName = "DataTable4";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    internal DataTable4DataTable(DataTable table)
    {
      DataSet1.DataTable4DataTable.__ENCAddToList((object) this);
      this.TableName = table.TableName;
      if (table.CaseSensitive != table.DataSet.CaseSensitive)
        this.CaseSensitive = table.CaseSensitive;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), false) != 0)
        this.Locale = table.Locale;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(table.Namespace, table.DataSet.Namespace, false) != 0)
        this.Namespace = table.Namespace;
      this.Prefix = table.Prefix;
      this.MinimumCapacity = table.MinimumCapacity;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    protected DataTable4DataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      DataSet1.DataTable4DataTable.__ENCAddToList((object) this);
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn PsrnoColumn => this.columnPsrno;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn surveynoColumn => this.columnsurveyno;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn citySurvenoColumn => this.columncitySurveno;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn TenureColumn => this.columnTenure;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn rentpaidyearColumn => this.columnrentpaidyear;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn AnnualgrrentColumn => this.columnAnnualgrrent;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DisNoColumn => this.columnDisNo;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DisFloorColumn => this.columnDisFloor;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn OccupancyColumn => this.columnOccupancy;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn TitalOccupancyColumn => this.columnTitalOccupancy;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn AnnualRentColumn => this.columnAnnualRent;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn costbldgColumn => this.columncostbldg;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn costsizeColumn => this.columncostsize;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn DOCColumn => this.columnDOC;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DOMColumn => this.columnDOM;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn RemarkColumn => this.columnRemark;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn MemNameColumn => this.columnMemName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn MemName1Column => this.columnMemName1;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn MemName2Column => this.columnMemName2;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn MemName3Column => this.columnMemName3;

    [DebuggerNonUserCode]
    [Browsable(false)]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataSet1.DataTable4Row this[int index] => (DataSet1.DataTable4Row) this.Rows[index];

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event DataSet1.DataTable4RowChangeEventHandler DataTable4RowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event DataSet1.DataTable4RowChangeEventHandler DataTable4RowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event DataSet1.DataTable4RowChangeEventHandler DataTable4RowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event DataSet1.DataTable4RowChangeEventHandler DataTable4RowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddDataTable4Row(DataSet1.DataTable4Row row) => this.Rows.Add((DataRow) row);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataSet1.DataTable4Row AddDataTable4Row(
      string Psrno,
      string surveyno,
      string citySurveno,
      string Tenure,
      string rentpaidyear,
      string Annualgrrent,
      string DisNo,
      string DisFloor,
      string Occupancy,
      string TitalOccupancy,
      string AnnualRent,
      string costbldg,
      string costsize,
      string DOC,
      string DOM,
      string Remark,
      string MemName,
      string MemName1,
      string MemName2,
      string MemName3)
    {
      DataSet1.DataTable4Row row = (DataSet1.DataTable4Row) this.NewRow();
      object[] objArray = new object[20]
      {
        (object) Psrno,
        (object) surveyno,
        (object) citySurveno,
        (object) Tenure,
        (object) rentpaidyear,
        (object) Annualgrrent,
        (object) DisNo,
        (object) DisFloor,
        (object) Occupancy,
        (object) TitalOccupancy,
        (object) AnnualRent,
        (object) costbldg,
        (object) costsize,
        (object) DOC,
        (object) DOM,
        (object) Remark,
        (object) MemName,
        (object) MemName1,
        (object) MemName2,
        (object) MemName3
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public override DataTable Clone()
    {
      DataSet1.DataTable4DataTable dataTable4DataTable = (DataSet1.DataTable4DataTable) base.Clone();
      dataTable4DataTable.InitVars();
      return (DataTable) dataTable4DataTable;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    protected override DataTable CreateInstance() => (DataTable) new DataSet1.DataTable4DataTable();

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnPsrno = this.Columns["Psrno"];
      this.columnsurveyno = this.Columns["surveyno"];
      this.columncitySurveno = this.Columns["citySurveno"];
      this.columnTenure = this.Columns["Tenure"];
      this.columnrentpaidyear = this.Columns["rentpaidyear"];
      this.columnAnnualgrrent = this.Columns["Annualgrrent"];
      this.columnDisNo = this.Columns["DisNo"];
      this.columnDisFloor = this.Columns["DisFloor"];
      this.columnOccupancy = this.Columns["Occupancy"];
      this.columnTitalOccupancy = this.Columns["TitalOccupancy"];
      this.columnAnnualRent = this.Columns["AnnualRent"];
      this.columncostbldg = this.Columns["costbldg"];
      this.columncostsize = this.Columns["costsize"];
      this.columnDOC = this.Columns["DOC"];
      this.columnDOM = this.Columns["DOM"];
      this.columnRemark = this.Columns["Remark"];
      this.columnMemName = this.Columns["MemName"];
      this.columnMemName1 = this.Columns["MemName1"];
      this.columnMemName2 = this.Columns["MemName2"];
      this.columnMemName3 = this.Columns["MemName3"];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    private void InitClass()
    {
      this.columnPsrno = new DataColumn("Psrno", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPsrno);
      this.columnsurveyno = new DataColumn("surveyno", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnsurveyno);
      this.columncitySurveno = new DataColumn("citySurveno", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columncitySurveno);
      this.columnTenure = new DataColumn("Tenure", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTenure);
      this.columnrentpaidyear = new DataColumn("rentpaidyear", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnrentpaidyear);
      this.columnAnnualgrrent = new DataColumn("Annualgrrent", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAnnualgrrent);
      this.columnDisNo = new DataColumn("DisNo", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDisNo);
      this.columnDisFloor = new DataColumn("DisFloor", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDisFloor);
      this.columnOccupancy = new DataColumn("Occupancy", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOccupancy);
      this.columnTitalOccupancy = new DataColumn("TitalOccupancy", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTitalOccupancy);
      this.columnAnnualRent = new DataColumn("AnnualRent", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAnnualRent);
      this.columncostbldg = new DataColumn("costbldg", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columncostbldg);
      this.columncostsize = new DataColumn("costsize", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columncostsize);
      this.columnDOC = new DataColumn("DOC", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDOC);
      this.columnDOM = new DataColumn("DOM", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDOM);
      this.columnRemark = new DataColumn("Remark", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRemark);
      this.columnMemName = new DataColumn("MemName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMemName);
      this.columnMemName1 = new DataColumn("MemName1", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMemName1);
      this.columnMemName2 = new DataColumn("MemName2", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMemName2);
      this.columnMemName3 = new DataColumn("MemName3", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMemName3);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataSet1.DataTable4Row NewDataTable4Row() => (DataSet1.DataTable4Row) this.NewRow();

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new DataSet1.DataTable4Row(builder);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    protected override Type GetRowType() => typeof (DataSet1.DataTable4Row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      if (this.DataTable4RowChangedEvent == null)
        return;
      DataSet1.DataTable4RowChangeEventHandler table4RowChangedEvent = this.DataTable4RowChangedEvent;
      if (table4RowChangedEvent == null)
        return;
      table4RowChangedEvent((object) this, new DataSet1.DataTable4RowChangeEvent((DataSet1.DataTable4Row) e.Row, e.Action));
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      if (this.DataTable4RowChangingEvent == null)
        return;
      DataSet1.DataTable4RowChangeEventHandler rowChangingEvent = this.DataTable4RowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new DataSet1.DataTable4RowChangeEvent((DataSet1.DataTable4Row) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      if (this.DataTable4RowDeletedEvent == null)
        return;
      DataSet1.DataTable4RowChangeEventHandler table4RowDeletedEvent = this.DataTable4RowDeletedEvent;
      if (table4RowDeletedEvent == null)
        return;
      table4RowDeletedEvent((object) this, new DataSet1.DataTable4RowChangeEvent((DataSet1.DataTable4Row) e.Row, e.Action));
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      if (this.DataTable4RowDeletingEvent == null)
        return;
      DataSet1.DataTable4RowChangeEventHandler rowDeletingEvent = this.DataTable4RowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new DataSet1.DataTable4RowChangeEvent((DataSet1.DataTable4Row) e.Row, e.Action));
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void RemoveDataTable4Row(DataSet1.DataTable4Row row) => this.Rows.Remove((DataRow) row);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      DataSet1 dataSet1 = new DataSet1();
      XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny();
      xmlSchemaAny1.Namespace = "http://www.w3.org/2001/XMLSchema";
      XmlSchemaAny xmlSchemaAny2 = xmlSchemaAny1;
      Decimal num1 = 0M;
      Decimal num2 = num1;
      xmlSchemaAny2.MinOccurs = num2;
      xmlSchemaAny1.MaxOccurs = Decimal.MaxValue;
      xmlSchemaAny1.ProcessContents = XmlSchemaContentProcessing.Lax;
      xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny1);
      XmlSchemaAny xmlSchemaAny3 = new XmlSchemaAny();
      xmlSchemaAny3.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
      XmlSchemaAny xmlSchemaAny4 = xmlSchemaAny3;
      num1 = 1M;
      Decimal num3 = num1;
      xmlSchemaAny4.MinOccurs = num3;
      xmlSchemaAny3.ProcessContents = XmlSchemaContentProcessing.Lax;
      xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny3);
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "namespace",
        FixedValue = dataSet1.Namespace
      });
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (DataTable4DataTable)
      });
      typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dataSet1.GetSchemaSerializable();
      if (xs.Contains(schemaSerializable.TargetNamespace))
      {
        MemoryStream memoryStream1 = new MemoryStream();
        MemoryStream memoryStream2 = new MemoryStream();
        try
        {
          schemaSerializable.Write((Stream) memoryStream1);
          IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
          while (enumerator.MoveNext())
          {
            XmlSchema current = (XmlSchema) enumerator.Current;
            memoryStream2.SetLength(0L);
            current.Write((Stream) memoryStream2);
            if (memoryStream1.Length == memoryStream2.Length)
            {
              memoryStream1.Position = 0L;
              memoryStream2.Position = 0L;
              do
                ;
              while (memoryStream1.Position != memoryStream1.Length && memoryStream1.ReadByte() == memoryStream2.ReadByte());
              if (memoryStream1.Position == memoryStream1.Length)
                return typedTableSchema;
            }
          }
        }
        finally
        {
          memoryStream1?.Close();
          memoryStream2?.Close();
        }
      }
      xs.Add(schemaSerializable);
      return typedTableSchema;
    }
  }

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class I_RegDataTable : TypedTableBase<DataSet1.I_RegRow>
  {
    private static List<WeakReference> __ENCList = new List<WeakReference>();
    private DataColumn columnIsrno;
    private DataColumn _columnIreg_MemId;
    private DataColumn columnDTENTPAY;
    private DataColumn columnENTAMT;
    private DataColumn columnMemName;
    private DataColumn columnMemName1;
    private DataColumn columnMemName2;
    private DataColumn columnMemName3;
    private DataColumn columnRAddress;
    private DataColumn columnPAddress;
    private DataColumn columnOCCUPATION;
    private DataColumn columnAge;
    private DataColumn _columnNreg_MemId;
    private DataColumn columnNName;
    private DataColumn columnNaddress;
    private DataColumn columnNDOP;
    private DataColumn columnDOC;
    private DataColumn columnCReason;
    private DataColumn columnremark;
    private DataColumn _columnSreg_MemId;
    private DataColumn columnSDOI;
    private DataColumn columnSharefrom;
    private DataColumn columnShareto;
    private DataColumn columnSamount;
    private DataColumn columnScertno;
    private DataColumn columnSharetrf;
    private DataColumn columnsrnotrf;
    private DataColumn columnsamountbal;

    [DebuggerNonUserCode]
    static I_RegDataTable()
    {
    }

    [DebuggerNonUserCode]
    private static void __ENCAddToList(object value)
    {
      lock (DataSet1.I_RegDataTable.__ENCList)
      {
        if (DataSet1.I_RegDataTable.__ENCList.Count == DataSet1.I_RegDataTable.__ENCList.Capacity)
        {
          int index1 = 0;
          int num = checked (DataSet1.I_RegDataTable.__ENCList.Count - 1);
          int index2 = 0;
          while (index2 <= num)
          {
            if (DataSet1.I_RegDataTable.__ENCList[index2].IsAlive)
            {
              if (index2 != index1)
                DataSet1.I_RegDataTable.__ENCList[index1] = DataSet1.I_RegDataTable.__ENCList[index2];
              checked { ++index1; }
            }
            checked { ++index2; }
          }
          DataSet1.I_RegDataTable.__ENCList.RemoveRange(index1, checked (DataSet1.I_RegDataTable.__ENCList.Count - index1));
          DataSet1.I_RegDataTable.__ENCList.Capacity = DataSet1.I_RegDataTable.__ENCList.Count;
        }
        DataSet1.I_RegDataTable.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
      }
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public I_RegDataTable()
    {
      DataSet1.I_RegDataTable.__ENCAddToList((object) this);
      this.TableName = "I Reg";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal I_RegDataTable(DataTable table)
    {
      DataSet1.I_RegDataTable.__ENCAddToList((object) this);
      this.TableName = table.TableName;
      if (table.CaseSensitive != table.DataSet.CaseSensitive)
        this.CaseSensitive = table.CaseSensitive;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), false) != 0)
        this.Locale = table.Locale;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(table.Namespace, table.DataSet.Namespace, false) != 0)
        this.Namespace = table.Namespace;
      this.Prefix = table.Prefix;
      this.MinimumCapacity = table.MinimumCapacity;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    protected I_RegDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      DataSet1.I_RegDataTable.__ENCAddToList((object) this);
      this.InitVars();
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn IsrnoColumn => this.columnIsrno;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn _Ireg_MemIdColumn => this._columnIreg_MemId;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DTENTPAYColumn => this.columnDTENTPAY;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ENTAMTColumn => this.columnENTAMT;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn MemNameColumn => this.columnMemName;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn MemName1Column => this.columnMemName1;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn MemName2Column => this.columnMemName2;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn MemName3Column => this.columnMemName3;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn RAddressColumn => this.columnRAddress;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn PAddressColumn => this.columnPAddress;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn OCCUPATIONColumn => this.columnOCCUPATION;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn AgeColumn => this.columnAge;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn _Nreg_MemIdColumn => this._columnNreg_MemId;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn NNameColumn => this.columnNName;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn NaddressColumn => this.columnNaddress;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn NDOPColumn => this.columnNDOP;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DOCColumn => this.columnDOC;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn CReasonColumn => this.columnCReason;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn remarkColumn => this.columnremark;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn _Sreg_MemIdColumn => this._columnSreg_MemId;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn SDOIColumn => this.columnSDOI;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn SharefromColumn => this.columnSharefrom;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn SharetoColumn => this.columnShareto;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn SamountColumn => this.columnSamount;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ScertnoColumn => this.columnScertno;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn SharetrfColumn => this.columnSharetrf;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn srnotrfColumn => this.columnsrnotrf;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn samountbalColumn => this.columnsamountbal;

    [Browsable(false)]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public int Count => this.Rows.Count;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataSet1.I_RegRow this[int index] => (DataSet1.I_RegRow) this.Rows[index];

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event DataSet1.I_RegRowChangeEventHandler I_RegRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event DataSet1.I_RegRowChangeEventHandler I_RegRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event DataSet1.I_RegRowChangeEventHandler I_RegRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event DataSet1.I_RegRowChangeEventHandler I_RegRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddI_RegRow(DataSet1.I_RegRow row) => this.Rows.Add((DataRow) row);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataSet1.I_RegRow AddI_RegRow(
      string Isrno,
      string _Ireg_MemId,
      string DTENTPAY,
      string ENTAMT,
      string MemName,
      string MemName1,
      string MemName2,
      string MemName3,
      string RAddress,
      string PAddress,
      string OCCUPATION,
      string Age,
      string _Nreg_MemId,
      string NName,
      string Naddress,
      string NDOP,
      string DOC,
      string CReason,
      string remark,
      string _Sreg_MemId,
      string SDOI,
      string Sharefrom,
      string Shareto,
      string Samount,
      string Scertno,
      string Sharetrf,
      string srnotrf,
      string samountbal)
    {
      DataSet1.I_RegRow row = (DataSet1.I_RegRow) this.NewRow();
      object[] objArray = new object[28]
      {
        (object) Isrno,
        (object) _Ireg_MemId,
        (object) DTENTPAY,
        (object) ENTAMT,
        (object) MemName,
        (object) MemName1,
        (object) MemName2,
        (object) MemName3,
        (object) RAddress,
        (object) PAddress,
        (object) OCCUPATION,
        (object) Age,
        (object) _Nreg_MemId,
        (object) NName,
        (object) Naddress,
        (object) NDOP,
        (object) DOC,
        (object) CReason,
        (object) remark,
        (object) _Sreg_MemId,
        (object) SDOI,
        (object) Sharefrom,
        (object) Shareto,
        (object) Samount,
        (object) Scertno,
        (object) Sharetrf,
        (object) srnotrf,
        (object) samountbal
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public override DataTable Clone()
    {
      DataSet1.I_RegDataTable iRegDataTable = (DataSet1.I_RegDataTable) base.Clone();
      iRegDataTable.InitVars();
      return (DataTable) iRegDataTable;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    protected override DataTable CreateInstance() => (DataTable) new DataSet1.I_RegDataTable();

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnIsrno = this.Columns["Isrno"];
      this._columnIreg_MemId = this.Columns["Ireg.MemId"];
      this.columnDTENTPAY = this.Columns["DTENTPAY"];
      this.columnENTAMT = this.Columns["ENTAMT"];
      this.columnMemName = this.Columns["MemName"];
      this.columnMemName1 = this.Columns["MemName1"];
      this.columnMemName2 = this.Columns["MemName2"];
      this.columnMemName3 = this.Columns["MemName3"];
      this.columnRAddress = this.Columns["RAddress"];
      this.columnPAddress = this.Columns["PAddress"];
      this.columnOCCUPATION = this.Columns["OCCUPATION"];
      this.columnAge = this.Columns["Age"];
      this._columnNreg_MemId = this.Columns["Nreg.MemId"];
      this.columnNName = this.Columns["NName"];
      this.columnNaddress = this.Columns["Naddress"];
      this.columnNDOP = this.Columns["NDOP"];
      this.columnDOC = this.Columns["DOC"];
      this.columnCReason = this.Columns["CReason"];
      this.columnremark = this.Columns["remark"];
      this._columnSreg_MemId = this.Columns["Sreg.MemId"];
      this.columnSDOI = this.Columns["SDOI"];
      this.columnSharefrom = this.Columns["Sharefrom"];
      this.columnShareto = this.Columns["Shareto"];
      this.columnSamount = this.Columns["Samount"];
      this.columnScertno = this.Columns["Scertno"];
      this.columnSharetrf = this.Columns["Sharetrf"];
      this.columnsrnotrf = this.Columns["srnotrf"];
      this.columnsamountbal = this.Columns["samountbal"];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    private void InitClass()
    {
      this.columnIsrno = new DataColumn("Isrno", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnIsrno);
      this._columnIreg_MemId = new DataColumn("Ireg.MemId", typeof (string), (string) null, MappingType.Element);
      this._columnIreg_MemId.ExtendedProperties.Add((object) "Generator_ColumnVarNameInTable", (object) "_columnIreg_MemId");
      this._columnIreg_MemId.ExtendedProperties.Add((object) "Generator_UserColumnName", (object) "Ireg.MemId");
      this.Columns.Add(this._columnIreg_MemId);
      this.columnDTENTPAY = new DataColumn("DTENTPAY", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDTENTPAY);
      this.columnENTAMT = new DataColumn("ENTAMT", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnENTAMT);
      this.columnMemName = new DataColumn("MemName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMemName);
      this.columnMemName1 = new DataColumn("MemName1", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMemName1);
      this.columnMemName2 = new DataColumn("MemName2", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMemName2);
      this.columnMemName3 = new DataColumn("MemName3", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMemName3);
      this.columnRAddress = new DataColumn("RAddress", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRAddress);
      this.columnPAddress = new DataColumn("PAddress", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPAddress);
      this.columnOCCUPATION = new DataColumn("OCCUPATION", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOCCUPATION);
      this.columnAge = new DataColumn("Age", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAge);
      this._columnNreg_MemId = new DataColumn("Nreg.MemId", typeof (string), (string) null, MappingType.Element);
      this._columnNreg_MemId.ExtendedProperties.Add((object) "Generator_ColumnVarNameInTable", (object) "_columnNreg_MemId");
      this._columnNreg_MemId.ExtendedProperties.Add((object) "Generator_UserColumnName", (object) "Nreg.MemId");
      this.Columns.Add(this._columnNreg_MemId);
      this.columnNName = new DataColumn("NName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNName);
      this.columnNaddress = new DataColumn("Naddress", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNaddress);
      this.columnNDOP = new DataColumn("NDOP", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNDOP);
      this.columnDOC = new DataColumn("DOC", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDOC);
      this.columnCReason = new DataColumn("CReason", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCReason);
      this.columnremark = new DataColumn("remark", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnremark);
      this._columnSreg_MemId = new DataColumn("Sreg.MemId", typeof (string), (string) null, MappingType.Element);
      this._columnSreg_MemId.ExtendedProperties.Add((object) "Generator_ColumnVarNameInTable", (object) "_columnSreg_MemId");
      this._columnSreg_MemId.ExtendedProperties.Add((object) "Generator_UserColumnName", (object) "Sreg.MemId");
      this.Columns.Add(this._columnSreg_MemId);
      this.columnSDOI = new DataColumn("SDOI", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSDOI);
      this.columnSharefrom = new DataColumn("Sharefrom", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSharefrom);
      this.columnShareto = new DataColumn("Shareto", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnShareto);
      this.columnSamount = new DataColumn("Samount", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSamount);
      this.columnScertno = new DataColumn("Scertno", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnScertno);
      this.columnSharetrf = new DataColumn("Sharetrf", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSharetrf);
      this.columnsrnotrf = new DataColumn("srnotrf", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnsrnotrf);
      this.columnsamountbal = new DataColumn("samountbal", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnsamountbal);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataSet1.I_RegRow NewI_RegRow() => (DataSet1.I_RegRow) this.NewRow();

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new DataSet1.I_RegRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (DataSet1.I_RegRow);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      if (this.I_RegRowChangedEvent == null)
        return;
      DataSet1.I_RegRowChangeEventHandler regRowChangedEvent = this.I_RegRowChangedEvent;
      if (regRowChangedEvent == null)
        return;
      regRowChangedEvent((object) this, new DataSet1.I_RegRowChangeEvent((DataSet1.I_RegRow) e.Row, e.Action));
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      if (this.I_RegRowChangingEvent == null)
        return;
      DataSet1.I_RegRowChangeEventHandler rowChangingEvent = this.I_RegRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new DataSet1.I_RegRowChangeEvent((DataSet1.I_RegRow) e.Row, e.Action));
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      if (this.I_RegRowDeletedEvent == null)
        return;
      DataSet1.I_RegRowChangeEventHandler regRowDeletedEvent = this.I_RegRowDeletedEvent;
      if (regRowDeletedEvent == null)
        return;
      regRowDeletedEvent((object) this, new DataSet1.I_RegRowChangeEvent((DataSet1.I_RegRow) e.Row, e.Action));
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      if (this.I_RegRowDeletingEvent == null)
        return;
      DataSet1.I_RegRowChangeEventHandler rowDeletingEvent = this.I_RegRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new DataSet1.I_RegRowChangeEvent((DataSet1.I_RegRow) e.Row, e.Action));
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void RemoveI_RegRow(DataSet1.I_RegRow row) => this.Rows.Remove((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      DataSet1 dataSet1 = new DataSet1();
      XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny();
      xmlSchemaAny1.Namespace = "http://www.w3.org/2001/XMLSchema";
      XmlSchemaAny xmlSchemaAny2 = xmlSchemaAny1;
      Decimal num1 = 0M;
      Decimal num2 = num1;
      xmlSchemaAny2.MinOccurs = num2;
      xmlSchemaAny1.MaxOccurs = Decimal.MaxValue;
      xmlSchemaAny1.ProcessContents = XmlSchemaContentProcessing.Lax;
      xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny1);
      XmlSchemaAny xmlSchemaAny3 = new XmlSchemaAny();
      xmlSchemaAny3.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
      XmlSchemaAny xmlSchemaAny4 = xmlSchemaAny3;
      num1 = 1M;
      Decimal num3 = num1;
      xmlSchemaAny4.MinOccurs = num3;
      xmlSchemaAny3.ProcessContents = XmlSchemaContentProcessing.Lax;
      xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny3);
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "namespace",
        FixedValue = dataSet1.Namespace
      });
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (I_RegDataTable)
      });
      typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dataSet1.GetSchemaSerializable();
      if (xs.Contains(schemaSerializable.TargetNamespace))
      {
        MemoryStream memoryStream1 = new MemoryStream();
        MemoryStream memoryStream2 = new MemoryStream();
        try
        {
          schemaSerializable.Write((Stream) memoryStream1);
          IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
          while (enumerator.MoveNext())
          {
            XmlSchema current = (XmlSchema) enumerator.Current;
            memoryStream2.SetLength(0L);
            current.Write((Stream) memoryStream2);
            if (memoryStream1.Length == memoryStream2.Length)
            {
              memoryStream1.Position = 0L;
              memoryStream2.Position = 0L;
              do
                ;
              while (memoryStream1.Position != memoryStream1.Length && memoryStream1.ReadByte() == memoryStream2.ReadByte());
              if (memoryStream1.Position == memoryStream1.Length)
                return typedTableSchema;
            }
          }
        }
        finally
        {
          memoryStream1?.Close();
          memoryStream2?.Close();
        }
      }
      xs.Add(schemaSerializable);
      return typedTableSchema;
    }
  }

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class InvestDataTable : TypedTableBase<DataSet1.InvestRow>
  {
    private static List<WeakReference> __ENCList = new List<WeakReference>();
    private DataColumn columnInvSrno;
    private DataColumn columnPurDate;
    private DataColumn columnPurNo;
    private DataColumn columnPurPart;
    private DataColumn columnPurPrice;
    private DataColumn columnPurTotal;
    private DataColumn columnSaleDate;
    private DataColumn columnSaleNo;
    private DataColumn columnSalePart;
    private DataColumn columnSalePrice;
    private DataColumn columnSaleTotal;
    private DataColumn columnIntDate;
    private DataColumn columnIntEarned;
    private DataColumn columnIntAccrued;
    private DataColumn columnIntTax;
    private DataColumn columnIntTotal;

    [DebuggerNonUserCode]
    static InvestDataTable()
    {
    }

    [DebuggerNonUserCode]
    private static void __ENCAddToList(object value)
    {
      lock (DataSet1.InvestDataTable.__ENCList)
      {
        if (DataSet1.InvestDataTable.__ENCList.Count == DataSet1.InvestDataTable.__ENCList.Capacity)
        {
          int index1 = 0;
          int num = checked (DataSet1.InvestDataTable.__ENCList.Count - 1);
          int index2 = 0;
          while (index2 <= num)
          {
            if (DataSet1.InvestDataTable.__ENCList[index2].IsAlive)
            {
              if (index2 != index1)
                DataSet1.InvestDataTable.__ENCList[index1] = DataSet1.InvestDataTable.__ENCList[index2];
              checked { ++index1; }
            }
            checked { ++index2; }
          }
          DataSet1.InvestDataTable.__ENCList.RemoveRange(index1, checked (DataSet1.InvestDataTable.__ENCList.Count - index1));
          DataSet1.InvestDataTable.__ENCList.Capacity = DataSet1.InvestDataTable.__ENCList.Count;
        }
        DataSet1.InvestDataTable.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
      }
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public InvestDataTable()
    {
      DataSet1.InvestDataTable.__ENCAddToList((object) this);
      this.TableName = "Invest";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    internal InvestDataTable(DataTable table)
    {
      DataSet1.InvestDataTable.__ENCAddToList((object) this);
      this.TableName = table.TableName;
      if (table.CaseSensitive != table.DataSet.CaseSensitive)
        this.CaseSensitive = table.CaseSensitive;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), false) != 0)
        this.Locale = table.Locale;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(table.Namespace, table.DataSet.Namespace, false) != 0)
        this.Namespace = table.Namespace;
      this.Prefix = table.Prefix;
      this.MinimumCapacity = table.MinimumCapacity;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    protected InvestDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      DataSet1.InvestDataTable.__ENCAddToList((object) this);
      this.InitVars();
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn InvSrnoColumn => this.columnInvSrno;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn PurDateColumn => this.columnPurDate;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn PurNoColumn => this.columnPurNo;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn PurPartColumn => this.columnPurPart;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn PurPriceColumn => this.columnPurPrice;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn PurTotalColumn => this.columnPurTotal;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn SaleDateColumn => this.columnSaleDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn SaleNoColumn => this.columnSaleNo;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn SalePartColumn => this.columnSalePart;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn SalePriceColumn => this.columnSalePrice;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn SaleTotalColumn => this.columnSaleTotal;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn IntDateColumn => this.columnIntDate;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn IntEarnedColumn => this.columnIntEarned;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn IntAccruedColumn => this.columnIntAccrued;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn IntTaxColumn => this.columnIntTax;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn IntTotalColumn => this.columnIntTotal;

    [Browsable(false)]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataSet1.InvestRow this[int index] => (DataSet1.InvestRow) this.Rows[index];

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event DataSet1.InvestRowChangeEventHandler InvestRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event DataSet1.InvestRowChangeEventHandler InvestRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event DataSet1.InvestRowChangeEventHandler InvestRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event DataSet1.InvestRowChangeEventHandler InvestRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddInvestRow(DataSet1.InvestRow row) => this.Rows.Add((DataRow) row);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataSet1.InvestRow AddInvestRow(
      string InvSrno,
      string PurDate,
      string PurNo,
      string PurPart,
      string PurPrice,
      string PurTotal,
      string SaleDate,
      string SaleNo,
      string SalePart,
      string SalePrice,
      string SaleTotal,
      string IntDate,
      string IntEarned,
      string IntAccrued,
      string IntTax,
      string IntTotal)
    {
      DataSet1.InvestRow row = (DataSet1.InvestRow) this.NewRow();
      object[] objArray = new object[16 /*0x10*/]
      {
        (object) InvSrno,
        (object) PurDate,
        (object) PurNo,
        (object) PurPart,
        (object) PurPrice,
        (object) PurTotal,
        (object) SaleDate,
        (object) SaleNo,
        (object) SalePart,
        (object) SalePrice,
        (object) SaleTotal,
        (object) IntDate,
        (object) IntEarned,
        (object) IntAccrued,
        (object) IntTax,
        (object) IntTotal
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      DataSet1.InvestDataTable investDataTable = (DataSet1.InvestDataTable) base.Clone();
      investDataTable.InitVars();
      return (DataTable) investDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance() => (DataTable) new DataSet1.InvestDataTable();

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    internal void InitVars()
    {
      this.columnInvSrno = this.Columns["InvSrno"];
      this.columnPurDate = this.Columns["PurDate"];
      this.columnPurNo = this.Columns["PurNo"];
      this.columnPurPart = this.Columns["PurPart"];
      this.columnPurPrice = this.Columns["PurPrice"];
      this.columnPurTotal = this.Columns["PurTotal"];
      this.columnSaleDate = this.Columns["SaleDate"];
      this.columnSaleNo = this.Columns["SaleNo"];
      this.columnSalePart = this.Columns["SalePart"];
      this.columnSalePrice = this.Columns["SalePrice"];
      this.columnSaleTotal = this.Columns["SaleTotal"];
      this.columnIntDate = this.Columns["IntDate"];
      this.columnIntEarned = this.Columns["IntEarned"];
      this.columnIntAccrued = this.Columns["IntAccrued"];
      this.columnIntTax = this.Columns["IntTax"];
      this.columnIntTotal = this.Columns["IntTotal"];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    private void InitClass()
    {
      this.columnInvSrno = new DataColumn("InvSrno", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInvSrno);
      this.columnPurDate = new DataColumn("PurDate", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPurDate);
      this.columnPurNo = new DataColumn("PurNo", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPurNo);
      this.columnPurPart = new DataColumn("PurPart", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPurPart);
      this.columnPurPrice = new DataColumn("PurPrice", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPurPrice);
      this.columnPurTotal = new DataColumn("PurTotal", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPurTotal);
      this.columnSaleDate = new DataColumn("SaleDate", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSaleDate);
      this.columnSaleNo = new DataColumn("SaleNo", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSaleNo);
      this.columnSalePart = new DataColumn("SalePart", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSalePart);
      this.columnSalePrice = new DataColumn("SalePrice", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSalePrice);
      this.columnSaleTotal = new DataColumn("SaleTotal", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSaleTotal);
      this.columnIntDate = new DataColumn("IntDate", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnIntDate);
      this.columnIntEarned = new DataColumn("IntEarned", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnIntEarned);
      this.columnIntAccrued = new DataColumn("IntAccrued", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnIntAccrued);
      this.columnIntTax = new DataColumn("IntTax", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnIntTax);
      this.columnIntTotal = new DataColumn("IntTotal", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnIntTotal);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataSet1.InvestRow NewInvestRow() => (DataSet1.InvestRow) this.NewRow();

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new DataSet1.InvestRow(builder);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    protected override Type GetRowType() => typeof (DataSet1.InvestRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      if (this.InvestRowChangedEvent == null)
        return;
      DataSet1.InvestRowChangeEventHandler investRowChangedEvent = this.InvestRowChangedEvent;
      if (investRowChangedEvent == null)
        return;
      investRowChangedEvent((object) this, new DataSet1.InvestRowChangeEvent((DataSet1.InvestRow) e.Row, e.Action));
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      if (this.InvestRowChangingEvent == null)
        return;
      DataSet1.InvestRowChangeEventHandler rowChangingEvent = this.InvestRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new DataSet1.InvestRowChangeEvent((DataSet1.InvestRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      if (this.InvestRowDeletedEvent == null)
        return;
      DataSet1.InvestRowChangeEventHandler investRowDeletedEvent = this.InvestRowDeletedEvent;
      if (investRowDeletedEvent == null)
        return;
      investRowDeletedEvent((object) this, new DataSet1.InvestRowChangeEvent((DataSet1.InvestRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      if (this.InvestRowDeletingEvent == null)
        return;
      DataSet1.InvestRowChangeEventHandler rowDeletingEvent = this.InvestRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new DataSet1.InvestRowChangeEvent((DataSet1.InvestRow) e.Row, e.Action));
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void RemoveInvestRow(DataSet1.InvestRow row) => this.Rows.Remove((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      DataSet1 dataSet1 = new DataSet1();
      XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny();
      xmlSchemaAny1.Namespace = "http://www.w3.org/2001/XMLSchema";
      XmlSchemaAny xmlSchemaAny2 = xmlSchemaAny1;
      Decimal num1 = 0M;
      Decimal num2 = num1;
      xmlSchemaAny2.MinOccurs = num2;
      xmlSchemaAny1.MaxOccurs = Decimal.MaxValue;
      xmlSchemaAny1.ProcessContents = XmlSchemaContentProcessing.Lax;
      xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny1);
      XmlSchemaAny xmlSchemaAny3 = new XmlSchemaAny();
      xmlSchemaAny3.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
      XmlSchemaAny xmlSchemaAny4 = xmlSchemaAny3;
      num1 = 1M;
      Decimal num3 = num1;
      xmlSchemaAny4.MinOccurs = num3;
      xmlSchemaAny3.ProcessContents = XmlSchemaContentProcessing.Lax;
      xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny3);
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "namespace",
        FixedValue = dataSet1.Namespace
      });
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (InvestDataTable)
      });
      typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dataSet1.GetSchemaSerializable();
      if (xs.Contains(schemaSerializable.TargetNamespace))
      {
        MemoryStream memoryStream1 = new MemoryStream();
        MemoryStream memoryStream2 = new MemoryStream();
        try
        {
          schemaSerializable.Write((Stream) memoryStream1);
          IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
          while (enumerator.MoveNext())
          {
            XmlSchema current = (XmlSchema) enumerator.Current;
            memoryStream2.SetLength(0L);
            current.Write((Stream) memoryStream2);
            if (memoryStream1.Length == memoryStream2.Length)
            {
              memoryStream1.Position = 0L;
              memoryStream2.Position = 0L;
              do
                ;
              while (memoryStream1.Position != memoryStream1.Length && memoryStream1.ReadByte() == memoryStream2.ReadByte());
              if (memoryStream1.Position == memoryStream1.Length)
                return typedTableSchema;
            }
          }
        }
        finally
        {
          memoryStream1?.Close();
          memoryStream2?.Close();
        }
      }
      xs.Add(schemaSerializable);
      return typedTableSchema;
    }
  }

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class IRDataTable : TypedTableBase<DataSet1.IRRow>
  {
    private static List<WeakReference> __ENCList = new List<WeakReference>();
    private DataColumn columnDC1;
    private DataColumn columnDC2;
    private DataColumn columnDC3;
    private DataColumn columnDC4;
    private DataColumn columnDC5;
    private DataColumn columnDC6;
    private DataColumn columnDC7;
    private DataColumn columnDC8;
    private DataColumn columnDC9;
    private DataColumn columnDC10;
    private DataColumn columnDC11;
    private DataColumn columnDC12;
    private DataColumn columnDC13;
    private DataColumn columnDC14;
    private DataColumn columnDC15;
    private DataColumn columnDC16;
    private DataColumn columnDC17;
    private DataColumn columnDC18;
    private DataColumn columnDC19;
    private DataColumn columnDC20;
    private DataColumn columnDC21;
    private DataColumn columnDC22;
    private DataColumn columnDC23;
    private DataColumn columnDC24;
    private DataColumn columnDC25;
    private DataColumn columnDC26;
    private DataColumn columnDC27;
    private DataColumn columnDC28;
    private DataColumn columnDC29;
    private DataColumn columnDC30;
    private DataColumn columnDC31;
    private DataColumn columnDC32;
    private DataColumn columnDC33;
    private DataColumn columnDC34;
    private DataColumn columnDC35;
    private DataColumn columnDC36;
    private DataColumn columnDC37;
    private DataColumn columnDC38;
    private DataColumn columnDC39;
    private DataColumn columnDC40;
    private DataColumn columnDC41;
    private DataColumn columnDC42;
    private DataColumn columnDC43;
    private DataColumn columnDC44;
    private DataColumn columnDC45;
    private DataColumn columnDC46;
    private DataColumn columnDC47;

    [DebuggerNonUserCode]
    static IRDataTable()
    {
    }

    [DebuggerNonUserCode]
    private static void __ENCAddToList(object value)
    {
      lock (DataSet1.IRDataTable.__ENCList)
      {
        if (DataSet1.IRDataTable.__ENCList.Count == DataSet1.IRDataTable.__ENCList.Capacity)
        {
          int index1 = 0;
          int num = checked (DataSet1.IRDataTable.__ENCList.Count - 1);
          int index2 = 0;
          while (index2 <= num)
          {
            if (DataSet1.IRDataTable.__ENCList[index2].IsAlive)
            {
              if (index2 != index1)
                DataSet1.IRDataTable.__ENCList[index1] = DataSet1.IRDataTable.__ENCList[index2];
              checked { ++index1; }
            }
            checked { ++index2; }
          }
          DataSet1.IRDataTable.__ENCList.RemoveRange(index1, checked (DataSet1.IRDataTable.__ENCList.Count - index1));
          DataSet1.IRDataTable.__ENCList.Capacity = DataSet1.IRDataTable.__ENCList.Count;
        }
        DataSet1.IRDataTable.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public IRDataTable()
    {
      DataSet1.IRDataTable.__ENCAddToList((object) this);
      this.TableName = "IR";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal IRDataTable(DataTable table)
    {
      DataSet1.IRDataTable.__ENCAddToList((object) this);
      this.TableName = table.TableName;
      if (table.CaseSensitive != table.DataSet.CaseSensitive)
        this.CaseSensitive = table.CaseSensitive;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), false) != 0)
        this.Locale = table.Locale;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(table.Namespace, table.DataSet.Namespace, false) != 0)
        this.Namespace = table.Namespace;
      this.Prefix = table.Prefix;
      this.MinimumCapacity = table.MinimumCapacity;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    protected IRDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      DataSet1.IRDataTable.__ENCAddToList((object) this);
      this.InitVars();
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn DC1Column => this.columnDC1;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn DC2Column => this.columnDC2;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DC3Column => this.columnDC3;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DC4Column => this.columnDC4;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DC5Column => this.columnDC5;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn DC6Column => this.columnDC6;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn DC7Column => this.columnDC7;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn DC8Column => this.columnDC8;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn DC9Column => this.columnDC9;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DC10Column => this.columnDC10;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DC11Column => this.columnDC11;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DC12Column => this.columnDC12;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn DC13Column => this.columnDC13;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DC14Column => this.columnDC14;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn DC15Column => this.columnDC15;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DC16Column => this.columnDC16;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn DC17Column => this.columnDC17;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DC18Column => this.columnDC18;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DC19Column => this.columnDC19;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DC20Column => this.columnDC20;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DC21Column => this.columnDC21;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DC22Column => this.columnDC22;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn DC23Column => this.columnDC23;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn DC24Column => this.columnDC24;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn DC25Column => this.columnDC25;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DC26Column => this.columnDC26;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DC27Column => this.columnDC27;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DC28Column => this.columnDC28;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DC29Column => this.columnDC29;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn DC30Column => this.columnDC30;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DC31Column => this.columnDC31;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn DC32Column => this.columnDC32;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DC33Column => this.columnDC33;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn DC34Column => this.columnDC34;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn DC35Column => this.columnDC35;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DC36Column => this.columnDC36;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn DC37Column => this.columnDC37;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn DC38Column => this.columnDC38;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn DC39Column => this.columnDC39;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn DC40Column => this.columnDC40;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DC41Column => this.columnDC41;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn DC42Column => this.columnDC42;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn DC43Column => this.columnDC43;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DC44Column => this.columnDC44;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DC45Column => this.columnDC45;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn DC46Column => this.columnDC46;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn DC47Column => this.columnDC47;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    [DebuggerNonUserCode]
    public int Count => this.Rows.Count;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataSet1.IRRow this[int index] => (DataSet1.IRRow) this.Rows[index];

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event DataSet1.IRRowChangeEventHandler IRRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event DataSet1.IRRowChangeEventHandler IRRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event DataSet1.IRRowChangeEventHandler IRRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event DataSet1.IRRowChangeEventHandler IRRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddIRRow(DataSet1.IRRow row) => this.Rows.Add((DataRow) row);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataSet1.IRRow AddIRRow(
      string DC1,
      string DC2,
      string DC3,
      string DC4,
      string DC5,
      string DC6,
      string DC7,
      string DC8,
      string DC9,
      string DC10,
      string DC11,
      string DC12,
      string DC13,
      string DC14,
      string DC15,
      string DC16,
      string DC17,
      string DC18,
      string DC19,
      string DC20,
      string DC21,
      string DC22,
      string DC23,
      string DC24,
      string DC25,
      string DC26,
      string DC27,
      string DC28,
      string DC29,
      string DC30,
      string DC31,
      string DC32,
      string DC33,
      string DC34,
      string DC35,
      string DC36,
      string DC37,
      string DC38,
      string DC39,
      string DC40,
      string DC41,
      string DC42,
      string DC43,
      string DC44,
      string DC45,
      string DC46,
      string DC47)
    {
      DataSet1.IRRow row = (DataSet1.IRRow) this.NewRow();
      object[] objArray = new object[47]
      {
        (object) DC1,
        (object) DC2,
        (object) DC3,
        (object) DC4,
        (object) DC5,
        (object) DC6,
        (object) DC7,
        (object) DC8,
        (object) DC9,
        (object) DC10,
        (object) DC11,
        (object) DC12,
        (object) DC13,
        (object) DC14,
        (object) DC15,
        (object) DC16,
        (object) DC17,
        (object) DC18,
        (object) DC19,
        (object) DC20,
        (object) DC21,
        (object) DC22,
        (object) DC23,
        (object) DC24,
        (object) DC25,
        (object) DC26,
        (object) DC27,
        (object) DC28,
        (object) DC29,
        (object) DC30,
        (object) DC31,
        (object) DC32,
        (object) DC33,
        (object) DC34,
        (object) DC35,
        (object) DC36,
        (object) DC37,
        (object) DC38,
        (object) DC39,
        (object) DC40,
        (object) DC41,
        (object) DC42,
        (object) DC43,
        (object) DC44,
        (object) DC45,
        (object) DC46,
        (object) DC47
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      DataSet1.IRDataTable irDataTable = (DataSet1.IRDataTable) base.Clone();
      irDataTable.InitVars();
      return (DataTable) irDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance() => (DataTable) new DataSet1.IRDataTable();

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnDC1 = this.Columns["DC1"];
      this.columnDC2 = this.Columns["DC2"];
      this.columnDC3 = this.Columns["DC3"];
      this.columnDC4 = this.Columns["DC4"];
      this.columnDC5 = this.Columns["DC5"];
      this.columnDC6 = this.Columns["DC6"];
      this.columnDC7 = this.Columns["DC7"];
      this.columnDC8 = this.Columns["DC8"];
      this.columnDC9 = this.Columns["DC9"];
      this.columnDC10 = this.Columns["DC10"];
      this.columnDC11 = this.Columns["DC11"];
      this.columnDC12 = this.Columns["DC12"];
      this.columnDC13 = this.Columns["DC13"];
      this.columnDC14 = this.Columns["DC14"];
      this.columnDC15 = this.Columns["DC15"];
      this.columnDC16 = this.Columns["DC16"];
      this.columnDC17 = this.Columns["DC17"];
      this.columnDC18 = this.Columns["DC18"];
      this.columnDC19 = this.Columns["DC19"];
      this.columnDC20 = this.Columns["DC20"];
      this.columnDC21 = this.Columns["DC21"];
      this.columnDC22 = this.Columns["DC22"];
      this.columnDC23 = this.Columns["DC23"];
      this.columnDC24 = this.Columns["DC24"];
      this.columnDC25 = this.Columns["DC25"];
      this.columnDC26 = this.Columns["DC26"];
      this.columnDC27 = this.Columns["DC27"];
      this.columnDC28 = this.Columns["DC28"];
      this.columnDC29 = this.Columns["DC29"];
      this.columnDC30 = this.Columns["DC30"];
      this.columnDC31 = this.Columns["DC31"];
      this.columnDC32 = this.Columns["DC32"];
      this.columnDC33 = this.Columns["DC33"];
      this.columnDC34 = this.Columns["DC34"];
      this.columnDC35 = this.Columns["DC35"];
      this.columnDC36 = this.Columns["DC36"];
      this.columnDC37 = this.Columns["DC37"];
      this.columnDC38 = this.Columns["DC38"];
      this.columnDC39 = this.Columns["DC39"];
      this.columnDC40 = this.Columns["DC40"];
      this.columnDC41 = this.Columns["DC41"];
      this.columnDC42 = this.Columns["DC42"];
      this.columnDC43 = this.Columns["DC43"];
      this.columnDC44 = this.Columns["DC44"];
      this.columnDC45 = this.Columns["DC45"];
      this.columnDC46 = this.Columns["DC46"];
      this.columnDC47 = this.Columns["DC47"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnDC1 = new DataColumn("DC1", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDC1);
      this.columnDC2 = new DataColumn("DC2", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDC2);
      this.columnDC3 = new DataColumn("DC3", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDC3);
      this.columnDC4 = new DataColumn("DC4", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDC4);
      this.columnDC5 = new DataColumn("DC5", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDC5);
      this.columnDC6 = new DataColumn("DC6", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDC6);
      this.columnDC7 = new DataColumn("DC7", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDC7);
      this.columnDC8 = new DataColumn("DC8", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDC8);
      this.columnDC9 = new DataColumn("DC9", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDC9);
      this.columnDC10 = new DataColumn("DC10", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDC10);
      this.columnDC11 = new DataColumn("DC11", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDC11);
      this.columnDC12 = new DataColumn("DC12", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDC12);
      this.columnDC13 = new DataColumn("DC13", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDC13);
      this.columnDC14 = new DataColumn("DC14", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDC14);
      this.columnDC15 = new DataColumn("DC15", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDC15);
      this.columnDC16 = new DataColumn("DC16", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDC16);
      this.columnDC17 = new DataColumn("DC17", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDC17);
      this.columnDC18 = new DataColumn("DC18", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDC18);
      this.columnDC19 = new DataColumn("DC19", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDC19);
      this.columnDC20 = new DataColumn("DC20", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDC20);
      this.columnDC21 = new DataColumn("DC21", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDC21);
      this.columnDC22 = new DataColumn("DC22", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDC22);
      this.columnDC23 = new DataColumn("DC23", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDC23);
      this.columnDC24 = new DataColumn("DC24", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDC24);
      this.columnDC25 = new DataColumn("DC25", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDC25);
      this.columnDC26 = new DataColumn("DC26", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDC26);
      this.columnDC27 = new DataColumn("DC27", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDC27);
      this.columnDC28 = new DataColumn("DC28", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDC28);
      this.columnDC29 = new DataColumn("DC29", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDC29);
      this.columnDC30 = new DataColumn("DC30", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDC30);
      this.columnDC31 = new DataColumn("DC31", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDC31);
      this.columnDC32 = new DataColumn("DC32", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDC32);
      this.columnDC33 = new DataColumn("DC33", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDC33);
      this.columnDC34 = new DataColumn("DC34", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDC34);
      this.columnDC35 = new DataColumn("DC35", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDC35);
      this.columnDC36 = new DataColumn("DC36", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDC36);
      this.columnDC37 = new DataColumn("DC37", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDC37);
      this.columnDC38 = new DataColumn("DC38", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDC38);
      this.columnDC39 = new DataColumn("DC39", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDC39);
      this.columnDC40 = new DataColumn("DC40", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDC40);
      this.columnDC41 = new DataColumn("DC41", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDC41);
      this.columnDC42 = new DataColumn("DC42", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDC42);
      this.columnDC43 = new DataColumn("DC43", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDC43);
      this.columnDC44 = new DataColumn("DC44", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDC44);
      this.columnDC45 = new DataColumn("DC45", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDC45);
      this.columnDC46 = new DataColumn("DC46", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDC46);
      this.columnDC47 = new DataColumn("DC47", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDC47);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataSet1.IRRow NewIRRow() => (DataSet1.IRRow) this.NewRow();

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new DataSet1.IRRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (DataSet1.IRRow);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      if (this.IRRowChangedEvent == null)
        return;
      DataSet1.IRRowChangeEventHandler irRowChangedEvent = this.IRRowChangedEvent;
      if (irRowChangedEvent == null)
        return;
      irRowChangedEvent((object) this, new DataSet1.IRRowChangeEvent((DataSet1.IRRow) e.Row, e.Action));
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      if (this.IRRowChangingEvent == null)
        return;
      DataSet1.IRRowChangeEventHandler rowChangingEvent = this.IRRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new DataSet1.IRRowChangeEvent((DataSet1.IRRow) e.Row, e.Action));
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      if (this.IRRowDeletedEvent == null)
        return;
      DataSet1.IRRowChangeEventHandler irRowDeletedEvent = this.IRRowDeletedEvent;
      if (irRowDeletedEvent == null)
        return;
      irRowDeletedEvent((object) this, new DataSet1.IRRowChangeEvent((DataSet1.IRRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      if (this.IRRowDeletingEvent == null)
        return;
      DataSet1.IRRowChangeEventHandler rowDeletingEvent = this.IRRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new DataSet1.IRRowChangeEvent((DataSet1.IRRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemoveIRRow(DataSet1.IRRow row) => this.Rows.Remove((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      DataSet1 dataSet1 = new DataSet1();
      XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny();
      xmlSchemaAny1.Namespace = "http://www.w3.org/2001/XMLSchema";
      XmlSchemaAny xmlSchemaAny2 = xmlSchemaAny1;
      Decimal num1 = 0M;
      Decimal num2 = num1;
      xmlSchemaAny2.MinOccurs = num2;
      xmlSchemaAny1.MaxOccurs = Decimal.MaxValue;
      xmlSchemaAny1.ProcessContents = XmlSchemaContentProcessing.Lax;
      xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny1);
      XmlSchemaAny xmlSchemaAny3 = new XmlSchemaAny();
      xmlSchemaAny3.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
      XmlSchemaAny xmlSchemaAny4 = xmlSchemaAny3;
      num1 = 1M;
      Decimal num3 = num1;
      xmlSchemaAny4.MinOccurs = num3;
      xmlSchemaAny3.ProcessContents = XmlSchemaContentProcessing.Lax;
      xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny3);
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "namespace",
        FixedValue = dataSet1.Namespace
      });
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (IRDataTable)
      });
      typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dataSet1.GetSchemaSerializable();
      if (xs.Contains(schemaSerializable.TargetNamespace))
      {
        MemoryStream memoryStream1 = new MemoryStream();
        MemoryStream memoryStream2 = new MemoryStream();
        try
        {
          schemaSerializable.Write((Stream) memoryStream1);
          IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
          while (enumerator.MoveNext())
          {
            XmlSchema current = (XmlSchema) enumerator.Current;
            memoryStream2.SetLength(0L);
            current.Write((Stream) memoryStream2);
            if (memoryStream1.Length == memoryStream2.Length)
            {
              memoryStream1.Position = 0L;
              memoryStream2.Position = 0L;
              do
                ;
              while (memoryStream1.Position != memoryStream1.Length && memoryStream1.ReadByte() == memoryStream2.ReadByte());
              if (memoryStream1.Position == memoryStream1.Length)
                return typedTableSchema;
            }
          }
        }
        finally
        {
          memoryStream1?.Close();
          memoryStream2?.Close();
        }
      }
      xs.Add(schemaSerializable);
      return typedTableSchema;
    }
  }

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class DATATABLE1DataTable : TypedTableBase<DataSet1.DATATABLE1Row>
  {
    private static List<WeakReference> __ENCList = new List<WeakReference>();
    private DataColumn columnId;
    private DataColumn columnMemId;
    private DataColumn columnJSrno;
    private DataColumn columnMClass;
    private DataColumn columnMemName;
    private DataColumn columnRAddress;
    private DataColumn columnISrno;
    private DataColumn columnPAddress;
    private DataColumn columnMemName1;
    private DataColumn columnMemName2;
    private DataColumn columnMemName3;

    [DebuggerNonUserCode]
    static DATATABLE1DataTable()
    {
    }

    [DebuggerNonUserCode]
    private static void __ENCAddToList(object value)
    {
      lock (DataSet1.DATATABLE1DataTable.__ENCList)
      {
        if (DataSet1.DATATABLE1DataTable.__ENCList.Count == DataSet1.DATATABLE1DataTable.__ENCList.Capacity)
        {
          int index1 = 0;
          int num = checked (DataSet1.DATATABLE1DataTable.__ENCList.Count - 1);
          int index2 = 0;
          while (index2 <= num)
          {
            if (DataSet1.DATATABLE1DataTable.__ENCList[index2].IsAlive)
            {
              if (index2 != index1)
                DataSet1.DATATABLE1DataTable.__ENCList[index1] = DataSet1.DATATABLE1DataTable.__ENCList[index2];
              checked { ++index1; }
            }
            checked { ++index2; }
          }
          DataSet1.DATATABLE1DataTable.__ENCList.RemoveRange(index1, checked (DataSet1.DATATABLE1DataTable.__ENCList.Count - index1));
          DataSet1.DATATABLE1DataTable.__ENCList.Capacity = DataSet1.DATATABLE1DataTable.__ENCList.Count;
        }
        DataSet1.DATATABLE1DataTable.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DATATABLE1DataTable()
    {
      DataSet1.DATATABLE1DataTable.__ENCAddToList((object) this);
      this.TableName = "DataTable1";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal DATATABLE1DataTable(DataTable table)
    {
      DataSet1.DATATABLE1DataTable.__ENCAddToList((object) this);
      this.TableName = table.TableName;
      if (table.CaseSensitive != table.DataSet.CaseSensitive)
        this.CaseSensitive = table.CaseSensitive;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), false) != 0)
        this.Locale = table.Locale;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(table.Namespace, table.DataSet.Namespace, false) != 0)
        this.Namespace = table.Namespace;
      this.Prefix = table.Prefix;
      this.MinimumCapacity = table.MinimumCapacity;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    protected DATATABLE1DataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      DataSet1.DATATABLE1DataTable.__ENCAddToList((object) this);
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn IdColumn => this.columnId;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn MemIdColumn => this.columnMemId;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn JSrnoColumn => this.columnJSrno;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn MClassColumn => this.columnMClass;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn MemNameColumn => this.columnMemName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn RAddressColumn => this.columnRAddress;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn ISrnoColumn => this.columnISrno;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn PAddressColumn => this.columnPAddress;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn MemName1Column => this.columnMemName1;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn MemName2Column => this.columnMemName2;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn MemName3Column => this.columnMemName3;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataSet1.DATATABLE1Row this[int index] => (DataSet1.DATATABLE1Row) this.Rows[index];

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event DataSet1.DATATABLE1RowChangeEventHandler DATATABLE1RowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event DataSet1.DATATABLE1RowChangeEventHandler DATATABLE1RowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event DataSet1.DATATABLE1RowChangeEventHandler DATATABLE1RowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event DataSet1.DATATABLE1RowChangeEventHandler DATATABLE1RowDeleted;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void AddDATATABLE1Row(DataSet1.DATATABLE1Row row) => this.Rows.Add((DataRow) row);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataSet1.DATATABLE1Row AddDATATABLE1Row(
      string Id,
      string MemId,
      string JSrno,
      string MClass,
      string MemName,
      string RAddress,
      string ISrno,
      string PAddress,
      string MemName1,
      string MemName2,
      string MemName3)
    {
      DataSet1.DATATABLE1Row row = (DataSet1.DATATABLE1Row) this.NewRow();
      object[] objArray = new object[11]
      {
        (object) Id,
        (object) MemId,
        (object) JSrno,
        (object) MClass,
        (object) MemName,
        (object) RAddress,
        (object) ISrno,
        (object) PAddress,
        (object) MemName1,
        (object) MemName2,
        (object) MemName3
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public override DataTable Clone()
    {
      DataSet1.DATATABLE1DataTable datatablE1DataTable = (DataSet1.DATATABLE1DataTable) base.Clone();
      datatablE1DataTable.InitVars();
      return (DataTable) datatablE1DataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance() => (DataTable) new DataSet1.DATATABLE1DataTable();

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    internal void InitVars()
    {
      this.columnId = this.Columns["Id"];
      this.columnMemId = this.Columns["MemId"];
      this.columnJSrno = this.Columns["JSrno"];
      this.columnMClass = this.Columns["MClass"];
      this.columnMemName = this.Columns["MemName"];
      this.columnRAddress = this.Columns["RAddress"];
      this.columnISrno = this.Columns["ISrno"];
      this.columnPAddress = this.Columns["PAddress"];
      this.columnMemName1 = this.Columns["MemName1"];
      this.columnMemName2 = this.Columns["MemName2"];
      this.columnMemName3 = this.Columns["MemName3"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnId = new DataColumn("Id", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnId);
      this.columnMemId = new DataColumn("MemId", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMemId);
      this.columnJSrno = new DataColumn("JSrno", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnJSrno);
      this.columnMClass = new DataColumn("MClass", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMClass);
      this.columnMemName = new DataColumn("MemName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMemName);
      this.columnRAddress = new DataColumn("RAddress", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRAddress);
      this.columnISrno = new DataColumn("ISrno", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnISrno);
      this.columnPAddress = new DataColumn("PAddress", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPAddress);
      this.columnMemName1 = new DataColumn("MemName1", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMemName1);
      this.columnMemName2 = new DataColumn("MemName2", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMemName2);
      this.columnMemName3 = new DataColumn("MemName3", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMemName3);
      this.columnId.AllowDBNull = false;
      this.columnMemId.AllowDBNull = false;
      this.columnJSrno.AllowDBNull = false;
      this.ExtendedProperties.Add((object) "Generator_RowClassName", (object) "DATATABLE1Row");
      this.ExtendedProperties.Add((object) "Generator_RowEvArgName", (object) "DATATABLE1RowChangeEvent");
      this.ExtendedProperties.Add((object) "Generator_RowEvHandlerName", (object) "DATATABLE1RowChangeEventHandler");
      this.ExtendedProperties.Add((object) "Generator_TableClassName", (object) nameof (DATATABLE1DataTable));
      this.ExtendedProperties.Add((object) "Generator_TablePropName", (object) "DATATABLE1");
      this.ExtendedProperties.Add((object) "Generator_TableVarName", (object) "tableDATATABLE1");
      this.ExtendedProperties.Add((object) "Generator_UserTableName", (object) "DataTable1");
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataSet1.DATATABLE1Row NewDATATABLE1Row() => (DataSet1.DATATABLE1Row) this.NewRow();

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new DataSet1.DATATABLE1Row(builder);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    protected override Type GetRowType() => typeof (DataSet1.DATATABLE1Row);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      if (this.DATATABLE1RowChangedEvent == null)
        return;
      DataSet1.DATATABLE1RowChangeEventHandler e1RowChangedEvent = this.DATATABLE1RowChangedEvent;
      if (e1RowChangedEvent == null)
        return;
      e1RowChangedEvent((object) this, new DataSet1.DATATABLE1RowChangeEvent((DataSet1.DATATABLE1Row) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      if (this.DATATABLE1RowChangingEvent == null)
        return;
      DataSet1.DATATABLE1RowChangeEventHandler rowChangingEvent = this.DATATABLE1RowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new DataSet1.DATATABLE1RowChangeEvent((DataSet1.DATATABLE1Row) e.Row, e.Action));
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      if (this.DATATABLE1RowDeletedEvent == null)
        return;
      DataSet1.DATATABLE1RowChangeEventHandler e1RowDeletedEvent = this.DATATABLE1RowDeletedEvent;
      if (e1RowDeletedEvent == null)
        return;
      e1RowDeletedEvent((object) this, new DataSet1.DATATABLE1RowChangeEvent((DataSet1.DATATABLE1Row) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      if (this.DATATABLE1RowDeletingEvent == null)
        return;
      DataSet1.DATATABLE1RowChangeEventHandler rowDeletingEvent = this.DATATABLE1RowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new DataSet1.DATATABLE1RowChangeEvent((DataSet1.DATATABLE1Row) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemoveDATATABLE1Row(DataSet1.DATATABLE1Row row) => this.Rows.Remove((DataRow) row);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      DataSet1 dataSet1 = new DataSet1();
      XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny();
      xmlSchemaAny1.Namespace = "http://www.w3.org/2001/XMLSchema";
      XmlSchemaAny xmlSchemaAny2 = xmlSchemaAny1;
      Decimal num1 = 0M;
      Decimal num2 = num1;
      xmlSchemaAny2.MinOccurs = num2;
      xmlSchemaAny1.MaxOccurs = Decimal.MaxValue;
      xmlSchemaAny1.ProcessContents = XmlSchemaContentProcessing.Lax;
      xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny1);
      XmlSchemaAny xmlSchemaAny3 = new XmlSchemaAny();
      xmlSchemaAny3.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
      XmlSchemaAny xmlSchemaAny4 = xmlSchemaAny3;
      num1 = 1M;
      Decimal num3 = num1;
      xmlSchemaAny4.MinOccurs = num3;
      xmlSchemaAny3.ProcessContents = XmlSchemaContentProcessing.Lax;
      xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny3);
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "namespace",
        FixedValue = dataSet1.Namespace
      });
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (DATATABLE1DataTable)
      });
      typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dataSet1.GetSchemaSerializable();
      if (xs.Contains(schemaSerializable.TargetNamespace))
      {
        MemoryStream memoryStream1 = new MemoryStream();
        MemoryStream memoryStream2 = new MemoryStream();
        try
        {
          schemaSerializable.Write((Stream) memoryStream1);
          IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
          while (enumerator.MoveNext())
          {
            XmlSchema current = (XmlSchema) enumerator.Current;
            memoryStream2.SetLength(0L);
            current.Write((Stream) memoryStream2);
            if (memoryStream1.Length == memoryStream2.Length)
            {
              memoryStream1.Position = 0L;
              memoryStream2.Position = 0L;
              do
                ;
              while (memoryStream1.Position != memoryStream1.Length && memoryStream1.ReadByte() == memoryStream2.ReadByte());
              if (memoryStream1.Position == memoryStream1.Length)
                return typedTableSchema;
            }
          }
        }
        finally
        {
          memoryStream1?.Close();
          memoryStream2?.Close();
        }
      }
      xs.Add(schemaSerializable);
      return typedTableSchema;
    }
  }

  public class Sink_FundRow : DataRow
  {
    private DataSet1.Sink_FundDataTable tableSink_Fund;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal Sink_FundRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableSink_Fund = (DataSet1.Sink_FundDataTable) this.Table;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string MemId
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableSink_Fund.MemIdColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'MemId' in table 'Sink Fund' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableSink_Fund.MemIdColumn] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string SFDate
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableSink_Fund.SFDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'SFDate' in table 'Sink Fund' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableSink_Fund.SFDateColumn] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string SFno
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableSink_Fund.SFnoColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'SFno' in table 'Sink Fund' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableSink_Fund.SFnoColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Cont
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableSink_Fund.ContColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Cont' in table 'Sink Fund' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableSink_Fund.ContColumn] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string SFTotal
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableSink_Fund.SFTotalColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'SFTotal' in table 'Sink Fund' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableSink_Fund.SFTotalColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string CDOI
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableSink_Fund.CDOIColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CDOI' in table 'Sink Fund' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableSink_Fund.CDOIColumn] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string CSRNO
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableSink_Fund.CSRNOColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CSRNO' in table 'Sink Fund' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableSink_Fund.CSRNOColumn] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string Camount
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableSink_Fund.CamountColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Camount' in table 'Sink Fund' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableSink_Fund.CamountColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Remark
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableSink_Fund.RemarkColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Remark' in table 'Sink Fund' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableSink_Fund.RemarkColumn] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string MemName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableSink_Fund.MemNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'MemName' in table 'Sink Fund' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableSink_Fund.MemNameColumn] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string MemRegn
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableSink_Fund.MemRegnColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'MemRegn' in table 'Sink Fund' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableSink_Fund.MemRegnColumn] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string FlatNo
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableSink_Fund.FlatNoColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'FlatNo' in table 'Sink Fund' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableSink_Fund.FlatNoColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string _Member_CostofFlat
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableSink_Fund._Member_CostofFlatColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Member.CostofFlat' in table 'Sink Fund' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableSink_Fund._Member_CostofFlatColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string _Member_Constcost
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableSink_Fund._Member_ConstcostColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Member.Constcost' in table 'Sink Fund' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableSink_Fund._Member_ConstcostColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string SFCont
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableSink_Fund.SFContColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'SFCont' in table 'Sink Fund' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableSink_Fund.SFContColumn] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsMemIdNull() => this.IsNull(this.tableSink_Fund.MemIdColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetMemIdNull()
    {
      this[this.tableSink_Fund.MemIdColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsSFDateNull() => this.IsNull(this.tableSink_Fund.SFDateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetSFDateNull()
    {
      this[this.tableSink_Fund.SFDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsSFnoNull() => this.IsNull(this.tableSink_Fund.SFnoColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetSFnoNull()
    {
      this[this.tableSink_Fund.SFnoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsContNull() => this.IsNull(this.tableSink_Fund.ContColumn);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetContNull()
    {
      this[this.tableSink_Fund.ContColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsSFTotalNull() => this.IsNull(this.tableSink_Fund.SFTotalColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetSFTotalNull()
    {
      this[this.tableSink_Fund.SFTotalColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsCDOINull() => this.IsNull(this.tableSink_Fund.CDOIColumn);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetCDOINull()
    {
      this[this.tableSink_Fund.CDOIColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsCSRNONull() => this.IsNull(this.tableSink_Fund.CSRNOColumn);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetCSRNONull()
    {
      this[this.tableSink_Fund.CSRNOColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsCamountNull() => this.IsNull(this.tableSink_Fund.CamountColumn);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetCamountNull()
    {
      this[this.tableSink_Fund.CamountColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsRemarkNull() => this.IsNull(this.tableSink_Fund.RemarkColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetRemarkNull()
    {
      this[this.tableSink_Fund.RemarkColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsMemNameNull() => this.IsNull(this.tableSink_Fund.MemNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetMemNameNull()
    {
      this[this.tableSink_Fund.MemNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsMemRegnNull() => this.IsNull(this.tableSink_Fund.MemRegnColumn);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetMemRegnNull()
    {
      this[this.tableSink_Fund.MemRegnColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsFlatNoNull() => this.IsNull(this.tableSink_Fund.FlatNoColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetFlatNoNull()
    {
      this[this.tableSink_Fund.FlatNoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool Is_Member_CostofFlatNull()
    {
      return this.IsNull(this.tableSink_Fund._Member_CostofFlatColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void Set_Member_CostofFlatNull()
    {
      this[this.tableSink_Fund._Member_CostofFlatColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool Is_Member_ConstcostNull()
    {
      return this.IsNull(this.tableSink_Fund._Member_ConstcostColumn);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void Set_Member_ConstcostNull()
    {
      this[this.tableSink_Fund._Member_ConstcostColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsSFContNull() => this.IsNull(this.tableSink_Fund.SFContColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetSFContNull()
    {
      this[this.tableSink_Fund.SFContColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class J_RegRow : DataRow
  {
    private DataSet1.J_RegDataTable tableJ_Reg;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    internal J_RegRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableJ_Reg = (DataSet1.J_RegDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Id
    {
      get => Conversions.ToString(this[this.tableJ_Reg.IdColumn]);
      set => this[this.tableJ_Reg.IdColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string MemId
    {
      get => Conversions.ToString(this[this.tableJ_Reg.MemIdColumn]);
      set => this[this.tableJ_Reg.MemIdColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string JSrno
    {
      get => Conversions.ToString(this[this.tableJ_Reg.JSrnoColumn]);
      set => this[this.tableJ_Reg.JSrnoColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string MClass
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableJ_Reg.MClassColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'MClass' in table 'J Reg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableJ_Reg.MClassColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string MemName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableJ_Reg.MemNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'MemName' in table 'J Reg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableJ_Reg.MemNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string RAddress
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableJ_Reg.RAddressColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'RAddress' in table 'J Reg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableJ_Reg.RAddressColumn] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string ISrno
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableJ_Reg.ISrnoColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ISrno' in table 'J Reg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableJ_Reg.ISrnoColumn] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string PAddress
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableJ_Reg.PAddressColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PAddress' in table 'J Reg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableJ_Reg.PAddressColumn] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string MemName1
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableJ_Reg.MemName1Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'MemName1' in table 'J Reg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableJ_Reg.MemName1Column] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string MemName2
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableJ_Reg.MemName2Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'MemName2' in table 'J Reg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableJ_Reg.MemName2Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string MemName3
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableJ_Reg.MemName3Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'MemName3' in table 'J Reg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableJ_Reg.MemName3Column] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsMClassNull() => this.IsNull(this.tableJ_Reg.MClassColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetMClassNull()
    {
      this[this.tableJ_Reg.MClassColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsMemNameNull() => this.IsNull(this.tableJ_Reg.MemNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetMemNameNull()
    {
      this[this.tableJ_Reg.MemNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsRAddressNull() => this.IsNull(this.tableJ_Reg.RAddressColumn);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetRAddressNull()
    {
      this[this.tableJ_Reg.RAddressColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsISrnoNull() => this.IsNull(this.tableJ_Reg.ISrnoColumn);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetISrnoNull()
    {
      this[this.tableJ_Reg.ISrnoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsPAddressNull() => this.IsNull(this.tableJ_Reg.PAddressColumn);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetPAddressNull()
    {
      this[this.tableJ_Reg.PAddressColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsMemName1Null() => this.IsNull(this.tableJ_Reg.MemName1Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetMemName1Null()
    {
      this[this.tableJ_Reg.MemName1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsMemName2Null() => this.IsNull(this.tableJ_Reg.MemName2Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetMemName2Null()
    {
      this[this.tableJ_Reg.MemName2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsMemName3Null() => this.IsNull(this.tableJ_Reg.MemName3Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetMemName3Null()
    {
      this[this.tableJ_Reg.MemName3Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class ShareRow : DataRow
  {
    private DataSet1.ShareDataTable tableShare;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal ShareRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableShare = (DataSet1.ShareDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Id
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableShare.IdColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Id' in table 'Share' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableShare.IdColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string MemId
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableShare.MemIdColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'MemId' in table 'Share' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableShare.MemIdColumn] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string Ssrno
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableShare.SsrnoColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Ssrno' in table 'Share' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableShare.SsrnoColumn] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string Scertno
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableShare.ScertnoColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Scertno' in table 'Share' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableShare.ScertnoColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string SDOI
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableShare.SDOIColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'SDOI' in table 'Share' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableShare.SDOIColumn] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string Sharefrom
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableShare.SharefromColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Sharefrom' in table 'Share' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableShare.SharefromColumn] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string Shareto
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableShare.SharetoColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Shareto' in table 'Share' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableShare.SharetoColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Sdop
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableShare.SdopColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Sdop' in table 'Share' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableShare.SdopColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Samount
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableShare.SamountColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Samount' in table 'Share' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableShare.SamountColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Sharetrf
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableShare.SharetrfColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Sharetrf' in table 'Share' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableShare.SharetrfColumn] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string samountbal
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableShare.samountbalColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'samountbal' in table 'Share' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableShare.samountbalColumn] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string srnotrf
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableShare.srnotrfColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'srnotrf' in table 'Share' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableShare.srnotrfColumn] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string MemRegn
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableShare.MemRegnColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'MemRegn' in table 'Share' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableShare.MemRegnColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string MemName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableShare.MemNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'MemName' in table 'Share' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableShare.MemNameColumn] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string RAddress
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableShare.RAddressColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'RAddress' in table 'Share' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableShare.RAddressColumn] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string Spart
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableShare.SpartColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Spart' in table 'Share' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableShare.SpartColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string MemName1
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableShare.MemName1Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'MemName1' in table 'Share' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableShare.MemName1Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string MemName2
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableShare.MemName2Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'MemName2' in table 'Share' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableShare.MemName2Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string MemName3
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableShare.MemName3Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'MemName3' in table 'Share' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableShare.MemName3Column] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsIdNull() => this.IsNull(this.tableShare.IdColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetIdNull()
    {
      this[this.tableShare.IdColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsMemIdNull() => this.IsNull(this.tableShare.MemIdColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetMemIdNull()
    {
      this[this.tableShare.MemIdColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsSsrnoNull() => this.IsNull(this.tableShare.SsrnoColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetSsrnoNull()
    {
      this[this.tableShare.SsrnoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsScertnoNull() => this.IsNull(this.tableShare.ScertnoColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetScertnoNull()
    {
      this[this.tableShare.ScertnoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsSDOINull() => this.IsNull(this.tableShare.SDOIColumn);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetSDOINull()
    {
      this[this.tableShare.SDOIColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsSharefromNull() => this.IsNull(this.tableShare.SharefromColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetSharefromNull()
    {
      this[this.tableShare.SharefromColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsSharetoNull() => this.IsNull(this.tableShare.SharetoColumn);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetSharetoNull()
    {
      this[this.tableShare.SharetoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsSdopNull() => this.IsNull(this.tableShare.SdopColumn);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetSdopNull()
    {
      this[this.tableShare.SdopColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsSamountNull() => this.IsNull(this.tableShare.SamountColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetSamountNull()
    {
      this[this.tableShare.SamountColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsSharetrfNull() => this.IsNull(this.tableShare.SharetrfColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetSharetrfNull()
    {
      this[this.tableShare.SharetrfColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IssamountbalNull() => this.IsNull(this.tableShare.samountbalColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetsamountbalNull()
    {
      this[this.tableShare.samountbalColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IssrnotrfNull() => this.IsNull(this.tableShare.srnotrfColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetsrnotrfNull()
    {
      this[this.tableShare.srnotrfColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsMemRegnNull() => this.IsNull(this.tableShare.MemRegnColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetMemRegnNull()
    {
      this[this.tableShare.MemRegnColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsMemNameNull() => this.IsNull(this.tableShare.MemNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetMemNameNull()
    {
      this[this.tableShare.MemNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsRAddressNull() => this.IsNull(this.tableShare.RAddressColumn);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetRAddressNull()
    {
      this[this.tableShare.RAddressColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsSpartNull() => this.IsNull(this.tableShare.SpartColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetSpartNull()
    {
      this[this.tableShare.SpartColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsMemName1Null() => this.IsNull(this.tableShare.MemName1Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetMemName1Null()
    {
      this[this.tableShare.MemName1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsMemName2Null() => this.IsNull(this.tableShare.MemName2Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetMemName2Null()
    {
      this[this.tableShare.MemName2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsMemName3Null() => this.IsNull(this.tableShare.MemName3Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetMemName3Null()
    {
      this[this.tableShare.MemName3Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class NomineeRow : DataRow
  {
    private DataSet1.NomineeDataTable tableNominee;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    internal NomineeRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableNominee = (DataSet1.NomineeDataTable) this.Table;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string Nsrno
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableNominee.NsrnoColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Nsrno' in table 'Nominee' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableNominee.NsrnoColumn] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string NDOR
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableNominee.NDORColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'NDOR' in table 'Nominee' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableNominee.NDORColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string MemName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableNominee.MemNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'MemName' in table 'Nominee' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableNominee.MemNameColumn] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string MemName1
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableNominee.MemName1Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'MemName1' in table 'Nominee' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableNominee.MemName1Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string MemName2
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableNominee.MemName2Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'MemName2' in table 'Nominee' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableNominee.MemName2Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string MemName3
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableNominee.MemName3Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'MemName3' in table 'Nominee' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableNominee.MemName3Column] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string RAddress
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableNominee.RAddressColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'RAddress' in table 'Nominee' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableNominee.RAddressColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string MemRegn
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableNominee.MemRegnColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'MemRegn' in table 'Nominee' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableNominee.MemRegnColumn] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string NName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableNominee.NNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'NName' in table 'Nominee' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableNominee.NNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Naddress
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableNominee.NaddressColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Naddress' in table 'Nominee' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableNominee.NaddressColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Nage
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableNominee.NageColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Nage' in table 'Nominee' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableNominee.NageColumn] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string NDOP
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableNominee.NDOPColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'NDOP' in table 'Nominee' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableNominee.NDOPColumn] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string NDOC
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableNominee.NDOCColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'NDOC' in table 'Nominee' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableNominee.NDOCColumn] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string NDOE
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableNominee.NDOEColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'NDOE' in table 'Nominee' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableNominee.NDOEColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string NPART
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableNominee.NPARTColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'NPART' in table 'Nominee' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableNominee.NPARTColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsNsrnoNull() => this.IsNull(this.tableNominee.NsrnoColumn);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetNsrnoNull()
    {
      this[this.tableNominee.NsrnoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsNDORNull() => this.IsNull(this.tableNominee.NDORColumn);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetNDORNull()
    {
      this[this.tableNominee.NDORColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsMemNameNull() => this.IsNull(this.tableNominee.MemNameColumn);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetMemNameNull()
    {
      this[this.tableNominee.MemNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsMemName1Null() => this.IsNull(this.tableNominee.MemName1Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetMemName1Null()
    {
      this[this.tableNominee.MemName1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsMemName2Null() => this.IsNull(this.tableNominee.MemName2Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetMemName2Null()
    {
      this[this.tableNominee.MemName2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsMemName3Null() => this.IsNull(this.tableNominee.MemName3Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetMemName3Null()
    {
      this[this.tableNominee.MemName3Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsRAddressNull() => this.IsNull(this.tableNominee.RAddressColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetRAddressNull()
    {
      this[this.tableNominee.RAddressColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsMemRegnNull() => this.IsNull(this.tableNominee.MemRegnColumn);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetMemRegnNull()
    {
      this[this.tableNominee.MemRegnColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsNNameNull() => this.IsNull(this.tableNominee.NNameColumn);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetNNameNull()
    {
      this[this.tableNominee.NNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsNaddressNull() => this.IsNull(this.tableNominee.NaddressColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetNaddressNull()
    {
      this[this.tableNominee.NaddressColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsNageNull() => this.IsNull(this.tableNominee.NageColumn);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetNageNull()
    {
      this[this.tableNominee.NageColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsNDOPNull() => this.IsNull(this.tableNominee.NDOPColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetNDOPNull()
    {
      this[this.tableNominee.NDOPColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsNDOCNull() => this.IsNull(this.tableNominee.NDOCColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetNDOCNull()
    {
      this[this.tableNominee.NDOCColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsNDOENull() => this.IsNull(this.tableNominee.NDOEColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetNDOENull()
    {
      this[this.tableNominee.NDOEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsNPARTNull() => this.IsNull(this.tableNominee.NPARTColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetNPARTNull()
    {
      this[this.tableNominee.NPARTColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class DataTable4Row : DataRow
  {
    private DataSet1.DataTable4DataTable tableDataTable4;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    internal DataTable4Row(DataRowBuilder rb)
      : base(rb)
    {
      this.tableDataTable4 = (DataSet1.DataTable4DataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Psrno
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableDataTable4.PsrnoColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Psrno' in table 'DataTable4' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableDataTable4.PsrnoColumn] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string surveyno
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableDataTable4.surveynoColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'surveyno' in table 'DataTable4' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableDataTable4.surveynoColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string citySurveno
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableDataTable4.citySurvenoColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'citySurveno' in table 'DataTable4' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableDataTable4.citySurvenoColumn] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string Tenure
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableDataTable4.TenureColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Tenure' in table 'DataTable4' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableDataTable4.TenureColumn] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string rentpaidyear
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableDataTable4.rentpaidyearColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'rentpaidyear' in table 'DataTable4' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableDataTable4.rentpaidyearColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Annualgrrent
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableDataTable4.AnnualgrrentColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Annualgrrent' in table 'DataTable4' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableDataTable4.AnnualgrrentColumn] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string DisNo
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableDataTable4.DisNoColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DisNo' in table 'DataTable4' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableDataTable4.DisNoColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string DisFloor
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableDataTable4.DisFloorColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DisFloor' in table 'DataTable4' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableDataTable4.DisFloorColumn] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string Occupancy
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableDataTable4.OccupancyColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Occupancy' in table 'DataTable4' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableDataTable4.OccupancyColumn] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string TitalOccupancy
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableDataTable4.TitalOccupancyColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'TitalOccupancy' in table 'DataTable4' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableDataTable4.TitalOccupancyColumn] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string AnnualRent
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableDataTable4.AnnualRentColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'AnnualRent' in table 'DataTable4' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableDataTable4.AnnualRentColumn] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string costbldg
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableDataTable4.costbldgColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'costbldg' in table 'DataTable4' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableDataTable4.costbldgColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string costsize
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableDataTable4.costsizeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'costsize' in table 'DataTable4' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableDataTable4.costsizeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string DOC
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableDataTable4.DOCColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DOC' in table 'DataTable4' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableDataTable4.DOCColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string DOM
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableDataTable4.DOMColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DOM' in table 'DataTable4' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableDataTable4.DOMColumn] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string Remark
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableDataTable4.RemarkColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Remark' in table 'DataTable4' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableDataTable4.RemarkColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string MemName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableDataTable4.MemNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'MemName' in table 'DataTable4' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableDataTable4.MemNameColumn] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string MemName1
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableDataTable4.MemName1Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'MemName1' in table 'DataTable4' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableDataTable4.MemName1Column] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string MemName2
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableDataTable4.MemName2Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'MemName2' in table 'DataTable4' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableDataTable4.MemName2Column] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string MemName3
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableDataTable4.MemName3Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'MemName3' in table 'DataTable4' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableDataTable4.MemName3Column] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsPsrnoNull() => this.IsNull(this.tableDataTable4.PsrnoColumn);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetPsrnoNull()
    {
      this[this.tableDataTable4.PsrnoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IssurveynoNull() => this.IsNull(this.tableDataTable4.surveynoColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetsurveynoNull()
    {
      this[this.tableDataTable4.surveynoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IscitySurvenoNull() => this.IsNull(this.tableDataTable4.citySurvenoColumn);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetcitySurvenoNull()
    {
      this[this.tableDataTable4.citySurvenoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsTenureNull() => this.IsNull(this.tableDataTable4.TenureColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetTenureNull()
    {
      this[this.tableDataTable4.TenureColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsrentpaidyearNull() => this.IsNull(this.tableDataTable4.rentpaidyearColumn);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetrentpaidyearNull()
    {
      this[this.tableDataTable4.rentpaidyearColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsAnnualgrrentNull() => this.IsNull(this.tableDataTable4.AnnualgrrentColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetAnnualgrrentNull()
    {
      this[this.tableDataTable4.AnnualgrrentColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsDisNoNull() => this.IsNull(this.tableDataTable4.DisNoColumn);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetDisNoNull()
    {
      this[this.tableDataTable4.DisNoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsDisFloorNull() => this.IsNull(this.tableDataTable4.DisFloorColumn);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetDisFloorNull()
    {
      this[this.tableDataTable4.DisFloorColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsOccupancyNull() => this.IsNull(this.tableDataTable4.OccupancyColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetOccupancyNull()
    {
      this[this.tableDataTable4.OccupancyColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsTitalOccupancyNull() => this.IsNull(this.tableDataTable4.TitalOccupancyColumn);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetTitalOccupancyNull()
    {
      this[this.tableDataTable4.TitalOccupancyColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsAnnualRentNull() => this.IsNull(this.tableDataTable4.AnnualRentColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetAnnualRentNull()
    {
      this[this.tableDataTable4.AnnualRentColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IscostbldgNull() => this.IsNull(this.tableDataTable4.costbldgColumn);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetcostbldgNull()
    {
      this[this.tableDataTable4.costbldgColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IscostsizeNull() => this.IsNull(this.tableDataTable4.costsizeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetcostsizeNull()
    {
      this[this.tableDataTable4.costsizeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsDOCNull() => this.IsNull(this.tableDataTable4.DOCColumn);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetDOCNull()
    {
      this[this.tableDataTable4.DOCColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsDOMNull() => this.IsNull(this.tableDataTable4.DOMColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetDOMNull()
    {
      this[this.tableDataTable4.DOMColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsRemarkNull() => this.IsNull(this.tableDataTable4.RemarkColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetRemarkNull()
    {
      this[this.tableDataTable4.RemarkColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsMemNameNull() => this.IsNull(this.tableDataTable4.MemNameColumn);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetMemNameNull()
    {
      this[this.tableDataTable4.MemNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsMemName1Null() => this.IsNull(this.tableDataTable4.MemName1Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetMemName1Null()
    {
      this[this.tableDataTable4.MemName1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsMemName2Null() => this.IsNull(this.tableDataTable4.MemName2Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetMemName2Null()
    {
      this[this.tableDataTable4.MemName2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsMemName3Null() => this.IsNull(this.tableDataTable4.MemName3Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetMemName3Null()
    {
      this[this.tableDataTable4.MemName3Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class I_RegRow : DataRow
  {
    private DataSet1.I_RegDataTable tableI_Reg;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    internal I_RegRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableI_Reg = (DataSet1.I_RegDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Isrno
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableI_Reg.IsrnoColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Isrno' in table 'I Reg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableI_Reg.IsrnoColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string _Ireg_MemId
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableI_Reg._Ireg_MemIdColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Ireg.MemId' in table 'I Reg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableI_Reg._Ireg_MemIdColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string DTENTPAY
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableI_Reg.DTENTPAYColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DTENTPAY' in table 'I Reg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableI_Reg.DTENTPAYColumn] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string ENTAMT
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableI_Reg.ENTAMTColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ENTAMT' in table 'I Reg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableI_Reg.ENTAMTColumn] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string MemName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableI_Reg.MemNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'MemName' in table 'I Reg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableI_Reg.MemNameColumn] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string MemName1
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableI_Reg.MemName1Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'MemName1' in table 'I Reg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableI_Reg.MemName1Column] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string MemName2
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableI_Reg.MemName2Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'MemName2' in table 'I Reg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableI_Reg.MemName2Column] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string MemName3
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableI_Reg.MemName3Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'MemName3' in table 'I Reg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableI_Reg.MemName3Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string RAddress
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableI_Reg.RAddressColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'RAddress' in table 'I Reg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableI_Reg.RAddressColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string PAddress
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableI_Reg.PAddressColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PAddress' in table 'I Reg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableI_Reg.PAddressColumn] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string OCCUPATION
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableI_Reg.OCCUPATIONColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'OCCUPATION' in table 'I Reg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableI_Reg.OCCUPATIONColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Age
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableI_Reg.AgeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Age' in table 'I Reg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableI_Reg.AgeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string _Nreg_MemId
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableI_Reg._Nreg_MemIdColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Nreg.MemId' in table 'I Reg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableI_Reg._Nreg_MemIdColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string NName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableI_Reg.NNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'NName' in table 'I Reg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableI_Reg.NNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Naddress
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableI_Reg.NaddressColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Naddress' in table 'I Reg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableI_Reg.NaddressColumn] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string NDOP
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableI_Reg.NDOPColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'NDOP' in table 'I Reg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableI_Reg.NDOPColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string DOC
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableI_Reg.DOCColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DOC' in table 'I Reg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableI_Reg.DOCColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string CReason
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableI_Reg.CReasonColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CReason' in table 'I Reg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableI_Reg.CReasonColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string remark
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableI_Reg.remarkColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'remark' in table 'I Reg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableI_Reg.remarkColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string _Sreg_MemId
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableI_Reg._Sreg_MemIdColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Sreg.MemId' in table 'I Reg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableI_Reg._Sreg_MemIdColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string SDOI
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableI_Reg.SDOIColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'SDOI' in table 'I Reg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableI_Reg.SDOIColumn] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string Sharefrom
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableI_Reg.SharefromColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Sharefrom' in table 'I Reg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableI_Reg.SharefromColumn] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string Shareto
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableI_Reg.SharetoColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Shareto' in table 'I Reg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableI_Reg.SharetoColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Samount
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableI_Reg.SamountColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Samount' in table 'I Reg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableI_Reg.SamountColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Scertno
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableI_Reg.ScertnoColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Scertno' in table 'I Reg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableI_Reg.ScertnoColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Sharetrf
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableI_Reg.SharetrfColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Sharetrf' in table 'I Reg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableI_Reg.SharetrfColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string srnotrf
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableI_Reg.srnotrfColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'srnotrf' in table 'I Reg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableI_Reg.srnotrfColumn] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string samountbal
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableI_Reg.samountbalColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'samountbal' in table 'I Reg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableI_Reg.samountbalColumn] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsIsrnoNull() => this.IsNull(this.tableI_Reg.IsrnoColumn);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetIsrnoNull()
    {
      this[this.tableI_Reg.IsrnoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool Is_Ireg_MemIdNull() => this.IsNull(this.tableI_Reg._Ireg_MemIdColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void Set_Ireg_MemIdNull()
    {
      this[this.tableI_Reg._Ireg_MemIdColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsDTENTPAYNull() => this.IsNull(this.tableI_Reg.DTENTPAYColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetDTENTPAYNull()
    {
      this[this.tableI_Reg.DTENTPAYColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsENTAMTNull() => this.IsNull(this.tableI_Reg.ENTAMTColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetENTAMTNull()
    {
      this[this.tableI_Reg.ENTAMTColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsMemNameNull() => this.IsNull(this.tableI_Reg.MemNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetMemNameNull()
    {
      this[this.tableI_Reg.MemNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsMemName1Null() => this.IsNull(this.tableI_Reg.MemName1Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetMemName1Null()
    {
      this[this.tableI_Reg.MemName1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsMemName2Null() => this.IsNull(this.tableI_Reg.MemName2Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetMemName2Null()
    {
      this[this.tableI_Reg.MemName2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsMemName3Null() => this.IsNull(this.tableI_Reg.MemName3Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetMemName3Null()
    {
      this[this.tableI_Reg.MemName3Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsRAddressNull() => this.IsNull(this.tableI_Reg.RAddressColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetRAddressNull()
    {
      this[this.tableI_Reg.RAddressColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsPAddressNull() => this.IsNull(this.tableI_Reg.PAddressColumn);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetPAddressNull()
    {
      this[this.tableI_Reg.PAddressColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsOCCUPATIONNull() => this.IsNull(this.tableI_Reg.OCCUPATIONColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetOCCUPATIONNull()
    {
      this[this.tableI_Reg.OCCUPATIONColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsAgeNull() => this.IsNull(this.tableI_Reg.AgeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetAgeNull()
    {
      this[this.tableI_Reg.AgeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool Is_Nreg_MemIdNull() => this.IsNull(this.tableI_Reg._Nreg_MemIdColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void Set_Nreg_MemIdNull()
    {
      this[this.tableI_Reg._Nreg_MemIdColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsNNameNull() => this.IsNull(this.tableI_Reg.NNameColumn);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetNNameNull()
    {
      this[this.tableI_Reg.NNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsNaddressNull() => this.IsNull(this.tableI_Reg.NaddressColumn);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetNaddressNull()
    {
      this[this.tableI_Reg.NaddressColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsNDOPNull() => this.IsNull(this.tableI_Reg.NDOPColumn);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetNDOPNull()
    {
      this[this.tableI_Reg.NDOPColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsDOCNull() => this.IsNull(this.tableI_Reg.DOCColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetDOCNull()
    {
      this[this.tableI_Reg.DOCColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsCReasonNull() => this.IsNull(this.tableI_Reg.CReasonColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetCReasonNull()
    {
      this[this.tableI_Reg.CReasonColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsremarkNull() => this.IsNull(this.tableI_Reg.remarkColumn);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetremarkNull()
    {
      this[this.tableI_Reg.remarkColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool Is_Sreg_MemIdNull() => this.IsNull(this.tableI_Reg._Sreg_MemIdColumn);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void Set_Sreg_MemIdNull()
    {
      this[this.tableI_Reg._Sreg_MemIdColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsSDOINull() => this.IsNull(this.tableI_Reg.SDOIColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetSDOINull()
    {
      this[this.tableI_Reg.SDOIColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsSharefromNull() => this.IsNull(this.tableI_Reg.SharefromColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetSharefromNull()
    {
      this[this.tableI_Reg.SharefromColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsSharetoNull() => this.IsNull(this.tableI_Reg.SharetoColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetSharetoNull()
    {
      this[this.tableI_Reg.SharetoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsSamountNull() => this.IsNull(this.tableI_Reg.SamountColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetSamountNull()
    {
      this[this.tableI_Reg.SamountColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsScertnoNull() => this.IsNull(this.tableI_Reg.ScertnoColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetScertnoNull()
    {
      this[this.tableI_Reg.ScertnoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsSharetrfNull() => this.IsNull(this.tableI_Reg.SharetrfColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetSharetrfNull()
    {
      this[this.tableI_Reg.SharetrfColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IssrnotrfNull() => this.IsNull(this.tableI_Reg.srnotrfColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetsrnotrfNull()
    {
      this[this.tableI_Reg.srnotrfColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IssamountbalNull() => this.IsNull(this.tableI_Reg.samountbalColumn);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetsamountbalNull()
    {
      this[this.tableI_Reg.samountbalColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class InvestRow : DataRow
  {
    private DataSet1.InvestDataTable tableInvest;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    internal InvestRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableInvest = (DataSet1.InvestDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string InvSrno
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableInvest.InvSrnoColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'InvSrno' in table 'Invest' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvest.InvSrnoColumn] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string PurDate
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableInvest.PurDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PurDate' in table 'Invest' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvest.PurDateColumn] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string PurNo
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableInvest.PurNoColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PurNo' in table 'Invest' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvest.PurNoColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string PurPart
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableInvest.PurPartColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PurPart' in table 'Invest' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvest.PurPartColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string PurPrice
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableInvest.PurPriceColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PurPrice' in table 'Invest' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvest.PurPriceColumn] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string PurTotal
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableInvest.PurTotalColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PurTotal' in table 'Invest' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvest.PurTotalColumn] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string SaleDate
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableInvest.SaleDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'SaleDate' in table 'Invest' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvest.SaleDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string SaleNo
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableInvest.SaleNoColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'SaleNo' in table 'Invest' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvest.SaleNoColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string SalePart
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableInvest.SalePartColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'SalePart' in table 'Invest' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvest.SalePartColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string SalePrice
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableInvest.SalePriceColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'SalePrice' in table 'Invest' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvest.SalePriceColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string SaleTotal
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableInvest.SaleTotalColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'SaleTotal' in table 'Invest' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvest.SaleTotalColumn] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string IntDate
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableInvest.IntDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'IntDate' in table 'Invest' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvest.IntDateColumn] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string IntEarned
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableInvest.IntEarnedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'IntEarned' in table 'Invest' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvest.IntEarnedColumn] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string IntAccrued
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableInvest.IntAccruedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'IntAccrued' in table 'Invest' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvest.IntAccruedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string IntTax
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableInvest.IntTaxColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'IntTax' in table 'Invest' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvest.IntTaxColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string IntTotal
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableInvest.IntTotalColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'IntTotal' in table 'Invest' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvest.IntTotalColumn] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsInvSrnoNull() => this.IsNull(this.tableInvest.InvSrnoColumn);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetInvSrnoNull()
    {
      this[this.tableInvest.InvSrnoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsPurDateNull() => this.IsNull(this.tableInvest.PurDateColumn);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetPurDateNull()
    {
      this[this.tableInvest.PurDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsPurNoNull() => this.IsNull(this.tableInvest.PurNoColumn);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetPurNoNull()
    {
      this[this.tableInvest.PurNoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsPurPartNull() => this.IsNull(this.tableInvest.PurPartColumn);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetPurPartNull()
    {
      this[this.tableInvest.PurPartColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsPurPriceNull() => this.IsNull(this.tableInvest.PurPriceColumn);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetPurPriceNull()
    {
      this[this.tableInvest.PurPriceColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsPurTotalNull() => this.IsNull(this.tableInvest.PurTotalColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetPurTotalNull()
    {
      this[this.tableInvest.PurTotalColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsSaleDateNull() => this.IsNull(this.tableInvest.SaleDateColumn);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetSaleDateNull()
    {
      this[this.tableInvest.SaleDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsSaleNoNull() => this.IsNull(this.tableInvest.SaleNoColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetSaleNoNull()
    {
      this[this.tableInvest.SaleNoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsSalePartNull() => this.IsNull(this.tableInvest.SalePartColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetSalePartNull()
    {
      this[this.tableInvest.SalePartColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsSalePriceNull() => this.IsNull(this.tableInvest.SalePriceColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetSalePriceNull()
    {
      this[this.tableInvest.SalePriceColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsSaleTotalNull() => this.IsNull(this.tableInvest.SaleTotalColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetSaleTotalNull()
    {
      this[this.tableInvest.SaleTotalColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsIntDateNull() => this.IsNull(this.tableInvest.IntDateColumn);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetIntDateNull()
    {
      this[this.tableInvest.IntDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsIntEarnedNull() => this.IsNull(this.tableInvest.IntEarnedColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetIntEarnedNull()
    {
      this[this.tableInvest.IntEarnedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsIntAccruedNull() => this.IsNull(this.tableInvest.IntAccruedColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetIntAccruedNull()
    {
      this[this.tableInvest.IntAccruedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsIntTaxNull() => this.IsNull(this.tableInvest.IntTaxColumn);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetIntTaxNull()
    {
      this[this.tableInvest.IntTaxColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsIntTotalNull() => this.IsNull(this.tableInvest.IntTotalColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetIntTotalNull()
    {
      this[this.tableInvest.IntTotalColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class IRRow : DataRow
  {
    private DataSet1.IRDataTable tableIR;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal IRRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableIR = (DataSet1.IRDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string DC1
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableIR.DC1Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DC1' in table 'IR' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableIR.DC1Column] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string DC2
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableIR.DC2Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DC2' in table 'IR' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableIR.DC2Column] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string DC3
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableIR.DC3Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DC3' in table 'IR' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableIR.DC3Column] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string DC4
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableIR.DC4Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DC4' in table 'IR' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableIR.DC4Column] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string DC5
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableIR.DC5Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DC5' in table 'IR' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableIR.DC5Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string DC6
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableIR.DC6Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DC6' in table 'IR' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableIR.DC6Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string DC7
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableIR.DC7Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DC7' in table 'IR' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableIR.DC7Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string DC8
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableIR.DC8Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DC8' in table 'IR' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableIR.DC8Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string DC9
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableIR.DC9Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DC9' in table 'IR' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableIR.DC9Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string DC10
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableIR.DC10Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DC10' in table 'IR' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableIR.DC10Column] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string DC11
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableIR.DC11Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DC11' in table 'IR' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableIR.DC11Column] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string DC12
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableIR.DC12Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DC12' in table 'IR' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableIR.DC12Column] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string DC13
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableIR.DC13Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DC13' in table 'IR' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableIR.DC13Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string DC14
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableIR.DC14Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DC14' in table 'IR' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableIR.DC14Column] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string DC15
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableIR.DC15Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DC15' in table 'IR' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableIR.DC15Column] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string DC16
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableIR.DC16Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DC16' in table 'IR' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableIR.DC16Column] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string DC17
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableIR.DC17Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DC17' in table 'IR' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableIR.DC17Column] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string DC18
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableIR.DC18Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DC18' in table 'IR' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableIR.DC18Column] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string DC19
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableIR.DC19Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DC19' in table 'IR' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableIR.DC19Column] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string DC20
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableIR.DC20Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DC20' in table 'IR' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableIR.DC20Column] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string DC21
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableIR.DC21Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DC21' in table 'IR' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableIR.DC21Column] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string DC22
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableIR.DC22Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DC22' in table 'IR' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableIR.DC22Column] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string DC23
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableIR.DC23Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DC23' in table 'IR' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableIR.DC23Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string DC24
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableIR.DC24Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DC24' in table 'IR' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableIR.DC24Column] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string DC25
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableIR.DC25Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DC25' in table 'IR' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableIR.DC25Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string DC26
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableIR.DC26Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DC26' in table 'IR' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableIR.DC26Column] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string DC27
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableIR.DC27Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DC27' in table 'IR' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableIR.DC27Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string DC28
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableIR.DC28Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DC28' in table 'IR' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableIR.DC28Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string DC29
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableIR.DC29Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DC29' in table 'IR' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableIR.DC29Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string DC30
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableIR.DC30Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DC30' in table 'IR' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableIR.DC30Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string DC31
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableIR.DC31Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DC31' in table 'IR' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableIR.DC31Column] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string DC32
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableIR.DC32Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DC32' in table 'IR' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableIR.DC32Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string DC33
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableIR.DC33Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DC33' in table 'IR' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableIR.DC33Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string DC34
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableIR.DC34Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DC34' in table 'IR' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableIR.DC34Column] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string DC35
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableIR.DC35Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DC35' in table 'IR' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableIR.DC35Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string DC36
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableIR.DC36Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DC36' in table 'IR' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableIR.DC36Column] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string DC37
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableIR.DC37Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DC37' in table 'IR' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableIR.DC37Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string DC38
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableIR.DC38Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DC38' in table 'IR' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableIR.DC38Column] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string DC39
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableIR.DC39Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DC39' in table 'IR' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableIR.DC39Column] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string DC40
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableIR.DC40Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DC40' in table 'IR' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableIR.DC40Column] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string DC41
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableIR.DC41Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DC41' in table 'IR' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableIR.DC41Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string DC42
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableIR.DC42Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DC42' in table 'IR' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableIR.DC42Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string DC43
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableIR.DC43Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DC43' in table 'IR' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableIR.DC43Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string DC44
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableIR.DC44Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DC44' in table 'IR' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableIR.DC44Column] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string DC45
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableIR.DC45Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DC45' in table 'IR' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableIR.DC45Column] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string DC46
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableIR.DC46Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DC46' in table 'IR' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableIR.DC46Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string DC47
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableIR.DC47Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DC47' in table 'IR' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableIR.DC47Column] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsDC1Null() => this.IsNull(this.tableIR.DC1Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetDC1Null()
    {
      this[this.tableIR.DC1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsDC2Null() => this.IsNull(this.tableIR.DC2Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetDC2Null()
    {
      this[this.tableIR.DC2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsDC3Null() => this.IsNull(this.tableIR.DC3Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetDC3Null()
    {
      this[this.tableIR.DC3Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsDC4Null() => this.IsNull(this.tableIR.DC4Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetDC4Null()
    {
      this[this.tableIR.DC4Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsDC5Null() => this.IsNull(this.tableIR.DC5Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetDC5Null()
    {
      this[this.tableIR.DC5Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsDC6Null() => this.IsNull(this.tableIR.DC6Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetDC6Null()
    {
      this[this.tableIR.DC6Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsDC7Null() => this.IsNull(this.tableIR.DC7Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetDC7Null()
    {
      this[this.tableIR.DC7Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsDC8Null() => this.IsNull(this.tableIR.DC8Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetDC8Null()
    {
      this[this.tableIR.DC8Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsDC9Null() => this.IsNull(this.tableIR.DC9Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetDC9Null()
    {
      this[this.tableIR.DC9Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsDC10Null() => this.IsNull(this.tableIR.DC10Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetDC10Null()
    {
      this[this.tableIR.DC10Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsDC11Null() => this.IsNull(this.tableIR.DC11Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetDC11Null()
    {
      this[this.tableIR.DC11Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsDC12Null() => this.IsNull(this.tableIR.DC12Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetDC12Null()
    {
      this[this.tableIR.DC12Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsDC13Null() => this.IsNull(this.tableIR.DC13Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetDC13Null()
    {
      this[this.tableIR.DC13Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsDC14Null() => this.IsNull(this.tableIR.DC14Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetDC14Null()
    {
      this[this.tableIR.DC14Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsDC15Null() => this.IsNull(this.tableIR.DC15Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetDC15Null()
    {
      this[this.tableIR.DC15Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsDC16Null() => this.IsNull(this.tableIR.DC16Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetDC16Null()
    {
      this[this.tableIR.DC16Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsDC17Null() => this.IsNull(this.tableIR.DC17Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetDC17Null()
    {
      this[this.tableIR.DC17Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsDC18Null() => this.IsNull(this.tableIR.DC18Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetDC18Null()
    {
      this[this.tableIR.DC18Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsDC19Null() => this.IsNull(this.tableIR.DC19Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetDC19Null()
    {
      this[this.tableIR.DC19Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsDC20Null() => this.IsNull(this.tableIR.DC20Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetDC20Null()
    {
      this[this.tableIR.DC20Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsDC21Null() => this.IsNull(this.tableIR.DC21Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetDC21Null()
    {
      this[this.tableIR.DC21Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsDC22Null() => this.IsNull(this.tableIR.DC22Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetDC22Null()
    {
      this[this.tableIR.DC22Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsDC23Null() => this.IsNull(this.tableIR.DC23Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetDC23Null()
    {
      this[this.tableIR.DC23Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsDC24Null() => this.IsNull(this.tableIR.DC24Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetDC24Null()
    {
      this[this.tableIR.DC24Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsDC25Null() => this.IsNull(this.tableIR.DC25Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetDC25Null()
    {
      this[this.tableIR.DC25Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsDC26Null() => this.IsNull(this.tableIR.DC26Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetDC26Null()
    {
      this[this.tableIR.DC26Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsDC27Null() => this.IsNull(this.tableIR.DC27Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetDC27Null()
    {
      this[this.tableIR.DC27Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsDC28Null() => this.IsNull(this.tableIR.DC28Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetDC28Null()
    {
      this[this.tableIR.DC28Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsDC29Null() => this.IsNull(this.tableIR.DC29Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetDC29Null()
    {
      this[this.tableIR.DC29Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsDC30Null() => this.IsNull(this.tableIR.DC30Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetDC30Null()
    {
      this[this.tableIR.DC30Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsDC31Null() => this.IsNull(this.tableIR.DC31Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetDC31Null()
    {
      this[this.tableIR.DC31Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsDC32Null() => this.IsNull(this.tableIR.DC32Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetDC32Null()
    {
      this[this.tableIR.DC32Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsDC33Null() => this.IsNull(this.tableIR.DC33Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetDC33Null()
    {
      this[this.tableIR.DC33Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsDC34Null() => this.IsNull(this.tableIR.DC34Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetDC34Null()
    {
      this[this.tableIR.DC34Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsDC35Null() => this.IsNull(this.tableIR.DC35Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetDC35Null()
    {
      this[this.tableIR.DC35Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsDC36Null() => this.IsNull(this.tableIR.DC36Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetDC36Null()
    {
      this[this.tableIR.DC36Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsDC37Null() => this.IsNull(this.tableIR.DC37Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetDC37Null()
    {
      this[this.tableIR.DC37Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsDC38Null() => this.IsNull(this.tableIR.DC38Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetDC38Null()
    {
      this[this.tableIR.DC38Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsDC39Null() => this.IsNull(this.tableIR.DC39Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetDC39Null()
    {
      this[this.tableIR.DC39Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsDC40Null() => this.IsNull(this.tableIR.DC40Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetDC40Null()
    {
      this[this.tableIR.DC40Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsDC41Null() => this.IsNull(this.tableIR.DC41Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetDC41Null()
    {
      this[this.tableIR.DC41Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsDC42Null() => this.IsNull(this.tableIR.DC42Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetDC42Null()
    {
      this[this.tableIR.DC42Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsDC43Null() => this.IsNull(this.tableIR.DC43Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetDC43Null()
    {
      this[this.tableIR.DC43Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsDC44Null() => this.IsNull(this.tableIR.DC44Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetDC44Null()
    {
      this[this.tableIR.DC44Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsDC45Null() => this.IsNull(this.tableIR.DC45Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetDC45Null()
    {
      this[this.tableIR.DC45Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsDC46Null() => this.IsNull(this.tableIR.DC46Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetDC46Null()
    {
      this[this.tableIR.DC46Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsDC47Null() => this.IsNull(this.tableIR.DC47Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetDC47Null()
    {
      this[this.tableIR.DC47Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class DATATABLE1Row : DataRow
  {
    private DataSet1.DATATABLE1DataTable tableDATATABLE1;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    internal DATATABLE1Row(DataRowBuilder rb)
      : base(rb)
    {
      this.tableDATATABLE1 = (DataSet1.DATATABLE1DataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Id
    {
      get => Conversions.ToString(this[this.tableDATATABLE1.IdColumn]);
      set => this[this.tableDATATABLE1.IdColumn] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string MemId
    {
      get => Conversions.ToString(this[this.tableDATATABLE1.MemIdColumn]);
      set => this[this.tableDATATABLE1.MemIdColumn] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string JSrno
    {
      get => Conversions.ToString(this[this.tableDATATABLE1.JSrnoColumn]);
      set => this[this.tableDATATABLE1.JSrnoColumn] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string MClass
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableDATATABLE1.MClassColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'MClass' in table 'DataTable1' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableDATATABLE1.MClassColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string MemName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableDATATABLE1.MemNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'MemName' in table 'DataTable1' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableDATATABLE1.MemNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string RAddress
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableDATATABLE1.RAddressColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'RAddress' in table 'DataTable1' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableDATATABLE1.RAddressColumn] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string ISrno
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableDATATABLE1.ISrnoColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ISrno' in table 'DataTable1' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableDATATABLE1.ISrnoColumn] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string PAddress
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableDATATABLE1.PAddressColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PAddress' in table 'DataTable1' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableDATATABLE1.PAddressColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string MemName1
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableDATATABLE1.MemName1Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'MemName1' in table 'DataTable1' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableDATATABLE1.MemName1Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string MemName2
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableDATATABLE1.MemName2Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'MemName2' in table 'DataTable1' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableDATATABLE1.MemName2Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string MemName3
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableDATATABLE1.MemName3Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'MemName3' in table 'DataTable1' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableDATATABLE1.MemName3Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsMClassNull() => this.IsNull(this.tableDATATABLE1.MClassColumn);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetMClassNull()
    {
      this[this.tableDATATABLE1.MClassColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsMemNameNull() => this.IsNull(this.tableDATATABLE1.MemNameColumn);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetMemNameNull()
    {
      this[this.tableDATATABLE1.MemNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsRAddressNull() => this.IsNull(this.tableDATATABLE1.RAddressColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetRAddressNull()
    {
      this[this.tableDATATABLE1.RAddressColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsISrnoNull() => this.IsNull(this.tableDATATABLE1.ISrnoColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetISrnoNull()
    {
      this[this.tableDATATABLE1.ISrnoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsPAddressNull() => this.IsNull(this.tableDATATABLE1.PAddressColumn);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetPAddressNull()
    {
      this[this.tableDATATABLE1.PAddressColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsMemName1Null() => this.IsNull(this.tableDATATABLE1.MemName1Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetMemName1Null()
    {
      this[this.tableDATATABLE1.MemName1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsMemName2Null() => this.IsNull(this.tableDATATABLE1.MemName2Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetMemName2Null()
    {
      this[this.tableDATATABLE1.MemName2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsMemName3Null() => this.IsNull(this.tableDATATABLE1.MemName3Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetMemName3Null()
    {
      this[this.tableDATATABLE1.MemName3Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class Sink_FundRowChangeEvent : EventArgs
  {
    private DataSet1.Sink_FundRow eventRow;
    private DataRowAction eventAction;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public Sink_FundRowChangeEvent(DataSet1.Sink_FundRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataSet1.Sink_FundRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class J_RegRowChangeEvent : EventArgs
  {
    private DataSet1.J_RegRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public J_RegRowChangeEvent(DataSet1.J_RegRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataSet1.J_RegRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class ShareRowChangeEvent : EventArgs
  {
    private DataSet1.ShareRow eventRow;
    private DataRowAction eventAction;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public ShareRowChangeEvent(DataSet1.ShareRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataSet1.ShareRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class NomineeRowChangeEvent : EventArgs
  {
    private DataSet1.NomineeRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public NomineeRowChangeEvent(DataSet1.NomineeRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataSet1.NomineeRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class DataTable4RowChangeEvent : EventArgs
  {
    private DataSet1.DataTable4Row eventRow;
    private DataRowAction eventAction;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataTable4RowChangeEvent(DataSet1.DataTable4Row row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataSet1.DataTable4Row Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class I_RegRowChangeEvent : EventArgs
  {
    private DataSet1.I_RegRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public I_RegRowChangeEvent(DataSet1.I_RegRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataSet1.I_RegRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class InvestRowChangeEvent : EventArgs
  {
    private DataSet1.InvestRow eventRow;
    private DataRowAction eventAction;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public InvestRowChangeEvent(DataSet1.InvestRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataSet1.InvestRow Row => this.eventRow;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class IRRowChangeEvent : EventArgs
  {
    private DataSet1.IRRow eventRow;
    private DataRowAction eventAction;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public IRRowChangeEvent(DataSet1.IRRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataSet1.IRRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class DATATABLE1RowChangeEvent : EventArgs
  {
    private DataSet1.DATATABLE1Row eventRow;
    private DataRowAction eventAction;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DATATABLE1RowChangeEvent(DataSet1.DATATABLE1Row row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataSet1.DATATABLE1Row Row => this.eventRow;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataRowAction Action => this.eventAction;
  }
}
