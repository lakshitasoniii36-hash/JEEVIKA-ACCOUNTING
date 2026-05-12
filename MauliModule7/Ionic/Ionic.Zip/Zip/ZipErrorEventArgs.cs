// Decompiled with JetBrains decompiler
// Type: Ionic.Zip.ZipErrorEventArgs
// Assembly: Ionic.Zip, Version=1.9.1.8, Culture=neutral, PublicKeyToken=edbe51ad942a3f5c
// MVID: BBD9ABA3-3797-4E5D-B8C5-A361E0F7EC0C
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Ionic.Zip.dll

using System;

#nullable disable
namespace Ionic.Zip;

public class ZipErrorEventArgs : ZipProgressEventArgs
{
  private Exception _exc;

  private ZipErrorEventArgs()
  {
  }

  internal static ZipErrorEventArgs Saving(string archiveName, ZipEntry entry, Exception exception)
  {
    ZipErrorEventArgs zipErrorEventArgs = new ZipErrorEventArgs();
    zipErrorEventArgs.EventType = ZipProgressEventType.Error_Saving;
    zipErrorEventArgs.ArchiveName = archiveName;
    zipErrorEventArgs.CurrentEntry = entry;
    zipErrorEventArgs._exc = exception;
    return zipErrorEventArgs;
  }

  public Exception Exception => this._exc;

  public string FileName => this.CurrentEntry.LocalFileName;
}
