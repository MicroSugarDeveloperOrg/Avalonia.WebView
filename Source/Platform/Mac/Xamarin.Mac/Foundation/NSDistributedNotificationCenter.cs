using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSDistributedNotificationCenter", true)]
public class NSDistributedNotificationCenter : NSNotificationCenter
{
	private static readonly IntPtr selDefaultCenterHandle = Selector.GetHandle("defaultCenter");

	private static readonly IntPtr selSuspendedHandle = Selector.GetHandle("suspended");

	private static readonly IntPtr selSetSuspended_Handle = Selector.GetHandle("setSuspended:");

	private static readonly IntPtr selAddObserverSelectorNameObjectSuspensionBehavior_Handle = Selector.GetHandle("addObserver:selector:name:object:suspensionBehavior:");

	private static readonly IntPtr selPostNotificationNameObjectUserInfoDeliverImmediately_Handle = Selector.GetHandle("postNotificationName:object:userInfo:deliverImmediately:");

	private static readonly IntPtr selPostNotificationNameObjectUserInfoOptions_Handle = Selector.GetHandle("postNotificationName:object:userInfo:options:");

	private static readonly IntPtr selAddObserverSelectorNameObject_Handle = Selector.GetHandle("addObserver:selector:name:object:");

	private static readonly IntPtr selPostNotificationNameObject_Handle = Selector.GetHandle("postNotificationName:object:");

	private static readonly IntPtr selPostNotificationNameObjectUserInfo_Handle = Selector.GetHandle("postNotificationName:object:userInfo:");

	private static readonly IntPtr selRemoveObserverNameObject_Handle = Selector.GetHandle("removeObserver:name:object:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSDistributedNotificationCenter");

	private static object __mt_DefaultCenter_var_static;

	private static NSString _NSLocalNotificationCenterType;

	public override IntPtr ClassHandle => class_ptr;

	public new static NSObject DefaultCenter
	{
		[Export("defaultCenter")]
		get
		{
			return (NSObject)(__mt_DefaultCenter_var_static = Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selDefaultCenterHandle)));
		}
	}

	public virtual bool Suspended
	{
		[Export("suspended")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selSuspendedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selSuspendedHandle);
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

	[Field("NSLocalNotificationCenterType", "Foundation")]
	public static NSString NSLocalNotificationCenterType
	{
		get
		{
			if (_NSLocalNotificationCenterType == null)
			{
				_NSLocalNotificationCenterType = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSLocalNotificationCenterType");
			}
			return _NSLocalNotificationCenterType;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSDistributedNotificationCenter()
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
	public NSDistributedNotificationCenter(NSCoder coder)
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
	public NSDistributedNotificationCenter(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSDistributedNotificationCenter(IntPtr handle)
		: base(handle)
	{
	}

	[Export("addObserver:selector:name:object:suspensionBehavior:")]
	public virtual void AddObserver(NSObject observer, Selector selector, string notificationName, string notificationSenderc, NSNotificationSuspensionBehavior suspensionBehavior)
	{
		if (observer == null)
		{
			throw new ArgumentNullException("observer");
		}
		if (selector == null)
		{
			throw new ArgumentNullException("selector");
		}
		IntPtr arg = NSString.CreateNative(notificationName);
		IntPtr arg2 = NSString.CreateNative(notificationSenderc);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_UInt64(base.Handle, selAddObserverSelectorNameObjectSuspensionBehavior_Handle, observer.Handle, selector.Handle, arg, arg2, (ulong)suspensionBehavior);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_UInt64(base.SuperHandle, selAddObserverSelectorNameObjectSuspensionBehavior_Handle, observer.Handle, selector.Handle, arg, arg2, (ulong)suspensionBehavior);
		}
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
	}

	[Export("postNotificationName:object:userInfo:deliverImmediately:")]
	public virtual void PostNotificationName(string name, string anObject, NSDictionary userInfo, bool deliverImmediately)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		IntPtr arg2 = NSString.CreateNative(anObject);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_bool(base.Handle, selPostNotificationNameObjectUserInfoDeliverImmediately_Handle, arg, arg2, userInfo?.Handle ?? IntPtr.Zero, deliverImmediately);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_bool(base.SuperHandle, selPostNotificationNameObjectUserInfoDeliverImmediately_Handle, arg, arg2, userInfo?.Handle ?? IntPtr.Zero, deliverImmediately);
		}
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
	}

	[Export("postNotificationName:object:userInfo:options:")]
	public virtual void PostNotificationName(string name, string anObjecb, NSDictionary userInfo, NSNotificationFlags options)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		IntPtr arg2 = NSString.CreateNative(anObjecb);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_UInt64(base.Handle, selPostNotificationNameObjectUserInfoOptions_Handle, arg, arg2, userInfo?.Handle ?? IntPtr.Zero, (ulong)options);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_UInt64(base.SuperHandle, selPostNotificationNameObjectUserInfoOptions_Handle, arg, arg2, userInfo?.Handle ?? IntPtr.Zero, (ulong)options);
		}
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
	}

	[Export("addObserver:selector:name:object:")]
	public new virtual void AddObserver(NSObject observer, Selector aSelector, string aName, NSObject anObject)
	{
		if (observer == null)
		{
			throw new ArgumentNullException("observer");
		}
		if (aSelector == null)
		{
			throw new ArgumentNullException("aSelector");
		}
		IntPtr arg = NSString.CreateNative(aName);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selAddObserverSelectorNameObject_Handle, observer.Handle, aSelector.Handle, arg, anObject?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selAddObserverSelectorNameObject_Handle, observer.Handle, aSelector.Handle, arg, anObject?.Handle ?? IntPtr.Zero);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("postNotificationName:object:")]
	public virtual void PostNotificationName(string aName, string anObject)
	{
		if (aName == null)
		{
			throw new ArgumentNullException("aName");
		}
		IntPtr arg = NSString.CreateNative(aName);
		IntPtr arg2 = NSString.CreateNative(anObject);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selPostNotificationNameObject_Handle, arg, arg2);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selPostNotificationNameObject_Handle, arg, arg2);
		}
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
	}

	[Export("postNotificationName:object:userInfo:")]
	public virtual void PostNotificationName(string aName, string anObject, NSDictionary aUserInfo)
	{
		if (aName == null)
		{
			throw new ArgumentNullException("aName");
		}
		IntPtr arg = NSString.CreateNative(aName);
		IntPtr arg2 = NSString.CreateNative(anObject);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selPostNotificationNameObjectUserInfo_Handle, arg, arg2, aUserInfo?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selPostNotificationNameObjectUserInfo_Handle, arg, arg2, aUserInfo?.Handle ?? IntPtr.Zero);
		}
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
	}

	[Export("removeObserver:name:object:")]
	public new virtual void RemoveObserver(NSObject observer, string aName, NSObject anObject)
	{
		if (observer == null)
		{
			throw new ArgumentNullException("observer");
		}
		IntPtr arg = NSString.CreateNative(aName);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selRemoveObserverNameObject_Handle, observer.Handle, arg, anObject?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selRemoveObserverNameObject_Handle, observer.Handle, arg, anObject?.Handle ?? IntPtr.Zero);
		}
		NSString.ReleaseNative(arg);
	}
}
