using System;
using System.ComponentModel;
using System.Threading.Tasks;
using CoreFoundation;
using CoreMedia;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVSampleBufferAudioRenderer", true)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public class AVSampleBufferAudioRenderer : NSObject, IAVQueuedSampleBufferRendering, INativeObject, IDisposable
{
	public static class Notifications
	{
		public static NSObject ObserveAudioRendererWasFlushedAutomatically(EventHandler<AudioRendererWasFlushedAutomaticallyEventArgs> handler)
		{
			EventHandler<AudioRendererWasFlushedAutomaticallyEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(AudioRendererWasFlushedAutomaticallyNotification, delegate(NSNotification notification)
			{
				handler2(null, new AudioRendererWasFlushedAutomaticallyEventArgs(notification));
			});
		}

		public static NSObject ObserveAudioRendererWasFlushedAutomatically(NSObject objectToObserve, EventHandler<AudioRendererWasFlushedAutomaticallyEventArgs> handler)
		{
			EventHandler<AudioRendererWasFlushedAutomaticallyEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(AudioRendererWasFlushedAutomaticallyNotification, delegate(NSNotification notification)
			{
				handler2(null, new AudioRendererWasFlushedAutomaticallyEventArgs(notification));
			}, objectToObserve);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAudioOutputDeviceUniqueID = "audioOutputDeviceUniqueID";

	private static readonly IntPtr selAudioOutputDeviceUniqueIDHandle = Selector.GetHandle("audioOutputDeviceUniqueID");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAudioTimePitchAlgorithm = "audioTimePitchAlgorithm";

	private static readonly IntPtr selAudioTimePitchAlgorithmHandle = Selector.GetHandle("audioTimePitchAlgorithm");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEnqueueSampleBuffer_ = "enqueueSampleBuffer:";

	private static readonly IntPtr selEnqueueSampleBuffer_Handle = Selector.GetHandle("enqueueSampleBuffer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selError = "error";

	private static readonly IntPtr selErrorHandle = Selector.GetHandle("error");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFlush = "flush";

	private static readonly IntPtr selFlushHandle = Selector.GetHandle("flush");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFlushFromSourceTime_CompletionHandler_ = "flushFromSourceTime:completionHandler:";

	private static readonly IntPtr selFlushFromSourceTime_CompletionHandler_Handle = Selector.GetHandle("flushFromSourceTime:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsMuted = "isMuted";

	private static readonly IntPtr selIsMutedHandle = Selector.GetHandle("isMuted");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsReadyForMoreMediaData = "isReadyForMoreMediaData";

	private static readonly IntPtr selIsReadyForMoreMediaDataHandle = Selector.GetHandle("isReadyForMoreMediaData");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRequestMediaDataWhenReadyOnQueue_UsingBlock_ = "requestMediaDataWhenReadyOnQueue:usingBlock:";

	private static readonly IntPtr selRequestMediaDataWhenReadyOnQueue_UsingBlock_Handle = Selector.GetHandle("requestMediaDataWhenReadyOnQueue:usingBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAudioOutputDeviceUniqueID_ = "setAudioOutputDeviceUniqueID:";

	private static readonly IntPtr selSetAudioOutputDeviceUniqueID_Handle = Selector.GetHandle("setAudioOutputDeviceUniqueID:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAudioTimePitchAlgorithm_ = "setAudioTimePitchAlgorithm:";

	private static readonly IntPtr selSetAudioTimePitchAlgorithm_Handle = Selector.GetHandle("setAudioTimePitchAlgorithm:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMuted_ = "setMuted:";

	private static readonly IntPtr selSetMuted_Handle = Selector.GetHandle("setMuted:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetVolume_ = "setVolume:";

	private static readonly IntPtr selSetVolume_Handle = Selector.GetHandle("setVolume:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStatus = "status";

	private static readonly IntPtr selStatusHandle = Selector.GetHandle("status");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStopRequestingMediaData = "stopRequestingMediaData";

	private static readonly IntPtr selStopRequestingMediaDataHandle = Selector.GetHandle("stopRequestingMediaData");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTimebase = "timebase";

	private static readonly IntPtr selTimebaseHandle = Selector.GetHandle("timebase");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVolume = "volume";

	private static readonly IntPtr selVolumeHandle = Selector.GetHandle("volume");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVSampleBufferAudioRenderer");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AudioRendererWasFlushedAutomaticallyNotification;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	public virtual string? AudioOutputDeviceUniqueId
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Export("audioOutputDeviceUniqueID")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAudioOutputDeviceUniqueIDHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAudioOutputDeviceUniqueIDHandle));
		}
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Export("setAudioOutputDeviceUniqueID:")]
		set
		{
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAudioOutputDeviceUniqueID_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAudioOutputDeviceUniqueID_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSError? Error
	{
		[Export("error")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSError>(Messaging.IntPtr_objc_msgSend(base.Handle, selErrorHandle));
			}
			return Runtime.GetNSObject<NSError>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selErrorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Muted
	{
		[Export("isMuted")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsMutedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsMutedHandle);
		}
		[Export("setMuted:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetMuted_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetMuted_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string PitchAlgorithm
	{
		[Export("audioTimePitchAlgorithm")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAudioTimePitchAlgorithmHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAudioTimePitchAlgorithmHandle));
		}
		[Export("setAudioTimePitchAlgorithm:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAudioTimePitchAlgorithm_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAudioTimePitchAlgorithm_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual bool ReadyForMoreMediaData
	{
		[Export("isReadyForMoreMediaData")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsReadyForMoreMediaDataHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsReadyForMoreMediaDataHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVQueuedSampleBufferRenderingStatus Status
	{
		[Export("status")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (AVQueuedSampleBufferRenderingStatus)Messaging.Int64_objc_msgSend(base.Handle, selStatusHandle);
			}
			return (AVQueuedSampleBufferRenderingStatus)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selStatusHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual CMTimebase Timebase
	{
		[Export("timebase", ArgumentSemantic.Retain)]
		get
		{
			IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTimebaseHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selTimebaseHandle));
			return (intPtr == IntPtr.Zero) ? null : new CMTimebase(intPtr);
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

	[Field("AVSampleBufferAudioRendererWasFlushedAutomaticallyNotification", "AVFoundation")]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Advice("Use AVSampleBufferAudioRenderer.Notifications.ObserveAudioRendererWasFlushedAutomatically helper method instead.")]
	public static NSString AudioRendererWasFlushedAutomaticallyNotification
	{
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_AudioRendererWasFlushedAutomaticallyNotification == null)
			{
				_AudioRendererWasFlushedAutomaticallyNotification = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVSampleBufferAudioRendererWasFlushedAutomaticallyNotification");
			}
			return _AudioRendererWasFlushedAutomaticallyNotification;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public AVSampleBufferAudioRenderer()
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
	protected AVSampleBufferAudioRenderer(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVSampleBufferAudioRenderer(IntPtr handle)
		: base(handle)
	{
	}

	[Export("enqueueSampleBuffer:")]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Enqueue(CMSampleBuffer sampleBuffer)
	{
		if (sampleBuffer == null)
		{
			throw new ArgumentNullException("sampleBuffer");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEnqueueSampleBuffer_Handle, sampleBuffer.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEnqueueSampleBuffer_Handle, sampleBuffer.Handle);
		}
	}

	[Export("flushFromSourceTime:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void Flush(CMTime time, [BlockProxy(typeof(Trampolines.NIDActionArity1V0))] Action<bool> completionHandler)
	{
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V0.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CMTime_IntPtr(base.Handle, selFlushFromSourceTime_CompletionHandler_Handle, time, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CMTime_IntPtr(base.SuperHandle, selFlushFromSourceTime_CompletionHandler_Handle, time, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<bool> FlushAsync(CMTime time)
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		Flush(time, delegate(bool obj_)
		{
			tcs.SetResult(obj_);
		});
		return tcs.Task;
	}

	[Export("flush")]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Flush()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selFlushHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selFlushHandle);
		}
	}

	[Export("requestMediaDataWhenReadyOnQueue:usingBlock:")]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void RequestMediaData(DispatchQueue queue, [BlockProxy(typeof(Trampolines.NIDAction))] Action handler)
	{
		if (queue == null)
		{
			throw new ArgumentNullException("queue");
		}
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDAction.Handler, handler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selRequestMediaDataWhenReadyOnQueue_UsingBlock_Handle, queue.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selRequestMediaDataWhenReadyOnQueue_UsingBlock_Handle, queue.Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("stopRequestingMediaData")]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void StopRequestingMediaData()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selStopRequestingMediaDataHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selStopRequestingMediaDataHandle);
		}
	}
}
