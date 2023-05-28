using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVMIDIPlayer", true)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
public class AVMidiPlayer : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentPosition = "currentPosition";

	private static readonly IntPtr selCurrentPositionHandle = Selector.GetHandle("currentPosition");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDuration = "duration";

	private static readonly IntPtr selDurationHandle = Selector.GetHandle("duration");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithContentsOfURL_SoundBankURL_Error_ = "initWithContentsOfURL:soundBankURL:error:";

	private static readonly IntPtr selInitWithContentsOfURL_SoundBankURL_Error_Handle = Selector.GetHandle("initWithContentsOfURL:soundBankURL:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithData_SoundBankURL_Error_ = "initWithData:soundBankURL:error:";

	private static readonly IntPtr selInitWithData_SoundBankURL_Error_Handle = Selector.GetHandle("initWithData:soundBankURL:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsPlaying = "isPlaying";

	private static readonly IntPtr selIsPlayingHandle = Selector.GetHandle("isPlaying");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPlay_ = "play:";

	private static readonly IntPtr selPlay_Handle = Selector.GetHandle("play:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrepareToPlay = "prepareToPlay";

	private static readonly IntPtr selPrepareToPlayHandle = Selector.GetHandle("prepareToPlay");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRate = "rate";

	private static readonly IntPtr selRateHandle = Selector.GetHandle("rate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCurrentPosition_ = "setCurrentPosition:";

	private static readonly IntPtr selSetCurrentPosition_Handle = Selector.GetHandle("setCurrentPosition:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRate_ = "setRate:";

	private static readonly IntPtr selSetRate_Handle = Selector.GetHandle("setRate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStop = "stop";

	private static readonly IntPtr selStopHandle = Selector.GetHandle("stop");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVMIDIPlayer");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double CurrentPosition
	{
		[Export("currentPosition")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selCurrentPositionHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selCurrentPositionHandle);
		}
		[Export("setCurrentPosition:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetCurrentPosition_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetCurrentPosition_Handle, value);
			}
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
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public AVMidiPlayer()
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
	protected AVMidiPlayer(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVMidiPlayer(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithContentsOfURL:soundBankURL:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVMidiPlayer(NSUrl contentsUrl, NSUrl? soundBankUrl, out NSError outError)
		: base(NSObjectFlag.Empty)
	{
		if (contentsUrl == null)
		{
			throw new ArgumentNullException("contentsUrl");
		}
		IntPtr arg = IntPtr.Zero;
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(base.Handle, selInitWithContentsOfURL_SoundBankURL_Error_Handle, contentsUrl.Handle, (soundBankUrl == null) ? IntPtr.Zero : soundBankUrl.Handle, ref arg), "initWithContentsOfURL:soundBankURL:error:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_ref_IntPtr(base.SuperHandle, selInitWithContentsOfURL_SoundBankURL_Error_Handle, contentsUrl.Handle, (soundBankUrl == null) ? IntPtr.Zero : soundBankUrl.Handle, ref arg), "initWithContentsOfURL:soundBankURL:error:");
		}
		outError = Runtime.GetNSObject<NSError>(arg);
	}

	[Export("initWithData:soundBankURL:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVMidiPlayer(NSData data, NSUrl? sounddBankUrl, out NSError outError)
		: base(NSObjectFlag.Empty)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		IntPtr arg = IntPtr.Zero;
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(base.Handle, selInitWithData_SoundBankURL_Error_Handle, data.Handle, (sounddBankUrl == null) ? IntPtr.Zero : sounddBankUrl.Handle, ref arg), "initWithData:soundBankURL:error:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_ref_IntPtr(base.SuperHandle, selInitWithData_SoundBankURL_Error_Handle, data.Handle, (sounddBankUrl == null) ? IntPtr.Zero : sounddBankUrl.Handle, ref arg), "initWithData:soundBankURL:error:");
		}
		outError = Runtime.GetNSObject<NSError>(arg);
	}

	[Export("play:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void Play([BlockProxy(typeof(Trampolines.NIDAction))] Action? completionHandler)
	{
		BlockLiteral* ptr;
		if (completionHandler == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDAction.Handler, completionHandler);
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selPlay_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selPlay_Handle, (IntPtr)ptr);
		}
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task PlayAsync()
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		Play(delegate
		{
			tcs.SetResult(result: true);
		});
		return tcs.Task;
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
}
