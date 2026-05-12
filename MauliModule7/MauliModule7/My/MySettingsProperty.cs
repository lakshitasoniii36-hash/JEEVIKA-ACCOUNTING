// Decompiled with JetBrains decompiler
// Type: MauliModule7.My.MySettingsProperty
// Assembly: MauliModule7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F045263-56C9-469F-9585-90776CDB702C
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\MauliModule7.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.CompilerServices;

#nullable disable
namespace MauliModule7.My;

[CompilerGenerated]
[HideModuleName]
[DebuggerNonUserCode]
[StandardModule]
internal sealed class MySettingsProperty
{
  [HelpKeyword("My.Settings")]
  internal static MySettings Settings
  {
    get
    {
      MySettings settings = MySettings.Default;
      return settings;
    }
  }
}
