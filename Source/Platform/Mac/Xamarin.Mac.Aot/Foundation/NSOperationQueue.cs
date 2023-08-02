using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSOperationQueue", true)]
public class NSOperationQueue : NSObject
{
	private static readonly IntPtr selOperationsHandle = Selector.GetHandle("operations");

	private static readonly IntPtr selOperationCountHandle = Selector.GetHandle("operationCount");

	private static readonly IntPtr selNameHandle = Selector.GetHandle("name");

	private static readonly IntPtr selSetName_Handle = Selector.GetHandle("setName:");

	private static readonly IntPtr selCurrentQueueHandle = Selector.GetHandle("currentQueue");

	private static readonly IntPtr selMainQueueHandle = Selector.GetHandle("mainQueue");

	private static readonly IntPtr selMaxConcurrentOperationCountHandle = Selector.GetHandle("maxConcurrentOperationCount");

	private static readonly IntPtr selSetMaxConcurrentOperationCount_Handle = Selector.GetHandle("setMaxConcurrentOperationCount:");

	private static readonly IntPtr selIsSuspendedHandle = Selector.GetHandle("isSuspended");

	private static readonly IntPtr selSetSuspended_Handle = Selector.GetHandle("setSuspended:");

	private static readonly IntPtr selAddOperation_Handle = Selector.GetHandle("addOperation:");

	private static readonly IntPtr selAddOperationsWaitUntilFinished_Handle = Selector.GetHandle("addOperations:waitUntilFinished:");

	private static readonly IntPtr selAddOperationWithBlock_Handle = Selector.GetHandle("addOperationWithBlock:");

	private static readonly IntPtr selCancelAllOperationsHandle = Selector.GetHandle("cancelAllOperations");

	private static readonly IntPtr selWaitUntilAllOperationsAreFinishedHandle = Selector.GetHandle("waitUntilAllOperationsAreFinished");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSOperationQueue");

	private object __mt_Operations_var;

	private static object __mt_CurrentQueue_var_static;

	private static object __mt_MainQueue_var_static;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSOperation[] Operations
	{
		[Export("operations")]
		get
		{
			return (NSOperation[])(__mt_Operations_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSOperation>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOperationsHandle)) : NSArray.ArrayFromHandle<NSOperation>(Messaging.IntPtr_objc_msgSend(base.Handle, selOperationsHandle))));
		}
	}

	public virtual ulong OperationCount
	{
		[Export("operationCount")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.UInt64_objc_msgSend(base.Handle, selOperationCountHandle);
			}
			return Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selOperationCountHandle);
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

	public static NSOperationQueue CurrentQueue
	{
		[Export("currentQueue")]
		get
		{
			return (NSOperationQueue)(__mt_CurrentQueue_var_static = (NSOperationQueue)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selCurrentQueueHandle)));
		}
	}

	public static NSOperationQueue MainQueue
	{
		[Export("mainQueue")]
		get
		{
			return (NSOperationQueue)(__mt_MainQueue_var_static = (NSOperationQueue)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selMainQueueHandle)));
		}
	}

	public virtual long MaxConcurrentOperationCount
	{
		[Export("maxConcurrentOperationCount")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selMaxConcurrentOperationCountHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selMaxConcurrentOperationCountHandle);
		}
		[Export("setMaxConcurrentOperationCount:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetMaxConcurrentOperationCount_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetMaxConcurrentOperationCount_Handle, value);
			}
		}
	}

	public virtual bool Suspended
	{
		[Export("isSuspended")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsSuspendedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsSuspendedHandle);
		}
		[Export("setSuspended:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetSuspended_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetSuspended_Handle, value);
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSOperationQueue()
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
	public NSOperationQueue(NSCoder coder)
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
	public NSOperationQueue(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSOperationQueue(IntPtr handle)
		: base(handle)
	{
	}

	[Export("addOperation:")]
	public virtual void AddOperation(NSOperation op)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddOperation_Handle, op?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddOperation_Handle, op?.Handle ?? IntPtr.Zero);
		}
		_ = Operations;
	}

	[Export("addOperations:waitUntilFinished:")]
	public virtual void AddOperations(NSOperation[] operations, bool waitUntilFinished)
	{
		NSArray nSArray = ((operations == null) ? null : NSArray.FromNSObjects(operations));
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_bool(base.Handle, selAddOperationsWaitUntilFinished_Handle, nSArray?.Handle ?? IntPtr.Zero, waitUntilFinished);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_bool(base.SuperHandle, selAddOperationsWaitUntilFinished_Handle, nSArray?.Handle ?? IntPtr.Zero, waitUntilFinished);
		}
		nSArray?.Dispose();
		_ = Operations;
	}

	[Export("addOperationWithBlock:")]
	public unsafe virtual void AddOperation(NSAction operation)
	{
		if (operation == null)
		{
			throw new ArgumentNullException("operation");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlock(Trampolines.SDNSAction.Handler, operation);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddOperationWithBlock_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddOperationWithBlock_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
		_ = Operations;
	}

	[Export("cancelAllOperations")]
	public virtual void CancelAllOperations()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selCancelAllOperationsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selCancelAllOperationsHandle);
		}
		_ = Operations;
	}

	[Export("waitUntilAllOperationsAreFinished")]
	public virtual void WaitUntilAllOperationsAreFinished()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selWaitUntilAllOperationsAreFinishedHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selWaitUntilAllOperationsAreFinishedHandle);
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Operations_var = null;
		}
	}
}
