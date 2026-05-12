// Decompiled with JetBrains decompiler
// Type: Ionic.Zip.ComHelper
// Assembly: Ionic.Zip, Version=1.9.1.8, Culture=neutral, PublicKeyToken=edbe51ad942a3f5c
// MVID: BBD9ABA3-3797-4E5D-B8C5-A361E0F7EC0C
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Ionic.Zip.dll

using System.Runtime.InteropServices;

#nullable disable
namespace Ionic.Zip;

[ComVisible(true)]
[Guid("ebc25cf6-9120-4283-b972-0e5520d0000F")]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
public class ComHelper
{
  public bool IsZipFile(string filename) => ZipFile.IsZipFile(filename);

  public bool IsZipFileWithExtract(string filename) => ZipFile.IsZipFile(filename, true);

  public bool CheckZip(string filename) => ZipFile.CheckZip(filename);

  public bool CheckZipPassword(string filename, string password)
  {
    return ZipFile.CheckZipPassword(filename, password);
  }

  public void FixZipDirectory(string filename) => ZipFile.FixZipDirectory(filename);

  public string GetZipLibraryVersion() => ZipFile.LibraryVersion.ToString();
}
