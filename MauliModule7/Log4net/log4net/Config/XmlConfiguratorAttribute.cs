// Decompiled with JetBrains decompiler
// Type: log4net.Config.XmlConfiguratorAttribute
// Assembly: log4net, Version=1.2.10.0, Culture=neutral, PublicKeyToken=692fbea5521e1304
// MVID: 7C47EEE6-E76D-4EE6-BAD3-6F27F14CD2E4
// Assembly location: C:\WINDOWS\assembly\GAC_32\log4net\1.2.10.0__692fbea5521e1304\log4net.dll

using log4net.Repository;
using log4net.Util;
using System;
using System.IO;
using System.Reflection;

#nullable disable
namespace log4net.Config;

[AttributeUsage(AttributeTargets.Assembly)]
[Serializable]
public class XmlConfiguratorAttribute : ConfiguratorAttribute
{
  private string m_configFile;
  private string m_configFileExtension;
  private bool m_configureAndWatch;

  public XmlConfiguratorAttribute()
    : base(0)
  {
  }

  public string ConfigFile
  {
    get => this.m_configFile;
    set => this.m_configFile = value;
  }

  public string ConfigFileExtension
  {
    get => this.m_configFileExtension;
    set => this.m_configFileExtension = value;
  }

  public bool Watch
  {
    get => this.m_configureAndWatch;
    set => this.m_configureAndWatch = value;
  }

  public override void Configure(Assembly sourceAssembly, ILoggerRepository targetRepository)
  {
    string uriString = (string) null;
    try
    {
      uriString = SystemInfo.ApplicationBaseDirectory;
    }
    catch
    {
    }
    if (uriString == null || new Uri(uriString).IsFile)
      this.ConfigureFromFile(sourceAssembly, targetRepository);
    else
      this.ConfigureFromUri(sourceAssembly, targetRepository);
  }

  private void ConfigureFromFile(Assembly sourceAssembly, ILoggerRepository targetRepository)
  {
    string fileName = (string) null;
    if (this.m_configFile == null || this.m_configFile.Length == 0)
    {
      if (this.m_configFileExtension != null)
      {
        if (this.m_configFileExtension.Length != 0)
        {
          if (this.m_configFileExtension[0] != '.')
            this.m_configFileExtension = "." + this.m_configFileExtension;
          string path1 = (string) null;
          try
          {
            path1 = SystemInfo.ApplicationBaseDirectory;
          }
          catch (Exception ex)
          {
            LogLog.Error("XmlConfiguratorAttribute: Exception getting ApplicationBaseDirectory. Must be able to resolve ApplicationBaseDirectory and AssemblyFileName when ConfigFileExtension property is set.", ex);
          }
          if (path1 != null)
          {
            fileName = Path.Combine(path1, SystemInfo.AssemblyFileName(sourceAssembly) + this.m_configFileExtension);
            goto label_16;
          }
          goto label_16;
        }
      }
      try
      {
        fileName = SystemInfo.ConfigurationFileLocation;
      }
      catch (Exception ex)
      {
        LogLog.Error("XmlConfiguratorAttribute: Exception getting ConfigurationFileLocation. Must be able to resolve ConfigurationFileLocation when ConfigFile and ConfigFileExtension properties are not set.", ex);
      }
    }
    else
    {
      string path1 = (string) null;
      try
      {
        path1 = SystemInfo.ApplicationBaseDirectory;
      }
      catch (Exception ex)
      {
        LogLog.Warn($"XmlConfiguratorAttribute: Exception getting ApplicationBaseDirectory. ConfigFile property path [{this.m_configFile}] will be treated as an absolute path.", ex);
      }
      fileName = path1 == null ? this.m_configFile : Path.Combine(path1, this.m_configFile);
    }
label_16:
    if (fileName == null)
      return;
    this.ConfigureFromFile(targetRepository, new FileInfo(fileName));
  }

  private void ConfigureFromFile(ILoggerRepository targetRepository, FileInfo configFile)
  {
    if (this.m_configureAndWatch)
      XmlConfigurator.ConfigureAndWatch(targetRepository, configFile);
    else
      XmlConfigurator.Configure(targetRepository, configFile);
  }

  private void ConfigureFromUri(Assembly sourceAssembly, ILoggerRepository targetRepository)
  {
    Uri configUri = (Uri) null;
    if (this.m_configFile == null || this.m_configFile.Length == 0)
    {
      if (this.m_configFileExtension == null || this.m_configFileExtension.Length == 0)
      {
        string uriString = (string) null;
        try
        {
          uriString = SystemInfo.ConfigurationFileLocation;
        }
        catch (Exception ex)
        {
          LogLog.Error("XmlConfiguratorAttribute: Exception getting ConfigurationFileLocation. Must be able to resolve ConfigurationFileLocation when ConfigFile and ConfigFileExtension properties are not set.", ex);
        }
        if (uriString != null)
          configUri = new Uri(uriString);
      }
      else
      {
        if (this.m_configFileExtension[0] != '.')
          this.m_configFileExtension = "." + this.m_configFileExtension;
        string uriString = (string) null;
        try
        {
          uriString = SystemInfo.ConfigurationFileLocation;
        }
        catch (Exception ex)
        {
          LogLog.Error("XmlConfiguratorAttribute: Exception getting ConfigurationFileLocation. Must be able to resolve ConfigurationFileLocation when the ConfigFile property are not set.", ex);
        }
        if (uriString != null)
        {
          UriBuilder uriBuilder = new UriBuilder(new Uri(uriString));
          string str1 = uriBuilder.Path;
          int length = str1.LastIndexOf(".");
          if (length >= 0)
            str1 = str1.Substring(0, length);
          string str2 = str1 + this.m_configFileExtension;
          uriBuilder.Path = str2;
          configUri = uriBuilder.Uri;
        }
      }
    }
    else
    {
      string uriString = (string) null;
      try
      {
        uriString = SystemInfo.ApplicationBaseDirectory;
      }
      catch (Exception ex)
      {
        LogLog.Warn($"XmlConfiguratorAttribute: Exception getting ApplicationBaseDirectory. ConfigFile property path [{this.m_configFile}] will be treated as an absolute URI.", ex);
      }
      configUri = uriString == null ? new Uri(this.m_configFile) : new Uri(new Uri(uriString), this.m_configFile);
    }
    if (!(configUri != (Uri) null))
      return;
    if (configUri.IsFile)
    {
      this.ConfigureFromFile(targetRepository, new FileInfo(configUri.LocalPath));
    }
    else
    {
      if (this.m_configureAndWatch)
        LogLog.Warn("XmlConfiguratorAttribute: Unable to watch config file loaded from a URI");
      XmlConfigurator.Configure(targetRepository, configUri);
    }
  }
}
