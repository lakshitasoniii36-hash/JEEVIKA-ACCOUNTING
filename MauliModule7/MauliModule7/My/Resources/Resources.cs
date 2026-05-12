// Decompiled with JetBrains decompiler
// Type: MauliModule7.My.Resources.Resources
// Assembly: MauliModule7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F045263-56C9-469F-9585-90776CDB702C
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\MauliModule7.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

#nullable disable
namespace MauliModule7.My.Resources;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[StandardModule]
[HideModuleName]
[CompilerGenerated]
[DebuggerNonUserCode]
internal sealed class Resources
{
  private static ResourceManager resourceMan;
  private static CultureInfo resourceCulture;

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  internal static ResourceManager ResourceManager
  {
    get
    {
      if (object.ReferenceEquals((object) MauliModule7.My.Resources.Resources.resourceMan, (object) null))
        MauliModule7.My.Resources.Resources.resourceMan = new ResourceManager("MauliModule7.Resources", typeof (MauliModule7.My.Resources.Resources).Assembly);
      return MauliModule7.My.Resources.Resources.resourceMan;
    }
  }

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  internal static CultureInfo Culture
  {
    get => MauliModule7.My.Resources.Resources.resourceCulture;
    set => MauliModule7.My.Resources.Resources.resourceCulture = value;
  }

  internal static Bitmap saml_bmp
  {
    get
    {
      return (Bitmap) RuntimeHelpers.GetObjectValue(MauliModule7.My.Resources.Resources.ResourceManager.GetObject("saml.bmp", MauliModule7.My.Resources.Resources.resourceCulture));
    }
  }
}
