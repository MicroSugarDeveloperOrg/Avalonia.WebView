using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVAudioPlayer", true)]
public class AVAudioPlayer : NSObject
{
	private static readonly IntPtr selIsPlayingHandle = Selector.GetHandle("isPlaying");

	private static readonly IntPtr selNumberOfChannelsHandle = Selector.GetHandle("numberOfChannels");

	private static readonly IntPtr selDurationHandle = Selector.GetHandle("duration");

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	private static readonly IntPtr selUrlHandle = Selector.GetHandle("url");

	private static readonly IntPtr selDataHandle = Selector.GetHandle("data");

	private static readonly IntPtr selVolumeHandle = Selector.GetHandle("volume");

	private static readonly IntPtr selSetVolume_Handle = Selector.GetHandle("setVolume:");

	private static readonly IntPtr selCurrentTimeHandle = Selector.GetHandle("currentTime");

	private static readonly IntPtr selSetCurrentTime_Handle = Selector.GetHandle("setCurrentTime:");

	private static readonly IntPtr selNumberOfLoopsHandle = Selector.GetHandle("numberOfLoops");

	private static readonly IntPtr selSetNumberOfLoops_Handle = Selector.GetHandle("setNumberOfLoops:");

	private static readonly IntPtr selIsMeteringEnabledHandle = Selector.GetHandle("isMeteringEnabled");

	private static readonly IntPtr selSetMeteringEnabled_Handle = Selector.GetHandle("setMeteringEnabled:");

	private static readonly IntPtr selDeviceCurrentTimeHandle = Selector.GetHandle("deviceCurrentTime");

	private static readonly IntPtr selPanHandle = Selector.GetHandle("pan");

	private static readonly IntPtr selSetPan_Handle = Selector.GetHandle("setPan:");

	private static readonly IntPtr selSettingsHandle = Selector.GetHandle("settings");

	private static readonly IntPtr selEnableRateHandle = Selector.GetHandle("enableRate");

	private static readonly IntPtr selSetEnableRate_Handle = Selector.GetHandle("setEnableRate:");

	private static readonly IntPtr selRateHandle = Selector.GetHandle("rate");

	private static readonly IntPtr selSetRate_Handle = Selector.GetHandle("setRate:");

	private static readonly IntPtr selInitWithContentsOfURLError_Handle = Selector.GetHandle("initWithContentsOfURL:error:");

	private static readonly IntPtr selInitWithDataError_Handle = Selector.GetHandle("initWithData:error:");

	private static readonly IntPtr selPrepareToPlayHandle = Selector.GetHandle("prepareToPlay");

	private static readonly IntPtr selPlayHandle = Selector.GetHandle("play");

	private static readonly IntPtr selPauseHandle = Selector.GetHandle("pause");

	private static readonly IntPtr selStopHandle = Selector.GetHandle("stop");

	private static readonly IntPtr selUpdateMetersHandle = Selector.GetHandle("updateMeters");

	private static readonly IntPtr selPeakPowerForChannel_Handle = Selector.GetHandle("peakPowerForChannel:");

	private static readonly IntPtr selAveragePowerForChannel_Handle = Selector.GetHandle("averagePowerForChannel:");

	private static readonly IntPtr selPlayAtTime_Handle = Selector.GetHandle("playAtTime:");

	private static readonly IntPtr class_ptr = Class.GetHandle("AVAudioPlayer");

	private object __mt_WeakDelegate_var;

	private object __mt_Url_var;

	private object __mt_Data_var;

	private object __mt_WeakSettings_var;

	[Advice("Use SoundSettings")]
	public AVAudioPlayerSettings Settings => new AVAudioPlayerSettings(WeakSettings);

	public override IntPtr ClassHandle => class_ptr;

	public virtual bool Playing
	{
		[Export("isPlaying")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsPlayingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsPlayingHandle);
		}
	}

	public virtual uint NumberOfChannels
	{
		[Export("numberOfChannels")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.UInt32_objc_msgSend(base.Handle, selNumberOfChannelsHandle);
			}
			return Messaging.UInt32_objc_msgSendSuper(base.SuperHandle, selNumberOfChannelsHandle);
		}
	}

	public virtual double Duration
	{
		[Export("duration")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selDurationHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selDurationHandle);
		}
	}

	public virtual NSObject WeakDelegate
	{
		[Export("delegate", ArgumentSemantic.Assign)]
		get
		{
			return (NSObject)(__mt_WeakDelegate_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle))));
		}
		[Export("setDelegate:", ArgumentSemantic.Assign)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDelegate_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDelegate_Handle, value.Handle);
			}
			__mt_WeakDelegate_var = value;
		}
	}

	public AVAudioPlayerDelegate Delegate
	{
		get
		{
			return WeakDelegate as AVAudioPlayerDelegate;
		}
		set
		{
			WeakDelegate = value;
		}
	}

	public virtual NSUrl Url
	{
		[Export("url")]
		get
		{
			return (NSUrl)(__mt_Url_var = ((!IsDirectBinding) ? ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUrlHandle))) : ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selUrlHandle)))));
		}
	}

	public virtual NSData Data
	{
		[Export("data")]
		get
		{
			return (NSData)(__mt_Data_var = ((!IsDirectBinding) ? ((NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDataHandle))) : ((NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDataHandle)))));
		}
	}

	public virtual float Volume
	{
		[Export("volume")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selVolumeHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selVolumeHandle);
		}
		[Export("setVolume:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetVolume_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetVolume_Handle, value);
			}
		}
	}

	public virtual double CurrentTime
	{
		[Export("currentTime")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selCurrentTimeHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selCurrentTimeHandle);
		}
		[Export("setCurrentTime:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetCurrentTime_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetCurrentTime_Handle, value);
			}
		}
	}

	public virtual int NumberOfLoops
	{
		[Export("numberOfLoops")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selNumberOfLoopsHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selNumberOfLoopsHandle);
		}
		[Export("setNumberOfLoops:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_int(base.Handle, selSetNumberOfLoops_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selSetNumberOfLoops_Handle, value);
			}
		}
	}

	public virtual bool MeteringEnabled
	{
		[Export("isMeteringEnabled")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsMeteringEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsMeteringEnabledHandle);
		}
		[Export("setMeteringEnabled:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetMeteringEnabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetMeteringEnabled_Handle, value);
			}
		}
	}

	[Since(4, 0)]
	public virtual double DeviceCurrentTime
	{
		[Export("deviceCurrentTime")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selDeviceCurrentTimeHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selDeviceCurrentTimeHandle);
		}
	}

	[Since(4, 0)]
	public virtual float Pan
	{
		[Export("pan")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selPanHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selPanHandle);
		}
		[Export("setPan:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetPan_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetPan_Handle, value);
			}
		}
	}

	[Since(4, 0)]
	protected virtual NSDictionary WeakSettings
	{
		[Export("settings")]
		get
		{
			return (NSDictionary)(__mt_WeakSettings_var = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSettingsHandle))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selSettingsHandle)))));
		}
	}

	public AudioSettings SoundSetting
	{
		get
		{
			NSDictionary weakSettings = WeakSettings;
			if (weakSettings != null)
			{
				return new AudioSettings(weakSettings);
			}
			return null;
		}
	}

	[Since(5, 0)]
	public virtual bool EnableRate
	{
		[Export("enableRate")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selEnableRateHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selEnableRateHandle);
		}
		[Export("setEnableRate:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetEnableRate_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetEnableRate_Handle, value);
			}
		}
	}

	[Since(5, 0)]
	public virtual float Rate
	{
		[Export("rate")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selRateHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selRateHandle);
		}
		[Export("setRate:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetRate_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetRate_Handle, value);
			}
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

	[Obsolete("This method had an invalid signature in MonoMac 1.0.3, use AVAudioPlayer.FromUrl instead")]
	public AVAudioPlayer(NSUrl url, NSError error)
		: this(url, IntPtr.Zero)
	{
	}

	[Obsolete("This method had an invalid signature in MonoMac 1.0.3, use AVAudioPlayer.FromData instead")]
	public AVAudioPlayer(NSData data, NSError error)
		: this(data, IntPtr.Zero)
	{
	}

	[Advice("This method was incorrectly named, use PlayAtTime instead")]
	public bool PlayAtTimetime(double time)
	{
		return PlayAtTime(time);
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

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public AVAudioPlayer(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public AVAudioPlayer(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public AVAudioPlayer(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithContentsOfURL:error:")]
	internal AVAudioPlayer(NSUrl url, IntPtr outError)
		: base(NSObjectFlag.Empty)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithContentsOfURLError_Handle, url.Handle, outError);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithContentsOfURLError_Handle, url.Handle, outError);
		}
	}

	[Export("initWithData:error:")]
	internal AVAudioPlayer(NSData data, IntPtr outError)
		: base(NSObjectFlag.Empty)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithDataError_Handle, data.Handle, outError);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithDataError_Handle, data.Handle, outError);
		}
	}

	[Export("prepareToPlay")]
	public virtual bool PrepareToPlay()
	{
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selPrepareToPlayHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selPrepareToPlayHandle);
	}

	[Export("play")]
	public virtual bool Play()
	{
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selPlayHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selPlayHandle);
	}

	[Export("pause")]
	public virtual void Pause()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selPauseHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selPauseHandle);
		}
	}

	[Export("stop")]
	public virtual void Stop()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selStopHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selStopHandle);
		}
	}

	[Export("updateMeters")]
	public virtual void UpdateMeters()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selUpdateMetersHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selUpdateMetersHandle);
		}
	}

	[Export("peakPowerForChannel:")]
	public virtual float PeakPower(uint channelNumber)
	{
		if (IsDirectBinding)
		{
			return Messaging.float_objc_msgSend_UInt32(base.Handle, selPeakPowerForChannel_Handle, channelNumber);
		}
		return Messaging.float_objc_msgSendSuper_UInt32(base.SuperHandle, selPeakPowerForChannel_Handle, channelNumber);
	}

	[Export("averagePowerForChannel:")]
	public virtual float AveragePower(uint channelNumber)
	{
		if (IsDirectBinding)
		{
			return Messaging.float_objc_msgSend_UInt32(base.Handle, selAveragePowerForChannel_Handle, channelNumber);
		}
		return Messaging.float_objc_msgSendSuper_UInt32(base.SuperHandle, selAveragePowerForChannel_Handle, channelNumber);
	}

	[Export("playAtTime:")]
	public virtual bool PlayAtTime(double time)
	{
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_Double(base.Handle, selPlayAtTime_Handle, time);
		}
		return Messaging.bool_objc_msgSendSuper_Double(base.SuperHandle, selPlayAtTime_Handle, time);
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_WeakDelegate_var = null;
			__mt_Url_var = null;
			__mt_Data_var = null;
			__mt_WeakSettings_var = null;
		}
	}
}
