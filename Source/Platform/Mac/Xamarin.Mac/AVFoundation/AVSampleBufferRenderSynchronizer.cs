using System;
using System.ComponentModel;
using System.Threading.Tasks;
using CoreFoundation;
using CoreMedia;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVSampleBufferRenderSynchronizer", true)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public class AVSampleBufferRenderSynchronizer : NSObject
{
	public static class Notifications
	{
		public static NSObject ObserveRateDidChange(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(RateDidChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveRateDidChange(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(RateDidChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddBoundaryTimeObserverForTimes_Queue_UsingBlock_ = "addBoundaryTimeObserverForTimes:queue:usingBlock:";

	private static readonly IntPtr selAddBoundaryTimeObserverForTimes_Queue_UsingBlock_Handle = Selector.GetHandle("addBoundaryTimeObserverForTimes:queue:usingBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddPeriodicTimeObserverForInterval_Queue_UsingBlock_ = "addPeriodicTimeObserverForInterval:queue:usingBlock:";

	private static readonly IntPtr selAddPeriodicTimeObserverForInterval_Queue_UsingBlock_Handle = Selector.GetHandle("addPeriodicTimeObserverForInterval:queue:usingBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddRenderer_ = "addRenderer:";

	private static readonly IntPtr selAddRenderer_Handle = Selector.GetHandle("addRenderer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentTime = "currentTime";

	private static readonly IntPtr selCurrentTimeHandle = Selector.GetHandle("currentTime");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRate = "rate";

	private static readonly IntPtr selRateHandle = Selector.GetHandle("rate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveRenderer_AtTime_CompletionHandler_ = "removeRenderer:atTime:completionHandler:";

	private static readonly IntPtr selRemoveRenderer_AtTime_CompletionHandler_Handle = Selector.GetHandle("removeRenderer:atTime:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveTimeObserver_ = "removeTimeObserver:";

	private static readonly IntPtr selRemoveTimeObserver_Handle = Selector.GetHandle("removeTimeObserver:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRenderers = "renderers";

	private static readonly IntPtr selRenderersHandle = Selector.GetHandle("renderers");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRate_ = "setRate:";

	private static readonly IntPtr selSetRate_Handle = Selector.GetHandle("setRate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRate_Time_ = "setRate:time:";

	private static readonly IntPtr selSetRate_Time_Handle = Selector.GetHandle("setRate:time:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTimebase = "timebase";

	private static readonly IntPtr selTimebaseHandle = Selector.GetHandle("timebase");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVSampleBufferRenderSynchronizer");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _RateDidChangeNotification;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public virtual CMTime CurrentTime
	{
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		[Export("currentTime")]
		get
		{
			CMTime retval;
			if (base.IsDirectBinding)
			{
				Messaging.CMTime_objc_msgSend_stret(out retval, base.Handle, selCurrentTimeHandle);
			}
			else
			{
				Messaging.CMTime_objc_msgSendSuper_stret(out retval, base.SuperHandle, selCurrentTimeHandle);
			}
			return retval;
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
	public virtual IAVQueuedSampleBufferRendering[] Renderers
	{
		[Export("renderers")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<IAVQueuedSampleBufferRendering>(Messaging.IntPtr_objc_msgSend(base.Handle, selRenderersHandle));
			}
			return NSArray.ArrayFromHandle<IAVQueuedSampleBufferRendering>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRenderersHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CMTimebase Timebase
	{
		[Export("timebase", ArgumentSemantic.Retain)]
		get
		{
			IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTimebaseHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selTimebaseHandle));
			return (intPtr == IntPtr.Zero) ? null : new CMTimebase(intPtr);
		}
	}

	[Field("AVSampleBufferRenderSynchronizerRateDidChangeNotification", "AVFoundation")]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[Advice("Use AVSampleBufferRenderSynchronizer.Notifications.ObserveRateDidChange helper method instead.")]
	public static NSString RateDidChangeNotification
	{
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_RateDidChangeNotification == null)
			{
				_RateDidChangeNotification = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVSampleBufferRenderSynchronizerRateDidChangeNotification");
			}
			return _RateDidChangeNotification;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public AVSampleBufferRenderSynchronizer()
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
	protected AVSampleBufferRenderSynchronizer(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVSampleBufferRenderSynchronizer(IntPtr handle)
		: base(handle)
	{
	}

	[Export("addRenderer:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Add(IAVQueuedSampleBufferRendering renderer)
	{
		if (renderer == null)
		{
			throw new ArgumentNullException("renderer");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddRenderer_Handle, renderer.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddRenderer_Handle, renderer.Handle);
		}
	}

	[Export("addBoundaryTimeObserverForTimes:queue:usingBlock:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual NSObject AddBoundaryTimeObserver(NSValue[] times, DispatchQueue? queue, [BlockProxy(typeof(Trampolines.NIDAction))] Action handler)
	{
		if (times == null)
		{
			throw new ArgumentNullException("times");
		}
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		NSArray nSArray = NSArray.FromNSObjects(times);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDAction.Handler, handler);
		NSObject result = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selAddBoundaryTimeObserverForTimes_Queue_UsingBlock_Handle, nSArray.Handle, (queue == null) ? IntPtr.Zero : queue.Handle, (IntPtr)ptr)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selAddBoundaryTimeObserverForTimes_Queue_UsingBlock_Handle, nSArray.Handle, (queue == null) ? IntPtr.Zero : queue.Handle, (IntPtr)ptr)));
		nSArray.Dispose();
		ptr->CleanupBlock();
		return result;
	}

	[Export("addPeriodicTimeObserverForInterval:queue:usingBlock:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual NSObject AddPeriodicTimeObserver(CMTime interval, DispatchQueue? queue, [BlockProxy(typeof(Trampolines.NIDActionArity1V5))] Action<CMTime> handler)
	{
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V5.Handler, handler);
		NSObject result = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_CMTime_IntPtr_IntPtr(base.SuperHandle, selAddPeriodicTimeObserverForInterval_Queue_UsingBlock_Handle, interval, (queue == null) ? IntPtr.Zero : queue.Handle, (IntPtr)ptr)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_CMTime_IntPtr_IntPtr(base.Handle, selAddPeriodicTimeObserverForInterval_Queue_UsingBlock_Handle, interval, (queue == null) ? IntPtr.Zero : queue.Handle, (IntPtr)ptr)));
		ptr->CleanupBlock();
		return result;
	}

	[Export("removeRenderer:atTime:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void Remove(IAVQueuedSampleBufferRendering renderer, CMTime time, [BlockProxy(typeof(Trampolines.NIDActionArity1V0))] Action<bool>? completionHandler)
	{
		if (renderer == null)
		{
			throw new ArgumentNullException("renderer");
		}
		BlockLiteral* ptr;
		if (completionHandler == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V0.Handler, completionHandler);
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_CMTime_IntPtr(base.Handle, selRemoveRenderer_AtTime_CompletionHandler_Handle, renderer.Handle, time, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_CMTime_IntPtr(base.SuperHandle, selRemoveRenderer_AtTime_CompletionHandler_Handle, renderer.Handle, time, (IntPtr)ptr);
		}
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<bool> RemoveAsync(IAVQueuedSampleBufferRendering renderer, CMTime time)
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		Remove(renderer, time, delegate(bool obj_)
		{
			tcs.SetResult(obj_);
		});
		return tcs.Task;
	}

	[Export("removeTimeObserver:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveTimeObserver(NSObject observer)
	{
		if (observer == null)
		{
			throw new ArgumentNullException("observer");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveTimeObserver_Handle, observer.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveTimeObserver_Handle, observer.Handle);
		}
	}

	[Export("setRate:time:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetRate(float rate, CMTime time)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_float_CMTime(base.Handle, selSetRate_Time_Handle, rate, time);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_float_CMTime(base.SuperHandle, selSetRate_Time_Handle, rate, time);
		}
	}
}
