// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Word.DocumentEvents_SinkHelper
// Assembly: Microsoft.Office.Interop.Word, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 0FCBC247-A161-4F2B-996F-3CF977673F41
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Word.dll

using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Interop.Word;

[ClassInterface(ClassInterfaceType.None)]
public sealed class DocumentEvents_SinkHelper : DocumentEvents
{
  public DocumentEvents_CloseEventHandler m_CloseDelegate;
  public DocumentEvents_OpenEventHandler m_OpenDelegate;
  public DocumentEvents_NewEventHandler m_NewDelegate;
  public int m_dwCookie;

  public virtual void Close()
  {
    if (this.m_CloseDelegate == null)
      return;
    this.m_CloseDelegate();
  }

  public virtual void Open()
  {
    if (this.m_OpenDelegate == null)
      return;
    this.m_OpenDelegate();
  }

  public virtual void New()
  {
    if (this.m_NewDelegate == null)
      return;
    this.m_NewDelegate();
  }

  internal DocumentEvents_SinkHelper()
  {
    this.m_dwCookie = 0;
    this.m_CloseDelegate = (DocumentEvents_CloseEventHandler) null;
    this.m_OpenDelegate = (DocumentEvents_OpenEventHandler) null;
    this.m_NewDelegate = (DocumentEvents_NewEventHandler) null;
  }
}
