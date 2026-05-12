// Decompiled with JetBrains decompiler
// Type: log4net.Util.PatternStringConverters.PropertyPatternConverter
// Assembly: log4net, Version=1.2.10.0, Culture=neutral, PublicKeyToken=692fbea5521e1304
// MVID: 7C47EEE6-E76D-4EE6-BAD3-6F27F14CD2E4
// Assembly location: C:\WINDOWS\assembly\GAC_32\log4net\1.2.10.0__692fbea5521e1304\log4net.dll

using log4net.Repository;
using System.Collections;
using System.IO;

#nullable disable
namespace log4net.Util.PatternStringConverters;

internal sealed class PropertyPatternConverter : PatternConverter
{
  protected override void Convert(TextWriter writer, object state)
  {
    CompositeProperties compositeProperties = new CompositeProperties();
    PropertiesDictionary properties1 = LogicalThreadContext.Properties.GetProperties(false);
    if (properties1 != null)
      compositeProperties.Add((ReadOnlyPropertiesDictionary) properties1);
    PropertiesDictionary properties2 = ThreadContext.Properties.GetProperties(false);
    if (properties2 != null)
      compositeProperties.Add((ReadOnlyPropertiesDictionary) properties2);
    compositeProperties.Add(GlobalContext.Properties.GetReadOnlyProperties());
    if (this.Option != null)
      PatternConverter.WriteObject(writer, (ILoggerRepository) null, compositeProperties[this.Option]);
    else
      PatternConverter.WriteDictionary(writer, (ILoggerRepository) null, (IDictionary) compositeProperties.Flatten());
  }
}
