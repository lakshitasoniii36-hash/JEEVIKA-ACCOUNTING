// Decompiled with JetBrains decompiler
// Type: CrystalDecisions.ReportAppServer.Prompting.ICRPromptingUtilDisp
// Assembly: CrystalDecisions.ReportAppServer.Prompting, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304
// MVID: 50393773-D187-42C3-9A0E-7AAAF93C2C84
// Assembly location: C:\WINDOWS\assembly\GAC_MSIL\CrystalDecisions.ReportAppServer.Prompting\13.0.2000.0__692fbea5521e1304\CrystalDecisions.ReportAppServer.Prompting.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace CrystalDecisions.ReportAppServer.Prompting;

[TypeLibType(4688)]
[Guid("3D95DAB6-F983-4E0D-9AE3-E030C9DCB1DE")]
[ComImport]
public interface ICRPromptingUtilDisp
{
  [DispId(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  PromptingUnits createParameterPromptingUnits([MarshalAs(UnmanagedType.Interface), In] CRParameterInstances paramInstances);

  [DispId(2)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  CRParameterInstances resolveParameterPromptingUnits([MarshalAs(UnmanagedType.Interface), In] PromptingResolveUnits units);

  [DispId(3)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  PromptPickList createPickList(
    [MarshalAs(UnmanagedType.BStr), In] string colName,
    [MarshalAs(UnmanagedType.BStr), In] string colFieldID,
    [In] ParameterValueType colValueType,
    [In] bool colVisible = true);

  [DispId(4)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void addColumnToPickList(
    [MarshalAs(UnmanagedType.Interface), In] PromptPickList pickList,
    [MarshalAs(UnmanagedType.BStr), In] string colName,
    [MarshalAs(UnmanagedType.BStr), In] string colFieldID,
    [In] ParameterValueType colValueType,
    [In] bool colVisible = true);

  [DispId(5)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  PromptPickList createStaticPickList(
    [MarshalAs(UnmanagedType.BStr), In] string browseFieldID,
    [In] ParameterValueType ValueType,
    [In] bool valueVisible = true);

  [DispId(6)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  PromptGroup createPromptGroup(
    [MarshalAs(UnmanagedType.BStr), In] string Name,
    [MarshalAs(UnmanagedType.BStr), In] string Description,
    [MarshalAs(UnmanagedType.BStr), In] string FieldID,
    [MarshalAs(UnmanagedType.BStr), In] string lovdsRef,
    [In] ParameterValueType ValueType);

  [DispId(7)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Prompt createPrompt(
    [MarshalAs(UnmanagedType.BStr), In] string Name,
    [MarshalAs(UnmanagedType.BStr), In] string Description,
    [MarshalAs(UnmanagedType.BStr), In] string FieldID,
    [In] ParameterValueType ValueType);

  [DispId(8)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  PromptGroup createStaticPromptGroup(
    [MarshalAs(UnmanagedType.BStr), In] string Name,
    [MarshalAs(UnmanagedType.BStr), In] string Description,
    [MarshalAs(UnmanagedType.BStr), In] string browseFieldID,
    [In] ParameterValueType ValueType);

  [DispId(9)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Prompt createStaticPrompt(
    [MarshalAs(UnmanagedType.BStr), In] string Name,
    [MarshalAs(UnmanagedType.BStr), In] string Description,
    [MarshalAs(UnmanagedType.BStr), In] string browseFieldID,
    [In] ParameterValueType ValueType);

  [DispId(20)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  DiscreteValue createDiscreteValue([In] ParameterValueType ValueType, [In] uint lcid, [MarshalAs(UnmanagedType.Struct), In] object vtValue);

  [DispId(21)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string convertVariantToPromptingValue([In] ParameterValueType ValueType, [In] uint lcid, [MarshalAs(UnmanagedType.Struct), In] object input);

  [DispId(22)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object convertPromptingValueToVariant([In] ParameterValueType ValueType, [MarshalAs(UnmanagedType.BStr), In] string input);

  [DispId(23)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object convertPromptingValueToVariantEx(
    [In] ParameterValueType ValueType,
    [In] uint lcid,
    [MarshalAs(UnmanagedType.BStr), In] string input,
    [In] ushort vtType);

  [DispId(24)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void sortPickList([MarshalAs(UnmanagedType.Interface), In] PromptPickList pickList);

  [DispId(25)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void validateValues([MarshalAs(UnmanagedType.Interface), In] Prompt Prompt, [MarshalAs(UnmanagedType.Interface), In] Values2 values);

  [DispId(26)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  PromptingUnits createCEParameterPromptingUnits([MarshalAs(UnmanagedType.IDispatch), In] object Parameters);

  [DispId(27)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object resolveCEParameterPromptingUnits([MarshalAs(UnmanagedType.Interface), In] PromptingResolveUnits units);

  [DispId(31 /*0x1F*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  PromptingUnits createParameterPromptingUnitsEx([In] uint lcid, [MarshalAs(UnmanagedType.Interface), In] CRParameterInstances paramInstances);

  [DispId(32 /*0x20*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  CRParameterInstances resolveParameterPromptingUnitsEx([In] uint lcid, [MarshalAs(UnmanagedType.Interface), In] PromptingResolveUnits units);

  [DispId(33)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  PromptingUnits createCEParameterPromptingUnitsEx([In] uint lcid, [MarshalAs(UnmanagedType.IDispatch), In] object Parameters);

  [DispId(34)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object resolveCEParameterPromptingUnitsEx([In] uint lcid, [MarshalAs(UnmanagedType.Interface), In] PromptingResolveUnits units);

  [DispId(35)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void sortPickListEx([In] uint lcid, [MarshalAs(UnmanagedType.Interface), In] PromptPickList pickList);

  [DispId(36)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void validateValuesEx([In] uint lcid, [MarshalAs(UnmanagedType.Interface), In] Prompt Prompt, [MarshalAs(UnmanagedType.Interface), In] Values2 values);

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(1610743831)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void reserve20();

  [DispId(1610743832)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void reserve19();

  [DispId(1610743833)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void reserve18();

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(1610743834)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void reserve17();

  [DispId(1610743835)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void reserve16();

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(1610743836)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void reserve15();

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(1610743837)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void reserve14();

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(1610743838)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void reserve13();

  [DispId(1610743839)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void reserve12();

  [DispId(1610743840 /*0x60020020*/)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void reserve11();

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(1610743841)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void reserve10();

  [DispId(1610743842)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void reserve9();

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(1610743843)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void reserve8();

  [DispId(1610743844)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void reserve7();

  [DispId(1610743845)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void reserve6();

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(1610743846)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void reserve5();

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(1610743847)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void reserve4();

  [DispId(1610743848)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void reserve3();

  [DispId(1610743849)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void reserve2();

  [DispId(1610743850)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void reserve1();
}
