using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSOperation", true)]
public class NSOperation : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddDependency_ = "addDependency:";

	private static readonly IntPtr selAddDependency_Handle = Selector.GetHandle("addDependency:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCancel = "cancel";

	private static readonly IntPtr selCancelHandle = Selector.GetHandle("cancel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCompletionBlock = "completionBlock";

	private static readonly IntPtr selCompletionBlockHandle = Selector.GetHandle("completionBlock");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDependencies = "dependencies";

	private static readonly IntPtr selDependenciesHandle = Selector.GetHandle("dependencies");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAsynchronous = "isAsynchronous";

	private static readonly IntPtr selIsAsynchronousHandle = Selector.GetHandle("isAsynchronous");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsCancelled = "isCancelled";

	private static readonly IntPtr selIsCancelledHandle = Selector.GetHandle("isCancelled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsConcurrent = "isConcurrent";

	private static readonly IntPtr selIsConcurrentHandle = Selector.GetHandle("isConcurrent");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsExecuting = "isExecuting";

	private static readonly IntPtr selIsExecutingHandle = Selector.GetHandle("isExecuting");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsFinished = "isFinished";

	private static readonly IntPtr selIsFinishedHandle = Selector.GetHandle("isFinished");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsReady = "isReady";

	private static readonly IntPtr selIsReadyHandle = Selector.GetHandle("isReady");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMain = "main";

	private static readonly IntPtr selMainHandle = Selector.GetHandle("main");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selName = "name";

	private static readonly IntPtr selNameHandle = Selector.GetHandle("name");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selQualityOfService = "qualityOfService";

	private static readonly IntPtr selQualityOfServiceHandle = Selector.GetHandle("qualityOfService");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selQueuePriority = "queuePriority";

	private static readonly IntPtr selQueuePriorityHandle = Selector.GetHandle("queuePriority");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveDependency_ = "removeDependency:";

	private static readonly IntPtr selRemoveDependency_Handle = Selector.GetHandle("removeDependency:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCompletionBlock_ = "setCompletionBlock:";

	private static readonly IntPtr selSetCompletionBlock_Handle = Selector.GetHandle("setCompletionBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetName_ = "setName:";

	private static readonly IntPtr selSetName_Handle = Selector.GetHandle("setName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetQualityOfService_ = "setQualityOfService:";

	private static readonly IntPtr selSetQualityOfService_Handle = Selector.GetHandle("setQualityOfService:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetQueuePriority_ = "setQueuePriority:";

	private static readonly IntPtr selSetQueuePriority_Handle = Selector.GetHandle("setQueuePriority:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetThreadPriority_ = "setThreadPriority:";

	private static readonly IntPtr selSetThreadPriority_Handle = Selector.GetHandle("setThreadPriority:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStart = "start";

	private static readonly IntPtr selStartHandle = Selector.GetHandle("start");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selThreadPriority = "threadPriority";

	private static readonly IntPtr selThreadPriorityHandle = Selector.GetHandle("threadPriority");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWaitUntilFinished = "waitUntilFinished";

	private static readonly IntPtr selWaitUntilFinishedHandle = Selector.GetHandle("waitUntilFinished");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSOperation");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	public virtual bool Asynchronous
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Export("isAsynchronous")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsAsynchronousHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAsynchronousHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual Action? CompletionBlock
	{
		[Export("completionBlock", ArgumentSemantic.Copy)]
		[return: DelegateProxy(typeof(Trampolines.SDAction))]
		get
		{
			IntPtr block = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCompletionBlockHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selCompletionBlockHandle));
			return Trampolines.NIDAction.Create(block);
		}
		[Export("setCompletionBlock:", ArgumentSemantic.Copy)]
		[param: BlockProxy(typeof(Trampolines.NIDAction))]
		set
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			BlockLiteral* ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDAction.Handler, value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetCompletionBlock_Handle, (IntPtr)ptr);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetCompletionBlock_Handle, (IntPtr)ptr);
			}
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSOperation[] Dependencies
	{
		[Export("dependencies")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSOperation>(Messaging.IntPtr_objc_msgSend(base.Handle, selDependenciesHandle));
			}
			return NSArray.ArrayFromHandle<NSOperation>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDependenciesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsCancelled
	{
		[Export("isCancelled")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsCancelledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsCancelledHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsConcurrent
	{
		[Export("isConcurrent")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsConcurrentHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsConcurrentHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsExecuting
	{
		[Export("isExecuting")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsExecutingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsExecutingHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsFinished
	{
		[Export("isFinished")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsFinishedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsFinishedHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsReady
	{
		[Export("isReady")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsReadyHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsReadyHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual string? Name
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("name")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNameHandle));
		}
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setName:")]
		set
		{
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
	public virtual NSOperationQueuePriority QueuePriority
	{
		[Export("queuePriority")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (NSOperationQueuePriority)Messaging.Int64_objc_msgSend(base.Handle, selQueuePriorityHandle);
			}
			return (NSOperationQueuePriority)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selQueuePriorityHandle);
		}
		[Export("setQueuePriority:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetQueuePriority_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetQueuePriority_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.iOS, 8, 0, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.WatchOS, 2, 0, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.TvOS, 9, 0, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, null)]
	public virtual double ThreadPriority
	{
		[Deprecated(PlatformName.iOS, 8, 0, PlatformArchitecture.None, null)]
		[Deprecated(PlatformName.WatchOS, 2, 0, PlatformArchitecture.None, null)]
		[Deprecated(PlatformName.TvOS, 9, 0, PlatformArchitecture.None, null)]
		[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, null)]
		[Export("threadPriority")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selThreadPriorityHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selThreadPriorityHandle);
		}
		[Deprecated(PlatformName.iOS, 8, 0, PlatformArchitecture.None, null)]
		[Deprecated(PlatformName.WatchOS, 2, 0, PlatformArchitecture.None, null)]
		[Deprecated(PlatformName.TvOS, 9, 0, PlatformArchitecture.None, null)]
		[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, null)]
		[Export("setThreadPriority:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetThreadPriority_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetThreadPriority_Handle, value);
			}
		}
	}

	[Obsolete("Use 'WaitUntilFinished' method.")]
	public virtual void WaitUntilFinishedNS()
	{
		WaitUntilFinished();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSOperation()
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
	protected NSOperation(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSOperation(IntPtr handle)
		: base(handle)
	{
	}

	[Export("addDependency:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddDependency(NSOperation op)
	{
		if (op == null)
		{
			throw new ArgumentNullException("op");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddDependency_Handle, op.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddDependency_Handle, op.Handle);
		}
	}

	[Export("cancel")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Cancel()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selCancelHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selCancelHandle);
		}
	}

	[Export("main")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Main()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selMainHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selMainHandle);
		}
	}

	[Export("removeDependency:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveDependency(NSOperation op)
	{
		if (op == null)
		{
			throw new ArgumentNullException("op");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveDependency_Handle, op.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveDependency_Handle, op.Handle);
		}
	}

	[Export("start")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Start()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selStartHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selStartHandle);
		}
	}

	[Export("waitUntilFinished")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WaitUntilFinished()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selWaitUntilFinishedHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selWaitUntilFinishedHandle);
		}
	}
}
