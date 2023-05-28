using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSDistributedNotificationCenter", true)]
public class NSDistributedNotificationCenter : NSNotificationCenter
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddObserver_Selector_Name_Object_ = "addObserver:selector:name:object:";

	private static readonly IntPtr selAddObserver_Selector_Name_Object_Handle = Selector.GetHandle("addObserver:selector:name:object:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddObserver_Selector_Name_Object_SuspensionBehavior_ = "addObserver:selector:name:object:suspensionBehavior:";

	private static readonly IntPtr selAddObserver_Selector_Name_Object_SuspensionBehavior_Handle = Selector.GetHandle("addObserver:selector:name:object:suspensionBehavior:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDefaultCenter = "defaultCenter";

	private static readonly IntPtr selDefaultCenterHandle = Selector.GetHandle("defaultCenter");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPostNotificationName_Object_ = "postNotificationName:object:";

	private static readonly IntPtr selPostNotificationName_Object_Handle = Selector.GetHandle("postNotificationName:object:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPostNotificationName_Object_UserInfo_ = "postNotificationName:object:userInfo:";

	private static readonly IntPtr selPostNotificationName_Object_UserInfo_Handle = Selector.GetHandle("postNotificationName:object:userInfo:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPostNotificationName_Object_UserInfo_DeliverImmediately_ = "postNotificationName:object:userInfo:deliverImmediately:";

	private static readonly IntPtr selPostNotificationName_Object_UserInfo_DeliverImmediately_Handle = Selector.GetHandle("postNotificationName:object:userInfo:deliverImmediately:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPostNotificationName_Object_UserInfo_Options_ = "postNotificationName:object:userInfo:options:";

	private static readonly IntPtr selPostNotificationName_Object_UserInfo_Options_Handle = Selector.GetHandle("postNotificationName:object:userInfo:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveObserver_Name_Object_ = "removeObserver:name:object:";

	private static readonly IntPtr selRemoveObserver_Name_Object_Handle = Selector.GetHandle("removeObserver:name:object:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSuspended_ = "setSuspended:";

	private static readonly IntPtr selSetSuspended_Handle = Selector.GetHandle("setSuspended:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSuspended = "suspended";

	private static readonly IntPtr selSuspendedHandle = Selector.GetHandle("suspended");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSDistributedNotificationCenter");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NSLocalNotificationCenterType;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Advice("Use 'GetDefaultCenter ()' for a strongly typed version.")]
	public new static NSObject DefaultCenter => GetDefaultCenter();

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Suspended
	{
		[Export("suspended")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selSuspendedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selSuspendedHandle);
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSDistributedNotificationCenter()
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
	protected NSDistributedNotificationCenter(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSDistributedNotificationCenter(IntPtr handle)
		: base(handle)
	{
	}

	[Export("addObserver:selector:name:object:suspensionBehavior:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddObserver(NSObject observer, Selector selector, string? notificationName, string? notificationSenderc, NSNotificationSuspensionBehavior suspensionBehavior)
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
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_UInt64(base.Handle, selAddObserver_Selector_Name_Object_SuspensionBehavior_Handle, observer.Handle, selector.Handle, arg, arg2, (ulong)suspensionBehavior);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_UInt64(base.SuperHandle, selAddObserver_Selector_Name_Object_SuspensionBehavior_Handle, observer.Handle, selector.Handle, arg, arg2, (ulong)suspensionBehavior);
		}
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
	}

	[Export("addObserver:selector:name:object:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddObserver(NSObject observer, Selector aSelector, string? aName, NSObject? anObject)
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
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selAddObserver_Selector_Name_Object_Handle, observer.Handle, aSelector.Handle, arg, anObject?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selAddObserver_Selector_Name_Object_Handle, observer.Handle, aSelector.Handle, arg, anObject?.Handle ?? IntPtr.Zero);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("defaultCenter")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSDistributedNotificationCenter GetDefaultCenter()
	{
		return Runtime.GetNSObject<NSDistributedNotificationCenter>(Messaging.IntPtr_objc_msgSend(class_ptr, selDefaultCenterHandle));
	}

	[Export("postNotificationName:object:userInfo:deliverImmediately:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PostNotificationName(string name, string? anObject, NSDictionary? userInfo, bool deliverImmediately)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		IntPtr arg2 = NSString.CreateNative(anObject);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_bool(base.Handle, selPostNotificationName_Object_UserInfo_DeliverImmediately_Handle, arg, arg2, userInfo?.Handle ?? IntPtr.Zero, deliverImmediately);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_bool(base.SuperHandle, selPostNotificationName_Object_UserInfo_DeliverImmediately_Handle, arg, arg2, userInfo?.Handle ?? IntPtr.Zero, deliverImmediately);
		}
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
	}

	[Export("postNotificationName:object:userInfo:options:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PostNotificationName(string name, string? anObjecb, NSDictionary? userInfo, NSNotificationFlags options)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		IntPtr arg2 = NSString.CreateNative(anObjecb);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_UInt64(base.Handle, selPostNotificationName_Object_UserInfo_Options_Handle, arg, arg2, userInfo?.Handle ?? IntPtr.Zero, (ulong)options);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_UInt64(base.SuperHandle, selPostNotificationName_Object_UserInfo_Options_Handle, arg, arg2, userInfo?.Handle ?? IntPtr.Zero, (ulong)options);
		}
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
	}

	[Export("postNotificationName:object:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PostNotificationName(string aName, string? anObject)
	{
		if (aName == null)
		{
			throw new ArgumentNullException("aName");
		}
		IntPtr arg = NSString.CreateNative(aName);
		IntPtr arg2 = NSString.CreateNative(anObject);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selPostNotificationName_Object_Handle, arg, arg2);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selPostNotificationName_Object_Handle, arg, arg2);
		}
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
	}

	[Export("postNotificationName:object:userInfo:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PostNotificationName(string aName, string? anObject, NSDictionary? aUserInfo)
	{
		if (aName == null)
		{
			throw new ArgumentNullException("aName");
		}
		IntPtr arg = NSString.CreateNative(aName);
		IntPtr arg2 = NSString.CreateNative(anObject);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selPostNotificationName_Object_UserInfo_Handle, arg, arg2, aUserInfo?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selPostNotificationName_Object_UserInfo_Handle, arg, arg2, aUserInfo?.Handle ?? IntPtr.Zero);
		}
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
	}

	[Export("removeObserver:name:object:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual void RemoveObserver(NSObject observer, string? aName, NSObject? anObject)
	{
		if (observer == null)
		{
			throw new ArgumentNullException("observer");
		}
		IntPtr arg = NSString.CreateNative(aName);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selRemoveObserver_Name_Object_Handle, observer.Handle, arg, anObject?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selRemoveObserver_Name_Object_Handle, observer.Handle, arg, anObject?.Handle ?? IntPtr.Zero);
		}
		NSString.ReleaseNative(arg);
	}
}
