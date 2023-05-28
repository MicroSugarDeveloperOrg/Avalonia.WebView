using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AVFoundation;

[Register("AVAudioSequencer", true)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class AVAudioSequencer : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBeatsForHostTime_Error_ = "beatsForHostTime:error:";

	private static readonly IntPtr selBeatsForHostTime_Error_Handle = Selector.GetHandle("beatsForHostTime:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBeatsForSeconds_ = "beatsForSeconds:";

	private static readonly IntPtr selBeatsForSeconds_Handle = Selector.GetHandle("beatsForSeconds:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentPositionInBeats = "currentPositionInBeats";

	private static readonly IntPtr selCurrentPositionInBeatsHandle = Selector.GetHandle("currentPositionInBeats");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentPositionInSeconds = "currentPositionInSeconds";

	private static readonly IntPtr selCurrentPositionInSecondsHandle = Selector.GetHandle("currentPositionInSeconds");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDataWithSMPTEResolution_Error_ = "dataWithSMPTEResolution:error:";

	private static readonly IntPtr selDataWithSMPTEResolution_Error_Handle = Selector.GetHandle("dataWithSMPTEResolution:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHostTimeForBeats_Error_ = "hostTimeForBeats:error:";

	private static readonly IntPtr selHostTimeForBeats_Error_Handle = Selector.GetHandle("hostTimeForBeats:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithAudioEngine_ = "initWithAudioEngine:";

	private static readonly IntPtr selInitWithAudioEngine_Handle = Selector.GetHandle("initWithAudioEngine:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsPlaying = "isPlaying";

	private static readonly IntPtr selIsPlayingHandle = Selector.GetHandle("isPlaying");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLoadFromData_Options_Error_ = "loadFromData:options:error:";

	private static readonly IntPtr selLoadFromData_Options_Error_Handle = Selector.GetHandle("loadFromData:options:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLoadFromURL_Options_Error_ = "loadFromURL:options:error:";

	private static readonly IntPtr selLoadFromURL_Options_Error_Handle = Selector.GetHandle("loadFromURL:options:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrepareToPlay = "prepareToPlay";

	private static readonly IntPtr selPrepareToPlayHandle = Selector.GetHandle("prepareToPlay");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRate = "rate";

	private static readonly IntPtr selRateHandle = Selector.GetHandle("rate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSecondsForBeats_ = "secondsForBeats:";

	private static readonly IntPtr selSecondsForBeats_Handle = Selector.GetHandle("secondsForBeats:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCurrentPositionInBeats_ = "setCurrentPositionInBeats:";

	private static readonly IntPtr selSetCurrentPositionInBeats_Handle = Selector.GetHandle("setCurrentPositionInBeats:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCurrentPositionInSeconds_ = "setCurrentPositionInSeconds:";

	private static readonly IntPtr selSetCurrentPositionInSeconds_Handle = Selector.GetHandle("setCurrentPositionInSeconds:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRate_ = "setRate:";

	private static readonly IntPtr selSetRate_Handle = Selector.GetHandle("setRate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStartAndReturnError_ = "startAndReturnError:";

	private static readonly IntPtr selStartAndReturnError_Handle = Selector.GetHandle("startAndReturnError:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStop = "stop";

	private static readonly IntPtr selStopHandle = Selector.GetHandle("stop");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTempoTrack = "tempoTrack";

	private static readonly IntPtr selTempoTrackHandle = Selector.GetHandle("tempoTrack");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTracks = "tracks";

	private static readonly IntPtr selTracksHandle = Selector.GetHandle("tracks");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUserInfo = "userInfo";

	private static readonly IntPtr selUserInfoHandle = Selector.GetHandle("userInfo");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWriteToURL_SMPTEResolution_ReplaceExisting_Error_ = "writeToURL:SMPTEResolution:replaceExisting:error:";

	private static readonly IntPtr selWriteToURL_SMPTEResolution_ReplaceExisting_Error_Handle = Selector.GetHandle("writeToURL:SMPTEResolution:replaceExisting:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVAudioSequencer");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double CurrentPositionInBeats
	{
		[Export("currentPositionInBeats")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selCurrentPositionInBeatsHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selCurrentPositionInBeatsHandle);
		}
		[Export("setCurrentPositionInBeats:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetCurrentPositionInBeats_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetCurrentPositionInBeats_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double CurrentPositionInSeconds
	{
		[Export("currentPositionInSeconds")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selCurrentPositionInSecondsHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selCurrentPositionInSecondsHandle);
		}
		[Export("setCurrentPositionInSeconds:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetCurrentPositionInSeconds_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetCurrentPositionInSeconds_Handle, value);
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
	public virtual AVMusicTrack TempoTrack
	{
		[Export("tempoTrack")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<AVMusicTrack>(Messaging.IntPtr_objc_msgSend(base.Handle, selTempoTrackHandle));
			}
			return Runtime.GetNSObject<AVMusicTrack>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTempoTrackHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVMusicTrack[] Tracks
	{
		[Export("tracks")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<AVMusicTrack>(Messaging.IntPtr_objc_msgSend(base.Handle, selTracksHandle));
			}
			return NSArray.ArrayFromHandle<AVMusicTrack>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTracksHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary<NSString, NSObject> UserInfo
	{
		[Export("userInfo")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary<NSString, NSObject>>(Messaging.IntPtr_objc_msgSend(base.Handle, selUserInfoHandle));
			}
			return Runtime.GetNSObject<NSDictionary<NSString, NSObject>>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUserInfoHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public AVAudioSequencer()
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
	protected AVAudioSequencer(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVAudioSequencer(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithAudioEngine:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVAudioSequencer(AVAudioEngine engine)
		: base(NSObjectFlag.Empty)
	{
		if (engine == null)
		{
			throw new ArgumentNullException("engine");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithAudioEngine_Handle, engine.Handle), "initWithAudioEngine:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithAudioEngine_Handle, engine.Handle), "initWithAudioEngine:");
		}
	}

	[Export("beatsForSeconds:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double GetBeats(double seconds)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.Double_objc_msgSend_Double(base.Handle, selBeatsForSeconds_Handle, seconds);
		}
		return Messaging.Double_objc_msgSendSuper_Double(base.SuperHandle, selBeatsForSeconds_Handle, seconds);
	}

	[Export("beatsForHostTime:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double GetBeats(ulong inHostTime, out NSError outError)
	{
		IntPtr arg = IntPtr.Zero;
		double result = ((!base.IsDirectBinding) ? Messaging.Double_objc_msgSendSuper_UInt64_ref_IntPtr(base.SuperHandle, selBeatsForHostTime_Error_Handle, inHostTime, ref arg) : Messaging.Double_objc_msgSend_UInt64_ref_IntPtr(base.Handle, selBeatsForHostTime_Error_Handle, inHostTime, ref arg));
		outError = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("dataWithSMPTEResolution:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSData GetData(nint smpteResolution, out NSError outError)
	{
		IntPtr arg = IntPtr.Zero;
		NSData result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper_nint_ref_IntPtr(base.SuperHandle, selDataWithSMPTEResolution_Error_Handle, smpteResolution, ref arg)) : Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend_nint_ref_IntPtr(base.Handle, selDataWithSMPTEResolution_Error_Handle, smpteResolution, ref arg)));
		outError = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("hostTimeForBeats:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual ulong GetHostTime(double inBeats, out NSError outError)
	{
		IntPtr arg = IntPtr.Zero;
		ulong result = ((!base.IsDirectBinding) ? Messaging.UInt64_objc_msgSendSuper_Double_ref_IntPtr(base.SuperHandle, selHostTimeForBeats_Error_Handle, inBeats, ref arg) : Messaging.UInt64_objc_msgSend_Double_ref_IntPtr(base.Handle, selHostTimeForBeats_Error_Handle, inBeats, ref arg));
		outError = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("secondsForBeats:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double GetSeconds(double beats)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.Double_objc_msgSend_Double(base.Handle, selSecondsForBeats_Handle, beats);
		}
		return Messaging.Double_objc_msgSendSuper_Double(base.SuperHandle, selSecondsForBeats_Handle, beats);
	}

	[Export("loadFromURL:options:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Load(NSUrl fileUrl, AVMusicSequenceLoadOptions options, out NSError outError)
	{
		if (fileUrl == null)
		{
			throw new ArgumentNullException("fileUrl");
		}
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_UInt64_ref_IntPtr(base.SuperHandle, selLoadFromURL_Options_Error_Handle, fileUrl.Handle, (ulong)options, ref arg) : Messaging.bool_objc_msgSend_IntPtr_UInt64_ref_IntPtr(base.Handle, selLoadFromURL_Options_Error_Handle, fileUrl.Handle, (ulong)options, ref arg));
		outError = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("loadFromData:options:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Load(NSData data, AVMusicSequenceLoadOptions options, out NSError outError)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_UInt64_ref_IntPtr(base.SuperHandle, selLoadFromData_Options_Error_Handle, data.Handle, (ulong)options, ref arg) : Messaging.bool_objc_msgSend_IntPtr_UInt64_ref_IntPtr(base.Handle, selLoadFromData_Options_Error_Handle, data.Handle, (ulong)options, ref arg));
		outError = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("prepareToPlay")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PrepareToPlay()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selPrepareToPlayHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selPrepareToPlayHandle);
		}
	}

	[Export("startAndReturnError:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Start(out NSError outError)
	{
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_ref_IntPtr(base.SuperHandle, selStartAndReturnError_Handle, ref arg) : Messaging.bool_objc_msgSend_ref_IntPtr(base.Handle, selStartAndReturnError_Handle, ref arg));
		outError = Runtime.GetNSObject<NSError>(arg);
		return result;
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

	[Export("writeToURL:SMPTEResolution:replaceExisting:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Write(NSUrl fileUrl, nint resolution, bool replace, out NSError outError)
	{
		if (fileUrl == null)
		{
			throw new ArgumentNullException("fileUrl");
		}
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_nint_bool_ref_IntPtr(base.SuperHandle, selWriteToURL_SMPTEResolution_ReplaceExisting_Error_Handle, fileUrl.Handle, resolution, replace, ref arg) : Messaging.bool_objc_msgSend_IntPtr_nint_bool_ref_IntPtr(base.Handle, selWriteToURL_SMPTEResolution_ReplaceExisting_Error_Handle, fileUrl.Handle, resolution, replace, ref arg));
		outError = Runtime.GetNSObject<NSError>(arg);
		return result;
	}
}
