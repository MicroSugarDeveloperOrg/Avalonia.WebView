using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSCache", true)]
public class NSCache : NSObject
{
	[Register]
	private sealed class _NSCacheDelegate : NSCacheDelegate
	{
		internal EventHandler<NSObjectEventArgs> willEvictObject;

		[Preserve(Conditional = true)]
		public override void WillEvictObject(NSCache cache, NSObject obj)
		{
			EventHandler<NSObjectEventArgs> eventHandler = willEvictObject;
			if (eventHandler != null)
			{
				NSObjectEventArgs e = new NSObjectEventArgs(obj);
				eventHandler(cache, e);
			}
		}
	}

	private static readonly IntPtr selNameHandle = Selector.GetHandle("name");

	private static readonly IntPtr selSetName_Handle = Selector.GetHandle("setName:");

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	private static readonly IntPtr selTotalCostLimitHandle = Selector.GetHandle("totalCostLimit");

	private static readonly IntPtr selSetTotalCostLimit_Handle = Selector.GetHandle("setTotalCostLimit:");

	private static readonly IntPtr selCountLimitHandle = Selector.GetHandle("countLimit");

	private static readonly IntPtr selSetCountLimit_Handle = Selector.GetHandle("setCountLimit:");

	private static readonly IntPtr selEvictsObjectsWithDiscardedContentHandle = Selector.GetHandle("evictsObjectsWithDiscardedContent");

	private static readonly IntPtr selSetEvictsObjectsWithDiscardedContent_Handle = Selector.GetHandle("setEvictsObjectsWithDiscardedContent:");

	private static readonly IntPtr selObjectForKey_Handle = Selector.GetHandle("objectForKey:");

	private static readonly IntPtr selSetObjectForKey_Handle = Selector.GetHandle("setObject:forKey:");

	private static readonly IntPtr selSetObjectForKeyCost_Handle = Selector.GetHandle("setObject:forKey:cost:");

	private static readonly IntPtr selRemoveObjectForKey_Handle = Selector.GetHandle("removeObjectForKey:");

	private static readonly IntPtr selRemoveAllObjectsHandle = Selector.GetHandle("removeAllObjects");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSCache");

	private object __mt_WeakDelegate_var;

	public override IntPtr ClassHandle => class_ptr;

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

	public virtual NSObject WeakDelegate
	{
		[Export("delegate")]
		get
		{
			return (NSObject)(__mt_WeakDelegate_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle))));
		}
		[Export("setDelegate:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDelegate_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDelegate_Handle, value.Handle);
			}
			__mt_WeakDelegate_var = value;
		}
	}

	public NSCacheDelegate Delegate
	{
		get
		{
			return WeakDelegate as NSCacheDelegate;
		}
		set
		{
			WeakDelegate = value;
		}
	}

	public virtual ulong TotalCostLimit
	{
		[Export("totalCostLimit")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.UInt64_objc_msgSend(base.Handle, selTotalCostLimitHandle);
			}
			return Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selTotalCostLimitHandle);
		}
		[Export("setTotalCostLimit:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetTotalCostLimit_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetTotalCostLimit_Handle, value);
			}
		}
	}

	public virtual ulong CountLimit
	{
		[Export("countLimit")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.UInt64_objc_msgSend(base.Handle, selCountLimitHandle);
			}
			return Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selCountLimitHandle);
		}
		[Export("setCountLimit:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetCountLimit_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetCountLimit_Handle, value);
			}
		}
	}

	public virtual bool EvictsObjectsWithDiscardedContent
	{
		[Export("evictsObjectsWithDiscardedContent")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selEvictsObjectsWithDiscardedContentHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selEvictsObjectsWithDiscardedContentHandle);
		}
		[Export("setEvictsObjectsWithDiscardedContent:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetEvictsObjectsWithDiscardedContent_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetEvictsObjectsWithDiscardedContent_Handle, value);
			}
		}
	}

	public event EventHandler<NSObjectEventArgs> WillEvictObject
	{
		add
		{
			_NSCacheDelegate nSCacheDelegate = EnsureNSCacheDelegate();
			nSCacheDelegate.willEvictObject = (EventHandler<NSObjectEventArgs>)System.Delegate.Combine(nSCacheDelegate.willEvictObject, value);
		}
		remove
		{
			_NSCacheDelegate nSCacheDelegate = EnsureNSCacheDelegate();
			nSCacheDelegate.willEvictObject = (EventHandler<NSObjectEventArgs>)System.Delegate.Remove(nSCacheDelegate.willEvictObject, value);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSCache()
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
	public NSCache(NSCoder coder)
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
	public NSCache(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSCache(IntPtr handle)
		: base(handle)
	{
	}

	[Export("objectForKey:")]
	public virtual NSObject ObjectForKey(NSObject key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selObjectForKey_Handle, key.Handle));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selObjectForKey_Handle, key.Handle));
	}

	[Export("setObject:forKey:")]
	public virtual void SetObjectforKey(NSObject obj, NSObject key)
	{
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetObjectForKey_Handle, obj.Handle, key.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetObjectForKey_Handle, obj.Handle, key.Handle);
		}
	}

	[Export("setObject:forKey:cost:")]
	public virtual void SetCost(NSObject obj, NSObject key, ulong cost)
	{
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_UInt64(base.Handle, selSetObjectForKeyCost_Handle, obj.Handle, key.Handle, cost);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_UInt64(base.SuperHandle, selSetObjectForKeyCost_Handle, obj.Handle, key.Handle, cost);
		}
	}

	[Export("removeObjectForKey:")]
	public virtual void RemoveObjectForKey(NSObject key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveObjectForKey_Handle, key.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveObjectForKey_Handle, key.Handle);
		}
	}

	[Export("removeAllObjects")]
	public virtual void RemoveAllObjects()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRemoveAllObjectsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRemoveAllObjectsHandle);
		}
	}

	private _NSCacheDelegate EnsureNSCacheDelegate()
	{
		NSObject nSObject = WeakDelegate;
		if (nSObject == null || !(nSObject is _NSCacheDelegate))
		{
			nSObject = (WeakDelegate = new _NSCacheDelegate());
		}
		return (_NSCacheDelegate)nSObject;
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_WeakDelegate_var = null;
		}
	}
}
