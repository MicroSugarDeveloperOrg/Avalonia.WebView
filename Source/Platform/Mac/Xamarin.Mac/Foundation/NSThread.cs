using System.ComponentModel;
using System.Runtime.InteropServices;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace Foundation;

[Register("NSThread", true)]
public class NSThread : NSObject
{
	private class ActionThread : NSThread
	{
		private Action action;

		public ActionThread(Action action)
		{
			this.action = action;
		}

		public override void Main()
		{
			action();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCallStackSymbols = "callStackSymbols";

	private static readonly IntPtr selCallStackSymbolsHandle = Selector.GetHandle("callStackSymbols");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCancel = "cancel";

	private static readonly IntPtr selCancelHandle = Selector.GetHandle("cancel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentThread = "currentThread";

	private static readonly IntPtr selCurrentThreadHandle = Selector.GetHandle("currentThread");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExit = "exit";

	private static readonly IntPtr selExitHandle = Selector.GetHandle("exit");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsCancelled = "isCancelled";

	private static readonly IntPtr selIsCancelledHandle = Selector.GetHandle("isCancelled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsExecuting = "isExecuting";

	private static readonly IntPtr selIsExecutingHandle = Selector.GetHandle("isExecuting");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsFinished = "isFinished";

	private static readonly IntPtr selIsFinishedHandle = Selector.GetHandle("isFinished");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsMainThread = "isMainThread";

	private static readonly IntPtr selIsMainThreadHandle = Selector.GetHandle("isMainThread");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsMultiThreaded = "isMultiThreaded";

	private static readonly IntPtr selIsMultiThreadedHandle = Selector.GetHandle("isMultiThreaded");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMain = "main";

	private static readonly IntPtr selMainHandle = Selector.GetHandle("main");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMainThread = "mainThread";

	private static readonly IntPtr selMainThreadHandle = Selector.GetHandle("mainThread");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selName = "name";

	private static readonly IntPtr selNameHandle = Selector.GetHandle("name");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selQualityOfService = "qualityOfService";

	private static readonly IntPtr selQualityOfServiceHandle = Selector.GetHandle("qualityOfService");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetName_ = "setName:";

	private static readonly IntPtr selSetName_Handle = Selector.GetHandle("setName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetQualityOfService_ = "setQualityOfService:";

	private static readonly IntPtr selSetQualityOfService_Handle = Selector.GetHandle("setQualityOfService:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetStackSize_ = "setStackSize:";

	private static readonly IntPtr selSetStackSize_Handle = Selector.GetHandle("setStackSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetThreadPriority_ = "setThreadPriority:";

	private static readonly IntPtr selSetThreadPriority_Handle = Selector.GetHandle("setThreadPriority:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSleepForTimeInterval_ = "sleepForTimeInterval:";

	private static readonly IntPtr selSleepForTimeInterval_Handle = Selector.GetHandle("sleepForTimeInterval:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSleepUntilDate_ = "sleepUntilDate:";

	private static readonly IntPtr selSleepUntilDate_Handle = Selector.GetHandle("sleepUntilDate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStackSize = "stackSize";

	private static readonly IntPtr selStackSizeHandle = Selector.GetHandle("stackSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStart = "start";

	private static readonly IntPtr selStartHandle = Selector.GetHandle("start");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selThreadPriority = "threadPriority";

	private static readonly IntPtr selThreadPriorityHandle = Selector.GetHandle("threadPriority");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSThread");

	public static double Priority
	{
		get
		{
			return _GetPriority();
		}
		set
		{
			_SetPriority(value);
		}
	}

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSThread Current
	{
		[Export("currentThread", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<NSThread>(Messaging.IntPtr_objc_msgSend(class_ptr, selCurrentThreadHandle));
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
	public static bool IsMain
	{
		[Export("isMainThread")]
		get
		{
			return Messaging.bool_objc_msgSend(class_ptr, selIsMainThreadHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsMainThread
	{
		[Export("isMainThread")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsMainThreadHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsMainThreadHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool IsMultiThreaded
	{
		[Export("isMultiThreaded")]
		get
		{
			return Messaging.bool_objc_msgSend(class_ptr, selIsMultiThreadedHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSThread MainThread
	{
		[Export("mainThread", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<NSThread>(Messaging.IntPtr_objc_msgSend(class_ptr, selMainThreadHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? Name
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
	public static string[] NativeCallStack
	{
		[Export("callStackSymbols", ArgumentSemantic.Copy)]
		get
		{
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(class_ptr, selCallStackSymbolsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public virtual NSQualityOfService QualityOfService
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Export("qualityOfService")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (NSQualityOfService)Messaging.Int64_objc_msgSend(base.Handle, selQualityOfServiceHandle);
			}
			return (NSQualityOfService)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selQualityOfServiceHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
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
	public virtual nuint StackSize
	{
		[Export("stackSize")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selStackSizeHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selStackSizeHandle);
		}
		[Export("setStackSize:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetStackSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetStackSize_Handle, value);
			}
		}
	}

	[DllImport("__Internal")]
	private static extern IntPtr xamarin_init_nsthread(IntPtr handle, bool is_direct_binding, IntPtr target, IntPtr selector, IntPtr argument);

	private IntPtr InitNSThread(NSObject target, Selector selector, NSObject argument)
	{
		if (target == null)
		{
			throw new ArgumentNullException("target");
		}
		if (selector == null)
		{
			throw new ArgumentNullException("selector");
		}
		return xamarin_init_nsthread(base.IsDirectBinding ? base.Handle : base.SuperHandle, base.IsDirectBinding, target.Handle, selector.Handle, argument?.Handle ?? IntPtr.Zero);
	}

	[Export("initWithTarget:selector:object:")]
	public NSThread(NSObject target, Selector selector, NSObject argument)
	{
		base.Handle = InitNSThread(target, selector, argument);
	}

	public static NSThread Start(Action action)
	{
		if (action == null)
		{
			throw new ArgumentNullException("action");
		}
		ActionThread actionThread = new ActionThread(action);
		actionThread.Start();
		return actionThread;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSThread()
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
	protected NSThread(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSThread(IntPtr handle)
		: base(handle)
	{
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

	[Export("exit")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void Exit()
	{
		Messaging.void_objc_msgSend(class_ptr, selExitHandle);
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

	[Export("sleepForTimeInterval:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SleepFor(double timeInterval)
	{
		Messaging.void_objc_msgSend_Double(class_ptr, selSleepForTimeInterval_Handle, timeInterval);
	}

	[Export("sleepUntilDate:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SleepUntil(NSDate date)
	{
		if (date == null)
		{
			throw new ArgumentNullException("date");
		}
		Messaging.void_objc_msgSend_IntPtr(class_ptr, selSleepUntilDate_Handle, date.Handle);
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

	[Export("threadPriority")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static double _GetPriority()
	{
		return Messaging.Double_objc_msgSend(class_ptr, selThreadPriorityHandle);
	}

	[Export("setThreadPriority:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static bool _SetPriority(double priority)
	{
		return Messaging.bool_objc_msgSend_Double(class_ptr, selSetThreadPriority_Handle, priority);
	}
}
