// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Core.ICustomXMLPartEvents
// Assembly: office, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: B995883C-34F0-4A0F-9779-9CEB61E0CAD4
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\office.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Core;

[Guid("000CDB06-0000-0000-C000-000000000046")]
[TypeLibType(4304)]
[ComImport]
public interface ICustomXMLPartEvents
{
  [DispId(1)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void NodeAfterInsert([MarshalAs(UnmanagedType.Interface), In] CustomXMLNode NewNode, [In] bool InUndoRedo);

  [DispId(2)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void NodeAfterDelete(
    [MarshalAs(UnmanagedType.Interface), In] CustomXMLNode OldNode,
    [MarshalAs(UnmanagedType.Interface), In] CustomXMLNode OldParentNode,
    [MarshalAs(UnmanagedType.Interface), In] CustomXMLNode OldNextSibling,
    [In] bool InUndoRedo);

  [DispId(3)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void NodeAfterReplace([MarshalAs(UnmanagedType.Interface), In] CustomXMLNode OldNode, [MarshalAs(UnmanagedType.Interface), In] CustomXMLNode NewNode, [In] bool InUndoRedo);
}
