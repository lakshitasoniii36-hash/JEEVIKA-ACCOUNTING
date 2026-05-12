// Decompiled with JetBrains decompiler
// Type: log4net.Layout.LayoutSkeleton
// Assembly: log4net, Version=1.2.10.0, Culture=neutral, PublicKeyToken=692fbea5521e1304
// MVID: 7C47EEE6-E76D-4EE6-BAD3-6F27F14CD2E4
// Assembly location: C:\WINDOWS\assembly\GAC_32\log4net\1.2.10.0__692fbea5521e1304\log4net.dll

using log4net.Core;
using System.IO;

#nullable disable
namespace log4net.Layout;

public abstract class LayoutSkeleton : ILayout, IOptionHandler
{
  private string m_header;
  private string m_footer;
  private bool m_ignoresException = true;

  public abstract void ActivateOptions();

  public abstract void Format(TextWriter writer, LoggingEvent loggingEvent);

  public virtual string ContentType => "text/plain";

  public virtual string Header
  {
    get => this.m_header;
    set => this.m_header = value;
  }

  public virtual string Footer
  {
    get => this.m_footer;
    set => this.m_footer = value;
  }

  public virtual bool IgnoresException
  {
    get => this.m_ignoresException;
    set => this.m_ignoresException = value;
  }
}
