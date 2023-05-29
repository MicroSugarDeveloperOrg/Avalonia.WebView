using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSMutableSet", true)]
public class NSMutableSet : NSSet, IEnumerable<NSObject>, IEnumerable
{
	private static readonly IntPtr selInitWithArray_Handle = Selector.GetHandle("initWithArray:");

	private static readonly IntPtr selInitWithSet_Handle = Selector.GetHandle("initWithSet:");

	private static readonly IntPtr selInitWithCapacity_Handle = Selector.GetHandle("initWithCapacity:");

	private static readonly IntPtr selAddObject_Handle = Selector.GetHandle("addObject:");

	private static readonly IntPtr selRemoveObject_Handle = Selector.GetHandle("removeObject:");

	private static readonly IntPtr selRemoveAllObjectsHandle = Selector.GetHandle("removeAllObjects");

	private static readonly IntPtr selAddObjectsFromArray_Handle = Selector.GetHandle("addObjectsFromArray:");

	private static readonly IntPtr selMinusSet_Handle = Selector.GetHandle("minusSet:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSMutableSet");

	public override IntPtr ClassHandle => class_ptr;

	public NSMutableSet(NSObject[] objs)
		: this(NSArray.FromNSObjects(objs))
	{
	}

	public NSMutableSet(params string[] strings)
		: this(NSArray.FromStrings(strings))
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSMutableSet()
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
	public NSMutableSet(NSCoder coder)
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
	public NSMutableSet(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSMutableSet(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithArray:")]
	public NSMutableSet(NSArray other)
		: base(NSObjectFlag.Empty)
	{
		if (other == null)
		{
			throw new ArgumentNullException("other");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithArray_Handle, other.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithArray_Handle, other.Handle);
		}
	}

	[Export("initWithSet:")]
	public NSMutableSet(NSSet other)
		: base(NSObjectFlag.Empty)
	{
		if (other == null)
		{
			throw new ArgumentNullException("other");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithSet_Handle, other.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithSet_Handle, other.Handle);
		}
	}

	[Export("initWithCapacity:")]
	public NSMutableSet(ulong capacity)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_UInt64(base.Handle, selInitWithCapacity_Handle, capacity);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_UInt64(base.SuperHandle, selInitWithCapacity_Handle, capacity);
		}
	}

	[Export("addObject:")]
	public virtual void Add(NSObject nso)
	{
		if (nso == null)
		{
			throw new ArgumentNullException("nso");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddObject_Handle, nso.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddObject_Handle, nso.Handle);
		}
	}

	[Export("removeObject:")]
	public virtual void Remove(NSObject nso)
	{
		if (nso == null)
		{
			throw new ArgumentNullException("nso");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveObject_Handle, nso.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveObject_Handle, nso.Handle);
		}
	}

	[Export("removeAllObjects")]
	public virtual void RemoveAll()
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

	[Export("addObjectsFromArray:")]
	public virtual void AddObjects(NSObject[] objects)
	{
		if (objects == null)
		{
			throw new ArgumentNullException("objects");
		}
		NSArray nSArray = NSArray.FromNSObjects(objects);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddObjectsFromArray_Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddObjectsFromArray_Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[Export("minusSet:")]
	internal virtual void MinusSet(NSSet other)
	{
		if (other == null)
		{
			throw new ArgumentNullException("other");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selMinusSet_Handle, other.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selMinusSet_Handle, other.Handle);
		}
	}
}
