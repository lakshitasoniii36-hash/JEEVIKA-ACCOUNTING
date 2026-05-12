// Decompiled with JetBrains decompiler
// Type: MauliModule7.RegDataSet
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

[DesignerCategory("code")]
[HelpKeyword("vs.data.DataSet")]
[XmlRoot("RegDataSet")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[Serializable]
public class RegDataSet : DataSet
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private RegDataSet.PvRegDataTable tablePvReg;
  private RegDataSet.J_RegDataTable tableJ_Reg;
  private RegDataSet.IRDataTable tableIR;
  private RegDataSet.InvestDataTable tableInvest;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  static RegDataSet()
  {
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (RegDataSet.__ENCList)
    {
      if (RegDataSet.__ENCList.Count == RegDataSet.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (RegDataSet.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (RegDataSet.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              RegDataSet.__ENCList[index1] = RegDataSet.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        RegDataSet.__ENCList.RemoveRange(index1, checked (RegDataSet.__ENCList.Count - index1));
        RegDataSet.__ENCList.Capacity = RegDataSet.__ENCList.Count;
      }
      RegDataSet.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
    }
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public RegDataSet()
  {
    RegDataSet.__ENCAddToList((object) this);
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
  protected RegDataSet(SerializationInfo info, StreamingContext context)
    : base(info, context, false)
  {
    RegDataSet.__ENCAddToList((object) this);
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
        if (dataSet.Tables[nameof (PvReg)] != null)
          base.Tables.Add((DataTable) new RegDataSet.PvRegDataTable(dataSet.Tables[nameof (PvReg)]));
        if (dataSet.Tables["J Reg"] != null)
          base.Tables.Add((DataTable) new RegDataSet.J_RegDataTable(dataSet.Tables["J Reg"]));
        if (dataSet.Tables[nameof (IR)] != null)
          base.Tables.Add((DataTable) new RegDataSet.IRDataTable(dataSet.Tables[nameof (IR)]));
        if (dataSet.Tables[nameof (Invest)] != null)
          base.Tables.Add((DataTable) new RegDataSet.InvestDataTable(dataSet.Tables[nameof (Invest)]));
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

  [DebuggerNonUserCode]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  [Browsable(false)]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public RegDataSet.PvRegDataTable PvReg => this.tablePvReg;

  [DebuggerNonUserCode]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  [Browsable(false)]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public RegDataSet.J_RegDataTable J_Reg => this.tableJ_Reg;

  [DebuggerNonUserCode]
  [Browsable(false)]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public RegDataSet.IRDataTable IR => this.tableIR;

  [Browsable(false)]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [DebuggerNonUserCode]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public RegDataSet.InvestDataTable Invest => this.tableInvest;

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [DebuggerNonUserCode]
  [Browsable(true)]
  public override SchemaSerializationMode SchemaSerializationMode
  {
    get => this._schemaSerializationMode;
    set => this._schemaSerializationMode = value;
  }

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [DebuggerNonUserCode]
  public new DataTableCollection Tables => base.Tables;

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [DebuggerNonUserCode]
  public new DataRelationCollection Relations => base.Relations;

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [DebuggerNonUserCode]
  protected override void InitializeDerivedDataSet()
  {
    this.BeginInit();
    this.InitClass();
    this.EndInit();
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [DebuggerNonUserCode]
  public override DataSet Clone()
  {
    RegDataSet regDataSet = (RegDataSet) base.Clone();
    regDataSet.InitVars();
    regDataSet.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) regDataSet;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  protected override bool ShouldSerializeTables() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  protected override bool ShouldSerializeRelations() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  protected override void ReadXmlSerializable(XmlReader reader)
  {
    if (this.DetermineSchemaSerializationMode(reader) == SchemaSerializationMode.IncludeSchema)
    {
      this.Reset();
      DataSet dataSet = new DataSet();
      int num = (int) dataSet.ReadXml(reader);
      if (dataSet.Tables["PvReg"] != null)
        base.Tables.Add((DataTable) new RegDataSet.PvRegDataTable(dataSet.Tables["PvReg"]));
      if (dataSet.Tables["J Reg"] != null)
        base.Tables.Add((DataTable) new RegDataSet.J_RegDataTable(dataSet.Tables["J Reg"]));
      if (dataSet.Tables["IR"] != null)
        base.Tables.Add((DataTable) new RegDataSet.IRDataTable(dataSet.Tables["IR"]));
      if (dataSet.Tables["Invest"] != null)
        base.Tables.Add((DataTable) new RegDataSet.InvestDataTable(dataSet.Tables["Invest"]));
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

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [DebuggerNonUserCode]
  internal void InitVars(bool initTable)
  {
    this.tablePvReg = (RegDataSet.PvRegDataTable) base.Tables["PvReg"];
    if (initTable && this.tablePvReg != null)
      this.tablePvReg.InitVars();
    this.tableJ_Reg = (RegDataSet.J_RegDataTable) base.Tables["J Reg"];
    if (initTable && this.tableJ_Reg != null)
      this.tableJ_Reg.InitVars();
    this.tableIR = (RegDataSet.IRDataTable) base.Tables["IR"];
    if (initTable && this.tableIR != null)
      this.tableIR.InitVars();
    this.tableInvest = (RegDataSet.InvestDataTable) base.Tables["Invest"];
    if (!initTable || this.tableInvest == null)
      return;
    this.tableInvest.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (RegDataSet);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/RegDataSet.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tablePvReg = new RegDataSet.PvRegDataTable();
    base.Tables.Add((DataTable) this.tablePvReg);
    this.tableJ_Reg = new RegDataSet.J_RegDataTable();
    base.Tables.Add((DataTable) this.tableJ_Reg);
    this.tableIR = new RegDataSet.IRDataTable();
    base.Tables.Add((DataTable) this.tableIR);
    this.tableInvest = new RegDataSet.InvestDataTable();
    base.Tables.Add((DataTable) this.tableInvest);
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [DebuggerNonUserCode]
  private bool ShouldSerializePvReg() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializeJ_Reg() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializeIR() => false;

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [DebuggerNonUserCode]
  private bool ShouldSerializeInvest() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private void SchemaChanged(object sender, CollectionChangeEventArgs e)
  {
    if (e.Action != CollectionChangeAction.Remove)
      return;
    this.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public static XmlSchemaComplexType GetTypedDataSetSchema(XmlSchemaSet xs)
  {
    RegDataSet regDataSet = new RegDataSet();
    XmlSchemaComplexType typedDataSetSchema = new XmlSchemaComplexType();
    typedDataSetSchema.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = regDataSet.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = regDataSet.GetSchemaSerializable();
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
  public delegate void PvRegRowChangeEventHandler(object sender, RegDataSet.PvRegRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void J_RegRowChangeEventHandler(object sender, RegDataSet.J_RegRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void IRRowChangeEventHandler(object sender, RegDataSet.IRRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void InvestRowChangeEventHandler(object sender, RegDataSet.InvestRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class PvRegDataTable : TypedTableBase<RegDataSet.PvRegRow>
  {
    private static List<WeakReference> __ENCList = new List<WeakReference>();
    private DataColumn columnC1;
    private DataColumn columnC2;
    private DataColumn columnC3;
    private DataColumn columnC4;
    private DataColumn columnC5;
    private DataColumn columnC6;
    private DataColumn columnC7;
    private DataColumn columnC8;
    private DataColumn columnC9;
    private DataColumn columnC10;
    private DataColumn columnC11;
    private DataColumn columnC12;
    private DataColumn columnC13;
    private DataColumn columnC14;
    private DataColumn columnC15;
    private DataColumn columnC16;
    private DataColumn columnC17;
    private DataColumn columnC18;
    private DataColumn columnC19;
    private DataColumn columnC20;
    private DataColumn columnC21;
    private DataColumn columnC22;
    private DataColumn columnC23;
    private DataColumn columnC24;
    private DataColumn columnC25;
    private DataColumn columnC26;
    private DataColumn columnC27;
    private DataColumn columnC28;
    private DataColumn columnC29;
    private DataColumn columnC30;
    private DataColumn columnC31;
    private DataColumn columnC32;
    private DataColumn columnC33;
    private DataColumn columnC34;
    private DataColumn columnC35;
    private DataColumn columnC36;
    private DataColumn columnC37;
    private DataColumn columnC38;
    private DataColumn columnC39;
    private DataColumn columnC40;
    private DataColumn columnC41;
    private DataColumn columnH1;
    private DataColumn columnH2;
    private DataColumn columnH3;
    private DataColumn columnH4;
    private DataColumn columnH5;
    private DataColumn columnH6;
    private DataColumn columnH7;
    private DataColumn columnH8;
    private DataColumn columnH9;
    private DataColumn columnH10;
    private DataColumn columnH11;
    private DataColumn columnH12;
    private DataColumn columnH13;
    private DataColumn columnH14;
    private DataColumn columnH15;
    private DataColumn columnH16;
    private DataColumn columnH17;
    private DataColumn columnH18;
    private DataColumn columnH19;
    private DataColumn columnH20;
    private DataColumn columnH21;
    private DataColumn columnH22;
    private DataColumn columnH23;
    private DataColumn columnH24;
    private DataColumn columnH25;
    private DataColumn columnC60;
    private DataColumn columnC61;
    private DataColumn columnC62;
    private DataColumn columnC63;
    private DataColumn columnC64;
    private DataColumn columnC65;
    private DataColumn columnC66;
    private DataColumn columnC67;
    private DataColumn columnC68;
    private DataColumn columnC69;
    private DataColumn columnC70;
    private DataColumn columnC71;
    private DataColumn columnC72;
    private DataColumn columnC73;
    private DataColumn columnC74;
    private DataColumn columnC42;
    private DataColumn columnC43;
    private DataColumn columnK1;
    private DataColumn columnK2;
    private DataColumn columnK3;
    private DataColumn columnK4;
    private DataColumn columnK5;
    private DataColumn columnK6;
    private DataColumn columnK7;
    private DataColumn columnK8;
    private DataColumn columnK9;
    private DataColumn columnK10;
    private DataColumn columnK11;
    private DataColumn columnK12;
    private DataColumn columnK13;
    private DataColumn columnK14;
    private DataColumn columnK15;
    private DataColumn columnK16;
    private DataColumn columnK17;
    private DataColumn columnK18;
    private DataColumn columnK19;
    private DataColumn columnK20;
    private DataColumn columnK21;
    private DataColumn columnK22;
    private DataColumn columnK23;
    private DataColumn columnK24;
    private DataColumn columnK25;
    private DataColumn columnK26;
    private DataColumn columnK27;
    private DataColumn columnK28;
    private DataColumn columnK29;
    private DataColumn columnK30;
    private DataColumn columnK31;
    private DataColumn columnK32;

    [DebuggerNonUserCode]
    static PvRegDataTable()
    {
    }

    [DebuggerNonUserCode]
    private static void __ENCAddToList(object value)
    {
      lock (RegDataSet.PvRegDataTable.__ENCList)
      {
        if (RegDataSet.PvRegDataTable.__ENCList.Count == RegDataSet.PvRegDataTable.__ENCList.Capacity)
        {
          int index1 = 0;
          int num = checked (RegDataSet.PvRegDataTable.__ENCList.Count - 1);
          int index2 = 0;
          while (index2 <= num)
          {
            if (RegDataSet.PvRegDataTable.__ENCList[index2].IsAlive)
            {
              if (index2 != index1)
                RegDataSet.PvRegDataTable.__ENCList[index1] = RegDataSet.PvRegDataTable.__ENCList[index2];
              checked { ++index1; }
            }
            checked { ++index2; }
          }
          RegDataSet.PvRegDataTable.__ENCList.RemoveRange(index1, checked (RegDataSet.PvRegDataTable.__ENCList.Count - index1));
          RegDataSet.PvRegDataTable.__ENCList.Capacity = RegDataSet.PvRegDataTable.__ENCList.Count;
        }
        RegDataSet.PvRegDataTable.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
      }
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public PvRegDataTable()
    {
      RegDataSet.PvRegDataTable.__ENCAddToList((object) this);
      this.TableName = "PvReg";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    internal PvRegDataTable(DataTable table)
    {
      RegDataSet.PvRegDataTable.__ENCAddToList((object) this);
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
    protected PvRegDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      RegDataSet.PvRegDataTable.__ENCAddToList((object) this);
      this.InitVars();
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn C1Column => this.columnC1;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn C2Column => this.columnC2;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn C3Column => this.columnC3;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn C4Column => this.columnC4;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn C5Column => this.columnC5;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn C6Column => this.columnC6;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn C7Column => this.columnC7;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn C8Column => this.columnC8;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn C9Column => this.columnC9;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn C10Column => this.columnC10;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn C11Column => this.columnC11;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn C12Column => this.columnC12;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn C13Column => this.columnC13;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn C14Column => this.columnC14;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn C15Column => this.columnC15;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn C16Column => this.columnC16;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn C17Column => this.columnC17;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn C18Column => this.columnC18;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn C19Column => this.columnC19;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn C20Column => this.columnC20;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn C21Column => this.columnC21;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn C22Column => this.columnC22;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn C23Column => this.columnC23;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn C24Column => this.columnC24;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn C25Column => this.columnC25;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn C26Column => this.columnC26;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn C27Column => this.columnC27;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn C28Column => this.columnC28;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn C29Column => this.columnC29;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn C30Column => this.columnC30;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn C31Column => this.columnC31;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn C32Column => this.columnC32;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn C33Column => this.columnC33;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn C34Column => this.columnC34;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn C35Column => this.columnC35;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn C36Column => this.columnC36;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn C37Column => this.columnC37;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn C38Column => this.columnC38;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn C39Column => this.columnC39;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn C40Column => this.columnC40;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn C41Column => this.columnC41;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn H1Column => this.columnH1;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn H2Column => this.columnH2;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn H3Column => this.columnH3;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn H4Column => this.columnH4;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn H5Column => this.columnH5;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn H6Column => this.columnH6;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn H7Column => this.columnH7;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn H8Column => this.columnH8;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn H9Column => this.columnH9;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn H10Column => this.columnH10;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn H11Column => this.columnH11;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn H12Column => this.columnH12;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn H13Column => this.columnH13;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn H14Column => this.columnH14;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn H15Column => this.columnH15;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn H16Column => this.columnH16;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn H17Column => this.columnH17;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn H18Column => this.columnH18;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn H19Column => this.columnH19;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn H20Column => this.columnH20;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn H21Column => this.columnH21;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn H22Column => this.columnH22;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn H23Column => this.columnH23;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn H24Column => this.columnH24;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn H25Column => this.columnH25;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn C60Column => this.columnC60;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn C61Column => this.columnC61;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn C62Column => this.columnC62;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn C63Column => this.columnC63;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn C64Column => this.columnC64;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn C65Column => this.columnC65;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn C66Column => this.columnC66;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn C67Column => this.columnC67;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn C68Column => this.columnC68;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn C69Column => this.columnC69;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn C70Column => this.columnC70;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn C71Column => this.columnC71;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn C72Column => this.columnC72;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn C73Column => this.columnC73;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn C74Column => this.columnC74;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn C42Column => this.columnC42;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn C43Column => this.columnC43;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn K1Column => this.columnK1;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn K2Column => this.columnK2;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn K3Column => this.columnK3;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn K4Column => this.columnK4;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn K5Column => this.columnK5;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn K6Column => this.columnK6;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn K7Column => this.columnK7;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn K8Column => this.columnK8;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn K9Column => this.columnK9;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn K10Column => this.columnK10;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn K11Column => this.columnK11;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn K12Column => this.columnK12;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn K13Column => this.columnK13;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn K14Column => this.columnK14;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn K15Column => this.columnK15;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn K16Column => this.columnK16;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn K17Column => this.columnK17;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn K18Column => this.columnK18;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn K19Column => this.columnK19;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn K20Column => this.columnK20;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn K21Column => this.columnK21;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn K22Column => this.columnK22;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn K23Column => this.columnK23;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn K24Column => this.columnK24;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn K25Column => this.columnK25;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn K26Column => this.columnK26;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn K27Column => this.columnK27;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn K28Column => this.columnK28;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn K29Column => this.columnK29;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn K30Column => this.columnK30;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn K31Column => this.columnK31;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn K32Column => this.columnK32;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public RegDataSet.PvRegRow this[int index] => (RegDataSet.PvRegRow) this.Rows[index];

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event RegDataSet.PvRegRowChangeEventHandler PvRegRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event RegDataSet.PvRegRowChangeEventHandler PvRegRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event RegDataSet.PvRegRowChangeEventHandler PvRegRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event RegDataSet.PvRegRowChangeEventHandler PvRegRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddPvRegRow(RegDataSet.PvRegRow row) => this.Rows.Add((DataRow) row);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public RegDataSet.PvRegRow AddPvRegRow(
      string C1,
      string C2,
      string C3,
      string C4,
      string C5,
      string C6,
      string C7,
      string C8,
      string C9,
      string C10,
      string C11,
      string C12,
      string C13,
      string C14,
      string C15,
      string C16,
      string C17,
      string C18,
      string C19,
      string C20,
      string C21,
      string C22,
      string C23,
      string C24,
      string C25,
      string C26,
      string C27,
      string C28,
      string C29,
      string C30,
      string C31,
      string C32,
      string C33,
      string C34,
      string C35,
      string C36,
      string C37,
      string C38,
      string C39,
      string C40,
      string C41,
      string H1,
      string H2,
      string H3,
      string H4,
      string H5,
      string H6,
      string H7,
      string H8,
      string H9,
      string H10,
      string H11,
      string H12,
      string H13,
      string H14,
      string H15,
      string H16,
      string H17,
      string H18,
      string H19,
      string H20,
      string H21,
      string H22,
      string H23,
      string H24,
      string H25,
      string C60,
      string C61,
      string C62,
      string C63,
      string C64,
      string C65,
      string C66,
      string C67,
      string C68,
      string C69,
      string C70,
      string C71,
      string C72,
      string C73,
      string C74,
      string C42,
      string C43,
      string K1,
      string K2,
      string K3,
      string K4,
      string K5,
      string K6,
      string K7,
      string K8,
      string K9,
      string K10,
      string K11,
      string K12,
      string K13,
      string K14,
      string K15,
      string K16,
      string K17,
      string K18,
      string K19,
      string K20,
      string K21,
      string K22,
      string K23,
      string K24,
      string K25,
      string K26,
      string K27,
      string K28,
      string K29,
      string K30,
      string K31,
      string K32)
    {
      RegDataSet.PvRegRow row = (RegDataSet.PvRegRow) this.NewRow();
      object[] objArray = new object[115]
      {
        (object) C1,
        (object) C2,
        (object) C3,
        (object) C4,
        (object) C5,
        (object) C6,
        (object) C7,
        (object) C8,
        (object) C9,
        (object) C10,
        (object) C11,
        (object) C12,
        (object) C13,
        (object) C14,
        (object) C15,
        (object) C16,
        (object) C17,
        (object) C18,
        (object) C19,
        (object) C20,
        (object) C21,
        (object) C22,
        (object) C23,
        (object) C24,
        (object) C25,
        (object) C26,
        (object) C27,
        (object) C28,
        (object) C29,
        (object) C30,
        (object) C31,
        (object) C32,
        (object) C33,
        (object) C34,
        (object) C35,
        (object) C36,
        (object) C37,
        (object) C38,
        (object) C39,
        (object) C40,
        (object) C41,
        (object) H1,
        (object) H2,
        (object) H3,
        (object) H4,
        (object) H5,
        (object) H6,
        (object) H7,
        (object) H8,
        (object) H9,
        (object) H10,
        (object) H11,
        (object) H12,
        (object) H13,
        (object) H14,
        (object) H15,
        (object) H16,
        (object) H17,
        (object) H18,
        (object) H19,
        (object) H20,
        (object) H21,
        (object) H22,
        (object) H23,
        (object) H24,
        (object) H25,
        (object) C60,
        (object) C61,
        (object) C62,
        (object) C63,
        (object) C64,
        (object) C65,
        (object) C66,
        (object) C67,
        (object) C68,
        (object) C69,
        (object) C70,
        (object) C71,
        (object) C72,
        (object) C73,
        (object) C74,
        (object) C42,
        (object) C43,
        (object) K1,
        (object) K2,
        (object) K3,
        (object) K4,
        (object) K5,
        (object) K6,
        (object) K7,
        (object) K8,
        (object) K9,
        (object) K10,
        (object) K11,
        (object) K12,
        (object) K13,
        (object) K14,
        (object) K15,
        (object) K16,
        (object) K17,
        (object) K18,
        (object) K19,
        (object) K20,
        (object) K21,
        (object) K22,
        (object) K23,
        (object) K24,
        (object) K25,
        (object) K26,
        (object) K27,
        (object) K28,
        (object) K29,
        (object) K30,
        (object) K31,
        (object) K32
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      RegDataSet.PvRegDataTable pvRegDataTable = (RegDataSet.PvRegDataTable) base.Clone();
      pvRegDataTable.InitVars();
      return (DataTable) pvRegDataTable;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    protected override DataTable CreateInstance() => (DataTable) new RegDataSet.PvRegDataTable();

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnC1 = this.Columns["C1"];
      this.columnC2 = this.Columns["C2"];
      this.columnC3 = this.Columns["C3"];
      this.columnC4 = this.Columns["C4"];
      this.columnC5 = this.Columns["C5"];
      this.columnC6 = this.Columns["C6"];
      this.columnC7 = this.Columns["C7"];
      this.columnC8 = this.Columns["C8"];
      this.columnC9 = this.Columns["C9"];
      this.columnC10 = this.Columns["C10"];
      this.columnC11 = this.Columns["C11"];
      this.columnC12 = this.Columns["C12"];
      this.columnC13 = this.Columns["C13"];
      this.columnC14 = this.Columns["C14"];
      this.columnC15 = this.Columns["C15"];
      this.columnC16 = this.Columns["C16"];
      this.columnC17 = this.Columns["C17"];
      this.columnC18 = this.Columns["C18"];
      this.columnC19 = this.Columns["C19"];
      this.columnC20 = this.Columns["C20"];
      this.columnC21 = this.Columns["C21"];
      this.columnC22 = this.Columns["C22"];
      this.columnC23 = this.Columns["C23"];
      this.columnC24 = this.Columns["C24"];
      this.columnC25 = this.Columns["C25"];
      this.columnC26 = this.Columns["C26"];
      this.columnC27 = this.Columns["C27"];
      this.columnC28 = this.Columns["C28"];
      this.columnC29 = this.Columns["C29"];
      this.columnC30 = this.Columns["C30"];
      this.columnC31 = this.Columns["C31"];
      this.columnC32 = this.Columns["C32"];
      this.columnC33 = this.Columns["C33"];
      this.columnC34 = this.Columns["C34"];
      this.columnC35 = this.Columns["C35"];
      this.columnC36 = this.Columns["C36"];
      this.columnC37 = this.Columns["C37"];
      this.columnC38 = this.Columns["C38"];
      this.columnC39 = this.Columns["C39"];
      this.columnC40 = this.Columns["C40"];
      this.columnC41 = this.Columns["C41"];
      this.columnH1 = this.Columns["H1"];
      this.columnH2 = this.Columns["H2"];
      this.columnH3 = this.Columns["H3"];
      this.columnH4 = this.Columns["H4"];
      this.columnH5 = this.Columns["H5"];
      this.columnH6 = this.Columns["H6"];
      this.columnH7 = this.Columns["H7"];
      this.columnH8 = this.Columns["H8"];
      this.columnH9 = this.Columns["H9"];
      this.columnH10 = this.Columns["H10"];
      this.columnH11 = this.Columns["H11"];
      this.columnH12 = this.Columns["H12"];
      this.columnH13 = this.Columns["H13"];
      this.columnH14 = this.Columns["H14"];
      this.columnH15 = this.Columns["H15"];
      this.columnH16 = this.Columns["H16"];
      this.columnH17 = this.Columns["H17"];
      this.columnH18 = this.Columns["H18"];
      this.columnH19 = this.Columns["H19"];
      this.columnH20 = this.Columns["H20"];
      this.columnH21 = this.Columns["H21"];
      this.columnH22 = this.Columns["H22"];
      this.columnH23 = this.Columns["H23"];
      this.columnH24 = this.Columns["H24"];
      this.columnH25 = this.Columns["H25"];
      this.columnC60 = this.Columns["C60"];
      this.columnC61 = this.Columns["C61"];
      this.columnC62 = this.Columns["C62"];
      this.columnC63 = this.Columns["C63"];
      this.columnC64 = this.Columns["C64"];
      this.columnC65 = this.Columns["C65"];
      this.columnC66 = this.Columns["C66"];
      this.columnC67 = this.Columns["C67"];
      this.columnC68 = this.Columns["C68"];
      this.columnC69 = this.Columns["C69"];
      this.columnC70 = this.Columns["C70"];
      this.columnC71 = this.Columns["C71"];
      this.columnC72 = this.Columns["C72"];
      this.columnC73 = this.Columns["C73"];
      this.columnC74 = this.Columns["C74"];
      this.columnC42 = this.Columns["C42"];
      this.columnC43 = this.Columns["C43"];
      this.columnK1 = this.Columns["K1"];
      this.columnK2 = this.Columns["K2"];
      this.columnK3 = this.Columns["K3"];
      this.columnK4 = this.Columns["K4"];
      this.columnK5 = this.Columns["K5"];
      this.columnK6 = this.Columns["K6"];
      this.columnK7 = this.Columns["K7"];
      this.columnK8 = this.Columns["K8"];
      this.columnK9 = this.Columns["K9"];
      this.columnK10 = this.Columns["K10"];
      this.columnK11 = this.Columns["K11"];
      this.columnK12 = this.Columns["K12"];
      this.columnK13 = this.Columns["K13"];
      this.columnK14 = this.Columns["K14"];
      this.columnK15 = this.Columns["K15"];
      this.columnK16 = this.Columns["K16"];
      this.columnK17 = this.Columns["K17"];
      this.columnK18 = this.Columns["K18"];
      this.columnK19 = this.Columns["K19"];
      this.columnK20 = this.Columns["K20"];
      this.columnK21 = this.Columns["K21"];
      this.columnK22 = this.Columns["K22"];
      this.columnK23 = this.Columns["K23"];
      this.columnK24 = this.Columns["K24"];
      this.columnK25 = this.Columns["K25"];
      this.columnK26 = this.Columns["K26"];
      this.columnK27 = this.Columns["K27"];
      this.columnK28 = this.Columns["K28"];
      this.columnK29 = this.Columns["K29"];
      this.columnK30 = this.Columns["K30"];
      this.columnK31 = this.Columns["K31"];
      this.columnK32 = this.Columns["K32"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnC1 = new DataColumn("C1", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnC1);
      this.columnC2 = new DataColumn("C2", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnC2);
      this.columnC3 = new DataColumn("C3", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnC3);
      this.columnC4 = new DataColumn("C4", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnC4);
      this.columnC5 = new DataColumn("C5", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnC5);
      this.columnC6 = new DataColumn("C6", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnC6);
      this.columnC7 = new DataColumn("C7", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnC7);
      this.columnC8 = new DataColumn("C8", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnC8);
      this.columnC9 = new DataColumn("C9", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnC9);
      this.columnC10 = new DataColumn("C10", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnC10);
      this.columnC11 = new DataColumn("C11", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnC11);
      this.columnC12 = new DataColumn("C12", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnC12);
      this.columnC13 = new DataColumn("C13", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnC13);
      this.columnC14 = new DataColumn("C14", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnC14);
      this.columnC15 = new DataColumn("C15", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnC15);
      this.columnC16 = new DataColumn("C16", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnC16);
      this.columnC17 = new DataColumn("C17", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnC17);
      this.columnC18 = new DataColumn("C18", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnC18);
      this.columnC19 = new DataColumn("C19", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnC19);
      this.columnC20 = new DataColumn("C20", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnC20);
      this.columnC21 = new DataColumn("C21", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnC21);
      this.columnC22 = new DataColumn("C22", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnC22);
      this.columnC23 = new DataColumn("C23", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnC23);
      this.columnC24 = new DataColumn("C24", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnC24);
      this.columnC25 = new DataColumn("C25", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnC25);
      this.columnC26 = new DataColumn("C26", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnC26);
      this.columnC27 = new DataColumn("C27", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnC27);
      this.columnC28 = new DataColumn("C28", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnC28);
      this.columnC29 = new DataColumn("C29", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnC29);
      this.columnC30 = new DataColumn("C30", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnC30);
      this.columnC31 = new DataColumn("C31", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnC31);
      this.columnC32 = new DataColumn("C32", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnC32);
      this.columnC33 = new DataColumn("C33", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnC33);
      this.columnC34 = new DataColumn("C34", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnC34);
      this.columnC35 = new DataColumn("C35", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnC35);
      this.columnC36 = new DataColumn("C36", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnC36);
      this.columnC37 = new DataColumn("C37", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnC37);
      this.columnC38 = new DataColumn("C38", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnC38);
      this.columnC39 = new DataColumn("C39", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnC39);
      this.columnC40 = new DataColumn("C40", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnC40);
      this.columnC41 = new DataColumn("C41", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnC41);
      this.columnH1 = new DataColumn("H1", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnH1);
      this.columnH2 = new DataColumn("H2", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnH2);
      this.columnH3 = new DataColumn("H3", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnH3);
      this.columnH4 = new DataColumn("H4", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnH4);
      this.columnH5 = new DataColumn("H5", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnH5);
      this.columnH6 = new DataColumn("H6", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnH6);
      this.columnH7 = new DataColumn("H7", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnH7);
      this.columnH8 = new DataColumn("H8", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnH8);
      this.columnH9 = new DataColumn("H9", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnH9);
      this.columnH10 = new DataColumn("H10", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnH10);
      this.columnH11 = new DataColumn("H11", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnH11);
      this.columnH12 = new DataColumn("H12", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnH12);
      this.columnH13 = new DataColumn("H13", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnH13);
      this.columnH14 = new DataColumn("H14", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnH14);
      this.columnH15 = new DataColumn("H15", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnH15);
      this.columnH16 = new DataColumn("H16", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnH16);
      this.columnH17 = new DataColumn("H17", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnH17);
      this.columnH18 = new DataColumn("H18", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnH18);
      this.columnH19 = new DataColumn("H19", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnH19);
      this.columnH20 = new DataColumn("H20", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnH20);
      this.columnH21 = new DataColumn("H21", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnH21);
      this.columnH22 = new DataColumn("H22", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnH22);
      this.columnH23 = new DataColumn("H23", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnH23);
      this.columnH24 = new DataColumn("H24", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnH24);
      this.columnH25 = new DataColumn("H25", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnH25);
      this.columnC60 = new DataColumn("C60", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnC60);
      this.columnC61 = new DataColumn("C61", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnC61);
      this.columnC62 = new DataColumn("C62", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnC62);
      this.columnC63 = new DataColumn("C63", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnC63);
      this.columnC64 = new DataColumn("C64", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnC64);
      this.columnC65 = new DataColumn("C65", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnC65);
      this.columnC66 = new DataColumn("C66", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnC66);
      this.columnC67 = new DataColumn("C67", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnC67);
      this.columnC68 = new DataColumn("C68", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnC68);
      this.columnC69 = new DataColumn("C69", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnC69);
      this.columnC70 = new DataColumn("C70", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnC70);
      this.columnC71 = new DataColumn("C71", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnC71);
      this.columnC72 = new DataColumn("C72", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnC72);
      this.columnC73 = new DataColumn("C73", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnC73);
      this.columnC74 = new DataColumn("C74", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnC74);
      this.columnC42 = new DataColumn("C42", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnC42);
      this.columnC43 = new DataColumn("C43", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnC43);
      this.columnK1 = new DataColumn("K1", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnK1);
      this.columnK2 = new DataColumn("K2", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnK2);
      this.columnK3 = new DataColumn("K3", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnK3);
      this.columnK4 = new DataColumn("K4", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnK4);
      this.columnK5 = new DataColumn("K5", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnK5);
      this.columnK6 = new DataColumn("K6", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnK6);
      this.columnK7 = new DataColumn("K7", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnK7);
      this.columnK8 = new DataColumn("K8", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnK8);
      this.columnK9 = new DataColumn("K9", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnK9);
      this.columnK10 = new DataColumn("K10", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnK10);
      this.columnK11 = new DataColumn("K11", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnK11);
      this.columnK12 = new DataColumn("K12", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnK12);
      this.columnK13 = new DataColumn("K13", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnK13);
      this.columnK14 = new DataColumn("K14", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnK14);
      this.columnK15 = new DataColumn("K15", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnK15);
      this.columnK16 = new DataColumn("K16", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnK16);
      this.columnK17 = new DataColumn("K17", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnK17);
      this.columnK18 = new DataColumn("K18", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnK18);
      this.columnK19 = new DataColumn("K19", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnK19);
      this.columnK20 = new DataColumn("K20", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnK20);
      this.columnK21 = new DataColumn("K21", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnK21);
      this.columnK22 = new DataColumn("K22", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnK22);
      this.columnK23 = new DataColumn("K23", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnK23);
      this.columnK24 = new DataColumn("K24", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnK24);
      this.columnK25 = new DataColumn("K25", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnK25);
      this.columnK26 = new DataColumn("K26", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnK26);
      this.columnK27 = new DataColumn("K27", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnK27);
      this.columnK28 = new DataColumn("K28", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnK28);
      this.columnK29 = new DataColumn("K29", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnK29);
      this.columnK30 = new DataColumn("K30", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnK30);
      this.columnK31 = new DataColumn("K31", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnK31);
      this.columnK32 = new DataColumn("K32", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnK32);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public RegDataSet.PvRegRow NewPvRegRow() => (RegDataSet.PvRegRow) this.NewRow();

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new RegDataSet.PvRegRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (RegDataSet.PvRegRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      if (this.PvRegRowChangedEvent == null)
        return;
      RegDataSet.PvRegRowChangeEventHandler regRowChangedEvent = this.PvRegRowChangedEvent;
      if (regRowChangedEvent == null)
        return;
      regRowChangedEvent((object) this, new RegDataSet.PvRegRowChangeEvent((RegDataSet.PvRegRow) e.Row, e.Action));
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      if (this.PvRegRowChangingEvent == null)
        return;
      RegDataSet.PvRegRowChangeEventHandler rowChangingEvent = this.PvRegRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new RegDataSet.PvRegRowChangeEvent((RegDataSet.PvRegRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      if (this.PvRegRowDeletedEvent == null)
        return;
      RegDataSet.PvRegRowChangeEventHandler regRowDeletedEvent = this.PvRegRowDeletedEvent;
      if (regRowDeletedEvent == null)
        return;
      regRowDeletedEvent((object) this, new RegDataSet.PvRegRowChangeEvent((RegDataSet.PvRegRow) e.Row, e.Action));
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      if (this.PvRegRowDeletingEvent == null)
        return;
      RegDataSet.PvRegRowChangeEventHandler rowDeletingEvent = this.PvRegRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new RegDataSet.PvRegRowChangeEvent((RegDataSet.PvRegRow) e.Row, e.Action));
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void RemovePvRegRow(RegDataSet.PvRegRow row) => this.Rows.Remove((DataRow) row);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      RegDataSet regDataSet = new RegDataSet();
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
        FixedValue = regDataSet.Namespace
      });
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (PvRegDataTable)
      });
      typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = regDataSet.GetSchemaSerializable();
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
  public class J_RegDataTable : TypedTableBase<RegDataSet.J_RegRow>
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
      lock (RegDataSet.J_RegDataTable.__ENCList)
      {
        if (RegDataSet.J_RegDataTable.__ENCList.Count == RegDataSet.J_RegDataTable.__ENCList.Capacity)
        {
          int index1 = 0;
          int num = checked (RegDataSet.J_RegDataTable.__ENCList.Count - 1);
          int index2 = 0;
          while (index2 <= num)
          {
            if (RegDataSet.J_RegDataTable.__ENCList[index2].IsAlive)
            {
              if (index2 != index1)
                RegDataSet.J_RegDataTable.__ENCList[index1] = RegDataSet.J_RegDataTable.__ENCList[index2];
              checked { ++index1; }
            }
            checked { ++index2; }
          }
          RegDataSet.J_RegDataTable.__ENCList.RemoveRange(index1, checked (RegDataSet.J_RegDataTable.__ENCList.Count - index1));
          RegDataSet.J_RegDataTable.__ENCList.Capacity = RegDataSet.J_RegDataTable.__ENCList.Count;
        }
        RegDataSet.J_RegDataTable.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public J_RegDataTable()
    {
      RegDataSet.J_RegDataTable.__ENCAddToList((object) this);
      this.TableName = "J Reg";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    internal J_RegDataTable(DataTable table)
    {
      RegDataSet.J_RegDataTable.__ENCAddToList((object) this);
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
      RegDataSet.J_RegDataTable.__ENCAddToList((object) this);
      this.InitVars();
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
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

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn MemNameColumn => this.columnMemName;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn RAddressColumn => this.columnRAddress;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ISrnoColumn => this.columnISrno;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn PAddressColumn => this.columnPAddress;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn MemName1Column => this.columnMemName1;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
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
    public RegDataSet.J_RegRow this[int index] => (RegDataSet.J_RegRow) this.Rows[index];

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event RegDataSet.J_RegRowChangeEventHandler J_RegRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event RegDataSet.J_RegRowChangeEventHandler J_RegRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event RegDataSet.J_RegRowChangeEventHandler J_RegRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event RegDataSet.J_RegRowChangeEventHandler J_RegRowDeleted;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void AddJ_RegRow(RegDataSet.J_RegRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public RegDataSet.J_RegRow AddJ_RegRow(
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
      RegDataSet.J_RegRow row = (RegDataSet.J_RegRow) this.NewRow();
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

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      RegDataSet.J_RegDataTable jRegDataTable = (RegDataSet.J_RegDataTable) base.Clone();
      jRegDataTable.InitVars();
      return (DataTable) jRegDataTable;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    protected override DataTable CreateInstance() => (DataTable) new RegDataSet.J_RegDataTable();

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
    public RegDataSet.J_RegRow NewJ_RegRow() => (RegDataSet.J_RegRow) this.NewRow();

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new RegDataSet.J_RegRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (RegDataSet.J_RegRow);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      if (this.J_RegRowChangedEvent == null)
        return;
      RegDataSet.J_RegRowChangeEventHandler regRowChangedEvent = this.J_RegRowChangedEvent;
      if (regRowChangedEvent == null)
        return;
      regRowChangedEvent((object) this, new RegDataSet.J_RegRowChangeEvent((RegDataSet.J_RegRow) e.Row, e.Action));
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      if (this.J_RegRowChangingEvent == null)
        return;
      RegDataSet.J_RegRowChangeEventHandler rowChangingEvent = this.J_RegRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new RegDataSet.J_RegRowChangeEvent((RegDataSet.J_RegRow) e.Row, e.Action));
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      if (this.J_RegRowDeletedEvent == null)
        return;
      RegDataSet.J_RegRowChangeEventHandler regRowDeletedEvent = this.J_RegRowDeletedEvent;
      if (regRowDeletedEvent == null)
        return;
      regRowDeletedEvent((object) this, new RegDataSet.J_RegRowChangeEvent((RegDataSet.J_RegRow) e.Row, e.Action));
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      if (this.J_RegRowDeletingEvent == null)
        return;
      RegDataSet.J_RegRowChangeEventHandler rowDeletingEvent = this.J_RegRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new RegDataSet.J_RegRowChangeEvent((RegDataSet.J_RegRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemoveJ_RegRow(RegDataSet.J_RegRow row) => this.Rows.Remove((DataRow) row);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      RegDataSet regDataSet = new RegDataSet();
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
        FixedValue = regDataSet.Namespace
      });
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (J_RegDataTable)
      });
      typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = regDataSet.GetSchemaSerializable();
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
  public class IRDataTable : TypedTableBase<RegDataSet.IRRow>
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
      lock (RegDataSet.IRDataTable.__ENCList)
      {
        if (RegDataSet.IRDataTable.__ENCList.Count == RegDataSet.IRDataTable.__ENCList.Capacity)
        {
          int index1 = 0;
          int num = checked (RegDataSet.IRDataTable.__ENCList.Count - 1);
          int index2 = 0;
          while (index2 <= num)
          {
            if (RegDataSet.IRDataTable.__ENCList[index2].IsAlive)
            {
              if (index2 != index1)
                RegDataSet.IRDataTable.__ENCList[index1] = RegDataSet.IRDataTable.__ENCList[index2];
              checked { ++index1; }
            }
            checked { ++index2; }
          }
          RegDataSet.IRDataTable.__ENCList.RemoveRange(index1, checked (RegDataSet.IRDataTable.__ENCList.Count - index1));
          RegDataSet.IRDataTable.__ENCList.Capacity = RegDataSet.IRDataTable.__ENCList.Count;
        }
        RegDataSet.IRDataTable.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
      }
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public IRDataTable()
    {
      RegDataSet.IRDataTable.__ENCAddToList((object) this);
      this.TableName = "IR";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    internal IRDataTable(DataTable table)
    {
      RegDataSet.IRDataTable.__ENCAddToList((object) this);
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
    protected IRDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      RegDataSet.IRDataTable.__ENCAddToList((object) this);
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DC1Column => this.columnDC1;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn DC2Column => this.columnDC2;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn DC3Column => this.columnDC3;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DC4Column => this.columnDC4;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn DC5Column => this.columnDC5;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn DC6Column => this.columnDC6;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn DC7Column => this.columnDC7;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DC8Column => this.columnDC8;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DC9Column => this.columnDC9;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DC10Column => this.columnDC10;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn DC11Column => this.columnDC11;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn DC12Column => this.columnDC12;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DC13Column => this.columnDC13;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DC14Column => this.columnDC14;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DC15Column => this.columnDC15;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn DC16Column => this.columnDC16;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn DC17Column => this.columnDC17;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn DC18Column => this.columnDC18;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DC19Column => this.columnDC19;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn DC20Column => this.columnDC20;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn DC21Column => this.columnDC21;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn DC22Column => this.columnDC22;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DC23Column => this.columnDC23;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn DC24Column => this.columnDC24;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DC25Column => this.columnDC25;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DC26Column => this.columnDC26;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn DC27Column => this.columnDC27;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn DC28Column => this.columnDC28;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn DC29Column => this.columnDC29;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn DC30Column => this.columnDC30;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn DC31Column => this.columnDC31;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn DC32Column => this.columnDC32;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DC33Column => this.columnDC33;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DC34Column => this.columnDC34;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn DC35Column => this.columnDC35;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
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

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DC42Column => this.columnDC42;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn DC43Column => this.columnDC43;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
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

    [Browsable(false)]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public RegDataSet.IRRow this[int index] => (RegDataSet.IRRow) this.Rows[index];

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event RegDataSet.IRRowChangeEventHandler IRRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event RegDataSet.IRRowChangeEventHandler IRRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event RegDataSet.IRRowChangeEventHandler IRRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event RegDataSet.IRRowChangeEventHandler IRRowDeleted;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void AddIRRow(RegDataSet.IRRow row) => this.Rows.Add((DataRow) row);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public RegDataSet.IRRow AddIRRow(
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
      RegDataSet.IRRow row = (RegDataSet.IRRow) this.NewRow();
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

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public override DataTable Clone()
    {
      RegDataSet.IRDataTable irDataTable = (RegDataSet.IRDataTable) base.Clone();
      irDataTable.InitVars();
      return (DataTable) irDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance() => (DataTable) new RegDataSet.IRDataTable();

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
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
    public RegDataSet.IRRow NewIRRow() => (RegDataSet.IRRow) this.NewRow();

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new RegDataSet.IRRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (RegDataSet.IRRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      if (this.IRRowChangedEvent == null)
        return;
      RegDataSet.IRRowChangeEventHandler irRowChangedEvent = this.IRRowChangedEvent;
      if (irRowChangedEvent == null)
        return;
      irRowChangedEvent((object) this, new RegDataSet.IRRowChangeEvent((RegDataSet.IRRow) e.Row, e.Action));
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      if (this.IRRowChangingEvent == null)
        return;
      RegDataSet.IRRowChangeEventHandler rowChangingEvent = this.IRRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new RegDataSet.IRRowChangeEvent((RegDataSet.IRRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      if (this.IRRowDeletedEvent == null)
        return;
      RegDataSet.IRRowChangeEventHandler irRowDeletedEvent = this.IRRowDeletedEvent;
      if (irRowDeletedEvent == null)
        return;
      irRowDeletedEvent((object) this, new RegDataSet.IRRowChangeEvent((RegDataSet.IRRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      if (this.IRRowDeletingEvent == null)
        return;
      RegDataSet.IRRowChangeEventHandler rowDeletingEvent = this.IRRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new RegDataSet.IRRowChangeEvent((RegDataSet.IRRow) e.Row, e.Action));
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void RemoveIRRow(RegDataSet.IRRow row) => this.Rows.Remove((DataRow) row);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      RegDataSet regDataSet = new RegDataSet();
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
        FixedValue = regDataSet.Namespace
      });
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (IRDataTable)
      });
      typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = regDataSet.GetSchemaSerializable();
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
  public class InvestDataTable : TypedTableBase<RegDataSet.InvestRow>
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
      lock (RegDataSet.InvestDataTable.__ENCList)
      {
        if (RegDataSet.InvestDataTable.__ENCList.Count == RegDataSet.InvestDataTable.__ENCList.Capacity)
        {
          int index1 = 0;
          int num = checked (RegDataSet.InvestDataTable.__ENCList.Count - 1);
          int index2 = 0;
          while (index2 <= num)
          {
            if (RegDataSet.InvestDataTable.__ENCList[index2].IsAlive)
            {
              if (index2 != index1)
                RegDataSet.InvestDataTable.__ENCList[index1] = RegDataSet.InvestDataTable.__ENCList[index2];
              checked { ++index1; }
            }
            checked { ++index2; }
          }
          RegDataSet.InvestDataTable.__ENCList.RemoveRange(index1, checked (RegDataSet.InvestDataTable.__ENCList.Count - index1));
          RegDataSet.InvestDataTable.__ENCList.Capacity = RegDataSet.InvestDataTable.__ENCList.Count;
        }
        RegDataSet.InvestDataTable.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public InvestDataTable()
    {
      RegDataSet.InvestDataTable.__ENCAddToList((object) this);
      this.TableName = "Invest";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal InvestDataTable(DataTable table)
    {
      RegDataSet.InvestDataTable.__ENCAddToList((object) this);
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
    protected InvestDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      RegDataSet.InvestDataTable.__ENCAddToList((object) this);
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn InvSrnoColumn => this.columnInvSrno;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn PurDateColumn => this.columnPurDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn SaleDateColumn => this.columnSaleDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn SaleNoColumn => this.columnSaleNo;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn SalePartColumn => this.columnSalePart;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn SalePriceColumn => this.columnSalePrice;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn SaleTotalColumn => this.columnSaleTotal;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn IntDateColumn => this.columnIntDate;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataColumn IntEarnedColumn => this.columnIntEarned;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn IntAccruedColumn => this.columnIntAccrued;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn IntTaxColumn => this.columnIntTax;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn IntTotalColumn => this.columnIntTotal;

    [Browsable(false)]
    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public RegDataSet.InvestRow this[int index] => (RegDataSet.InvestRow) this.Rows[index];

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event RegDataSet.InvestRowChangeEventHandler InvestRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event RegDataSet.InvestRowChangeEventHandler InvestRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event RegDataSet.InvestRowChangeEventHandler InvestRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event RegDataSet.InvestRowChangeEventHandler InvestRowDeleted;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void AddInvestRow(RegDataSet.InvestRow row) => this.Rows.Add((DataRow) row);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public RegDataSet.InvestRow AddInvestRow(
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
      RegDataSet.InvestRow row = (RegDataSet.InvestRow) this.NewRow();
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
      RegDataSet.InvestDataTable investDataTable = (RegDataSet.InvestDataTable) base.Clone();
      investDataTable.InitVars();
      return (DataTable) investDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance() => (DataTable) new RegDataSet.InvestDataTable();

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public RegDataSet.InvestRow NewInvestRow() => (RegDataSet.InvestRow) this.NewRow();

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new RegDataSet.InvestRow(builder);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    protected override Type GetRowType() => typeof (RegDataSet.InvestRow);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      if (this.InvestRowChangedEvent == null)
        return;
      RegDataSet.InvestRowChangeEventHandler investRowChangedEvent = this.InvestRowChangedEvent;
      if (investRowChangedEvent == null)
        return;
      investRowChangedEvent((object) this, new RegDataSet.InvestRowChangeEvent((RegDataSet.InvestRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      if (this.InvestRowChangingEvent == null)
        return;
      RegDataSet.InvestRowChangeEventHandler rowChangingEvent = this.InvestRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new RegDataSet.InvestRowChangeEvent((RegDataSet.InvestRow) e.Row, e.Action));
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      if (this.InvestRowDeletedEvent == null)
        return;
      RegDataSet.InvestRowChangeEventHandler investRowDeletedEvent = this.InvestRowDeletedEvent;
      if (investRowDeletedEvent == null)
        return;
      investRowDeletedEvent((object) this, new RegDataSet.InvestRowChangeEvent((RegDataSet.InvestRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      if (this.InvestRowDeletingEvent == null)
        return;
      RegDataSet.InvestRowChangeEventHandler rowDeletingEvent = this.InvestRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new RegDataSet.InvestRowChangeEvent((RegDataSet.InvestRow) e.Row, e.Action));
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void RemoveInvestRow(RegDataSet.InvestRow row) => this.Rows.Remove((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      RegDataSet regDataSet = new RegDataSet();
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
        FixedValue = regDataSet.Namespace
      });
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (InvestDataTable)
      });
      typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = regDataSet.GetSchemaSerializable();
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

  public class PvRegRow : DataRow
  {
    private RegDataSet.PvRegDataTable tablePvReg;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal PvRegRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablePvReg = (RegDataSet.PvRegDataTable) this.Table;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string C1
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.C1Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'C1' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.C1Column] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string C2
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.C2Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'C2' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.C2Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string C3
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.C3Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'C3' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.C3Column] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string C4
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.C4Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'C4' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.C4Column] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string C5
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.C5Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'C5' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.C5Column] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string C6
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.C6Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'C6' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.C6Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string C7
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.C7Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'C7' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.C7Column] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string C8
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.C8Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'C8' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.C8Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string C9
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.C9Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'C9' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.C9Column] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string C10
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.C10Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'C10' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.C10Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string C11
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.C11Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'C11' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.C11Column] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string C12
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.C12Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'C12' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.C12Column] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string C13
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.C13Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'C13' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.C13Column] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string C14
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.C14Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'C14' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.C14Column] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string C15
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.C15Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'C15' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.C15Column] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string C16
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.C16Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'C16' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.C16Column] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string C17
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.C17Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'C17' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.C17Column] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string C18
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.C18Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'C18' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.C18Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string C19
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.C19Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'C19' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.C19Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string C20
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.C20Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'C20' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.C20Column] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string C21
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.C21Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'C21' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.C21Column] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string C22
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.C22Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'C22' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.C22Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string C23
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.C23Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'C23' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.C23Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string C24
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.C24Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'C24' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.C24Column] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string C25
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.C25Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'C25' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.C25Column] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string C26
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.C26Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'C26' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.C26Column] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string C27
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.C27Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'C27' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.C27Column] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string C28
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.C28Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'C28' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.C28Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string C29
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.C29Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'C29' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.C29Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string C30
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.C30Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'C30' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.C30Column] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string C31
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.C31Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'C31' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.C31Column] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string C32
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.C32Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'C32' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.C32Column] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string C33
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.C33Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'C33' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.C33Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string C34
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.C34Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'C34' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.C34Column] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string C35
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.C35Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'C35' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.C35Column] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string C36
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.C36Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'C36' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.C36Column] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string C37
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.C37Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'C37' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.C37Column] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string C38
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.C38Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'C38' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.C38Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string C39
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.C39Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'C39' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.C39Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string C40
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.C40Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'C40' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.C40Column] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string C41
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.C41Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'C41' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.C41Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string H1
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.H1Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'H1' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.H1Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string H2
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.H2Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'H2' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.H2Column] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string H3
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.H3Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'H3' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.H3Column] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string H4
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.H4Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'H4' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.H4Column] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string H5
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.H5Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'H5' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.H5Column] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string H6
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.H6Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'H6' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.H6Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string H7
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.H7Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'H7' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.H7Column] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string H8
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.H8Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'H8' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.H8Column] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string H9
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.H9Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'H9' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.H9Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string H10
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.H10Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'H10' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.H10Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string H11
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.H11Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'H11' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.H11Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string H12
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.H12Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'H12' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.H12Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string H13
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.H13Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'H13' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.H13Column] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string H14
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.H14Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'H14' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.H14Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string H15
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.H15Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'H15' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.H15Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string H16
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.H16Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'H16' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.H16Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string H17
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.H17Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'H17' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.H17Column] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string H18
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.H18Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'H18' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.H18Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string H19
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.H19Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'H19' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.H19Column] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string H20
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.H20Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'H20' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.H20Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string H21
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.H21Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'H21' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.H21Column] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string H22
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.H22Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'H22' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.H22Column] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string H23
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.H23Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'H23' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.H23Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string H24
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.H24Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'H24' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.H24Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string H25
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.H25Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'H25' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.H25Column] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string C60
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.C60Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'C60' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.C60Column] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string C61
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.C61Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'C61' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.C61Column] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string C62
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.C62Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'C62' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.C62Column] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string C63
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.C63Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'C63' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.C63Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string C64
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.C64Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'C64' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.C64Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string C65
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.C65Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'C65' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.C65Column] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string C66
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.C66Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'C66' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.C66Column] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string C67
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.C67Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'C67' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.C67Column] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string C68
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.C68Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'C68' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.C68Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string C69
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.C69Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'C69' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.C69Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string C70
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.C70Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'C70' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.C70Column] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string C71
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.C71Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'C71' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.C71Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string C72
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.C72Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'C72' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.C72Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string C73
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.C73Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'C73' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.C73Column] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string C74
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.C74Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'C74' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.C74Column] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string C42
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.C42Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'C42' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.C42Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string C43
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.C43Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'C43' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.C43Column] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string K1
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.K1Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'K1' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.K1Column] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string K2
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.K2Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'K2' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.K2Column] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string K3
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.K3Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'K3' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.K3Column] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string K4
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.K4Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'K4' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.K4Column] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string K5
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.K5Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'K5' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.K5Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string K6
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.K6Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'K6' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.K6Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string K7
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.K7Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'K7' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.K7Column] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string K8
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.K8Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'K8' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.K8Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string K9
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.K9Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'K9' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.K9Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string K10
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.K10Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'K10' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.K10Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string K11
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.K11Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'K11' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.K11Column] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string K12
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.K12Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'K12' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.K12Column] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string K13
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.K13Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'K13' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.K13Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string K14
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.K14Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'K14' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.K14Column] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string K15
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.K15Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'K15' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.K15Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string K16
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.K16Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'K16' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.K16Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string K17
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.K17Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'K17' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.K17Column] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string K18
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.K18Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'K18' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.K18Column] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string K19
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.K19Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'K19' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.K19Column] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string K20
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.K20Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'K20' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.K20Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string K21
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.K21Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'K21' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.K21Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string K22
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.K22Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'K22' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.K22Column] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string K23
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.K23Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'K23' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.K23Column] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string K24
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.K24Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'K24' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.K24Column] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string K25
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.K25Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'K25' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.K25Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string K26
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.K26Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'K26' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.K26Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string K27
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.K27Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'K27' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.K27Column] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string K28
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.K28Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'K28' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.K28Column] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string K29
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.K29Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'K29' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.K29Column] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string K30
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.K30Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'K30' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.K30Column] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string K31
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.K31Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'K31' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.K31Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string K32
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePvReg.K32Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'K32' in table 'PvReg' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePvReg.K32Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsC1Null() => this.IsNull(this.tablePvReg.C1Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetC1Null()
    {
      this[this.tablePvReg.C1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsC2Null() => this.IsNull(this.tablePvReg.C2Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetC2Null()
    {
      this[this.tablePvReg.C2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsC3Null() => this.IsNull(this.tablePvReg.C3Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetC3Null()
    {
      this[this.tablePvReg.C3Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsC4Null() => this.IsNull(this.tablePvReg.C4Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetC4Null()
    {
      this[this.tablePvReg.C4Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsC5Null() => this.IsNull(this.tablePvReg.C5Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetC5Null()
    {
      this[this.tablePvReg.C5Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsC6Null() => this.IsNull(this.tablePvReg.C6Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetC6Null()
    {
      this[this.tablePvReg.C6Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsC7Null() => this.IsNull(this.tablePvReg.C7Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetC7Null()
    {
      this[this.tablePvReg.C7Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsC8Null() => this.IsNull(this.tablePvReg.C8Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetC8Null()
    {
      this[this.tablePvReg.C8Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsC9Null() => this.IsNull(this.tablePvReg.C9Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetC9Null()
    {
      this[this.tablePvReg.C9Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsC10Null() => this.IsNull(this.tablePvReg.C10Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetC10Null()
    {
      this[this.tablePvReg.C10Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsC11Null() => this.IsNull(this.tablePvReg.C11Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetC11Null()
    {
      this[this.tablePvReg.C11Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsC12Null() => this.IsNull(this.tablePvReg.C12Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetC12Null()
    {
      this[this.tablePvReg.C12Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsC13Null() => this.IsNull(this.tablePvReg.C13Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetC13Null()
    {
      this[this.tablePvReg.C13Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsC14Null() => this.IsNull(this.tablePvReg.C14Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetC14Null()
    {
      this[this.tablePvReg.C14Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsC15Null() => this.IsNull(this.tablePvReg.C15Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetC15Null()
    {
      this[this.tablePvReg.C15Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsC16Null() => this.IsNull(this.tablePvReg.C16Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetC16Null()
    {
      this[this.tablePvReg.C16Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsC17Null() => this.IsNull(this.tablePvReg.C17Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetC17Null()
    {
      this[this.tablePvReg.C17Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsC18Null() => this.IsNull(this.tablePvReg.C18Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetC18Null()
    {
      this[this.tablePvReg.C18Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsC19Null() => this.IsNull(this.tablePvReg.C19Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetC19Null()
    {
      this[this.tablePvReg.C19Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsC20Null() => this.IsNull(this.tablePvReg.C20Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetC20Null()
    {
      this[this.tablePvReg.C20Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsC21Null() => this.IsNull(this.tablePvReg.C21Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetC21Null()
    {
      this[this.tablePvReg.C21Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsC22Null() => this.IsNull(this.tablePvReg.C22Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetC22Null()
    {
      this[this.tablePvReg.C22Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsC23Null() => this.IsNull(this.tablePvReg.C23Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetC23Null()
    {
      this[this.tablePvReg.C23Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsC24Null() => this.IsNull(this.tablePvReg.C24Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetC24Null()
    {
      this[this.tablePvReg.C24Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsC25Null() => this.IsNull(this.tablePvReg.C25Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetC25Null()
    {
      this[this.tablePvReg.C25Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsC26Null() => this.IsNull(this.tablePvReg.C26Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetC26Null()
    {
      this[this.tablePvReg.C26Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsC27Null() => this.IsNull(this.tablePvReg.C27Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetC27Null()
    {
      this[this.tablePvReg.C27Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsC28Null() => this.IsNull(this.tablePvReg.C28Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetC28Null()
    {
      this[this.tablePvReg.C28Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsC29Null() => this.IsNull(this.tablePvReg.C29Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetC29Null()
    {
      this[this.tablePvReg.C29Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsC30Null() => this.IsNull(this.tablePvReg.C30Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetC30Null()
    {
      this[this.tablePvReg.C30Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsC31Null() => this.IsNull(this.tablePvReg.C31Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetC31Null()
    {
      this[this.tablePvReg.C31Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsC32Null() => this.IsNull(this.tablePvReg.C32Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetC32Null()
    {
      this[this.tablePvReg.C32Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsC33Null() => this.IsNull(this.tablePvReg.C33Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetC33Null()
    {
      this[this.tablePvReg.C33Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsC34Null() => this.IsNull(this.tablePvReg.C34Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetC34Null()
    {
      this[this.tablePvReg.C34Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsC35Null() => this.IsNull(this.tablePvReg.C35Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetC35Null()
    {
      this[this.tablePvReg.C35Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsC36Null() => this.IsNull(this.tablePvReg.C36Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetC36Null()
    {
      this[this.tablePvReg.C36Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsC37Null() => this.IsNull(this.tablePvReg.C37Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetC37Null()
    {
      this[this.tablePvReg.C37Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsC38Null() => this.IsNull(this.tablePvReg.C38Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetC38Null()
    {
      this[this.tablePvReg.C38Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsC39Null() => this.IsNull(this.tablePvReg.C39Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetC39Null()
    {
      this[this.tablePvReg.C39Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsC40Null() => this.IsNull(this.tablePvReg.C40Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetC40Null()
    {
      this[this.tablePvReg.C40Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsC41Null() => this.IsNull(this.tablePvReg.C41Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetC41Null()
    {
      this[this.tablePvReg.C41Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsH1Null() => this.IsNull(this.tablePvReg.H1Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetH1Null()
    {
      this[this.tablePvReg.H1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsH2Null() => this.IsNull(this.tablePvReg.H2Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetH2Null()
    {
      this[this.tablePvReg.H2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsH3Null() => this.IsNull(this.tablePvReg.H3Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetH3Null()
    {
      this[this.tablePvReg.H3Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsH4Null() => this.IsNull(this.tablePvReg.H4Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetH4Null()
    {
      this[this.tablePvReg.H4Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsH5Null() => this.IsNull(this.tablePvReg.H5Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetH5Null()
    {
      this[this.tablePvReg.H5Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsH6Null() => this.IsNull(this.tablePvReg.H6Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetH6Null()
    {
      this[this.tablePvReg.H6Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsH7Null() => this.IsNull(this.tablePvReg.H7Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetH7Null()
    {
      this[this.tablePvReg.H7Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsH8Null() => this.IsNull(this.tablePvReg.H8Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetH8Null()
    {
      this[this.tablePvReg.H8Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsH9Null() => this.IsNull(this.tablePvReg.H9Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetH9Null()
    {
      this[this.tablePvReg.H9Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsH10Null() => this.IsNull(this.tablePvReg.H10Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetH10Null()
    {
      this[this.tablePvReg.H10Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsH11Null() => this.IsNull(this.tablePvReg.H11Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetH11Null()
    {
      this[this.tablePvReg.H11Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsH12Null() => this.IsNull(this.tablePvReg.H12Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetH12Null()
    {
      this[this.tablePvReg.H12Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsH13Null() => this.IsNull(this.tablePvReg.H13Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetH13Null()
    {
      this[this.tablePvReg.H13Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsH14Null() => this.IsNull(this.tablePvReg.H14Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetH14Null()
    {
      this[this.tablePvReg.H14Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsH15Null() => this.IsNull(this.tablePvReg.H15Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetH15Null()
    {
      this[this.tablePvReg.H15Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsH16Null() => this.IsNull(this.tablePvReg.H16Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetH16Null()
    {
      this[this.tablePvReg.H16Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsH17Null() => this.IsNull(this.tablePvReg.H17Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetH17Null()
    {
      this[this.tablePvReg.H17Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsH18Null() => this.IsNull(this.tablePvReg.H18Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetH18Null()
    {
      this[this.tablePvReg.H18Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsH19Null() => this.IsNull(this.tablePvReg.H19Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetH19Null()
    {
      this[this.tablePvReg.H19Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsH20Null() => this.IsNull(this.tablePvReg.H20Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetH20Null()
    {
      this[this.tablePvReg.H20Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsH21Null() => this.IsNull(this.tablePvReg.H21Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetH21Null()
    {
      this[this.tablePvReg.H21Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsH22Null() => this.IsNull(this.tablePvReg.H22Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetH22Null()
    {
      this[this.tablePvReg.H22Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsH23Null() => this.IsNull(this.tablePvReg.H23Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetH23Null()
    {
      this[this.tablePvReg.H23Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsH24Null() => this.IsNull(this.tablePvReg.H24Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetH24Null()
    {
      this[this.tablePvReg.H24Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsH25Null() => this.IsNull(this.tablePvReg.H25Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetH25Null()
    {
      this[this.tablePvReg.H25Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsC60Null() => this.IsNull(this.tablePvReg.C60Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetC60Null()
    {
      this[this.tablePvReg.C60Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsC61Null() => this.IsNull(this.tablePvReg.C61Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetC61Null()
    {
      this[this.tablePvReg.C61Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsC62Null() => this.IsNull(this.tablePvReg.C62Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetC62Null()
    {
      this[this.tablePvReg.C62Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsC63Null() => this.IsNull(this.tablePvReg.C63Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetC63Null()
    {
      this[this.tablePvReg.C63Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsC64Null() => this.IsNull(this.tablePvReg.C64Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetC64Null()
    {
      this[this.tablePvReg.C64Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsC65Null() => this.IsNull(this.tablePvReg.C65Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetC65Null()
    {
      this[this.tablePvReg.C65Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsC66Null() => this.IsNull(this.tablePvReg.C66Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetC66Null()
    {
      this[this.tablePvReg.C66Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsC67Null() => this.IsNull(this.tablePvReg.C67Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetC67Null()
    {
      this[this.tablePvReg.C67Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsC68Null() => this.IsNull(this.tablePvReg.C68Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetC68Null()
    {
      this[this.tablePvReg.C68Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsC69Null() => this.IsNull(this.tablePvReg.C69Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetC69Null()
    {
      this[this.tablePvReg.C69Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsC70Null() => this.IsNull(this.tablePvReg.C70Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetC70Null()
    {
      this[this.tablePvReg.C70Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsC71Null() => this.IsNull(this.tablePvReg.C71Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetC71Null()
    {
      this[this.tablePvReg.C71Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsC72Null() => this.IsNull(this.tablePvReg.C72Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetC72Null()
    {
      this[this.tablePvReg.C72Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsC73Null() => this.IsNull(this.tablePvReg.C73Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetC73Null()
    {
      this[this.tablePvReg.C73Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsC74Null() => this.IsNull(this.tablePvReg.C74Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetC74Null()
    {
      this[this.tablePvReg.C74Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsC42Null() => this.IsNull(this.tablePvReg.C42Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetC42Null()
    {
      this[this.tablePvReg.C42Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsC43Null() => this.IsNull(this.tablePvReg.C43Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetC43Null()
    {
      this[this.tablePvReg.C43Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsK1Null() => this.IsNull(this.tablePvReg.K1Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetK1Null()
    {
      this[this.tablePvReg.K1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsK2Null() => this.IsNull(this.tablePvReg.K2Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetK2Null()
    {
      this[this.tablePvReg.K2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsK3Null() => this.IsNull(this.tablePvReg.K3Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetK3Null()
    {
      this[this.tablePvReg.K3Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsK4Null() => this.IsNull(this.tablePvReg.K4Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetK4Null()
    {
      this[this.tablePvReg.K4Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsK5Null() => this.IsNull(this.tablePvReg.K5Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetK5Null()
    {
      this[this.tablePvReg.K5Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsK6Null() => this.IsNull(this.tablePvReg.K6Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetK6Null()
    {
      this[this.tablePvReg.K6Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsK7Null() => this.IsNull(this.tablePvReg.K7Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetK7Null()
    {
      this[this.tablePvReg.K7Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsK8Null() => this.IsNull(this.tablePvReg.K8Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetK8Null()
    {
      this[this.tablePvReg.K8Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsK9Null() => this.IsNull(this.tablePvReg.K9Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetK9Null()
    {
      this[this.tablePvReg.K9Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsK10Null() => this.IsNull(this.tablePvReg.K10Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetK10Null()
    {
      this[this.tablePvReg.K10Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsK11Null() => this.IsNull(this.tablePvReg.K11Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetK11Null()
    {
      this[this.tablePvReg.K11Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsK12Null() => this.IsNull(this.tablePvReg.K12Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetK12Null()
    {
      this[this.tablePvReg.K12Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsK13Null() => this.IsNull(this.tablePvReg.K13Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetK13Null()
    {
      this[this.tablePvReg.K13Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsK14Null() => this.IsNull(this.tablePvReg.K14Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetK14Null()
    {
      this[this.tablePvReg.K14Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsK15Null() => this.IsNull(this.tablePvReg.K15Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetK15Null()
    {
      this[this.tablePvReg.K15Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsK16Null() => this.IsNull(this.tablePvReg.K16Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetK16Null()
    {
      this[this.tablePvReg.K16Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsK17Null() => this.IsNull(this.tablePvReg.K17Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetK17Null()
    {
      this[this.tablePvReg.K17Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsK18Null() => this.IsNull(this.tablePvReg.K18Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetK18Null()
    {
      this[this.tablePvReg.K18Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsK19Null() => this.IsNull(this.tablePvReg.K19Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetK19Null()
    {
      this[this.tablePvReg.K19Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsK20Null() => this.IsNull(this.tablePvReg.K20Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetK20Null()
    {
      this[this.tablePvReg.K20Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsK21Null() => this.IsNull(this.tablePvReg.K21Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetK21Null()
    {
      this[this.tablePvReg.K21Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsK22Null() => this.IsNull(this.tablePvReg.K22Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetK22Null()
    {
      this[this.tablePvReg.K22Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsK23Null() => this.IsNull(this.tablePvReg.K23Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetK23Null()
    {
      this[this.tablePvReg.K23Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsK24Null() => this.IsNull(this.tablePvReg.K24Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetK24Null()
    {
      this[this.tablePvReg.K24Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsK25Null() => this.IsNull(this.tablePvReg.K25Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetK25Null()
    {
      this[this.tablePvReg.K25Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsK26Null() => this.IsNull(this.tablePvReg.K26Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetK26Null()
    {
      this[this.tablePvReg.K26Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsK27Null() => this.IsNull(this.tablePvReg.K27Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetK27Null()
    {
      this[this.tablePvReg.K27Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsK28Null() => this.IsNull(this.tablePvReg.K28Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetK28Null()
    {
      this[this.tablePvReg.K28Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsK29Null() => this.IsNull(this.tablePvReg.K29Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetK29Null()
    {
      this[this.tablePvReg.K29Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsK30Null() => this.IsNull(this.tablePvReg.K30Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetK30Null()
    {
      this[this.tablePvReg.K30Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsK31Null() => this.IsNull(this.tablePvReg.K31Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetK31Null()
    {
      this[this.tablePvReg.K31Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsK32Null() => this.IsNull(this.tablePvReg.K32Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetK32Null()
    {
      this[this.tablePvReg.K32Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class J_RegRow : DataRow
  {
    private RegDataSet.J_RegDataTable tableJ_Reg;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    internal J_RegRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableJ_Reg = (RegDataSet.J_RegDataTable) this.Table;
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

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public string JSrno
    {
      get => Conversions.ToString(this[this.tableJ_Reg.JSrnoColumn]);
      set => this[this.tableJ_Reg.JSrnoColumn] = (object) value;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
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

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
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

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
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

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsMClassNull() => this.IsNull(this.tableJ_Reg.MClassColumn);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetMClassNull()
    {
      this[this.tableJ_Reg.MClassColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsMemNameNull() => this.IsNull(this.tableJ_Reg.MemNameColumn);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetMemNameNull()
    {
      this[this.tableJ_Reg.MemNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsRAddressNull() => this.IsNull(this.tableJ_Reg.RAddressColumn);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetRAddressNull()
    {
      this[this.tableJ_Reg.RAddressColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsISrnoNull() => this.IsNull(this.tableJ_Reg.ISrnoColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsMemName3Null() => this.IsNull(this.tableJ_Reg.MemName3Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetMemName3Null()
    {
      this[this.tableJ_Reg.MemName3Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class IRRow : DataRow
  {
    private RegDataSet.IRDataTable tableIR;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal IRRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableIR = (RegDataSet.IRDataTable) this.Table;
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

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
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

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
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

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
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

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
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

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
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

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
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

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
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

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
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

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
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

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsDC3Null() => this.IsNull(this.tableIR.DC3Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetDC3Null()
    {
      this[this.tableIR.DC3Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsDC4Null() => this.IsNull(this.tableIR.DC4Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetDC4Null()
    {
      this[this.tableIR.DC4Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetDC7Null()
    {
      this[this.tableIR.DC7Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsDC8Null() => this.IsNull(this.tableIR.DC8Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetDC8Null()
    {
      this[this.tableIR.DC8Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsDC9Null() => this.IsNull(this.tableIR.DC9Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetDC9Null()
    {
      this[this.tableIR.DC9Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
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

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsDC14Null() => this.IsNull(this.tableIR.DC14Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetDC14Null()
    {
      this[this.tableIR.DC14Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
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

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetDC16Null()
    {
      this[this.tableIR.DC16Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsDC17Null() => this.IsNull(this.tableIR.DC17Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetDC17Null()
    {
      this[this.tableIR.DC17Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsDC18Null() => this.IsNull(this.tableIR.DC18Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetDC18Null()
    {
      this[this.tableIR.DC18Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsDC19Null() => this.IsNull(this.tableIR.DC19Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetDC19Null()
    {
      this[this.tableIR.DC19Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsDC20Null() => this.IsNull(this.tableIR.DC20Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetDC20Null()
    {
      this[this.tableIR.DC20Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsDC21Null() => this.IsNull(this.tableIR.DC21Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetDC21Null()
    {
      this[this.tableIR.DC21Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsDC22Null() => this.IsNull(this.tableIR.DC22Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetDC22Null()
    {
      this[this.tableIR.DC22Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsDC23Null() => this.IsNull(this.tableIR.DC23Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetDC23Null()
    {
      this[this.tableIR.DC23Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsDC24Null() => this.IsNull(this.tableIR.DC24Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetDC24Null()
    {
      this[this.tableIR.DC24Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
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

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetDC26Null()
    {
      this[this.tableIR.DC26Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetDC29Null()
    {
      this[this.tableIR.DC29Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsDC30Null() => this.IsNull(this.tableIR.DC30Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetDC30Null()
    {
      this[this.tableIR.DC30Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsDC31Null() => this.IsNull(this.tableIR.DC31Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetDC31Null()
    {
      this[this.tableIR.DC31Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsDC32Null() => this.IsNull(this.tableIR.DC32Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetDC32Null()
    {
      this[this.tableIR.DC32Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsDC33Null() => this.IsNull(this.tableIR.DC33Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetDC33Null()
    {
      this[this.tableIR.DC33Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsDC34Null() => this.IsNull(this.tableIR.DC34Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetDC34Null()
    {
      this[this.tableIR.DC34Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsDC38Null() => this.IsNull(this.tableIR.DC38Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetDC38Null()
    {
      this[this.tableIR.DC38Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsDC39Null() => this.IsNull(this.tableIR.DC39Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetDC39Null()
    {
      this[this.tableIR.DC39Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsDC40Null() => this.IsNull(this.tableIR.DC40Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetDC40Null()
    {
      this[this.tableIR.DC40Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsDC41Null() => this.IsNull(this.tableIR.DC41Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetDC41Null()
    {
      this[this.tableIR.DC41Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
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

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetDC43Null()
    {
      this[this.tableIR.DC43Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsDC44Null() => this.IsNull(this.tableIR.DC44Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetDC44Null()
    {
      this[this.tableIR.DC44Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsDC45Null() => this.IsNull(this.tableIR.DC45Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetDC45Null()
    {
      this[this.tableIR.DC45Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsDC46Null() => this.IsNull(this.tableIR.DC46Column);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetDC46Null()
    {
      this[this.tableIR.DC46Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsDC47Null() => this.IsNull(this.tableIR.DC47Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetDC47Null()
    {
      this[this.tableIR.DC47Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class InvestRow : DataRow
  {
    private RegDataSet.InvestDataTable tableInvest;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    internal InvestRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableInvest = (RegDataSet.InvestDataTable) this.Table;
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

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
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

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
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

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
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

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
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

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetPurTotalNull()
    {
      this[this.tableInvest.PurTotalColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsSaleDateNull() => this.IsNull(this.tableInvest.SaleDateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetSaleDateNull()
    {
      this[this.tableInvest.SaleDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsSaleNoNull() => this.IsNull(this.tableInvest.SaleNoColumn);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetSaleNoNull()
    {
      this[this.tableInvest.SaleNoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsSalePartNull() => this.IsNull(this.tableInvest.SalePartColumn);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetSalePartNull()
    {
      this[this.tableInvest.SalePartColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsSalePriceNull() => this.IsNull(this.tableInvest.SalePriceColumn);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetSalePriceNull()
    {
      this[this.tableInvest.SalePriceColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsSaleTotalNull() => this.IsNull(this.tableInvest.SaleTotalColumn);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetSaleTotalNull()
    {
      this[this.tableInvest.SaleTotalColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsIntDateNull() => this.IsNull(this.tableInvest.IntDateColumn);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetIntDateNull()
    {
      this[this.tableInvest.IntDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool IsIntEarnedNull() => this.IsNull(this.tableInvest.IntEarnedColumn);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
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

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsIntTaxNull() => this.IsNull(this.tableInvest.IntTaxColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetIntTaxNull()
    {
      this[this.tableInvest.IntTaxColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsIntTotalNull() => this.IsNull(this.tableInvest.IntTotalColumn);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void SetIntTotalNull()
    {
      this[this.tableInvest.IntTotalColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class PvRegRowChangeEvent : EventArgs
  {
    private RegDataSet.PvRegRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public PvRegRowChangeEvent(RegDataSet.PvRegRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public RegDataSet.PvRegRow Row => this.eventRow;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class J_RegRowChangeEvent : EventArgs
  {
    private RegDataSet.J_RegRow eventRow;
    private DataRowAction eventAction;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public J_RegRowChangeEvent(RegDataSet.J_RegRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public RegDataSet.J_RegRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class IRRowChangeEvent : EventArgs
  {
    private RegDataSet.IRRow eventRow;
    private DataRowAction eventAction;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public IRRowChangeEvent(RegDataSet.IRRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public RegDataSet.IRRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class InvestRowChangeEvent : EventArgs
  {
    private RegDataSet.InvestRow eventRow;
    private DataRowAction eventAction;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public InvestRowChangeEvent(RegDataSet.InvestRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public RegDataSet.InvestRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
