using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSConditionLock", true)]
public class NSConditionLock : NSObject, INSLocking, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCondition = "condition";

	private static readonly IntPtr selConditionHandle = Selector.GetHandle("condition");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCondition_ = "initWithCondition:";

	private static readonly IntPtr selInitWithCondition_Handle = Selector.GetHandle("initWithCondition:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLock = "lock";

	private static readonly IntPtr selLockHandle = Selector.GetHandle("lock");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLockBeforeDate_ = "lockBeforeDate:";

	private static readonly IntPtr selLockBeforeDate_Handle = Selector.GetHandle("lockBeforeDate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLockWhenCondition_ = "lockWhenCondition:";

	private static readonly IntPtr selLockWhenCondition_Handle = Selector.GetHandle("lockWhenCondition:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLockWhenCondition_BeforeDate_ = "lockWhenCondition:beforeDate:";

	private static readonly IntPtr selLockWhenCondition_BeforeDate_Handle = Selector.GetHandle("lockWhenCondition:beforeDate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selName = "name";

	private static readonly IntPtr selNameHandle = Selector.GetHandle("name");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetName_ = "setName:";

	private static readonly IntPtr selSetName_Handle = Selector.GetHandle("setName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTryLock = "tryLock";

	private static readonly IntPtr selTryLockHandle = Selector.GetHandle("tryLock");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTryLockWhenCondition_ = "tryLockWhenCondition:";

	private static readonly IntPtr selTryLockWhenCondition_Handle = Selector.GetHandle("tryLockWhenCondition:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnlock = "unlock";

	private static readonly IntPtr selUnlockHandle = Selector.GetHandle("unlock");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnlockWithCondition_ = "unlockWithCondition:";

	private static readonly IntPtr selUnlockWithCondition_Handle = Selector.GetHandle("unlockWithCondition:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSConditionLock");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint Condition
	{
		[Export("condition")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selConditionHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selConditionHandle);
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
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSConditionLock()
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
	protected NSConditionLock(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSConditionLock(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithCondition:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSConditionLock(nint condition)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_nint(base.Handle, selInitWithCondition_Handle, condition), "initWithCondition:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_nint(base.SuperHandle, selInitWithCondition_Handle, condition), "initWithCondition:");
		}
	}

	[Export("lock")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Lock()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selLockHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selLockHandle);
		}
	}

	[Export("lockBeforeDate:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool LockBeforeDate(NSDate limit)
	{
		if (limit == null)
		{
			throw new ArgumentNullException("limit");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selLockBeforeDate_Handle, limit.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selLockBeforeDate_Handle, limit.Handle);
	}

	[Export("lockWhenCondition:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void LockWhenCondition(nint condition)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nint(base.Handle, selLockWhenCondition_Handle, condition);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selLockWhenCondition_Handle, condition);
		}
	}

	[Export("lockWhenCondition:beforeDate:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool LockWhenCondition(nint condition, NSDate limit)
	{
		if (limit == null)
		{
			throw new ArgumentNullException("limit");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_nint_IntPtr(base.Handle, selLockWhenCondition_BeforeDate_Handle, condition, limit.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_nint_IntPtr(base.SuperHandle, selLockWhenCondition_BeforeDate_Handle, condition, limit.Handle);
	}

	[Export("tryLock")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool TryLock()
	{
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selTryLockHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selTryLockHandle);
	}

	[Export("tryLockWhenCondition:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool TryLockWhenCondition(nint condition)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_nint(base.Handle, selTryLockWhenCondition_Handle, condition);
		}
		return Messaging.bool_objc_msgSendSuper_nint(base.SuperHandle, selTryLockWhenCondition_Handle, condition);
	}

	[Export("unlock")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Unlock()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selUnlockHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selUnlockHandle);
		}
	}

	[Export("unlockWithCondition:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void UnlockWithCondition(nint condition)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nint(base.Handle, selUnlockWithCondition_Handle, condition);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selUnlockWithCondition_Handle, condition);
		}
	}
}
