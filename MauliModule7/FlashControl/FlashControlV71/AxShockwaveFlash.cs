// Decompiled with JetBrains decompiler
// Type: FlashControlV71.AxShockwaveFlash
// Assembly: FlashControlV71, Version=1.0.3187.32366, Culture=neutral, PublicKeyToken=692fbea5521e1304
// MVID: 040B5991-52B3-42C2-AAE4-00B537F75ED6
// Assembly location: C:\WINDOWS\assembly\GAC\FlashControlV71\1.0.3187.32366__692fbea5521e1304\FlashControlV71.dll

using ShockwaveFlashObjects;
using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;

#nullable disable
namespace FlashControlV71;

[ToolboxItem(true)]
[DesignTimeVisible(true)]
[AxHost.Clsid("{d27cdb6e-ae6d-11cf-96b8-444553540000}")]
public class AxShockwaveFlash : AxHost
{
  private IShockwaveFlash ocx;
  private AxShockwaveFlashEventMulticaster eventMulticaster;
  private AxHost.ConnectionPointCookie cookie;

  public AxShockwaveFlash()
    : base("d27cdb6e-ae6d-11cf-96b8-444553540000")
  {
  }

  [DispId(-525)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public virtual int ReadyState
  {
    get
    {
      return this.ocx != null ? this.ocx.ReadyState : throw new AxHost.InvalidActiveXStateException(nameof (ReadyState), AxHost.ActiveXInvokeKind.PropertyGet);
    }
  }

  [DispId(124)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public virtual int TotalFrames
  {
    get
    {
      return this.ocx != null ? this.ocx.TotalFrames : throw new AxHost.InvalidActiveXStateException(nameof (TotalFrames), AxHost.ActiveXInvokeKind.PropertyGet);
    }
  }

  [DispId(125)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public virtual bool Playing
  {
    get
    {
      return this.ocx != null ? this.ocx.Playing : throw new AxHost.InvalidActiveXStateException(nameof (Playing), AxHost.ActiveXInvokeKind.PropertyGet);
    }
    set
    {
      if (this.ocx == null)
        throw new AxHost.InvalidActiveXStateException(nameof (Playing), AxHost.ActiveXInvokeKind.PropertySet);
      this.ocx.Playing = value;
    }
  }

  [DispId(105)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public virtual int Quality
  {
    get
    {
      return this.ocx != null ? this.ocx.Quality : throw new AxHost.InvalidActiveXStateException(nameof (Quality), AxHost.ActiveXInvokeKind.PropertyGet);
    }
    set
    {
      if (this.ocx == null)
        throw new AxHost.InvalidActiveXStateException(nameof (Quality), AxHost.ActiveXInvokeKind.PropertySet);
      this.ocx.Quality = value;
    }
  }

  [DispId(120)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public virtual int ScaleMode
  {
    get
    {
      return this.ocx != null ? this.ocx.ScaleMode : throw new AxHost.InvalidActiveXStateException(nameof (ScaleMode), AxHost.ActiveXInvokeKind.PropertyGet);
    }
    set
    {
      if (this.ocx == null)
        throw new AxHost.InvalidActiveXStateException(nameof (ScaleMode), AxHost.ActiveXInvokeKind.PropertySet);
      this.ocx.ScaleMode = value;
    }
  }

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [DispId(121)]
  public virtual int AlignMode
  {
    get
    {
      return this.ocx != null ? this.ocx.AlignMode : throw new AxHost.InvalidActiveXStateException(nameof (AlignMode), AxHost.ActiveXInvokeKind.PropertyGet);
    }
    set
    {
      if (this.ocx == null)
        throw new AxHost.InvalidActiveXStateException(nameof (AlignMode), AxHost.ActiveXInvokeKind.PropertySet);
      this.ocx.AlignMode = value;
    }
  }

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [DispId(123)]
  public virtual int BackgroundColor
  {
    get
    {
      return this.ocx != null ? this.ocx.BackgroundColor : throw new AxHost.InvalidActiveXStateException(nameof (BackgroundColor), AxHost.ActiveXInvokeKind.PropertyGet);
    }
    set
    {
      if (this.ocx == null)
        throw new AxHost.InvalidActiveXStateException(nameof (BackgroundColor), AxHost.ActiveXInvokeKind.PropertySet);
      this.ocx.BackgroundColor = value;
    }
  }

  [DispId(106)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public virtual bool Loop
  {
    get
    {
      return this.ocx != null ? this.ocx.Loop : throw new AxHost.InvalidActiveXStateException(nameof (Loop), AxHost.ActiveXInvokeKind.PropertyGet);
    }
    set
    {
      if (this.ocx == null)
        throw new AxHost.InvalidActiveXStateException(nameof (Loop), AxHost.ActiveXInvokeKind.PropertySet);
      this.ocx.Loop = value;
    }
  }

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [DispId(102)]
  public virtual string Movie
  {
    get
    {
      return this.ocx != null ? this.ocx.Movie : throw new AxHost.InvalidActiveXStateException(nameof (Movie), AxHost.ActiveXInvokeKind.PropertyGet);
    }
    set
    {
      if (this.ocx == null)
        throw new AxHost.InvalidActiveXStateException(nameof (Movie), AxHost.ActiveXInvokeKind.PropertySet);
      this.ocx.Movie = value;
    }
  }

  [DispId(107)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public virtual int FrameNum
  {
    get
    {
      return this.ocx != null ? this.ocx.FrameNum : throw new AxHost.InvalidActiveXStateException(nameof (FrameNum), AxHost.ActiveXInvokeKind.PropertyGet);
    }
    set
    {
      if (this.ocx == null)
        throw new AxHost.InvalidActiveXStateException(nameof (FrameNum), AxHost.ActiveXInvokeKind.PropertySet);
      this.ocx.FrameNum = value;
    }
  }

  [DispId(133)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public virtual string WMode
  {
    get
    {
      return this.ocx != null ? this.ocx.WMode : throw new AxHost.InvalidActiveXStateException(nameof (WMode), AxHost.ActiveXInvokeKind.PropertyGet);
    }
    set
    {
      if (this.ocx == null)
        throw new AxHost.InvalidActiveXStateException(nameof (WMode), AxHost.ActiveXInvokeKind.PropertySet);
      this.ocx.WMode = value;
    }
  }

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [DispId(134)]
  public virtual string SAlign
  {
    get
    {
      return this.ocx != null ? this.ocx.SAlign : throw new AxHost.InvalidActiveXStateException(nameof (SAlign), AxHost.ActiveXInvokeKind.PropertyGet);
    }
    set
    {
      if (this.ocx == null)
        throw new AxHost.InvalidActiveXStateException(nameof (SAlign), AxHost.ActiveXInvokeKind.PropertySet);
      this.ocx.SAlign = value;
    }
  }

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [DispId(135)]
  public virtual bool Menu
  {
    get
    {
      return this.ocx != null ? this.ocx.Menu : throw new AxHost.InvalidActiveXStateException(nameof (Menu), AxHost.ActiveXInvokeKind.PropertyGet);
    }
    set
    {
      if (this.ocx == null)
        throw new AxHost.InvalidActiveXStateException(nameof (Menu), AxHost.ActiveXInvokeKind.PropertySet);
      this.ocx.Menu = value;
    }
  }

  [DispId(136)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public virtual string Base
  {
    get
    {
      return this.ocx != null ? this.ocx.Base : throw new AxHost.InvalidActiveXStateException(nameof (Base), AxHost.ActiveXInvokeKind.PropertyGet);
    }
    set
    {
      if (this.ocx == null)
        throw new AxHost.InvalidActiveXStateException(nameof (Base), AxHost.ActiveXInvokeKind.PropertySet);
      this.ocx.Base = value;
    }
  }

  [DispId(137)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public virtual string CtlScale
  {
    get
    {
      return this.ocx != null ? this.ocx.Scale : throw new AxHost.InvalidActiveXStateException(nameof (CtlScale), AxHost.ActiveXInvokeKind.PropertyGet);
    }
    set
    {
      if (this.ocx == null)
        throw new AxHost.InvalidActiveXStateException(nameof (CtlScale), AxHost.ActiveXInvokeKind.PropertySet);
      this.ocx.Scale = value;
    }
  }

  [DispId(138)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public virtual bool DeviceFont
  {
    get
    {
      return this.ocx != null ? this.ocx.DeviceFont : throw new AxHost.InvalidActiveXStateException(nameof (DeviceFont), AxHost.ActiveXInvokeKind.PropertyGet);
    }
    set
    {
      if (this.ocx == null)
        throw new AxHost.InvalidActiveXStateException(nameof (DeviceFont), AxHost.ActiveXInvokeKind.PropertySet);
      this.ocx.DeviceFont = value;
    }
  }

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [DispId(139)]
  public virtual bool EmbedMovie
  {
    get
    {
      return this.ocx != null ? this.ocx.EmbedMovie : throw new AxHost.InvalidActiveXStateException(nameof (EmbedMovie), AxHost.ActiveXInvokeKind.PropertyGet);
    }
    set
    {
      if (this.ocx == null)
        throw new AxHost.InvalidActiveXStateException(nameof (EmbedMovie), AxHost.ActiveXInvokeKind.PropertySet);
      this.ocx.EmbedMovie = value;
    }
  }

  [DispId(140)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public virtual string BGColor
  {
    get
    {
      return this.ocx != null ? this.ocx.BGColor : throw new AxHost.InvalidActiveXStateException(nameof (BGColor), AxHost.ActiveXInvokeKind.PropertyGet);
    }
    set
    {
      if (this.ocx == null)
        throw new AxHost.InvalidActiveXStateException(nameof (BGColor), AxHost.ActiveXInvokeKind.PropertySet);
      this.ocx.BGColor = value;
    }
  }

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [DispId(141)]
  public virtual string Quality2
  {
    get
    {
      return this.ocx != null ? this.ocx.Quality2 : throw new AxHost.InvalidActiveXStateException(nameof (Quality2), AxHost.ActiveXInvokeKind.PropertyGet);
    }
    set
    {
      if (this.ocx == null)
        throw new AxHost.InvalidActiveXStateException(nameof (Quality2), AxHost.ActiveXInvokeKind.PropertySet);
      this.ocx.Quality2 = value;
    }
  }

  [DispId(159)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public virtual string SWRemote
  {
    get
    {
      return this.ocx != null ? this.ocx.SWRemote : throw new AxHost.InvalidActiveXStateException(nameof (SWRemote), AxHost.ActiveXInvokeKind.PropertyGet);
    }
    set
    {
      if (this.ocx == null)
        throw new AxHost.InvalidActiveXStateException(nameof (SWRemote), AxHost.ActiveXInvokeKind.PropertySet);
      this.ocx.SWRemote = value;
    }
  }

  [DispId(170)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public virtual string FlashVars
  {
    get
    {
      return this.ocx != null ? this.ocx.FlashVars : throw new AxHost.InvalidActiveXStateException(nameof (FlashVars), AxHost.ActiveXInvokeKind.PropertyGet);
    }
    set
    {
      if (this.ocx == null)
        throw new AxHost.InvalidActiveXStateException(nameof (FlashVars), AxHost.ActiveXInvokeKind.PropertySet);
      this.ocx.FlashVars = value;
    }
  }

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [DispId(171)]
  public virtual string AllowScriptAccess
  {
    get
    {
      return this.ocx != null ? this.ocx.AllowScriptAccess : throw new AxHost.InvalidActiveXStateException(nameof (AllowScriptAccess), AxHost.ActiveXInvokeKind.PropertyGet);
    }
    set
    {
      if (this.ocx == null)
        throw new AxHost.InvalidActiveXStateException(nameof (AllowScriptAccess), AxHost.ActiveXInvokeKind.PropertySet);
      this.ocx.AllowScriptAccess = value;
    }
  }

  [DispId(190)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public virtual string MovieData
  {
    get
    {
      return this.ocx != null ? this.ocx.MovieData : throw new AxHost.InvalidActiveXStateException(nameof (MovieData), AxHost.ActiveXInvokeKind.PropertyGet);
    }
    set
    {
      if (this.ocx == null)
        throw new AxHost.InvalidActiveXStateException(nameof (MovieData), AxHost.ActiveXInvokeKind.PropertySet);
      this.ocx.MovieData = value;
    }
  }

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [DispId(191)]
  public virtual object InlineData
  {
    get
    {
      return this.ocx != null ? this.ocx.InlineData : throw new AxHost.InvalidActiveXStateException(nameof (InlineData), AxHost.ActiveXInvokeKind.PropertyGet);
    }
    set
    {
      if (this.ocx == null)
        throw new AxHost.InvalidActiveXStateException(nameof (InlineData), AxHost.ActiveXInvokeKind.PropertySet);
      this.ocx.InlineData = value;
    }
  }

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [DispId(192 /*0xC0*/)]
  public virtual bool SeamlessTabbing
  {
    get
    {
      return this.ocx != null ? this.ocx.SeamlessTabbing : throw new AxHost.InvalidActiveXStateException(nameof (SeamlessTabbing), AxHost.ActiveXInvokeKind.PropertyGet);
    }
    set
    {
      if (this.ocx == null)
        throw new AxHost.InvalidActiveXStateException(nameof (SeamlessTabbing), AxHost.ActiveXInvokeKind.PropertySet);
      this.ocx.SeamlessTabbing = value;
    }
  }

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [DispId(194)]
  public virtual bool Profile
  {
    get
    {
      return this.ocx != null ? this.ocx.Profile : throw new AxHost.InvalidActiveXStateException(nameof (Profile), AxHost.ActiveXInvokeKind.PropertyGet);
    }
    set
    {
      if (this.ocx == null)
        throw new AxHost.InvalidActiveXStateException(nameof (Profile), AxHost.ActiveXInvokeKind.PropertySet);
      this.ocx.Profile = value;
    }
  }

  [DispId(195)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public virtual string ProfileAddress
  {
    get
    {
      return this.ocx != null ? this.ocx.ProfileAddress : throw new AxHost.InvalidActiveXStateException(nameof (ProfileAddress), AxHost.ActiveXInvokeKind.PropertyGet);
    }
    set
    {
      if (this.ocx == null)
        throw new AxHost.InvalidActiveXStateException(nameof (ProfileAddress), AxHost.ActiveXInvokeKind.PropertySet);
      this.ocx.ProfileAddress = value;
    }
  }

  [DispId(196)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public virtual int ProfilePort
  {
    get
    {
      return this.ocx != null ? this.ocx.ProfilePort : throw new AxHost.InvalidActiveXStateException(nameof (ProfilePort), AxHost.ActiveXInvokeKind.PropertyGet);
    }
    set
    {
      if (this.ocx == null)
        throw new AxHost.InvalidActiveXStateException(nameof (ProfilePort), AxHost.ActiveXInvokeKind.PropertySet);
      this.ocx.ProfilePort = value;
    }
  }

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [DispId(201)]
  public virtual string AllowNetworking
  {
    get
    {
      return this.ocx != null ? this.ocx.AllowNetworking : throw new AxHost.InvalidActiveXStateException(nameof (AllowNetworking), AxHost.ActiveXInvokeKind.PropertyGet);
    }
    set
    {
      if (this.ocx == null)
        throw new AxHost.InvalidActiveXStateException(nameof (AllowNetworking), AxHost.ActiveXInvokeKind.PropertySet);
      this.ocx.AllowNetworking = value;
    }
  }

  public event _IShockwaveFlashEvents_FlashCallEventHandler FlashCall;

  public event _IShockwaveFlashEvents_FSCommandEventHandler FSCommand;

  public event _IShockwaveFlashEvents_OnProgressEventHandler OnProgress;

  public event _IShockwaveFlashEvents_OnReadyStateChangeEventHandler OnReadyStateChange;

  public virtual void DisableLocalSecurity()
  {
    if (this.ocx == null)
      throw new AxHost.InvalidActiveXStateException(nameof (DisableLocalSecurity), AxHost.ActiveXInvokeKind.MethodInvoke);
    this.ocx.DisableLocalSecurity();
  }

  public virtual void SetReturnValue(string returnValue)
  {
    if (this.ocx == null)
      throw new AxHost.InvalidActiveXStateException(nameof (SetReturnValue), AxHost.ActiveXInvokeKind.MethodInvoke);
    this.ocx.SetReturnValue(returnValue);
  }

  public virtual string CallFunction(string request)
  {
    return this.ocx != null ? this.ocx.CallFunction(request) : throw new AxHost.InvalidActiveXStateException(nameof (CallFunction), AxHost.ActiveXInvokeKind.MethodInvoke);
  }

  public virtual void EnforceLocalSecurity()
  {
    if (this.ocx == null)
      throw new AxHost.InvalidActiveXStateException(nameof (EnforceLocalSecurity), AxHost.ActiveXInvokeKind.MethodInvoke);
    this.ocx.EnforceLocalSecurity();
  }

  public virtual double TGetPropertyAsNumber(string target, int property)
  {
    if (this.ocx == null)
      throw new AxHost.InvalidActiveXStateException(nameof (TGetPropertyAsNumber), AxHost.ActiveXInvokeKind.MethodInvoke);
    return this.ocx.TGetPropertyAsNumber(target, property);
  }

  public virtual double TGetPropertyNum(string target, int property)
  {
    if (this.ocx == null)
      throw new AxHost.InvalidActiveXStateException(nameof (TGetPropertyNum), AxHost.ActiveXInvokeKind.MethodInvoke);
    return this.ocx.TGetPropertyNum(target, property);
  }

  public virtual void TSetPropertyNum(string target, int property, double value)
  {
    if (this.ocx == null)
      throw new AxHost.InvalidActiveXStateException(nameof (TSetPropertyNum), AxHost.ActiveXInvokeKind.MethodInvoke);
    this.ocx.TSetPropertyNum(target, property, value);
  }

  public virtual void TCallLabel(string target, string label)
  {
    if (this.ocx == null)
      throw new AxHost.InvalidActiveXStateException(nameof (TCallLabel), AxHost.ActiveXInvokeKind.MethodInvoke);
    this.ocx.TCallLabel(target, label);
  }

  public virtual void TCallFrame(string target, int frameNum)
  {
    if (this.ocx == null)
      throw new AxHost.InvalidActiveXStateException(nameof (TCallFrame), AxHost.ActiveXInvokeKind.MethodInvoke);
    this.ocx.TCallFrame(target, frameNum);
  }

  public virtual string TGetProperty(string target, int property)
  {
    if (this.ocx == null)
      throw new AxHost.InvalidActiveXStateException(nameof (TGetProperty), AxHost.ActiveXInvokeKind.MethodInvoke);
    return this.ocx.TGetProperty(target, property);
  }

  public virtual void TSetProperty(string target, int property, string value)
  {
    if (this.ocx == null)
      throw new AxHost.InvalidActiveXStateException(nameof (TSetProperty), AxHost.ActiveXInvokeKind.MethodInvoke);
    this.ocx.TSetProperty(target, property, value);
  }

  public virtual string GetVariable(string name)
  {
    return this.ocx != null ? this.ocx.GetVariable(name) : throw new AxHost.InvalidActiveXStateException(nameof (GetVariable), AxHost.ActiveXInvokeKind.MethodInvoke);
  }

  public virtual void SetVariable(string name, string value)
  {
    if (this.ocx == null)
      throw new AxHost.InvalidActiveXStateException(nameof (SetVariable), AxHost.ActiveXInvokeKind.MethodInvoke);
    this.ocx.SetVariable(name, value);
  }

  public virtual void TStopPlay(string target)
  {
    if (this.ocx == null)
      throw new AxHost.InvalidActiveXStateException(nameof (TStopPlay), AxHost.ActiveXInvokeKind.MethodInvoke);
    this.ocx.TStopPlay(target);
  }

  public virtual void TPlay(string target)
  {
    if (this.ocx == null)
      throw new AxHost.InvalidActiveXStateException(nameof (TPlay), AxHost.ActiveXInvokeKind.MethodInvoke);
    this.ocx.TPlay(target);
  }

  public virtual string TCurrentLabel(string target)
  {
    return this.ocx != null ? this.ocx.TCurrentLabel(target) : throw new AxHost.InvalidActiveXStateException(nameof (TCurrentLabel), AxHost.ActiveXInvokeKind.MethodInvoke);
  }

  public virtual int TCurrentFrame(string target)
  {
    return this.ocx != null ? this.ocx.TCurrentFrame(target) : throw new AxHost.InvalidActiveXStateException(nameof (TCurrentFrame), AxHost.ActiveXInvokeKind.MethodInvoke);
  }

  public virtual void TGotoLabel(string target, string label)
  {
    if (this.ocx == null)
      throw new AxHost.InvalidActiveXStateException(nameof (TGotoLabel), AxHost.ActiveXInvokeKind.MethodInvoke);
    this.ocx.TGotoLabel(target, label);
  }

  public virtual void TGotoFrame(string target, int frameNum)
  {
    if (this.ocx == null)
      throw new AxHost.InvalidActiveXStateException(nameof (TGotoFrame), AxHost.ActiveXInvokeKind.MethodInvoke);
    this.ocx.TGotoFrame(target, frameNum);
  }

  public virtual void LoadMovie(int layer, string url)
  {
    if (this.ocx == null)
      throw new AxHost.InvalidActiveXStateException(nameof (LoadMovie), AxHost.ActiveXInvokeKind.MethodInvoke);
    this.ocx.LoadMovie(layer, url);
  }

  public virtual int FlashVersion()
  {
    return this.ocx != null ? this.ocx.FlashVersion() : throw new AxHost.InvalidActiveXStateException(nameof (FlashVersion), AxHost.ActiveXInvokeKind.MethodInvoke);
  }

  public virtual bool FrameLoaded(int frameNum)
  {
    return this.ocx != null ? this.ocx.FrameLoaded(frameNum) : throw new AxHost.InvalidActiveXStateException(nameof (FrameLoaded), AxHost.ActiveXInvokeKind.MethodInvoke);
  }

  public virtual int PercentLoaded()
  {
    return this.ocx != null ? this.ocx.PercentLoaded() : throw new AxHost.InvalidActiveXStateException(nameof (PercentLoaded), AxHost.ActiveXInvokeKind.MethodInvoke);
  }

  public virtual bool IsPlaying()
  {
    return this.ocx != null ? this.ocx.IsPlaying() : throw new AxHost.InvalidActiveXStateException(nameof (IsPlaying), AxHost.ActiveXInvokeKind.MethodInvoke);
  }

  public virtual int CurrentFrame()
  {
    return this.ocx != null ? this.ocx.CurrentFrame() : throw new AxHost.InvalidActiveXStateException(nameof (CurrentFrame), AxHost.ActiveXInvokeKind.MethodInvoke);
  }

  public virtual void GotoFrame(int frameNum)
  {
    if (this.ocx == null)
      throw new AxHost.InvalidActiveXStateException(nameof (GotoFrame), AxHost.ActiveXInvokeKind.MethodInvoke);
    this.ocx.GotoFrame(frameNum);
  }

  public virtual void StopPlay()
  {
    if (this.ocx == null)
      throw new AxHost.InvalidActiveXStateException(nameof (StopPlay), AxHost.ActiveXInvokeKind.MethodInvoke);
    this.ocx.StopPlay();
  }

  public virtual void Rewind()
  {
    if (this.ocx == null)
      throw new AxHost.InvalidActiveXStateException(nameof (Rewind), AxHost.ActiveXInvokeKind.MethodInvoke);
    this.ocx.Rewind();
  }

  public virtual void Forward()
  {
    if (this.ocx == null)
      throw new AxHost.InvalidActiveXStateException(nameof (Forward), AxHost.ActiveXInvokeKind.MethodInvoke);
    this.ocx.Forward();
  }

  public virtual void Back()
  {
    if (this.ocx == null)
      throw new AxHost.InvalidActiveXStateException(nameof (Back), AxHost.ActiveXInvokeKind.MethodInvoke);
    this.ocx.Back();
  }

  public virtual void Stop()
  {
    if (this.ocx == null)
      throw new AxHost.InvalidActiveXStateException(nameof (Stop), AxHost.ActiveXInvokeKind.MethodInvoke);
    this.ocx.Stop();
  }

  public virtual void Play()
  {
    if (this.ocx == null)
      throw new AxHost.InvalidActiveXStateException(nameof (Play), AxHost.ActiveXInvokeKind.MethodInvoke);
    this.ocx.Play();
  }

  public virtual void Pan(int x, int y, int mode)
  {
    if (this.ocx == null)
      throw new AxHost.InvalidActiveXStateException(nameof (Pan), AxHost.ActiveXInvokeKind.MethodInvoke);
    this.ocx.Pan(x, y, mode);
  }

  public virtual void Zoom(int factor)
  {
    if (this.ocx == null)
      throw new AxHost.InvalidActiveXStateException(nameof (Zoom), AxHost.ActiveXInvokeKind.MethodInvoke);
    this.ocx.Zoom(factor);
  }

  public virtual void SetZoomRect(int left, int top, int right, int bottom)
  {
    if (this.ocx == null)
      throw new AxHost.InvalidActiveXStateException(nameof (SetZoomRect), AxHost.ActiveXInvokeKind.MethodInvoke);
    this.ocx.SetZoomRect(left, top, right, bottom);
  }

  protected override void CreateSink()
  {
    try
    {
      this.eventMulticaster = new AxShockwaveFlashEventMulticaster(this);
      this.cookie = new AxHost.ConnectionPointCookie((object) this.ocx, (object) this.eventMulticaster, typeof (_IShockwaveFlashEvents));
    }
    catch (Exception ex)
    {
    }
  }

  protected override void DetachSink()
  {
    try
    {
      this.cookie.Disconnect();
    }
    catch (Exception ex)
    {
    }
  }

  protected override void AttachInterfaces()
  {
    try
    {
      this.ocx = (IShockwaveFlash) this.GetOcx();
    }
    catch (Exception ex)
    {
    }
  }

  internal void RaiseOnFlashCall(object sender, _IShockwaveFlashEvents_FlashCallEvent e)
  {
    if (this.FlashCall == null)
      return;
    this.FlashCall(sender, e);
  }

  internal void RaiseOnFSCommand(object sender, _IShockwaveFlashEvents_FSCommandEvent e)
  {
    if (this.FSCommand == null)
      return;
    this.FSCommand(sender, e);
  }

  internal void RaiseOnOnProgress(object sender, _IShockwaveFlashEvents_OnProgressEvent e)
  {
    if (this.OnProgress == null)
      return;
    this.OnProgress(sender, e);
  }

  internal void RaiseOnOnReadyStateChange(
    object sender,
    _IShockwaveFlashEvents_OnReadyStateChangeEvent e)
  {
    if (this.OnReadyStateChange == null)
      return;
    this.OnReadyStateChange(sender, e);
  }
}
