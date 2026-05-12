// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Excel.WorkbookEvents_AfterXmlExportEventHandler
// Assembly: Microsoft.Office.Interop.Excel, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 201AF11D-0E77-491F-92E5-AC46D3FEB35B
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Excel.dll

using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Interop.Excel;

[ComVisible(false)]
[TypeLibType(16 /*0x10*/)]
public delegate void WorkbookEvents_AfterXmlExportEventHandler(
  [MarshalAs(UnmanagedType.Interface), In] XmlMap Map,
  [MarshalAs(UnmanagedType.BStr), In] string Url,
  [In] XlXmlExportResult Result);
