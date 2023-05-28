using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVAudioPlayer", true)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
public class AVAudioPlayer : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAveragePowerForChannel_ = "averagePowerForChannel:";

	private static readonly IntPtr selAveragePowerForChannel_Handle = Selector.GetHandle("averagePowerForChannel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentDevice = "currentDevice";

	private static readonly IntPtr selCurrentDeviceHandle = Selector.GetHandle("currentDevice");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentTime = "currentTime";

	private static readonly IntPtr selCurrentTimeHandle = Selector.GetHandle("currentTime");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selData = "data";

	private static readonly IntPtr selDataHandle = Selector.GetHandle("data");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDeviceCurrentTime = "deviceCurrentTime";

	private static readonly IntPtr selDeviceCurrentTimeHandle = Selector.GetHandle("deviceCurrentTime");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDuration = "duration";

	private static readonly IntPtr selDurationHandle = Selector.GetHandle("duration");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEnableRate = "enableRate";

	private static readonly IntPtr selEnableRateHandle = Selector.GetHandle("enableRate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFormat = "format";

	private static readonly IntPtr selFormatHandle = Selector.GetHandle("format");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithContentsOfURL_Error_ = "initWithContentsOfURL:error:";

	private static readonly IntPtr selInitWithContentsOfURL_Error_Handle = Selector.GetHandle("initWithContentsOfURL:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithContentsOfURL_FileTypeHint_Error_ = "initWithContentsOfURL:fileTypeHint:error:";

	private static readonly IntPtr selInitWithContentsOfURL_FileTypeHint_Error_Handle = Selector.GetHandle("initWithContentsOfURL:fileTypeHint:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithData_Error_ = "initWithData:error:";

	private static readonly IntPtr selInitWithData_Error_Handle = Selector.GetHandle("initWithData:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithData_FileTypeHint_Error_ = "initWithData:fileTypeHint:error:";

	private static readonly IntPtr selInitWithData_FileTypeHint_Error_Handle = Selector.GetHandle("initWithData:fileTypeHint:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsMeteringEnabled = "isMeteringEnabled";

	private static readonly IntPtr selIsMeteringEnabledHandle = Selector.GetHandle("isMeteringEnabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsPlaying = "isPlaying";

	private static readonly IntPtr selIsPlayingHandle = Selector.GetHandle("isPlaying");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNumberOfChannels = "numberOfChannels";

	private static readonly IntPtr selNumberOfChannelsHandle = Selector.GetHandle("numberOfChannels");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNumberOfLoops = "numberOfLoops";

	private static readonly IntPtr selNumberOfLoopsHandle = Selector.GetHandle("numberOfLoops");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPan = "pan";

	private static readonly IntPtr selPanHandle = Selector.GetHandle("pan");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPause = "pause";

	private static readonly IntPtr selPauseHandle = Selector.GetHandle("pause");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPeakPowerForChannel_ = "peakPowerForChannel:";

	private static readonly IntPtr selPeakPowerForChannel_Handle = Selector.GetHandle("peakPowerForChannel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPlay = "play";

	private static readonly IntPtr selPlayHandle = Selector.GetHandle("play");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPlayAtTime_ = "playAtTime:";

	private static readonly IntPtr selPlayAtTime_Handle = Selector.GetHandle("playAtTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrepareToPlay = "prepareToPlay";

	private static readonly IntPtr selPrepareToPlayHandle = Selector.GetHandle("prepareToPlay");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRate = "rate";

	private static readonly IntPtr selRateHandle = Selector.GetHandle("rate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCurrentDevice_ = "setCurrentDevice:";

	private static readonly IntPtr selSetCurrentDevice_Handle = Selector.GetHandle("setCurrentDevice:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCurrentTime_ = "setCurrentTime:";

	private static readonly IntPtr selSetCurrentTime_Handle = Selector.GetHandle("setCurrentTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelegate_ = "setDelegate:";

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEnableRate_ = "setEnableRate:";

	private static readonly IntPtr selSetEnableRate_Handle = Selector.GetHandle("setEnableRate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMeteringEnabled_ = "setMeteringEnabled:";

	private static readonly IntPtr selSetMeteringEnabled_Handle = Selector.GetHandle("setMeteringEnabled:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetNumberOfLoops_ = "setNumberOfLoops:";

	private static readonly IntPtr selSetNumberOfLoops_Handle = Selector.GetHandle("setNumberOfLoops:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPan_ = "setPan:";

	private static readonly IntPtr selSetPan_Handle = Selector.GetHandle("setPan:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRate_ = "setRate:";

	private static readonly IntPtr selSetRate_Handle = Selector.GetHandle("setRate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetVolume_ = "setVolume:";

	private static readonly IntPtr selSetVolume_Handle = Selector.GetHandle("setVolume:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetVolume_FadeDuration_ = "setVolume:fadeDuration:";

	private static readonly IntPtr selSetVolume_FadeDuration_Handle = Selector.GetHandle("setVolume:fadeDuration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSettings = "settings";

	private static readonly IntPtr selSettingsHandle = Selector.GetHandle("settings");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStop = "stop";

	private static readonly IntPtr selStopHandle = Selector.GetHandle("stop");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUpdateMeters = "updateMeters";

	private static readonly IntPtr selUpdateMetersHandle = Selector.GetHandle("updateMeters");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUrl = "url";

	private static readonly IntPtr selUrlHandle = Selector.GetHandle("url");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVolume = "volume";

	private static readonly IntPtr selVolumeHandle = Selector.GetHandle("volume");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVAudioPlayer");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakDelegate_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	public virtual string? CurrentDevice
	{
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Export("currentDevice")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selCurrentDeviceHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCurrentDeviceHandle));
		}
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Export("setCurrentDevice:")]
		set
		{
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetCurrentDevice_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetCurrentDevice_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double CurrentTime
	{
		[Export("currentTime")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selCurrentTimeHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selCurrentTimeHandle);
		}
		[Export("setCurrentTime:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetCurrentTime_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetCurrentTime_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSData? Data
	{
		[Export("data")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend(base.Handle, selDataHandle));
			}
			return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDataHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public IAVAudioPlayerDelegate? Delegate
	{
		get
		{
			return WeakDelegate as IAVAudioPlayerDelegate;
		}
		set
		{
			NSObject nSObject = value as NSObject;
			if (value != null && nSObject == null)
			{
				throw new ArgumentException("The object passed of type " + value.GetType()?.ToString() + " does not derive from NSObject");
			}
			WeakDelegate = nSObject;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double DeviceCurrentTime
	{
		[Export("deviceCurrentTime")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selDeviceCurrentTimeHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selDeviceCurrentTimeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double Duration
	{
		[Export("duration")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selDurationHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selDurationHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool EnableRate
	{
		[Export("enableRate")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selEnableRateHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selEnableRateHandle);
		}
		[Export("setEnableRate:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetEnableRate_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetEnableRate_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	public virtual AVAudioFormat Format
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		[Export("format")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<AVAudioFormat>(Messaging.IntPtr_objc_msgSend(base.Handle, selFormatHandle));
			}
			return Runtime.GetNSObject<AVAudioFormat>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFormatHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool MeteringEnabled
	{
		[Export("isMeteringEnabled")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsMeteringEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsMeteringEnabledHandle);
		}
		[Export("setMeteringEnabled:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetMeteringEnabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetMeteringEnabled_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint NumberOfChannels
	{
		[Export("numberOfChannels")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selNumberOfChannelsHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selNumberOfChannelsHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint NumberOfLoops
	{
		[Export("numberOfLoops")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selNumberOfLoopsHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selNumberOfLoopsHandle);
		}
		[Export("setNumberOfLoops:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetNumberOfLoops_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetNumberOfLoops_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float Pan
	{
		[Export("pan")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selPanHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selPanHandle);
		}
		[Export("setPan:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetPan_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetPan_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Playing
	{
		[Export("isPlaying")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsPlayingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsPlayingHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float Rate
	{
		[Export("rate")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selRateHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selRateHandle);
		}
		[Export("setRate:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetRate_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetRate_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AudioSettings SoundSetting
	{
		get
		{
			NSMutableDictionary nSMutableDictionary = ((WeakSettings != null) ? new NSMutableDictionary(WeakSettings) : null);
			return (nSMutableDictionary == null) ? null : new AudioSettings(nSMutableDictionary);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl? Url
	{
		[Export("url")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend(base.Handle, selUrlHandle));
			}
			return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUrlHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float Volume
	{
		[Export("volume")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selVolumeHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selVolumeHandle);
		}
		[Export("setVolume:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetVolume_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetVolume_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject? WeakDelegate
	{
		[Export("delegate", ArgumentSemantic.Assign)]
		get
		{
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle)));
			MarkDirty();
			__mt_WeakDelegate_var = nSObject;
			return nSObject;
		}
		[Export("setDelegate:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_WeakDelegate_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected virtual NSDictionary WeakSettings
	{
		[Export("settings")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selSettingsHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSettingsHandle));
		}
	}

	public event EventHandler<AVStatusEventArgs> FinishedPlaying
	{
		add
		{
			InternalAVAudioPlayerDelegate internalAVAudioPlayerDelegate = EnsureEventDelegate();
			internalAVAudioPlayerDelegate.cbFinishedPlaying = (EventHandler<AVStatusEventArgs>)System.Delegate.Combine(internalAVAudioPlayerDelegate.cbFinishedPlaying, value);
		}
		remove
		{
			InternalAVAudioPlayerDelegate internalAVAudioPlayerDelegate = EnsureEventDelegate();
			internalAVAudioPlayerDelegate.cbFinishedPlaying = (EventHandler<AVStatusEventArgs>)System.Delegate.Remove(internalAVAudioPlayerDelegate.cbFinishedPlaying, value);
		}
	}

	public event EventHandler<AVErrorEventArgs> DecoderError
	{
		add
		{
			InternalAVAudioPlayerDelegate internalAVAudioPlayerDelegate = EnsureEventDelegate();
			internalAVAudioPlayerDelegate.cbDecoderError = (EventHandler<AVErrorEventArgs>)System.Delegate.Combine(internalAVAudioPlayerDelegate.cbDecoderError, value);
		}
		remove
		{
			InternalAVAudioPlayerDelegate internalAVAudioPlayerDelegate = EnsureEventDelegate();
			internalAVAudioPlayerDelegate.cbDecoderError = (EventHandler<AVErrorEventArgs>)System.Delegate.Remove(internalAVAudioPlayerDelegate.cbDecoderError, value);
		}
	}

	public event EventHandler BeginInterruption
	{
		add
		{
			InternalAVAudioPlayerDelegate internalAVAudioPlayerDelegate = EnsureEventDelegate();
			internalAVAudioPlayerDelegate.cbBeginInterruption = (EventHandler)System.Delegate.Combine(internalAVAudioPlayerDelegate.cbBeginInterruption, value);
		}
		remove
		{
			InternalAVAudioPlayerDelegate internalAVAudioPlayerDelegate = EnsureEventDelegate();
			internalAVAudioPlayerDelegate.cbBeginInterruption = (EventHandler)System.Delegate.Remove(internalAVAudioPlayerDelegate.cbBeginInterruption, value);
		}
	}

	public event EventHandler EndInterruption
	{
		add
		{
			InternalAVAudioPlayerDelegate internalAVAudioPlayerDelegate = EnsureEventDelegate();
			internalAVAudioPlayerDelegate.cbEndInterruption = (EventHandler)System.Delegate.Combine(internalAVAudioPlayerDelegate.cbEndInterruption, value);
		}
		remove
		{
			InternalAVAudioPlayerDelegate internalAVAudioPlayerDelegate = EnsureEventDelegate();
			internalAVAudioPlayerDelegate.cbEndInterruption = (EventHandler)System.Delegate.Remove(internalAVAudioPlayerDelegate.cbEndInterruption, value);
		}
	}

	public unsafe static AVAudioPlayer FromUrl(NSUrl url, out NSError error)
	{
		IntPtr ptr = default(IntPtr);
		IntPtr outError = (IntPtr)(&ptr);
		AVAudioPlayer aVAudioPlayer = new AVAudioPlayer(url, outError);
		if (aVAudioPlayer.Handle == IntPtr.Zero)
		{
			error = (NSError)Runtime.GetNSObject(ptr);
			return null;
		}
		error = null;
		return aVAudioPlayer;
	}

	public static AVAudioPlayer FromUrl(NSUrl url)
	{
		AVAudioPlayer aVAudioPlayer = new AVAudioPlayer(url, IntPtr.Zero);
		if (aVAudioPlayer.Handle == IntPtr.Zero)
		{
			return null;
		}
		return aVAudioPlayer;
	}

	public unsafe static AVAudioPlayer FromData(NSData data, out NSError error)
	{
		IntPtr ptr = default(IntPtr);
		IntPtr outError = (IntPtr)(&ptr);
		AVAudioPlayer aVAudioPlayer = new AVAudioPlayer(data, outError);
		if (aVAudioPlayer.Handle == IntPtr.Zero)
		{
			error = (NSError)Runtime.GetNSObject(ptr);
			return null;
		}
		error = null;
		return aVAudioPlayer;
	}

	public static AVAudioPlayer FromData(NSData data)
	{
		AVAudioPlayer aVAudioPlayer = new AVAudioPlayer(data, IntPtr.Zero);
		if (aVAudioPlayer.Handle == IntPtr.Zero)
		{
			return null;
		}
		return aVAudioPlayer;
	}

	private InternalAVAudioPlayerDelegate EnsureEventDelegate()
	{
		InternalAVAudioPlayerDelegate internalAVAudioPlayerDelegate = WeakDelegate as InternalAVAudioPlayerDelegate;
		if (internalAVAudioPlayerDelegate == null)
		{
			internalAVAudioPlayerDelegate = (InternalAVAudioPlayerDelegate)(WeakDelegate = new InternalAVAudioPlayerDelegate());
		}
		return internalAVAudioPlayerDelegate;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AVAudioPlayer(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVAudioPlayer(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithContentsOfURL:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal AVAudioPlayer(NSUrl url, IntPtr outError)
		: base(NSObjectFlag.Empty)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithContentsOfURL_Error_Handle, url.Handle, outError), "initWithContentsOfURL:error:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithContentsOfURL_Error_Handle, url.Handle, outError), "initWithContentsOfURL:error:");
		}
	}

	[Export("initWithData:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal AVAudioPlayer(NSData data, IntPtr outError)
		: base(NSObjectFlag.Empty)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithData_Error_Handle, data.Handle, outError), "initWithData:error:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithData_Error_Handle, data.Handle, outError), "initWithData:error:");
		}
	}

	[Export("initWithData:fileTypeHint:error:")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVAudioPlayer(NSData data, string? fileTypeHint, out NSError outError)
		: base(NSObjectFlag.Empty)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr arg2 = NSString.CreateNative(fileTypeHint);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(base.Handle, selInitWithData_FileTypeHint_Error_Handle, data.Handle, arg2, ref arg), "initWithData:fileTypeHint:error:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_ref_IntPtr(base.SuperHandle, selInitWithData_FileTypeHint_Error_Handle, data.Handle, arg2, ref arg), "initWithData:fileTypeHint:error:");
		}
		NSString.ReleaseNative(arg2);
		outError = Runtime.GetNSObject<NSError>(arg);
	}

	[Export("initWithContentsOfURL:fileTypeHint:error:")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVAudioPlayer(NSUrl url, string? fileTypeHint, out NSError outError)
		: base(NSObjectFlag.Empty)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr arg2 = NSString.CreateNative(fileTypeHint);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(base.Handle, selInitWithContentsOfURL_FileTypeHint_Error_Handle, url.Handle, arg2, ref arg), "initWithContentsOfURL:fileTypeHint:error:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_ref_IntPtr(base.SuperHandle, selInitWithContentsOfURL_FileTypeHint_Error_Handle, url.Handle, arg2, ref arg), "initWithContentsOfURL:fileTypeHint:error:");
		}
		NSString.ReleaseNative(arg2);
		outError = Runtime.GetNSObject<NSError>(arg);
	}

	[Export("averagePowerForChannel:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float AveragePower(nuint channelNumber)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.float_objc_msgSend_nuint(base.Handle, selAveragePowerForChannel_Handle, channelNumber);
		}
		return Messaging.float_objc_msgSendSuper_nuint(base.SuperHandle, selAveragePowerForChannel_Handle, channelNumber);
	}

	[Export("pause")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Pause()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selPauseHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selPauseHandle);
		}
	}

	[Export("peakPowerForChannel:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float PeakPower(nuint channelNumber)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.float_objc_msgSend_nuint(base.Handle, selPeakPowerForChannel_Handle, channelNumber);
		}
		return Messaging.float_objc_msgSendSuper_nuint(base.SuperHandle, selPeakPowerForChannel_Handle, channelNumber);
	}

	[Export("play")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Play()
	{
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selPlayHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selPlayHandle);
	}

	[Export("playAtTime:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool PlayAtTime(double time)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_Double(base.Handle, selPlayAtTime_Handle, time);
		}
		return Messaging.bool_objc_msgSendSuper_Double(base.SuperHandle, selPlayAtTime_Handle, time);
	}

	[Export("prepareToPlay")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool PrepareToPlay()
	{
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selPrepareToPlayHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selPrepareToPlayHandle);
	}

	[Export("setVolume:fadeDuration:")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetVolume(float volume, double duration)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_float_Double(base.Handle, selSetVolume_FadeDuration_Handle, volume, duration);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_float_Double(base.SuperHandle, selSetVolume_FadeDuration_Handle, volume, duration);
		}
	}

	[Export("stop")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Stop()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selStopHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selStopHandle);
		}
	}

	[Export("updateMeters")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void UpdateMeters()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selUpdateMetersHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selUpdateMetersHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_WeakDelegate_var = null;
		}
	}
}
