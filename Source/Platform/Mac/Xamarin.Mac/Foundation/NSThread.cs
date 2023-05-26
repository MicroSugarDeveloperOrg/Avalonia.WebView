using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSThread", true)]
public class NSThread : NSObject
{
	private static readonly IntPtr selCurrentThreadHandle = Selector.GetHandle("currentThread");

	private static readonly IntPtr selIsMultiThreadedHandle = Selector.GetHandle("isMultiThreaded");

	private static readonly IntPtr selNameHandle = Selector.GetHandle("name");

	private static readonly IntPtr selSetName_Handle = Selector.GetHandle("setName:");

	private static readonly IntPtr selStackSizeHandle = Selector.GetHandle("stackSize");

	private static readonly IntPtr selSetStackSize_Handle = Selector.GetHandle("setStackSize:");

	private static readonly IntPtr selIsMainThreadHandle = Selector.GetHandle("isMainThread");

	private static readonly IntPtr selMainThreadHandle = Selector.GetHandle("mainThread");

	private static readonly IntPtr selIsExecutingHandle = Selector.GetHandle("isExecuting");

	private static readonly IntPtr selIsFinishedHandle = Selector.GetHandle("isFinished");

	private static readonly IntPtr selIsCancelledHandle = Selector.GetHandle("isCancelled");

	private static readonly IntPtr selSleepUntilDate_Handle = Selector.GetHandle("sleepUntilDate:");

	private static readonly IntPtr selSleepForTimeInterval_Handle = Selector.GetHandle("sleepForTimeInterval:");

	private static readonly IntPtr selExitHandle = Selector.GetHandle("exit");

	private static readonly IntPtr selThreadPriorityHandle = Selector.GetHandle("threadPriority");

	private static readonly IntPtr selSetThreadPriority_Handle = Selector.GetHandle("setThreadPriority:");

	private static readonly IntPtr selInitWithTargetSelectorObject_Handle = Selector.GetHandle("initWithTarget:selector:object:");

	private static readonly IntPtr selCancelHandle = Selector.GetHandle("cancel");

	private static readonly IntPtr selStartHandle = Selector.GetHandle("start");

	private static readonly IntPtr selMainHandle = Selector.GetHandle("main");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSThread");

	private static object __mt_Current_var_static;

	private static object __mt_MainThread_var_static;

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

	public static NSThread Current
	{
		[Export("currentThread")]
		get
		{
			return (NSThread)(__mt_Current_var_static = (NSThread)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selCurrentThreadHandle)));
		}
	}

	public static bool IsMultiThreaded
	{
		[Export("isMultiThreaded")]
		get
		{
			return Messaging.bool_objc_msgSend(class_ptr, selIsMultiThreadedHandle);
		}
	}

	public virtual string Name
	{
		[Export("name")]
		get
		{
			if (IsDirectBinding)
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
			if (IsDirectBinding)
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

	public virtual ulong StackSize
	{
		[Export("stackSize")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.UInt64_objc_msgSend(base.Handle, selStackSizeHandle);
			}
			return Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selStackSizeHandle);
		}
		[Export("setStackSize:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetStackSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetStackSize_Handle, value);
			}
		}
	}

	public virtual bool IsMainThread
	{
		[Export("isMainThread")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsMainThreadHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsMainThreadHandle);
		}
	}

	public static bool IsMain
	{
		[Export("isMainThread")]
		get
		{
			return Messaging.bool_objc_msgSend(class_ptr, selIsMainThreadHandle);
		}
	}

	public static NSThread MainThread
	{
		[Export("mainThread")]
		get
		{
			return (NSThread)(__mt_MainThread_var_static = (NSThread)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selMainThreadHandle)));
		}
	}

	public virtual bool IsExecuting
	{
		[Export("isExecuting")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsExecutingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsExecutingHandle);
		}
	}

	public virtual bool IsFinished
	{
		[Export("isFinished")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsFinishedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsFinishedHandle);
		}
	}

	public virtual bool IsCancelled
	{
		[Export("isCancelled")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsCancelledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsCancelledHandle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSThread()
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
	public NSThread(NSCoder coder)
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
	public NSThread(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSThread(IntPtr handle)
		: base(handle)
	{
	}

	[Export("sleepUntilDate:")]
	public static void SleepUntil(NSDate date)
	{
		if (date == null)
		{
			throw new ArgumentNullException("date");
		}
		Messaging.void_objc_msgSend_IntPtr(class_ptr, selSleepUntilDate_Handle, date.Handle);
	}

	[Export("sleepForTimeInterval:")]
	public static void SleepFor(double timeInterval)
	{
		Messaging.void_objc_msgSend_Double(class_ptr, selSleepForTimeInterval_Handle, timeInterval);
	}

	[Export("exit")]
	public static void Exit()
	{
		Messaging.void_objc_msgSend(class_ptr, selExitHandle);
	}

	[Export("threadPriority")]
	internal static double _GetPriority()
	{
		return Messaging.Double_objc_msgSend(class_ptr, selThreadPriorityHandle);
	}

	[Export("setThreadPriority:")]
	internal static bool _SetPriority(double priority)
	{
		return Messaging.bool_objc_msgSend_Double(class_ptr, selSetThreadPriority_Handle, priority);
	}

	[Export("initWithTarget:selector:object:")]
	public NSThread(NSObject target, Selector selector, NSObject argument)
		: base(NSObjectFlag.Empty)
	{
		if (target == null)
		{
			throw new ArgumentNullException("target");
		}
		if (selector == null)
		{
			throw new ArgumentNullException("selector");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selInitWithTargetSelectorObject_Handle, target.Handle, selector.Handle, argument?.Handle ?? IntPtr.Zero);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selInitWithTargetSelectorObject_Handle, target.Handle, selector.Handle, argument?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("cancel")]
	public virtual void Cancel()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selCancelHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selCancelHandle);
		}
	}

	[Export("start")]
	public virtual void Start()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selStartHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selStartHandle);
		}
	}

	[Export("main")]
	public virtual void Main()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selMainHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selMainHandle);
		}
	}
}
