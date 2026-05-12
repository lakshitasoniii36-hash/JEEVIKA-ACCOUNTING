// Decompiled with JetBrains decompiler
// Type: CrystalDecisions.ReportAppServer.Prompting.CRPromptingUtilClass
// Assembly: CrystalDecisions.ReportAppServer.Prompting, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304
// MVID: 50393773-D187-42C3-9A0E-7AAAF93C2C84
// Assembly location: C:\WINDOWS\assembly\GAC_MSIL\CrystalDecisions.ReportAppServer.Prompting\13.0.2000.0__692fbea5521e1304\CrystalDecisions.ReportAppServer.Prompting.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace CrystalDecisions.ReportAppServer.Prompting;

[TypeLibType(530)]
[Guid("E493820E-E623-496C-83CE-CABB36EDD605")]
[ClassInterface(0)]
[ComImport]
public class CRPromptingUtilClass : ICRPromptingUtilDisp, CRPromptingUtil
{
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public extern CRPromptingUtilClass();

  [DispId(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  public virtual extern PromptingUnits createParameterPromptingUnits(
    [MarshalAs(UnmanagedType.Interface), In] CRParameterInstances paramInstances);

  [DispId(2)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  public virtual extern CRParameterInstances resolveParameterPromptingUnits(
    [MarshalAs(UnmanagedType.Interface), In] PromptingResolveUnits units);

  [DispId(3)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  public virtual extern PromptPickList createPickList(
    [MarshalAs(UnmanagedType.BStr), In] string colName,
    [MarshalAs(UnmanagedType.BStr), In] string colFieldID,
    [In] ParameterValueType colValueType,
    [In] bool colVisible = true);

  [DispId(4)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void addColumnToPickList(
    [MarshalAs(UnmanagedType.Interface), In] PromptPickList pickList,
    [MarshalAs(UnmanagedType.BStr), In] string colName,
    [MarshalAs(UnmanagedType.BStr), In] string colFieldID,
    [In] ParameterValueType colValueType,
    [In] bool colVisible = true);

  [DispId(5)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  public virtual extern PromptPickList createStaticPickList(
    [MarshalAs(UnmanagedType.BStr), In] string browseFieldID,
    [In] ParameterValueType ValueType,
    [In] bool valueVisible = true);

  [DispId(6)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  public virtual extern PromptGroup createPromptGroup(
    [MarshalAs(UnmanagedType.BStr), In] string Name,
    [MarshalAs(UnmanagedType.BStr), In] string Description,
    [MarshalAs(UnmanagedType.BStr), In] string FieldID,
    [MarshalAs(UnmanagedType.BStr), In] string lovdsRef,
    [In] ParameterValueType ValueType);

  [DispId(7)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  public virtual extern Prompt createPrompt(
    [MarshalAs(UnmanagedType.BStr), In] string Name,
    [MarshalAs(UnmanagedType.BStr), In] string Description,
    [MarshalAs(UnmanagedType.BStr), In] string FieldID,
    [In] ParameterValueType ValueType);

  [DispId(8)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  public virtual extern PromptGroup createStaticPromptGroup(
    [MarshalAs(UnmanagedType.BStr), In] string Name,
    [MarshalAs(UnmanagedType.BStr), In] string Description,
    [MarshalAs(UnmanagedType.BStr), In] string browseFieldID,
    [In] ParameterValueType ValueType);

  [DispId(9)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  public virtual extern Prompt createStaticPrompt(
    [MarshalAs(UnmanagedType.BStr), In] string Name,
    [MarshalAs(UnmanagedType.BStr), In] string Description,
    [MarshalAs(UnmanagedType.BStr), In] string browseFieldID,
    [In] ParameterValueType ValueType);

  [DispId(20)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  public virtual extern DiscreteValue createDiscreteValue(
    [In] ParameterValueType ValueType,
    [In] uint lcid,
    [MarshalAs(UnmanagedType.Struct), In] object vtValue);

  [DispId(21)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  public virtual extern string convertVariantToPromptingValue(
    [In] ParameterValueType ValueType,
    [In] uint lcid,
    [MarshalAs(UnmanagedType.Struct), In] object input);

  [DispId(22)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  public virtual extern object convertPromptingValueToVariant(
    [In] ParameterValueType ValueType,
    [MarshalAs(UnmanagedType.BStr), In] string input);

  [DispId(23)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  public virtual extern object convertPromptingValueToVariantEx(
    [In] ParameterValueType ValueType,
    [In] uint lcid,
    [MarshalAs(UnmanagedType.BStr), In] string input,
    [In] ushort vtType);

  [DispId(24)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void sortPickList([MarshalAs(UnmanagedType.Interface), In] PromptPickList pickList);

  [DispId(25)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void validateValues([MarshalAs(UnmanagedType.Interface), In] Prompt Prompt, [MarshalAs(UnmanagedType.Interface), In] Values2 values);

  [DispId(26)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  public virtual extern PromptingUnits createCEParameterPromptingUnits([MarshalAs(UnmanagedType.IDispatch), In] object Parameters);

  [DispId(27)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  public virtual extern object resolveCEParameterPromptingUnits([MarshalAs(UnmanagedType.Interface), In] PromptingResolveUnits units);

  [DispId(31 /*0x1F*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  public virtual extern PromptingUnits createParameterPromptingUnitsEx(
    [In] uint lcid,
    [MarshalAs(UnmanagedType.Interface), In] CRParameterInstances paramInstances);

  [DispId(32 /*0x20*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  public virtual extern CRParameterInstances resolveParameterPromptingUnitsEx(
    [In] uint lcid,
    [MarshalAs(UnmanagedType.Interface), In] PromptingResolveUnits units);

  [DispId(33)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  public virtual extern PromptingUnits createCEParameterPromptingUnitsEx(
    [In] uint lcid,
    [MarshalAs(UnmanagedType.IDispatch), In] object Parameters);

  [DispId(34)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  public virtual extern object resolveCEParameterPromptingUnitsEx(
    [In] uint lcid,
    [MarshalAs(UnmanagedType.Interface), In] PromptingResolveUnits units);

  [DispId(35)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void sortPickListEx([In] uint lcid, [MarshalAs(UnmanagedType.Interface), In] PromptPickList pickList);

  [DispId(36)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void validateValuesEx([In] uint lcid, [MarshalAs(UnmanagedType.Interface), In] Prompt Prompt, [MarshalAs(UnmanagedType.Interface), In] Values2 values);

  [DispId(1610743831)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void reserve20();

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(1610743832)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void reserve19();

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(1610743833)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void reserve18();

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(1610743834)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void reserve17();

  [DispId(1610743835)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void reserve16();

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(1610743836)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void reserve15();

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(1610743837)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void reserve14();

  [DispId(1610743838)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void reserve13();

  [DispId(1610743839)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void reserve12();

  [DispId(1610743840 /*0x60020020*/)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void reserve11();

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(1610743841)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void reserve10();

  [DispId(1610743842)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void reserve9();

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(1610743843)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void reserve8();

  [DispId(1610743844)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void reserve7();

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(1610743845)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void reserve6();

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(1610743846)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void reserve5();

  [DispId(1610743847)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void reserve4();

  [DispId(1610743848)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void reserve3();

  [DispId(1610743849)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void reserve2();

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(1610743850)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void reserve1();
}
