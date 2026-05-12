// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Word.DocumentEvents2_BuildingBlockInsertEventHandler
// Assembly: Microsoft.Office.Interop.Word, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 0FCBC247-A161-4F2B-996F-3CF977673F41
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Word.dll

using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Interop.Word;

[TypeLibType(16 /*0x10*/)]
[ComVisible(false)]
public delegate void DocumentEvents2_BuildingBlockInsertEventHandler(
  [MarshalAs(UnmanagedType.Interface), In] Range Range,
  [MarshalAs(UnmanagedType.BStr), In] string Name,
  [MarshalAs(UnmanagedType.BStr), In] string Category,
  [MarshalAs(UnmanagedType.BStr), In] string BlockType,
  [MarshalAs(UnmanagedType.BStr), In] string Template);
