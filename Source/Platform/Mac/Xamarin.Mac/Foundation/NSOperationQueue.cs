using System;
using System.ComponentModel;
using CoreFoundation;
using ObjCRuntime;

namespace Foundation;

[Register("NSOperationQueue", true)]
public class NSOperationQueue : NSObject, INSProgressReporting, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddBarrierBlock_ = "addBarrierBlock:";

	private static readonly IntPtr selAddBarrierBlock_Handle = Selector.GetHandle("addBarrierBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddOperation_ = "addOperation:";

	private static readonly IntPtr selAddOperation_Handle = Selector.GetHandle("addOperation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddOperationWithBlock_ = "addOperationWithBlock:";

	private static readonly IntPtr selAddOperationWithBlock_Handle = Selector.GetHandle("addOperationWithBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddOperations_WaitUntilFinished_ = "addOperations:waitUntilFinished:";

	private static readonly IntPtr selAddOperations_WaitUntilFinished_Handle = Selector.GetHandle("addOperations:waitUntilFinished:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCancelAllOperations = "cancelAllOperations";

	private static readonly IntPtr selCancelAllOperationsHandle = Selector.GetHandle("cancelAllOperations");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentQueue = "currentQueue";

	private static readonly IntPtr selCurrentQueueHandle = Selector.GetHandle("currentQueue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsSuspended = "isSuspended";

	private static readonly IntPtr selIsSuspendedHandle = Selector.GetHandle("isSuspended");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMainQueue = "mainQueue";

	private static readonly IntPtr selMainQueueHandle = Selector.GetHandle("mainQueue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaxConcurrentOperationCount = "maxConcurrentOperationCount";

	private static readonly IntPtr selMaxConcurrentOperationCountHandle = Selector.GetHandle("maxConcurrentOperationCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selName = "name";

	private static readonly IntPtr selNameHandle = Selector.GetHandle("name");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOperationCount = "operationCount";

	private static readonly IntPtr selOperationCountHandle = Selector.GetHandle("operationCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOperations = "operations";

	private static readonly IntPtr selOperationsHandle = Selector.GetHandle("operations");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selProgress = "progress";

	private static readonly IntPtr selProgressHandle = Selector.GetHandle("progress");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selQualityOfService = "qualityOfService";

	private static readonly IntPtr selQualityOfServiceHandle = Selector.GetHandle("qualityOfService");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMaxConcurrentOperationCount_ = "setMaxConcurrentOperationCount:";

	private static readonly IntPtr selSetMaxConcurrentOperationCount_Handle = Selector.GetHandle("setMaxConcurrentOperationCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetName_ = "setName:";

	private static readonly IntPtr selSetName_Handle = Selector.GetHandle("setName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetQualityOfService_ = "setQualityOfService:";

	private static readonly IntPtr selSetQualityOfService_Handle = Selector.GetHandle("setQualityOfService:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSuspended_ = "setSuspended:";

	private static readonly IntPtr selSetSuspended_Handle = Selector.GetHandle("setSuspended:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetUnderlyingQueue_ = "setUnderlyingQueue:";

	private static readonly IntPtr selSetUnderlyingQueue_Handle = Selector.GetHandle("setUnderlyingQueue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnderlyingQueue = "underlyingQueue";

	private static readonly IntPtr selUnderlyingQueueHandle = Selector.GetHandle("underlyingQueue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWaitUntilAllOperationsAreFinished = "waitUntilAllOperationsAreFinished";

	private static readonly IntPtr selWaitUntilAllOperationsAreFinishedHandle = Selector.GetHandle("waitUntilAllOperationsAreFinished");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSOperationQueue");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSOperationQueue CurrentQueue
	{
		[Export("currentQueue", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<NSOperationQueue>(Messaging.IntPtr_objc_msgSend(class_ptr, selCurrentQueueHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSOperationQueue MainQueue
	{
		[Export("mainQueue", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<NSOperationQueue>(Messaging.IntPtr_objc_msgSend(class_ptr, selMainQueueHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint MaxConcurrentOperationCount
	{
		[Export("maxConcurrentOperationCount")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selMaxConcurrentOperationCountHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selMaxConcurrentOperationCountHandle);
		}
		[Export("setMaxConcurrentOperationCount:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetMaxConcurrentOperationCount_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetMaxConcurrentOperationCount_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Name
	{
		[Export("name")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNameHandle));
		}
		[Export("setName:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetName_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetName_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.WatchOS, 6, 0, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, null)]
	public virtual nint OperationCount
	{
		[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, null)]
		[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, null)]
		[Deprecated(PlatformName.WatchOS, 6, 0, PlatformArchitecture.None, null)]
		[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, null)]
		[Export("operationCount")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selOperationCountHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selOperationCountHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 15, 0, PlatformArchitecture.None, "This API should not be used as it is subject to race conditions. If synchronization is needed use 'AddBarrier' instead.")]
	[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "This API should not be used as it is subject to race conditions. If synchronization is needed use 'AddBarrier' instead.")]
	[Deprecated(PlatformName.WatchOS, 6, 0, PlatformArchitecture.None, "This API should not be used as it is subject to race conditions. If synchronization is needed use 'AddBarrier' instead.")]
	[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "This API should not be used as it is subject to race conditions. If synchronization is needed use 'AddBarrier' instead.")]
	public virtual NSOperation[] Operations
	{
		[Deprecated(PlatformName.MacOSX, 10, 15, 0, PlatformArchitecture.None, "This API should not be used as it is subject to race conditions. If synchronization is needed use 'AddBarrier' instead.")]
		[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "This API should not be used as it is subject to race conditions. If synchronization is needed use 'AddBarrier' instead.")]
		[Deprecated(PlatformName.WatchOS, 6, 0, PlatformArchitecture.None, "This API should not be used as it is subject to race conditions. If synchronization is needed use 'AddBarrier' instead.")]
		[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "This API should not be used as it is subject to race conditions. If synchronization is needed use 'AddBarrier' instead.")]
		[Export("operations")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSOperation>(Messaging.IntPtr_objc_msgSend(base.Handle, selOperationsHandle));
			}
			return NSArray.ArrayFromHandle<NSOperation>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOperationsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual NSProgress Progress
	{
		[Export("progress")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSProgress>(Messaging.IntPtr_objc_msgSend(base.Handle, selProgressHandle));
			}
			return Runtime.GetNSObject<NSProgress>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selProgressHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSQualityOfService QualityOfService
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("qualityOfService")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (NSQualityOfService)Messaging.Int64_objc_msgSend(base.Handle, selQualityOfServiceHandle);
			}
			return (NSQualityOfService)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selQualityOfServiceHandle);
		}
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setQualityOfService:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetQualityOfService_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetQualityOfService_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Suspended
	{
		[Export("isSuspended")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsSuspendedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsSuspendedHandle);
		}
		[Export("setSuspended:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetSuspended_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetSuspended_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual DispatchQueue? UnderlyingQueue
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("underlyingQueue", ArgumentSemantic.Assign)]
		get
		{
			IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUnderlyingQueueHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selUnderlyingQueueHandle));
			return (intPtr == IntPtr.Zero) ? null : new DispatchQueue(intPtr);
		}
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setUnderlyingQueue:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetUnderlyingQueue_Handle, (value == null) ? IntPtr.Zero : value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetUnderlyingQueue_Handle, (value == null) ? IntPtr.Zero : value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSOperationQueue()
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
	protected NSOperationQueue(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSOperationQueue(IntPtr handle)
		: base(handle)
	{
	}

	[Export("addBarrierBlock:")]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void AddBarrier([BlockProxy(typeof(Trampolines.NIDAction))] Action barrier)
	{
		if (barrier == null)
		{
			throw new ArgumentNullException("barrier");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDAction.Handler, barrier);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddBarrierBlock_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddBarrierBlock_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("addOperation:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddOperation(NSOperation? op)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddOperation_Handle, op?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddOperation_Handle, op?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("addOperationWithBlock:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void AddOperation([BlockProxy(typeof(Trampolines.NIDAction))] Action operation)
	{
		if (operation == null)
		{
			throw new ArgumentNullException("operation");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDAction.Handler, operation);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddOperationWithBlock_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddOperationWithBlock_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("addOperations:waitUntilFinished:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddOperations(NSOperation[]? operations, bool waitUntilFinished)
	{
		NSArray nSArray = ((operations == null) ? null : NSArray.FromNSObjects(operations));
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_bool(base.Handle, selAddOperations_WaitUntilFinished_Handle, nSArray?.Handle ?? IntPtr.Zero, waitUntilFinished);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_bool(base.SuperHandle, selAddOperations_WaitUntilFinished_Handle, nSArray?.Handle ?? IntPtr.Zero, waitUntilFinished);
		}
		nSArray?.Dispose();
	}

	[Export("cancelAllOperations")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void CancelAllOperations()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selCancelAllOperationsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selCancelAllOperationsHandle);
		}
	}

	[Export("waitUntilAllOperationsAreFinished")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WaitUntilAllOperationsAreFinished()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selWaitUntilAllOperationsAreFinishedHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selWaitUntilAllOperationsAreFinishedHandle);
		}
	}
}
