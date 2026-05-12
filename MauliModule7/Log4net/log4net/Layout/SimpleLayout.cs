// Decompiled with JetBrains decompiler
// Type: log4net.Layout.SimpleLayout
// Assembly: log4net, Version=1.2.10.0, Culture=neutral, PublicKeyToken=692fbea5521e1304
// MVID: 7C47EEE6-E76D-4EE6-BAD3-6F27F14CD2E4
// Assembly location: C:\WINDOWS\assembly\GAC_32\log4net\1.2.10.0__692fbea5521e1304\log4net.dll

using log4net.Core;
using System;
using System.IO;

#nullable disable
namespace log4net.Layout;

public class SimpleLayout : LayoutSkeleton
{
  public SimpleLayout() => this.IgnoresException = true;

  public override void ActivateOptions()
  {
  }

  public override void Format(TextWriter writer, LoggingEvent loggingEvent)
  {
    if (loggingEvent == null)
      throw new ArgumentNullException(nameof (loggingEvent));
    writer.Write(loggingEvent.Level.DisplayName);
    writer.Write(" - ");
    loggingEvent.WriteRenderedMessage(writer);
    writer.WriteLine();
  }
}
