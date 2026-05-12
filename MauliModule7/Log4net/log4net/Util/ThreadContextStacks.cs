// Decompiled with JetBrains decompiler
// Type: log4net.Util.ThreadContextStacks
// Assembly: log4net, Version=1.2.10.0, Culture=neutral, PublicKeyToken=692fbea5521e1304
// MVID: 7C47EEE6-E76D-4EE6-BAD3-6F27F14CD2E4
// Assembly location: C:\WINDOWS\assembly\GAC_32\log4net\1.2.10.0__692fbea5521e1304\log4net.dll

#nullable disable
namespace log4net.Util;

public sealed class ThreadContextStacks
{
  private readonly ContextPropertiesBase m_properties;

  internal ThreadContextStacks(ContextPropertiesBase properties) => this.m_properties = properties;

  public ThreadContextStack this[string key]
  {
    get
    {
      object property = this.m_properties[key];
      if (property == null)
      {
        threadContextStack = new ThreadContextStack();
        this.m_properties[key] = (object) threadContextStack;
      }
      else if (!(property is ThreadContextStack threadContextStack))
      {
        string nullText = SystemInfo.NullText;
        try
        {
          nullText = property.ToString();
        }
        catch
        {
        }
        LogLog.Error($"ThreadContextStacks: Request for stack named [{key}] failed because a property with the same name exists which is a [{property.GetType().Name}] with value [{nullText}]");
        threadContextStack = new ThreadContextStack();
      }
      return threadContextStack;
    }
  }
}
