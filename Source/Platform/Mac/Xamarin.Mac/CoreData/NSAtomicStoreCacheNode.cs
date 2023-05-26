using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreData;

[Register("NSAtomicStoreCacheNode", true)]
public class NSAtomicStoreCacheNode : NSObject
{
	private static readonly IntPtr selObjectIDHandle = Selector.GetHandle("objectID");

	private static readonly IntPtr selPropertyCacheHandle = Selector.GetHandle("propertyCache");

	private static readonly IntPtr selSetPropertyCache_Handle = Selector.GetHandle("setPropertyCache:");

	private static readonly IntPtr selInitWithObjectID_Handle = Selector.GetHandle("initWithObjectID:");

	private static readonly IntPtr selValueForKey_Handle = Selector.GetHandle("valueForKey:");

	private static readonly IntPtr selSetValueForKey_Handle = Selector.GetHandle("setValue:forKey:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSAtomicStoreCacheNode");

	private object __mt_ObjectID_var;

	private object __mt_PropertyCache_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSManagedObjectID ObjectID
	{
		[Export("objectID")]
		get
		{
			return (NSManagedObjectID)(__mt_ObjectID_var = ((!IsDirectBinding) ? ((NSManagedObjectID)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selObjectIDHandle))) : ((NSManagedObjectID)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selObjectIDHandle)))));
		}
	}

	public virtual NSDictionary PropertyCache
	{
		[Export("propertyCache")]
		get
		{
			return (NSDictionary)(__mt_PropertyCache_var = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPropertyCacheHandle))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selPropertyCacheHandle)))));
		}
		[Export("setPropertyCache:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPropertyCache_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPropertyCache_Handle, value.Handle);
			}
			__mt_PropertyCache_var = value;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSAtomicStoreCacheNode(NSCoder coder)
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
	public NSAtomicStoreCacheNode(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSAtomicStoreCacheNode(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithObjectID:")]
	public NSAtomicStoreCacheNode(NSManagedObjectID moid)
		: base(NSObjectFlag.Empty)
	{
		if (moid == null)
		{
			throw new ArgumentNullException("moid");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithObjectID_Handle, moid.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithObjectID_Handle, moid.Handle);
		}
	}

	[Export("valueForKey:")]
	public virtual NSAtomicStoreCacheNode ValueForKey(string key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		NSAtomicStoreCacheNode result = ((!IsDirectBinding) ? ((NSAtomicStoreCacheNode)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selValueForKey_Handle, arg))) : ((NSAtomicStoreCacheNode)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selValueForKey_Handle, arg))));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("setValue:forKey:")]
	public virtual void SetValue(NSObject value, string key)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetValueForKey_Handle, value.Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetValueForKey_Handle, value.Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_ObjectID_var = null;
			__mt_PropertyCache_var = null;
		}
	}
}
