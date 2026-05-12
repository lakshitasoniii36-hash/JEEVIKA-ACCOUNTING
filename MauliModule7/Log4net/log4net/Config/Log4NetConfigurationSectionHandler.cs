// Decompiled with JetBrains decompiler
// Type: log4net.Config.Log4NetConfigurationSectionHandler
// Assembly: log4net, Version=1.2.10.0, Culture=neutral, PublicKeyToken=692fbea5521e1304
// MVID: 7C47EEE6-E76D-4EE6-BAD3-6F27F14CD2E4
// Assembly location: C:\WINDOWS\assembly\GAC_32\log4net\1.2.10.0__692fbea5521e1304\log4net.dll

using System.Configuration;
using System.Xml;

#nullable disable
namespace log4net.Config;

public class Log4NetConfigurationSectionHandler : IConfigurationSectionHandler
{
  public object Create(object parent, object configContext, XmlNode section) => (object) section;
}
