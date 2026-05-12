// Decompiled with JetBrains decompiler
// Type: ShockwaveFlashObjects.IFlashObjectInterface
// Assembly: ShockwaveFlashObjects, Version=1.0.0.0, Culture=neutral, PublicKeyToken=692fbea5521e1304
// MVID: 074923B7-35CE-44D7-AC6B-153DD1515B7D
// Assembly location: C:\WINDOWS\assembly\GAC\ShockwaveFlashObjects\1.0.0.0__692fbea5521e1304\ShockwaveFlashObjects.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace ShockwaveFlashObjects;

[Guid("D27CDB72-AE6D-11CF-96B8-444553540000")]
[TypeLibType(4096 /*0x1000*/)]
[ComImport]
public interface IFlashObjectInterface : IDispatchEx
{
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  new void GetDispID([MarshalAs(UnmanagedType.BStr), In] string bstrName, [In] uint grfdex, out int pid);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  new void RemoteInvokeEx(
    [In] int id,
    [In] uint lcid,
    [In] uint dwFlags,
    [In] ref stdole.DISPPARAMS pdp,
    [MarshalAs(UnmanagedType.Struct)] out object pvarRes,
    out stdole.EXCEPINFO pei,
    [MarshalAs(UnmanagedType.Interface), In] IServiceProvider pspCaller,
    [In] uint cvarRefArg,
    [In] ref uint rgiRefArg,
    [MarshalAs(UnmanagedType.Struct), In, Out] ref object rgvarRefArg);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  new void DeleteMemberByName([MarshalAs(UnmanagedType.BStr), In] string bstrName, [In] uint grfdex);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  new void DeleteMemberByDispID([In] int id);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  new void GetMemberProperties([In] int id, [In] uint grfdexFetch, out uint pgrfdex);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  new void GetMemberName([In] int id, [MarshalAs(UnmanagedType.BStr)] out string pbstrName);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  new void GetNextDispID([In] uint grfdex, [In] int id, out int pid);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  new void GetNameSpaceParent([MarshalAs(UnmanagedType.IUnknown)] out object ppunk);
}
