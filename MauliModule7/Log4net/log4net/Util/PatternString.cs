// Decompiled with JetBrains decompiler
// Type: log4net.Util.PatternString
// Assembly: log4net, Version=1.2.10.0, Culture=neutral, PublicKeyToken=692fbea5521e1304
// MVID: 7C47EEE6-E76D-4EE6-BAD3-6F27F14CD2E4
// Assembly location: C:\WINDOWS\assembly\GAC_32\log4net\1.2.10.0__692fbea5521e1304\log4net.dll

using log4net.Core;
using log4net.Util.PatternStringConverters;
using System;
using System.Collections;
using System.Globalization;
using System.IO;

#nullable disable
namespace log4net.Util;

public class PatternString : IOptionHandler
{
  private static Hashtable s_globalRulesRegistry = new Hashtable(15);
  private string m_pattern;
  private PatternConverter m_head;
  private Hashtable m_instanceRulesRegistry = new Hashtable();

  static PatternString()
  {
    PatternString.s_globalRulesRegistry.Add((object) "appdomain", (object) typeof (AppDomainPatternConverter));
    PatternString.s_globalRulesRegistry.Add((object) "date", (object) typeof (DatePatternConverter));
    PatternString.s_globalRulesRegistry.Add((object) "env", (object) typeof (EnvironmentPatternConverter));
    PatternString.s_globalRulesRegistry.Add((object) "identity", (object) typeof (IdentityPatternConverter));
    PatternString.s_globalRulesRegistry.Add((object) "literal", (object) typeof (LiteralPatternConverter));
    PatternString.s_globalRulesRegistry.Add((object) "newline", (object) typeof (NewLinePatternConverter));
    PatternString.s_globalRulesRegistry.Add((object) "processid", (object) typeof (ProcessIdPatternConverter));
    PatternString.s_globalRulesRegistry.Add((object) "property", (object) typeof (PropertyPatternConverter));
    PatternString.s_globalRulesRegistry.Add((object) "random", (object) typeof (RandomStringPatternConverter));
    PatternString.s_globalRulesRegistry.Add((object) "username", (object) typeof (UserNamePatternConverter));
    PatternString.s_globalRulesRegistry.Add((object) "utcdate", (object) typeof (UtcDatePatternConverter));
    PatternString.s_globalRulesRegistry.Add((object) "utcDate", (object) typeof (UtcDatePatternConverter));
    PatternString.s_globalRulesRegistry.Add((object) "UtcDate", (object) typeof (UtcDatePatternConverter));
  }

  public PatternString()
  {
  }

  public PatternString(string pattern)
  {
    this.m_pattern = pattern;
    this.ActivateOptions();
  }

  public string ConversionPattern
  {
    get => this.m_pattern;
    set => this.m_pattern = value;
  }

  public virtual void ActivateOptions()
  {
    this.m_head = this.CreatePatternParser(this.m_pattern).Parse();
  }

  private PatternParser CreatePatternParser(string pattern)
  {
    PatternParser patternParser = new PatternParser(pattern);
    foreach (DictionaryEntry dictionaryEntry in PatternString.s_globalRulesRegistry)
      patternParser.PatternConverters.Add(dictionaryEntry.Key, dictionaryEntry.Value);
    foreach (DictionaryEntry dictionaryEntry in this.m_instanceRulesRegistry)
      patternParser.PatternConverters[dictionaryEntry.Key] = dictionaryEntry.Value;
    return patternParser;
  }

  public void Format(TextWriter writer)
  {
    if (writer == null)
      throw new ArgumentNullException(nameof (writer));
    for (PatternConverter patternConverter = this.m_head; patternConverter != null; patternConverter = patternConverter.Next)
      patternConverter.Format(writer, (object) null);
  }

  public string Format()
  {
    StringWriter writer = new StringWriter((IFormatProvider) CultureInfo.InvariantCulture);
    this.Format((TextWriter) writer);
    return writer.ToString();
  }

  public void AddConverter(PatternString.ConverterInfo converterInfo)
  {
    this.AddConverter(converterInfo.Name, converterInfo.Type);
  }

  public void AddConverter(string name, Type type)
  {
    if (name == null)
      throw new ArgumentNullException(nameof (name));
    if (type == null)
      throw new ArgumentNullException(nameof (type));
    this.m_instanceRulesRegistry[(object) name] = typeof (PatternConverter).IsAssignableFrom(type) ? (object) type : throw new ArgumentException($"The converter type specified [{(object) type}] must be a subclass of log4net.Util.PatternConverter", nameof (type));
  }

  public sealed class ConverterInfo
  {
    private string m_name;
    private Type m_type;

    public string Name
    {
      get => this.m_name;
      set => this.m_name = value;
    }

    public Type Type
    {
      get => this.m_type;
      set => this.m_type = value;
    }
  }
}
