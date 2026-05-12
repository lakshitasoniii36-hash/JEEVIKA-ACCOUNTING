// Decompiled with JetBrains decompiler
// Type: ADOX.RightsEnum
// Assembly: Interop.ADOX, Version=2.8.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 69CDF16F-3374-4ED0-952A-9EAF19059C50
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Interop.ADOX.dll

#nullable disable
namespace ADOX;

public enum RightsEnum
{
  adRightRead = -2147483648, // 0x80000000
  adRightNone = 0,
  adRightDrop = 256, // 0x00000100
  adRightExclusive = 512, // 0x00000200
  adRightReadDesign = 1024, // 0x00000400
  adRightWriteDesign = 2048, // 0x00000800
  adRightWithGrant = 4096, // 0x00001000
  adRightReference = 8192, // 0x00002000
  adRightCreate = 16384, // 0x00004000
  adRightInsert = 32768, // 0x00008000
  adRightDelete = 65536, // 0x00010000
  adRightReadPermissions = 131072, // 0x00020000
  adRightWritePermissions = 262144, // 0x00040000
  adRightWriteOwner = 524288, // 0x00080000
  adRightMaximumAllowed = 33554432, // 0x02000000
  adRightFull = 268435456, // 0x10000000
  adRightExecute = 536870912, // 0x20000000
  adRightUpdate = 1073741824, // 0x40000000
}
