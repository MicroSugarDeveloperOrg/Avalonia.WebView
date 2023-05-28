using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AVFoundation;

[Register("AVAudioRecorder", true)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
public class AVAudioRecorder : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAveragePowerForChannel_ = "averagePowerForChannel:";

	private static readonly IntPtr selAveragePowerForChannel_Handle = Selector.GetHandle("averagePowerForChannel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentTime = "currentTime";

	private static readonly IntPtr selCurrentTimeHandle = Selector.GetHandle("currentTime");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDeleteRecording = "deleteRecording";

	private static readonly IntPtr selDeleteRecordingHandle = Selector.GetHandle("deleteRecording");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDeviceCurrentTime = "deviceCurrentTime";

	private static readonly IntPtr selDeviceCurrentTimeHandle = Selector.GetHandle("deviceCurrentTime");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFormat = "format";

	private static readonly IntPtr selFormatHandle = Selector.GetHandle("format");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithURL_Format_Error_ = "initWithURL:format:error:";

	private static readonly IntPtr selInitWithURL_Format_Error_Handle = Selector.GetHandle("initWithURL:format:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithURL_Settings_Error_ = "initWithURL:settings:error:";

	private static readonly IntPtr selInitWithURL_Settings_Error_Handle = Selector.GetHandle("initWithURL:settings:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsMeteringEnabled = "isMeteringEnabled";

	private static readonly IntPtr selIsMeteringEnabledHandle = Selector.GetHandle("isMeteringEnabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsRecording = "isRecording";

	private static readonly IntPtr selIsRecordingHandle = Selector.GetHandle("isRecording");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPause = "pause";

	private static readonly IntPtr selPauseHandle = Selector.GetHandle("pause");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPeakPowerForChannel_ = "peakPowerForChannel:";

	private static readonly IntPtr selPeakPowerForChannel_Handle = Selector.GetHandle("peakPowerForChannel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrepareToRecord = "prepareToRecord";

	private static readonly IntPtr selPrepareToRecordHandle = Selector.GetHandle("prepareToRecord");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRecord = "record";

	private static readonly IntPtr selRecordHandle = Selector.GetHandle("record");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRecordAtTime_ = "recordAtTime:";

	private static readonly IntPtr selRecordAtTime_Handle = Selector.GetHandle("recordAtTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRecordAtTime_ForDuration_ = "recordAtTime:forDuration:";

	private static readonly IntPtr selRecordAtTime_ForDuration_Handle = Selector.GetHandle("recordAtTime:forDuration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRecordForDuration_ = "recordForDuration:";

	private static readonly IntPtr selRecordForDuration_Handle = Selector.GetHandle("recordForDuration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelegate_ = "setDelegate:";

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMeteringEnabled_ = "setMeteringEnabled:";

	private static readonly IntPtr selSetMeteringEnabled_Handle = Selector.GetHandle("setMeteringEnabled:");

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
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVAudioRecorder");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakDelegate_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public IAVAudioRecorderDelegate? Delegate
	{
		get
		{
			return WeakDelegate as IAVAudioRecorderDelegate;
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
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	public virtual double DeviceCurrentTime
	{
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
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
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public virtual AVAudioFormat Format
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
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
	public virtual bool Recording
	{
		[Export("isRecording")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsRecordingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsRecordingHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AudioSettings Settings
	{
		get
		{
			NSMutableDictionary nSMutableDictionary = ((WeakSettings != null) ? new NSMutableDictionary(WeakSettings) : null);
			return (nSMutableDictionary == null) ? null : new AudioSettings(nSMutableDictionary);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl Url
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
	public virtual NSDictionary WeakSettings
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double currentTime
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
	}

	public event EventHandler<AVStatusEventArgs> FinishedRecording
	{
		add
		{
			InternalAVAudioRecorderDelegate internalAVAudioRecorderDelegate = EnsureEventDelegate();
			internalAVAudioRecorderDelegate.cbFinishedRecording = (EventHandler<AVStatusEventArgs>)System.Delegate.Combine(internalAVAudioRecorderDelegate.cbFinishedRecording, value);
		}
		remove
		{
			InternalAVAudioRecorderDelegate internalAVAudioRecorderDelegate = EnsureEventDelegate();
			internalAVAudioRecorderDelegate.cbFinishedRecording = (EventHandler<AVStatusEventArgs>)System.Delegate.Remove(internalAVAudioRecorderDelegate.cbFinishedRecording, value);
		}
	}

	public event EventHandler<AVErrorEventArgs> EncoderError
	{
		add
		{
			InternalAVAudioRecorderDelegate internalAVAudioRecorderDelegate = EnsureEventDelegate();
			internalAVAudioRecorderDelegate.cbEncoderError = (EventHandler<AVErrorEventArgs>)System.Delegate.Combine(internalAVAudioRecorderDelegate.cbEncoderError, value);
		}
		remove
		{
			InternalAVAudioRecorderDelegate internalAVAudioRecorderDelegate = EnsureEventDelegate();
			internalAVAudioRecorderDelegate.cbEncoderError = (EventHandler<AVErrorEventArgs>)System.Delegate.Remove(internalAVAudioRecorderDelegate.cbEncoderError, value);
		}
	}

	public event EventHandler BeginInterruption
	{
		add
		{
			InternalAVAudioRecorderDelegate internalAVAudioRecorderDelegate = EnsureEventDelegate();
			internalAVAudioRecorderDelegate.cbBeginInterruption = (EventHandler)System.Delegate.Combine(internalAVAudioRecorderDelegate.cbBeginInterruption, value);
		}
		remove
		{
			InternalAVAudioRecorderDelegate internalAVAudioRecorderDelegate = EnsureEventDelegate();
			internalAVAudioRecorderDelegate.cbBeginInterruption = (EventHandler)System.Delegate.Remove(internalAVAudioRecorderDelegate.cbBeginInterruption, value);
		}
	}

	public event EventHandler EndInterruption
	{
		add
		{
			InternalAVAudioRecorderDelegate internalAVAudioRecorderDelegate = EnsureEventDelegate();
			internalAVAudioRecorderDelegate.cbEndInterruption = (EventHandler)System.Delegate.Combine(internalAVAudioRecorderDelegate.cbEndInterruption, value);
		}
		remove
		{
			InternalAVAudioRecorderDelegate internalAVAudioRecorderDelegate = EnsureEventDelegate();
			internalAVAudioRecorderDelegate.cbEndInterruption = (EventHandler)System.Delegate.Remove(internalAVAudioRecorderDelegate.cbEndInterruption, value);
		}
	}

	private AVAudioRecorder(NSUrl url, AudioSettings settings, out NSError error)
	{
		base.Handle = InitWithUrl(url, settings.Dictionary, out error);
	}

	private AVAudioRecorder(NSUrl url, AVAudioFormat format, out NSError error)
	{
		base.Handle = InitWithUrl(url, format, out error);
	}

	public static AVAudioRecorder Create(NSUrl url, AudioSettings settings, out NSError error)
	{
		if (settings == null)
		{
			throw new ArgumentNullException("settings");
		}
		error = null;
		try
		{
			AVAudioRecorder aVAudioRecorder = new AVAudioRecorder(url, settings, out error);
			if (aVAudioRecorder.Handle == IntPtr.Zero)
			{
				return null;
			}
			return aVAudioRecorder;
		}
		catch
		{
			return null;
		}
	}

	[iOS(10, 0)]
	[Mac(10, 12)]
	public static AVAudioRecorder Create(NSUrl url, AVAudioFormat format, out NSError error)
	{
		if (format == null)
		{
			throw new ArgumentNullException("format");
		}
		error = null;
		try
		{
			AVAudioRecorder aVAudioRecorder = new AVAudioRecorder(url, format, out error);
			if (aVAudioRecorder.Handle == IntPtr.Zero)
			{
				return null;
			}
			return aVAudioRecorder;
		}
		catch
		{
			return null;
		}
	}

	internal static AVAudioRecorder ToUrl(NSUrl url, NSDictionary settings, out NSError error)
	{
		return Create(url, new AudioSettings(settings), out error);
	}

	private InternalAVAudioRecorderDelegate EnsureEventDelegate()
	{
		InternalAVAudioRecorderDelegate internalAVAudioRecorderDelegate = WeakDelegate as InternalAVAudioRecorderDelegate;
		if (internalAVAudioRecorderDelegate == null)
		{
			internalAVAudioRecorderDelegate = (InternalAVAudioRecorderDelegate)(WeakDelegate = new InternalAVAudioRecorderDelegate());
		}
		return internalAVAudioRecorderDelegate;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public AVAudioRecorder()
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init), "init");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AVAudioRecorder(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVAudioRecorder(IntPtr handle)
		: base(handle)
	{
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

	[Export("deleteRecording")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool DeleteRecording()
	{
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selDeleteRecordingHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selDeleteRecordingHandle);
	}

	[Export("initWithURL:settings:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual IntPtr InitWithUrl(NSUrl url, NSDictionary settings, out NSError error)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (settings == null)
		{
			throw new ArgumentNullException("settings");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr result = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_ref_IntPtr(base.SuperHandle, selInitWithURL_Settings_Error_Handle, url.Handle, settings.Handle, ref arg) : Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(base.Handle, selInitWithURL_Settings_Error_Handle, url.Handle, settings.Handle, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("initWithURL:format:error:")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual IntPtr InitWithUrl(NSUrl url, AVAudioFormat format, out NSError outError)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (format == null)
		{
			throw new ArgumentNullException("format");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr result = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_ref_IntPtr(base.SuperHandle, selInitWithURL_Format_Error_Handle, url.Handle, format.Handle, ref arg) : Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(base.Handle, selInitWithURL_Format_Error_Handle, url.Handle, format.Handle, ref arg));
		outError = Runtime.GetNSObject<NSError>(arg);
		return result;
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

	[Export("prepareToRecord")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool PrepareToRecord()
	{
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selPrepareToRecordHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selPrepareToRecordHandle);
	}

	[Export("record")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Record()
	{
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selRecordHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selRecordHandle);
	}

	[Export("recordAtTime:")]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool RecordAt(double time)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_Double(base.Handle, selRecordAtTime_Handle, time);
		}
		return Messaging.bool_objc_msgSendSuper_Double(base.SuperHandle, selRecordAtTime_Handle, time);
	}

	[Export("recordAtTime:forDuration:")]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool RecordAt(double time, double duration)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_Double_Double(base.Handle, selRecordAtTime_ForDuration_Handle, time, duration);
		}
		return Messaging.bool_objc_msgSendSuper_Double_Double(base.SuperHandle, selRecordAtTime_ForDuration_Handle, time, duration);
	}

	[Export("recordForDuration:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool RecordFor(double duration)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_Double(base.Handle, selRecordForDuration_Handle, duration);
		}
		return Messaging.bool_objc_msgSendSuper_Double(base.SuperHandle, selRecordForDuration_Handle, duration);
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
