using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSOrderedSet", true)]
public class NSOrderedSet : NSObject, IEnumerable<NSObject>, IEnumerable
{
	internal const string selSetWithArray = "orderedSetWithArray:";

	private static readonly IntPtr selCountHandle = Selector.GetHandle("count");

	private static readonly IntPtr selInitWithObject_Handle = Selector.GetHandle("initWithObject:");

	private static readonly IntPtr selInitWithArray_Handle = Selector.GetHandle("initWithArray:");

	private static readonly IntPtr selInitWithSet_Handle = Selector.GetHandle("initWithSet:");

	private static readonly IntPtr selInitWithOrderedSet_Handle = Selector.GetHandle("initWithOrderedSet:");

	private static readonly IntPtr selObjectAtIndex_Handle = Selector.GetHandle("objectAtIndex:");

	private static readonly IntPtr selArrayHandle = Selector.GetHandle("array");

	private static readonly IntPtr selIndexOfObject_Handle = Selector.GetHandle("indexOfObject:");

	private static readonly IntPtr selObjectEnumeratorHandle = Selector.GetHandle("objectEnumerator");

	private static readonly IntPtr selSetHandle = Selector.GetHandle("set");

	private static readonly IntPtr selContainsObject_Handle = Selector.GetHandle("containsObject:");

	private static readonly IntPtr selFirstObjectHandle = Selector.GetHandle("firstObject");

	private static readonly IntPtr selLastObjectHandle = Selector.GetHandle("lastObject");

	private static readonly IntPtr selIsEqualToOrderedSet_Handle = Selector.GetHandle("isEqualToOrderedSet:");

	private static readonly IntPtr selIntersectsOrderedSet_Handle = Selector.GetHandle("intersectsOrderedSet:");

	private static readonly IntPtr selIntersectsSet_Handle = Selector.GetHandle("intersectsSet:");

	private static readonly IntPtr selIsSubsetOfOrderedSet_Handle = Selector.GetHandle("isSubsetOfOrderedSet:");

	private static readonly IntPtr selIsSubsetOfSet_Handle = Selector.GetHandle("isSubsetOfSet:");

	private static readonly IntPtr selReversedOrderedSetHandle = Selector.GetHandle("reversedOrderedSet");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSOrderedSet");

	public NSObject this[int idx] => GetObject(idx);

	public override IntPtr ClassHandle => class_ptr;

	public virtual int Count
	{
		[Export("count")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selCountHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selCountHandle);
		}
	}

	public NSOrderedSet(params NSObject[] objs)
		: this(NSArray.FromNSObjects(objs))
	{
	}

	public NSOrderedSet(params object[] objs)
		: this(NSArray.FromObjects(objs))
	{
	}

	public NSOrderedSet(params string[] strings)
		: this(NSArray.FromStrings(strings))
	{
	}

	public T[] ToArray<T>() where T : NSObject
	{
		return NSArray.ArrayFromHandle<T>(_ToArray());
	}

	public static NSOrderedSet MakeNSOrderedSet<T>(T[] values) where T : NSObject
	{
		NSArray nSArray = NSArray.FromNSObjects(values);
		return (NSOrderedSet)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, Selector.GetHandle("orderedSetWithArray:"), nSArray.Handle));
	}

	public IEnumerator<NSObject> GetEnumerator()
	{
		NSEnumerator enumerator = _GetEnumerator();
		while (true)
		{
			NSObject nSObject;
			NSObject obj = (nSObject = enumerator.NextObject());
			if (nSObject != null)
			{
				yield return obj;
				continue;
			}
			break;
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		NSEnumerator enumerator = _GetEnumerator();
		while (true)
		{
			NSObject nSObject;
			NSObject obj = (nSObject = enumerator.NextObject());
			if (nSObject != null)
			{
				yield return obj;
				continue;
			}
			break;
		}
	}

	public static NSOrderedSet operator +(NSOrderedSet first, NSOrderedSet second)
	{
		if (first == null)
		{
			return second;
		}
		if (second == null)
		{
			return first;
		}
		NSMutableOrderedSet nSMutableOrderedSet = new NSMutableOrderedSet();
		nSMutableOrderedSet.UnionSet(second.AsSet());
		return nSMutableOrderedSet;
	}

	public static NSOrderedSet operator -(NSOrderedSet first, NSOrderedSet second)
	{
		if (first == null)
		{
			return null;
		}
		if (second == null)
		{
			return first;
		}
		NSMutableOrderedSet nSMutableOrderedSet = new NSMutableOrderedSet(first);
		nSMutableOrderedSet.MinusSet(second.AsSet());
		return nSMutableOrderedSet;
	}

	public static NSOrderedSet operator -(NSOrderedSet first, NSSet second)
	{
		if (first == null)
		{
			return null;
		}
		if (second == null)
		{
			return first;
		}
		NSMutableOrderedSet nSMutableOrderedSet = new NSMutableOrderedSet(first);
		nSMutableOrderedSet.MinusSet(second);
		return nSMutableOrderedSet;
	}

	public static bool operator ==(NSOrderedSet first, NSOrderedSet second)
	{
		return first.IsEqualToOrderedSet(second);
	}

	public static bool operator !=(NSOrderedSet first, NSOrderedSet second)
	{
		return !first.IsEqualToOrderedSet(second);
	}

	public bool Contains(object obj)
	{
		return Contains(NSObject.FromObject(obj));
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSOrderedSet()
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
	public NSOrderedSet(NSCoder coder)
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
	public NSOrderedSet(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSOrderedSet(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithObject:")]
	public NSOrderedSet(NSObject start)
		: base(NSObjectFlag.Empty)
	{
		if (start == null)
		{
			throw new ArgumentNullException("start");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithObject_Handle, start.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithObject_Handle, start.Handle);
		}
	}

	[Export("initWithArray:")]
	internal NSOrderedSet(NSArray array)
		: base(NSObjectFlag.Empty)
	{
		if (array == null)
		{
			throw new ArgumentNullException("array");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithArray_Handle, array.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithArray_Handle, array.Handle);
		}
	}

	[Export("initWithSet:")]
	public NSOrderedSet(NSSet source)
		: base(NSObjectFlag.Empty)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithSet_Handle, source.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithSet_Handle, source.Handle);
		}
	}

	[Export("initWithOrderedSet:")]
	public NSOrderedSet(NSOrderedSet source)
		: base(NSObjectFlag.Empty)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithOrderedSet_Handle, source.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithOrderedSet_Handle, source.Handle);
		}
	}

	[Export("objectAtIndex:")]
	internal virtual NSObject GetObject(int idx)
	{
		if (IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_int(base.Handle, selObjectAtIndex_Handle, idx));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_int(base.SuperHandle, selObjectAtIndex_Handle, idx));
	}

	[Export("array")]
	internal virtual IntPtr _ToArray()
	{
		if (IsDirectBinding)
		{
			return Messaging.IntPtr_objc_msgSend(base.Handle, selArrayHandle);
		}
		return Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selArrayHandle);
	}

	[Export("indexOfObject:")]
	public virtual int IndexOf(NSObject obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		if (IsDirectBinding)
		{
			return Messaging.int_objc_msgSend_IntPtr(base.Handle, selIndexOfObject_Handle, obj.Handle);
		}
		return Messaging.int_objc_msgSendSuper_IntPtr(base.SuperHandle, selIndexOfObject_Handle, obj.Handle);
	}

	[Export("objectEnumerator")]
	internal virtual NSEnumerator _GetEnumerator()
	{
		if (IsDirectBinding)
		{
			return (NSEnumerator)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selObjectEnumeratorHandle));
		}
		return (NSEnumerator)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selObjectEnumeratorHandle));
	}

	[Export("set")]
	public virtual NSSet AsSet()
	{
		if (IsDirectBinding)
		{
			return (NSSet)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selSetHandle));
		}
		return (NSSet)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSetHandle));
	}

	[Export("containsObject:")]
	public virtual bool Contains(NSObject obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selContainsObject_Handle, obj.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selContainsObject_Handle, obj.Handle);
	}

	[Export("firstObject")]
	public virtual NSObject FirstObject()
	{
		if (IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selFirstObjectHandle));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFirstObjectHandle));
	}

	[Export("lastObject")]
	public virtual NSObject LastObject()
	{
		if (IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selLastObjectHandle));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLastObjectHandle));
	}

	[Export("isEqualToOrderedSet:")]
	public virtual bool IsEqualToOrderedSet(NSOrderedSet other)
	{
		if (other == null)
		{
			throw new ArgumentNullException("other");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIsEqualToOrderedSet_Handle, other.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIsEqualToOrderedSet_Handle, other.Handle);
	}

	[Export("intersectsOrderedSet:")]
	public virtual bool Intersects(NSOrderedSet other)
	{
		if (other == null)
		{
			throw new ArgumentNullException("other");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIntersectsOrderedSet_Handle, other.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIntersectsOrderedSet_Handle, other.Handle);
	}

	[Export("intersectsSet:")]
	public virtual bool Intersects(NSSet other)
	{
		if (other == null)
		{
			throw new ArgumentNullException("other");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIntersectsSet_Handle, other.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIntersectsSet_Handle, other.Handle);
	}

	[Export("isSubsetOfOrderedSet:")]
	public virtual bool IsSubset(NSOrderedSet other)
	{
		if (other == null)
		{
			throw new ArgumentNullException("other");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIsSubsetOfOrderedSet_Handle, other.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIsSubsetOfOrderedSet_Handle, other.Handle);
	}

	[Export("isSubsetOfSet:")]
	public virtual bool IsSubset(NSSet other)
	{
		if (other == null)
		{
			throw new ArgumentNullException("other");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIsSubsetOfSet_Handle, other.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIsSubsetOfSet_Handle, other.Handle);
	}

	[Export("reversedOrderedSet")]
	public virtual NSOrderedSet GetReverseOrderedSet()
	{
		if (IsDirectBinding)
		{
			return (NSOrderedSet)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selReversedOrderedSetHandle));
		}
		return (NSOrderedSet)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selReversedOrderedSetHandle));
	}
}
