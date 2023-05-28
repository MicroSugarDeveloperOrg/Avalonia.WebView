using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSDistributedLock", true)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
public class NSDistributedLock : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBreakLock = "breakLock";

	private static readonly IntPtr selBreakLockHandle = Selector.GetHandle("breakLock");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithPath_ = "initWithPath:";

	private static readonly IntPtr selInitWithPath_Handle = Selector.GetHandle("initWithPath:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLockDate = "lockDate";

	private static readonly IntPtr selLockDateHandle = Selector.GetHandle("lockDate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLockWithPath_ = "lockWithPath:";

	private static readonly IntPtr selLockWithPath_Handle = Selector.GetHandle("lockWithPath:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTryLock = "tryLock";

	private static readonly IntPtr selTryLockHandle = Selector.GetHandle("tryLock");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnlock = "unlock";

	private static readonly IntPtr selUnlockHandle = Selector.GetHandle("unlock");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSDistributedLock");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDate LockDate
	{
		[Export("lockDate", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSend(base.Handle, selLockDateHandle));
			}
			return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLockDateHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSDistributedLock(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSDistributedLock(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithPath:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSDistributedLock(string path)
		: base(NSObjectFlag.Empty)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = NSString.CreateNative(path);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithPath_Handle, arg), "initWithPath:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithPath_Handle, arg), "initWithPath:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("breakLock")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void BreakLock()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selBreakLockHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selBreakLockHandle);
		}
	}

	[Export("lockWithPath:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSDistributedLock? FromPath(string path)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = NSString.CreateNative(path);
		NSDistributedLock nSObject = Runtime.GetNSObject<NSDistributedLock>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selLockWithPath_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
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
}
