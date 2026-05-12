// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Word.ApplicationEvents_SinkHelper
// Assembly: Microsoft.Office.Interop.Word, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 0FCBC247-A161-4F2B-996F-3CF977673F41
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Word.dll

using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Interop.Word;

[ClassInterface(ClassInterfaceType.None)]
public sealed class ApplicationEvents_SinkHelper : ApplicationEvents
{
  public int m_dwCookie;

  internal ApplicationEvents_SinkHelper() => this.m_dwCookie = 0;
}
