// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Word.ApplicationEvents2_WindowActivateEventHandler
// Assembly: Microsoft.Office.Interop.Word, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 0FCBC247-A161-4F2B-996F-3CF977673F41
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Word.dll

using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Interop.Word;

[TypeLibType(16 /*0x10*/)]
[ComVisible(false)]
public delegate void ApplicationEvents2_WindowActivateEventHandler([MarshalAs(UnmanagedType.Interface), In] Document Doc, [MarshalAs(UnmanagedType.Interface), In] Window Wn);
