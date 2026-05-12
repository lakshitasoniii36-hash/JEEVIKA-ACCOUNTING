// Decompiled with JetBrains decompiler
// Type: ADOX.DataTypeEnum
// Assembly: Interop.ADOX, Version=2.8.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 69CDF16F-3374-4ED0-952A-9EAF19059C50
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Interop.ADOX.dll

#nullable disable
namespace ADOX;

public enum DataTypeEnum
{
  adEmpty = 0,
  adSmallInt = 2,
  adInteger = 3,
  adSingle = 4,
  adDouble = 5,
  adCurrency = 6,
  adDate = 7,
  adBSTR = 8,
  adIDispatch = 9,
  adError = 10, // 0x0000000A
  adBoolean = 11, // 0x0000000B
  adVariant = 12, // 0x0000000C
  adIUnknown = 13, // 0x0000000D
  adDecimal = 14, // 0x0000000E
  adTinyInt = 16, // 0x00000010
  adUnsignedTinyInt = 17, // 0x00000011
  adUnsignedSmallInt = 18, // 0x00000012
  adUnsignedInt = 19, // 0x00000013
  adBigInt = 20, // 0x00000014
  adUnsignedBigInt = 21, // 0x00000015
  adFileTime = 64, // 0x00000040
  adGUID = 72, // 0x00000048
  adBinary = 128, // 0x00000080
  adChar = 129, // 0x00000081
  adWChar = 130, // 0x00000082
  adNumeric = 131, // 0x00000083
  adUserDefined = 132, // 0x00000084
  adDBDate = 133, // 0x00000085
  adDBTime = 134, // 0x00000086
  adDBTimeStamp = 135, // 0x00000087
  adChapter = 136, // 0x00000088
  adPropVariant = 138, // 0x0000008A
  adVarNumeric = 139, // 0x0000008B
  adVarChar = 200, // 0x000000C8
  adLongVarChar = 201, // 0x000000C9
  adVarWChar = 202, // 0x000000CA
  adLongVarWChar = 203, // 0x000000CB
  adVarBinary = 204, // 0x000000CC
  adLongVarBinary = 205, // 0x000000CD
}
