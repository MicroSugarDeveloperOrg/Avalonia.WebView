using System;
using System.ComponentModel;
using AppKit;
using ObjCRuntime;

namespace Foundation;

[Register("NSCache", true)]
public class NSCache : NSObject
{
	[Register]
	internal class _NSCacheDelegate : NSObject, INSCacheDelegate, INativeObject, IDisposable
	{
		internal EventHandler<NSObjectEventArgs>? willEvictObject;

		public _NSCacheDelegate()
		{
			base.IsDirectBinding = false;
		}

		[Preserve(Conditional = true)]
		[Export("cache:willEvictObject:")]
		public void WillEvictObject(NSCache cache, NSObject obj)
		{
			EventHandler<NSObjectEventArgs> eventHandler = willEvictObject;
			if (eventHandler != null)
			{
				NSObjectEventArgs e = new NSObjectEventArgs(obj);
				eventHandler(cache, e);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCountLimit = "countLimit";

	private static readonly IntPtr selCountLimitHandle = Selector.GetHandle("countLimit");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEvictsObjectsWithDiscardedContent = "evictsObjectsWithDiscardedContent";

	private static readonly IntPtr selEvictsObjectsWithDiscardedContentHandle = Selector.GetHandle("evictsObjectsWithDiscardedContent");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selName = "name";

	private static readonly IntPtr selNameHandle = Selector.GetHandle("name");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selObjectForKey_ = "objectForKey:";

	private static readonly IntPtr selObjectForKey_Handle = Selector.GetHandle("objectForKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveAllObjects = "removeAllObjects";

	private static readonly IntPtr selRemoveAllObjectsHandle = Selector.GetHandle("removeAllObjects");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveObjectForKey_ = "removeObjectForKey:";

	private static readonly IntPtr selRemoveObjectForKey_Handle = Selector.GetHandle("removeObjectForKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCountLimit_ = "setCountLimit:";

	private static readonly IntPtr selSetCountLimit_Handle = Selector.GetHandle("setCountLimit:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelegate_ = "setDelegate:";

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEvictsObjectsWithDiscardedContent_ = "setEvictsObjectsWithDiscardedContent:";

	private static readonly IntPtr selSetEvictsObjectsWithDiscardedContent_Handle = Selector.GetHandle("setEvictsObjectsWithDiscardedContent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetName_ = "setName:";

	private static readonly IntPtr selSetName_Handle = Selector.GetHandle("setName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetObject_ForKey_ = "setObject:forKey:";

	private static readonly IntPtr selSetObject_ForKey_Handle = Selector.GetHandle("setObject:forKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetObject_ForKey_Cost_ = "setObject:forKey:cost:";

	private static readonly IntPtr selSetObject_ForKey_Cost_Handle = Selector.GetHandle("setObject:forKey:cost:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTotalCostLimit_ = "setTotalCostLimit:";

	private static readonly IntPtr selSetTotalCostLimit_Handle = Selector.GetHandle("setTotalCostLimit:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTotalCostLimit = "totalCostLimit";

	private static readonly IntPtr selTotalCostLimitHandle = Selector.GetHandle("totalCostLimit");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSCache");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakDelegate_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint CountLimit
	{
		[Export("countLimit")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selCountLimitHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selCountLimitHandle);
		}
		[Export("setCountLimit:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetCountLimit_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetCountLimit_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public INSCacheDelegate Delegate
	{
		get
		{
			return WeakDelegate as INSCacheDelegate;
		}
		set
		{
			NSObject nSObject = value as NSObject;
			if (value != null && nSObject == null)
			{
				throw new ArgumentException("The object passed of type " + value.GetType()?.ToString() + " does not derive from NSObject");
			}
			WeakDelegate = nSObject;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool EvictsObjectsWithDiscardedContent
	{
		[Export("evictsObjectsWithDiscardedContent")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selEvictsObjectsWithDiscardedContentHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selEvictsObjectsWithDiscardedContentHandle);
		}
		[Export("setEvictsObjectsWithDiscardedContent:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetEvictsObjectsWithDiscardedContent_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetEvictsObjectsWithDiscardedContent_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Name
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
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
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
	public virtual nuint TotalCostLimit
	{
		[Export("totalCostLimit")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selTotalCostLimitHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selTotalCostLimitHandle);
		}
		[Export("setTotalCostLimit:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetTotalCostLimit_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetTotalCostLimit_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject? WeakDelegate
	{
		[Export("delegate", ArgumentSemantic.Assign)]
		get
		{
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle)));
			MarkDirty();
			__mt_WeakDelegate_var = nSObject;
			return nSObject;
		}
		[Export("setDelegate:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureDelegateAssignIsNotOverwritingInternalDelegate(__mt_WeakDelegate_var, value, GetInternalEventDelegateType);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_WeakDelegate_var = value;
		}
	}

	internal virtual Type GetInternalEventDelegateType => typeof(_NSCacheDelegate);

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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSCache()
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
	protected NSCache(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSCache(IntPtr handle)
		: base(handle)
	{
	}

	[Export("objectForKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject ObjectForKey(NSObject key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selObjectForKey_Handle, key.Handle));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selObjectForKey_Handle, key.Handle));
	}

	[Export("removeAllObjects")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveAllObjects()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRemoveAllObjectsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRemoveAllObjectsHandle);
		}
	}

	[Export("removeObjectForKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveObjectForKey(NSObject key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveObjectForKey_Handle, key.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveObjectForKey_Handle, key.Handle);
		}
	}

	[Export("setObject:forKey:cost:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetCost(NSObject obj, NSObject key, nuint cost)
	{
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_nuint(base.Handle, selSetObject_ForKey_Cost_Handle, obj.Handle, key.Handle, cost);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_nuint(base.SuperHandle, selSetObject_ForKey_Cost_Handle, obj.Handle, key.Handle, cost);
		}
	}

	[Export("setObject:forKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetObject_ForKey_Handle, obj.Handle, key.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetObject_ForKey_Handle, obj.Handle, key.Handle);
		}
	}

	internal virtual _NSCacheDelegate CreateInternalEventDelegateType()
	{
		return new _NSCacheDelegate();
	}

	internal _NSCacheDelegate EnsureNSCacheDelegate()
	{
		if (WeakDelegate != null)
		{
			NSApplication.EnsureEventAndDelegateAreNotMismatched(WeakDelegate, GetInternalEventDelegateType);
		}
		_NSCacheDelegate nSCacheDelegate = Delegate as _NSCacheDelegate;
		if (nSCacheDelegate == null)
		{
			nSCacheDelegate = (_NSCacheDelegate)(Delegate = CreateInternalEventDelegateType());
		}
		return nSCacheDelegate;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_WeakDelegate_var = null;
		}
	}
}
