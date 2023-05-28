using System;
using System.ComponentModel;
using CoreAnimation;
using CoreFoundation;
using CoreMedia;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVSampleBufferDisplayLayer", true)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 2, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
public class AVSampleBufferDisplayLayer : CALayer
{
	public static class Notifications
	{
		public static NSObject ObserveFailedToDecode(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(FailedToDecodeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveFailedToDecode(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(FailedToDecodeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selControlTimebase = "controlTimebase";

	private static readonly IntPtr selControlTimebaseHandle = Selector.GetHandle("controlTimebase");

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
	private const string selFlushAndRemoveImage = "flushAndRemoveImage";

	private static readonly IntPtr selFlushAndRemoveImageHandle = Selector.GetHandle("flushAndRemoveImage");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsReadyForMoreMediaData = "isReadyForMoreMediaData";

	private static readonly IntPtr selIsReadyForMoreMediaDataHandle = Selector.GetHandle("isReadyForMoreMediaData");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreventsCapture = "preventsCapture";

	private static readonly IntPtr selPreventsCaptureHandle = Selector.GetHandle("preventsCapture");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreventsDisplaySleepDuringVideoPlayback = "preventsDisplaySleepDuringVideoPlayback";

	private static readonly IntPtr selPreventsDisplaySleepDuringVideoPlaybackHandle = Selector.GetHandle("preventsDisplaySleepDuringVideoPlayback");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRequestMediaDataWhenReadyOnQueue_UsingBlock_ = "requestMediaDataWhenReadyOnQueue:usingBlock:";

	private static readonly IntPtr selRequestMediaDataWhenReadyOnQueue_UsingBlock_Handle = Selector.GetHandle("requestMediaDataWhenReadyOnQueue:usingBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetControlTimebase_ = "setControlTimebase:";

	private static readonly IntPtr selSetControlTimebase_Handle = Selector.GetHandle("setControlTimebase:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPreventsCapture_ = "setPreventsCapture:";

	private static readonly IntPtr selSetPreventsCapture_Handle = Selector.GetHandle("setPreventsCapture:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPreventsDisplaySleepDuringVideoPlayback_ = "setPreventsDisplaySleepDuringVideoPlayback:";

	private static readonly IntPtr selSetPreventsDisplaySleepDuringVideoPlayback_Handle = Selector.GetHandle("setPreventsDisplaySleepDuringVideoPlayback:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetVideoGravity_ = "setVideoGravity:";

	private static readonly IntPtr selSetVideoGravity_Handle = Selector.GetHandle("setVideoGravity:");

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
	private const string selVideoGravity = "videoGravity";

	private static readonly IntPtr selVideoGravityHandle = Selector.GetHandle("videoGravity");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVSampleBufferDisplayLayer");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FailedToDecodeNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FailedToDecodeNotificationErrorKey;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CMTimebase? ControlTimebase
	{
		[Export("controlTimebase", ArgumentSemantic.Retain)]
		get
		{
			IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selControlTimebaseHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selControlTimebaseHandle));
			return (intPtr == IntPtr.Zero) ? null : new CMTimebase(intPtr);
		}
		[Export("setControlTimebase:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetControlTimebase_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetControlTimebase_Handle, value?.Handle ?? IntPtr.Zero);
			}
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
	[Introduced(PlatformName.TvOS, 12, 2, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 2, PlatformArchitecture.All, null)]
	public virtual bool PreventsCapture
	{
		[Introduced(PlatformName.TvOS, 12, 2, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 2, PlatformArchitecture.All, null)]
		[Export("preventsCapture")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selPreventsCaptureHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selPreventsCaptureHandle);
		}
		[Introduced(PlatformName.TvOS, 12, 2, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 2, PlatformArchitecture.All, null)]
		[Export("setPreventsCapture:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetPreventsCapture_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetPreventsCapture_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	public virtual bool PreventsDisplaySleepDuringVideoPlayback
	{
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("preventsDisplaySleepDuringVideoPlayback")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selPreventsDisplaySleepDuringVideoPlaybackHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selPreventsDisplaySleepDuringVideoPlaybackHandle);
		}
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("setPreventsDisplaySleepDuringVideoPlayback:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetPreventsDisplaySleepDuringVideoPlayback_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetPreventsDisplaySleepDuringVideoPlayback_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual CMTimebase Timebase
	{
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("timebase", ArgumentSemantic.Retain)]
		get
		{
			IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTimebaseHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selTimebaseHandle));
			return (intPtr == IntPtr.Zero) ? null : new CMTimebase(intPtr);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string VideoGravity
	{
		[Export("videoGravity")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selVideoGravityHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selVideoGravityHandle));
		}
		[Export("setVideoGravity:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetVideoGravity_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetVideoGravity_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[Field("AVSampleBufferDisplayLayerFailedToDecodeNotification", "AVFoundation")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Advice("Use AVSampleBufferDisplayLayer.Notifications.ObserveFailedToDecode helper method instead.")]
	public static NSString FailedToDecodeNotification
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		get
		{
			if (_FailedToDecodeNotification == null)
			{
				_FailedToDecodeNotification = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVSampleBufferDisplayLayerFailedToDecodeNotification");
			}
			return _FailedToDecodeNotification;
		}
	}

	[Field("AVSampleBufferDisplayLayerFailedToDecodeNotificationErrorKey", "AVFoundation")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public static NSString FailedToDecodeNotificationErrorKey
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		get
		{
			if (_FailedToDecodeNotificationErrorKey == null)
			{
				_FailedToDecodeNotificationErrorKey = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVSampleBufferDisplayLayerFailedToDecodeNotificationErrorKey");
			}
			return _FailedToDecodeNotificationErrorKey;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public AVSampleBufferDisplayLayer()
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
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public AVSampleBufferDisplayLayer(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AVSampleBufferDisplayLayer(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVSampleBufferDisplayLayer(IntPtr handle)
		: base(handle)
	{
	}

	[Export("enqueueSampleBuffer:")]
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

	[Obsolete("Use the 'Enqueue' method instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EnqueueSampleBuffer(CMSampleBuffer sampleBuffer)
	{
		Enqueue(sampleBuffer);
	}

	[Export("flush")]
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

	[Export("flushAndRemoveImage")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void FlushAndRemoveImage()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selFlushAndRemoveImageHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selFlushAndRemoveImageHandle);
		}
	}

	[Export("requestMediaDataWhenReadyOnQueue:usingBlock:")]
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

	[Obsolete("Use the 'RequestMediaData' method instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RequestMediaDataWhenReadyOnQueue(DispatchQueue queue, [BlockProxy(typeof(Trampolines.NIDAction))] Action enqueuer)
	{
		RequestMediaData(queue, enqueuer);
	}

	[Export("stopRequestingMediaData")]
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
