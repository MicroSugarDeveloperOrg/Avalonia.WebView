using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Foundation;
using ObjCRuntime;

namespace CoreMotion;

[Register("CMPedometer", true)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
public class CMPedometer : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAuthorizationStatus = "authorizationStatus";

	private static readonly IntPtr selAuthorizationStatusHandle = Selector.GetHandle("authorizationStatus");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsCadenceAvailable = "isCadenceAvailable";

	private static readonly IntPtr selIsCadenceAvailableHandle = Selector.GetHandle("isCadenceAvailable");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsDistanceAvailable = "isDistanceAvailable";

	private static readonly IntPtr selIsDistanceAvailableHandle = Selector.GetHandle("isDistanceAvailable");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsFloorCountingAvailable = "isFloorCountingAvailable";

	private static readonly IntPtr selIsFloorCountingAvailableHandle = Selector.GetHandle("isFloorCountingAvailable");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsPaceAvailable = "isPaceAvailable";

	private static readonly IntPtr selIsPaceAvailableHandle = Selector.GetHandle("isPaceAvailable");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsPedometerEventTrackingAvailable = "isPedometerEventTrackingAvailable";

	private static readonly IntPtr selIsPedometerEventTrackingAvailableHandle = Selector.GetHandle("isPedometerEventTrackingAvailable");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsStepCountingAvailable = "isStepCountingAvailable";

	private static readonly IntPtr selIsStepCountingAvailableHandle = Selector.GetHandle("isStepCountingAvailable");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selQueryPedometerDataFromDate_ToDate_WithHandler_ = "queryPedometerDataFromDate:toDate:withHandler:";

	private static readonly IntPtr selQueryPedometerDataFromDate_ToDate_WithHandler_Handle = Selector.GetHandle("queryPedometerDataFromDate:toDate:withHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStartPedometerEventUpdatesWithHandler_ = "startPedometerEventUpdatesWithHandler:";

	private static readonly IntPtr selStartPedometerEventUpdatesWithHandler_Handle = Selector.GetHandle("startPedometerEventUpdatesWithHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStartPedometerUpdatesFromDate_WithHandler_ = "startPedometerUpdatesFromDate:withHandler:";

	private static readonly IntPtr selStartPedometerUpdatesFromDate_WithHandler_Handle = Selector.GetHandle("startPedometerUpdatesFromDate:withHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStopPedometerEventUpdates = "stopPedometerEventUpdates";

	private static readonly IntPtr selStopPedometerEventUpdatesHandle = Selector.GetHandle("stopPedometerEventUpdates");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStopPedometerUpdates = "stopPedometerUpdates";

	private static readonly IntPtr selStopPedometerUpdatesHandle = Selector.GetHandle("stopPedometerUpdates");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CMPedometer");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public static CMAuthorizationStatus AuthorizationStatus
	{
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("authorizationStatus")]
		get
		{
			return (CMAuthorizationStatus)Messaging.Int64_objc_msgSend(class_ptr, selAuthorizationStatusHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	public static bool IsCadenceAvailable
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Export("isCadenceAvailable")]
		get
		{
			return Messaging.bool_objc_msgSend(class_ptr, selIsCadenceAvailableHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool IsDistanceAvailable
	{
		[Export("isDistanceAvailable")]
		get
		{
			return Messaging.bool_objc_msgSend(class_ptr, selIsDistanceAvailableHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool IsFloorCountingAvailable
	{
		[Export("isFloorCountingAvailable")]
		get
		{
			return Messaging.bool_objc_msgSend(class_ptr, selIsFloorCountingAvailableHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	public static bool IsPaceAvailable
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Export("isPaceAvailable")]
		get
		{
			return Messaging.bool_objc_msgSend(class_ptr, selIsPaceAvailableHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	public static bool IsPedometerEventTrackingAvailable
	{
		[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Export("isPedometerEventTrackingAvailable")]
		get
		{
			return Messaging.bool_objc_msgSend(class_ptr, selIsPedometerEventTrackingAvailableHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool IsStepCountingAvailable
	{
		[Export("isStepCountingAvailable")]
		get
		{
			return Messaging.bool_objc_msgSend(class_ptr, selIsStepCountingAvailableHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public CMPedometer()
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
	protected CMPedometer(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CMPedometer(IntPtr handle)
		: base(handle)
	{
	}

	[Export("queryPedometerDataFromDate:toDate:withHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void QueryPedometerData(NSDate start, NSDate end, [BlockProxy(typeof(Trampolines.NIDActionArity2V38))] Action<CMPedometerData, NSError> handler)
	{
		if (start == null)
		{
			throw new ArgumentNullException("start");
		}
		if (end == null)
		{
			throw new ArgumentNullException("end");
		}
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V38.Handler, handler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selQueryPedometerDataFromDate_ToDate_WithHandler_Handle, start.Handle, end.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selQueryPedometerDataFromDate_ToDate_WithHandler_Handle, start.Handle, end.Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<CMPedometerData> QueryPedometerDataAsync(NSDate start, NSDate end)
	{
		TaskCompletionSource<CMPedometerData> tcs = new TaskCompletionSource<CMPedometerData>();
		QueryPedometerData(start, end, delegate(CMPedometerData arg1_, NSError arg2_)
		{
			if (arg2_ != null)
			{
				tcs.SetException(new NSErrorException(arg2_));
			}
			else
			{
				tcs.SetResult(arg1_);
			}
		});
		return tcs.Task;
	}

	[Export("startPedometerEventUpdatesWithHandler:")]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void StartPedometerEventUpdates([BlockProxy(typeof(Trampolines.NIDActionArity2V39))] Action<CMPedometerEvent, NSError> handler)
	{
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V39.Handler, handler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selStartPedometerEventUpdatesWithHandler_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selStartPedometerEventUpdatesWithHandler_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<CMPedometerEvent> StartPedometerEventUpdatesAsync()
	{
		TaskCompletionSource<CMPedometerEvent> tcs = new TaskCompletionSource<CMPedometerEvent>();
		StartPedometerEventUpdates(delegate(CMPedometerEvent arg1_, NSError arg2_)
		{
			if (arg2_ != null)
			{
				tcs.SetException(new NSErrorException(arg2_));
			}
			else
			{
				tcs.SetResult(arg1_);
			}
		});
		return tcs.Task;
	}

	[Export("startPedometerUpdatesFromDate:withHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void StartPedometerUpdates(NSDate start, [BlockProxy(typeof(Trampolines.NIDActionArity2V38))] Action<CMPedometerData, NSError> handler)
	{
		if (start == null)
		{
			throw new ArgumentNullException("start");
		}
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V38.Handler, handler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selStartPedometerUpdatesFromDate_WithHandler_Handle, start.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selStartPedometerUpdatesFromDate_WithHandler_Handle, start.Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<CMPedometerData> StartPedometerUpdatesAsync(NSDate start)
	{
		TaskCompletionSource<CMPedometerData> tcs = new TaskCompletionSource<CMPedometerData>();
		StartPedometerUpdates(start, delegate(CMPedometerData arg1_, NSError arg2_)
		{
			if (arg2_ != null)
			{
				tcs.SetException(new NSErrorException(arg2_));
			}
			else
			{
				tcs.SetResult(arg1_);
			}
		});
		return tcs.Task;
	}

	[Export("stopPedometerEventUpdates")]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void StopPedometerEventUpdates()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selStopPedometerEventUpdatesHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selStopPedometerEventUpdatesHandle);
		}
	}

	[Export("stopPedometerUpdates")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void StopPedometerUpdates()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selStopPedometerUpdatesHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selStopPedometerUpdatesHandle);
		}
	}
}
