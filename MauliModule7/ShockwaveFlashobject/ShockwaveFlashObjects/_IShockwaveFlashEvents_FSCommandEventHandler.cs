// Decompiled with JetBrains decompiler
// Type: ShockwaveFlashObjects._IShockwaveFlashEvents_FSCommandEventHandler
// Assembly: ShockwaveFlashObjects, Version=1.0.0.0, Culture=neutral, PublicKeyToken=692fbea5521e1304
// MVID: 074923B7-35CE-44D7-AC6B-153DD1515B7D
// Assembly location: C:\WINDOWS\assembly\GAC\ShockwaveFlashObjects\1.0.0.0__692fbea5521e1304\ShockwaveFlashObjects.dll

using System.Runtime.InteropServices;

#nullable disable
namespace ShockwaveFlashObjects;

[TypeLibType(16 /*0x10*/)]
[ComVisible(false)]
public delegate void _IShockwaveFlashEvents_FSCommandEventHandler([MarshalAs(UnmanagedType.BStr), In] string command, [MarshalAs(UnmanagedType.BStr), In] string args);
