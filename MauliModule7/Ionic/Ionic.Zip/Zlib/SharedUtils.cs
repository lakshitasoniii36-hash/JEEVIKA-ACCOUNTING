// Decompiled with JetBrains decompiler
// Type: Ionic.Zlib.SharedUtils
// Assembly: Ionic.Zip, Version=1.9.1.8, Culture=neutral, PublicKeyToken=edbe51ad942a3f5c
// MVID: BBD9ABA3-3797-4E5D-B8C5-A361E0F7EC0C
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Ionic.Zip.dll

using System.IO;
using System.Text;

#nullable disable
namespace Ionic.Zlib;

internal class SharedUtils
{
  public static int URShift(int number, int bits) => number >>> bits;

  public static int ReadInput(TextReader sourceTextReader, byte[] target, int start, int count)
  {
    if (target.Length == 0)
      return 0;
    char[] buffer = new char[target.Length];
    int num = sourceTextReader.Read(buffer, start, count);
    if (num == 0)
      return -1;
    for (int index = start; index < start + num; ++index)
      target[index] = (byte) buffer[index];
    return num;
  }

  internal static byte[] ToByteArray(string sourceString) => Encoding.UTF8.GetBytes(sourceString);

  internal static char[] ToCharArray(byte[] byteArray) => Encoding.UTF8.GetChars(byteArray);
}
