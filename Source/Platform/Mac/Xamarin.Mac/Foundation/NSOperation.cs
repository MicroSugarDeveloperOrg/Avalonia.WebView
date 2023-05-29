using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSOperation", true)]
public class NSOperation : NSObject
{
	private static readonly IntPtr selIsCancelledHandle = Selector.GetHandle("isCancelled");

	private static readonly IntPtr selIsExecutingHandle = Selector.GetHandle("isExecuting");

	private static readonly IntPtr selIsFinishedHandle = Selector.GetHandle("isFinished");

	private static readonly IntPtr selIsConcurrentHandle = Selector.GetHandle("isConcurrent");

	private static readonly IntPtr selIsReadyHandle = Selector.GetHandle("isReady");

	private static readonly IntPtr selDependenciesHandle = Selector.GetHandle("dependencies");

	private static readonly IntPtr selThreadPriorityHandle = Selector.GetHandle("threadPriority");

	private static readonly IntPtr selSetThreadPriority_Handle = Selector.GetHandle("setThreadPriority:");

	private static readonly IntPtr selQueuePriorityHandle = Selector.GetHandle("queuePriority");

	private static readonly IntPtr selSetQueuePriority_Handle = Selector.GetHandle("setQueuePriority:");

	private static readonly IntPtr selStartHandle = Selector.GetHandle("start");

	private static readonly IntPtr selMainHandle = Selector.GetHandle("main");

	private static readonly IntPtr selCancelHandle = Selector.GetHandle("cancel");

	private static readonly IntPtr selAddDependency_Handle = Selector.GetHandle("addDependency:");

	private static readonly IntPtr selRemoveDependency_Handle = Selector.GetHandle("removeDependency:");

	private static readonly IntPtr selWaitUntilFinishedHandle = Selector.GetHandle("waitUntilFinished");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSOperation");

	private object __mt_Dependencies_var;

	public override IntPtr ClassHandle => class_ptr;

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

	public virtual bool IsConcurrent
	{
		[Export("isConcurrent")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsConcurrentHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsConcurrentHandle);
		}
	}

	public virtual bool IsReady
	{
		[Export("isReady")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsReadyHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsReadyHandle);
		}
	}

	public virtual NSOperation[] Dependencies
	{
		[Export("dependencies")]
		get
		{
			return (NSOperation[])(__mt_Dependencies_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSOperation>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDependenciesHandle)) : NSArray.ArrayFromHandle<NSOperation>(Messaging.IntPtr_objc_msgSend(base.Handle, selDependenciesHandle))));
		}
	}

	public virtual double ThreadPriority
	{
		[Export("threadPriority")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selThreadPriorityHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selThreadPriorityHandle);
		}
		[Export("setThreadPriority:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetThreadPriority_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetThreadPriority_Handle, value);
			}
		}
	}

	public virtual NSOperationQueuePriority QueuePriority
	{
		[Export("queuePriority")]
		get
		{
			if (IsDirectBinding)
			{
				return (NSOperationQueuePriority)Messaging.Int64_objc_msgSend(base.Handle, selQueuePriorityHandle);
			}
			return (NSOperationQueuePriority)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selQueuePriorityHandle);
		}
		[Export("setQueuePriority:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetQueuePriority_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetQueuePriority_Handle, (long)value);
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSOperation()
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
	public NSOperation(NSCoder coder)
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
	public NSOperation(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSOperation(IntPtr handle)
		: base(handle)
	{
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

	[Export("addDependency:")]
	public virtual void AddDependency(NSOperation op)
	{
		if (op == null)
		{
			throw new ArgumentNullException("op");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddDependency_Handle, op.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddDependency_Handle, op.Handle);
		}
		_ = Dependencies;
	}

	[Export("removeDependency:")]
	public virtual void RemoveDependency(NSOperation op)
	{
		if (op == null)
		{
			throw new ArgumentNullException("op");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveDependency_Handle, op.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveDependency_Handle, op.Handle);
		}
		_ = Dependencies;
	}

	[Export("waitUntilFinished")]
	public virtual void WaitUntilFinishedNS()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selWaitUntilFinishedHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selWaitUntilFinishedHandle);
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Dependencies_var = null;
		}
	}
}
