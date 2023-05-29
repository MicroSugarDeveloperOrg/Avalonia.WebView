using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVAudioRecorder", true)]
public class AVAudioRecorder : NSObject
{
	private static readonly IntPtr selIsRecordingHandle = Selector.GetHandle("isRecording");

	private static readonly IntPtr selUrlHandle = Selector.GetHandle("url");

	private static readonly IntPtr selSettingsHandle = Selector.GetHandle("settings");

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	private static readonly IntPtr selCurrentTimeHandle = Selector.GetHandle("currentTime");

	private static readonly IntPtr selIsMeteringEnabledHandle = Selector.GetHandle("isMeteringEnabled");

	private static readonly IntPtr selSetMeteringEnabled_Handle = Selector.GetHandle("setMeteringEnabled:");

	private static readonly IntPtr selInitWithURLSettingsError_Handle = Selector.GetHandle("initWithURL:settings:error:");

	private static readonly IntPtr selPrepareToRecordHandle = Selector.GetHandle("prepareToRecord");

	private static readonly IntPtr selRecordHandle = Selector.GetHandle("record");

	private static readonly IntPtr selRecordForDuration_Handle = Selector.GetHandle("recordForDuration:");

	private static readonly IntPtr selPauseHandle = Selector.GetHandle("pause");

	private static readonly IntPtr selStopHandle = Selector.GetHandle("stop");

	private static readonly IntPtr selDeleteRecordingHandle = Selector.GetHandle("deleteRecording");

	private static readonly IntPtr selUpdateMetersHandle = Selector.GetHandle("updateMeters");

	private static readonly IntPtr selPeakPowerForChannel_Handle = Selector.GetHandle("peakPowerForChannel:");

	private static readonly IntPtr selAveragePowerForChannel_Handle = Selector.GetHandle("averagePowerForChannel:");

	private static readonly IntPtr class_ptr = Class.GetHandle("AVAudioRecorder");

	private object __mt_Url_var;

	private object __mt_Settings_var;

	private object __mt_WeakDelegate_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual bool Recording
	{
		[Export("isRecording")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsRecordingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsRecordingHandle);
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

	public virtual NSDictionary Settings
	{
		[Export("settings")]
		get
		{
			return (NSDictionary)(__mt_Settings_var = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSettingsHandle))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selSettingsHandle)))));
		}
	}

	public AudioSettings AudioSettings
	{
		get
		{
			NSDictionary settings = Settings;
			if (settings != null)
			{
				return new AudioSettings(settings);
			}
			return null;
		}
	}

	public virtual NSObject WeakDelegate
	{
		[Export("delegate")]
		get
		{
			return (NSObject)(__mt_WeakDelegate_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle))));
		}
		[Export("setDelegate:")]
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

	public AVAudioRecorderDelegate Delegate
	{
		get
		{
			return WeakDelegate as AVAudioRecorderDelegate;
		}
		set
		{
			WeakDelegate = value;
		}
	}

	public virtual double currentTime
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

	[Obsolete("Use static Create method as this method had an invalid signature up to MonoMac 1.4.4", true)]
	public AVAudioRecorder(NSUrl url, NSDictionary settings, NSError outError)
	{
		throw new Exception("This constructor is no longer supported, use the AVAudioRecorder.ToUrl factory method instead");
	}

	public static AVAudioRecorder Create(NSUrl url, AudioSettings settings, out NSError error)
	{
		if (settings == null)
		{
			throw new ArgumentNullException("settings");
		}
		return ToUrl(url, settings.Dictionary, out error);
	}

	[Advice("Use Create method")]
	public static AVAudioRecorder ToUrl(NSUrl url, AVAudioRecorderSettings settings, out NSError error)
	{
		if (settings == null)
		{
			throw new ArgumentNullException("settings");
		}
		return ToUrl(url, settings.ToDictionary(), out error);
	}

	[Advice("Use Create method")]
	public unsafe static AVAudioRecorder ToUrl(NSUrl url, NSDictionary settings, out NSError error)
	{
		IntPtr ptr = default(IntPtr);
		IntPtr outError = (IntPtr)(&ptr);
		AVAudioRecorder aVAudioRecorder = new AVAudioRecorder(url, settings, outError);
		if (aVAudioRecorder.Handle == IntPtr.Zero)
		{
			error = (NSError)Runtime.GetNSObject(ptr);
			return null;
		}
		error = null;
		return aVAudioRecorder;
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

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public AVAudioRecorder()
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public AVAudioRecorder(NSCoder coder)
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
	public AVAudioRecorder(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public AVAudioRecorder(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithURL:settings:error:")]
	internal AVAudioRecorder(NSUrl url, NSDictionary settings, IntPtr outError)
		: base(NSObjectFlag.Empty)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (settings == null)
		{
			throw new ArgumentNullException("settings");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selInitWithURLSettingsError_Handle, url.Handle, settings.Handle, outError);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selInitWithURLSettingsError_Handle, url.Handle, settings.Handle, outError);
		}
	}

	[Export("prepareToRecord")]
	public virtual bool PrepareToRecord()
	{
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selPrepareToRecordHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selPrepareToRecordHandle);
	}

	[Export("record")]
	public virtual bool Record()
	{
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selRecordHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selRecordHandle);
	}

	[Export("recordForDuration:")]
	public virtual bool RecordFor(double duration)
	{
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_Double(base.Handle, selRecordForDuration_Handle, duration);
		}
		return Messaging.bool_objc_msgSendSuper_Double(base.SuperHandle, selRecordForDuration_Handle, duration);
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

	[Export("deleteRecording")]
	public virtual bool DeleteRecording()
	{
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selDeleteRecordingHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selDeleteRecordingHandle);
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

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Url_var = null;
			__mt_Settings_var = null;
			__mt_WeakDelegate_var = null;
		}
	}
}
