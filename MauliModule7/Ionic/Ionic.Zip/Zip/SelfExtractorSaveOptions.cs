// Decompiled with JetBrains decompiler
// Type: Ionic.Zip.SelfExtractorSaveOptions
// Assembly: Ionic.Zip, Version=1.9.1.8, Culture=neutral, PublicKeyToken=edbe51ad942a3f5c
// MVID: BBD9ABA3-3797-4E5D-B8C5-A361E0F7EC0C
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Ionic.Zip.dll

using System;

#nullable disable
namespace Ionic.Zip;

public class SelfExtractorSaveOptions
{
  public SelfExtractorFlavor Flavor { get; set; }

  public string PostExtractCommandLine { get; set; }

  public string DefaultExtractDirectory { get; set; }

  public string IconFile { get; set; }

  public bool Quiet { get; set; }

  public ExtractExistingFileAction ExtractExistingFile { get; set; }

  public bool RemoveUnpackedFilesAfterExecute { get; set; }

  public Version FileVersion { get; set; }

  public string ProductVersion { get; set; }

  public string Copyright { get; set; }

  public string Description { get; set; }

  public string ProductName { get; set; }

  public string SfxExeWindowTitle { get; set; }

  public string AdditionalCompilerSwitches { get; set; }
}
