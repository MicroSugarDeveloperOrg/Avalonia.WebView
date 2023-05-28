using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreData;

[Register("NSAtomicStoreCacheNode", true)]
public class NSAtomicStoreCacheNode : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithObjectID_ = "initWithObjectID:";

	private static readonly IntPtr selInitWithObjectID_Handle = Selector.GetHandle("initWithObjectID:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selObjectID = "objectID";

	private static readonly IntPtr selObjectIDHandle = Selector.GetHandle("objectID");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPropertyCache = "propertyCache";

	private static readonly IntPtr selPropertyCacheHandle = Selector.GetHandle("propertyCache");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPropertyCache_ = "setPropertyCache:";

	private static readonly IntPtr selSetPropertyCache_Handle = Selector.GetHandle("setPropertyCache:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetValue_ForKey_ = "setValue:forKey:";

	private static readonly IntPtr selSetValue_ForKey_Handle = Selector.GetHandle("setValue:forKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValueForKey_ = "valueForKey:";

	private static readonly IntPtr selValueForKey_Handle = Selector.GetHandle("valueForKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSAtomicStoreCacheNode");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSManagedObjectID ObjectID
	{
		[Export("objectID", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSManagedObjectID>(Messaging.IntPtr_objc_msgSend(base.Handle, selObjectIDHandle));
			}
			return Runtime.GetNSObject<NSManagedObjectID>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selObjectIDHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary? PropertyCache
	{
		[Export("propertyCache", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selPropertyCacheHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPropertyCacheHandle));
		}
		[Export("setPropertyCache:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPropertyCache_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPropertyCache_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSAtomicStoreCacheNode(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSAtomicStoreCacheNode(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithObjectID:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSAtomicStoreCacheNode(NSManagedObjectID moid)
		: base(NSObjectFlag.Empty)
	{
		if (moid == null)
		{
			throw new ArgumentNullException("moid");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithObjectID_Handle, moid.Handle), "initWithObjectID:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithObjectID_Handle, moid.Handle), "initWithObjectID:");
		}
	}

	[Export("setValue:forKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetValue(NSObject? value, string key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetValue_ForKey_Handle, value?.Handle ?? IntPtr.Zero, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetValue_ForKey_Handle, value?.Handle ?? IntPtr.Zero, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("valueForKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSAtomicStoreCacheNode? ValueForKey(string key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		NSAtomicStoreCacheNode result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSAtomicStoreCacheNode>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selValueForKey_Handle, arg)) : Runtime.GetNSObject<NSAtomicStoreCacheNode>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selValueForKey_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}
}
