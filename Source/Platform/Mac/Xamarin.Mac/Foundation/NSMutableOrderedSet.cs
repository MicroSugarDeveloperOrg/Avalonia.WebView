using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSMutableOrderedSet", SkipRegistration = true)]
public sealed class NSMutableOrderedSet<TKey> : NSMutableOrderedSet, IEnumerable<TKey>, IEnumerable where TKey : class, INativeObject
{
	public new TKey this[nint idx]
	{
		get
		{
			IntPtr ptr = _GetObject(idx);
			return Runtime.GetINativeObject<TKey>(ptr, owns: false);
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			_SetObject(value.Handle, idx);
		}
	}

	public NSMutableOrderedSet()
	{
	}

	public NSMutableOrderedSet(NSCoder coder)
		: base(coder)
	{
	}

	internal NSMutableOrderedSet(IntPtr handle)
		: base(handle)
	{
	}

	public NSMutableOrderedSet(nint capacity)
		: base(capacity)
	{
	}

	public NSMutableOrderedSet(TKey start)
		: base(start)
	{
	}

	public NSMutableOrderedSet(params TKey[] objs)
		: base(objs)
	{
	}

	public NSMutableOrderedSet(NSSet<TKey> source)
		: base(source)
	{
	}

	public NSMutableOrderedSet(NSOrderedSet<TKey> other)
		: base(other)
	{
	}

	public NSMutableOrderedSet(NSMutableOrderedSet<TKey> other)
		: base(other)
	{
	}

	public new NSSet<TKey> AsSet()
	{
		IntPtr ptr = _AsSet();
		return Runtime.GetINativeObject<NSSet<TKey>>(ptr, owns: false);
	}

	public void Insert(TKey obj, nint atIndex)
	{
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		_Insert(obj.Handle, atIndex);
	}

	public void Replace(nint objectAtIndex, TKey newObject)
	{
		if (newObject == null)
		{
			throw new ArgumentNullException("newObject");
		}
		_Replace(objectAtIndex, newObject.Handle);
	}

	public void Add(TKey obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		_Add(obj.Handle);
	}

	public void AddObjects(params TKey[] source)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		_AddObjects(NSArray.FromNativeObjects(source));
	}

	public void InsertObjects(TKey[] objects, NSIndexSet atIndexes)
	{
		if (objects == null)
		{
			throw new ArgumentNullException("objects");
		}
		if (atIndexes == null)
		{
			throw new ArgumentNullException("atIndexes");
		}
		_InsertObjects(NSArray.FromNativeObjects(objects), atIndexes);
	}

	public void ReplaceObjects(NSIndexSet indexSet, params TKey[] replacementObjects)
	{
		if (replacementObjects == null)
		{
			throw new ArgumentNullException("replacementObjects");
		}
		if (indexSet == null)
		{
			throw new ArgumentNullException("indexSet");
		}
		_ReplaceObjects(indexSet, NSArray.FromNativeObjects(replacementObjects));
	}

	public void RemoveObject(TKey obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		_RemoveObject(obj.Handle);
	}

	public void RemoveObjects(params TKey[] objects)
	{
		if (objects == null)
		{
			throw new ArgumentNullException("objects");
		}
		_RemoveObjects(NSArray.FromNativeObjects(objects));
	}

	IEnumerator<TKey> IEnumerable<TKey>.GetEnumerator()
	{
		return new NSFastEnumerator<TKey>(this);
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return new NSFastEnumerator<TKey>(this);
	}

	public static NSMutableOrderedSet<TKey>operator +(NSMutableOrderedSet<TKey> first, NSMutableOrderedSet<TKey> second)
	{
		if (first == null)
		{
			return (second != null) ? new NSMutableOrderedSet<TKey>(second) : null;
		}
		if (second == null)
		{
			return new NSMutableOrderedSet<TKey>(first);
		}
		NSMutableOrderedSet<TKey> nSMutableOrderedSet = new NSMutableOrderedSet<TKey>(first);
		nSMutableOrderedSet.UnionSet(second);
		return nSMutableOrderedSet;
	}

	public static NSMutableOrderedSet<TKey>operator +(NSMutableOrderedSet<TKey> first, NSSet<TKey> second)
	{
		if (first == null)
		{
			return (second != null) ? new NSMutableOrderedSet<TKey>(second) : null;
		}
		if (second == null)
		{
			return new NSMutableOrderedSet<TKey>(first);
		}
		NSMutableOrderedSet<TKey> nSMutableOrderedSet = new NSMutableOrderedSet<TKey>(first);
		nSMutableOrderedSet.UnionSet(second);
		return nSMutableOrderedSet;
	}

	public static NSMutableOrderedSet<TKey>operator +(NSMutableOrderedSet<TKey> first, NSOrderedSet<TKey> second)
	{
		if (first == null)
		{
			return (second != null) ? new NSMutableOrderedSet<TKey>(second) : null;
		}
		if (second == null)
		{
			return new NSMutableOrderedSet<TKey>(first);
		}
		NSMutableOrderedSet<TKey> nSMutableOrderedSet = new NSMutableOrderedSet<TKey>(first);
		nSMutableOrderedSet.UnionSet(second);
		return nSMutableOrderedSet;
	}

	public static NSMutableOrderedSet<TKey>operator -(NSMutableOrderedSet<TKey> first, NSMutableOrderedSet<TKey> second)
	{
		if (first == null)
		{
			return null;
		}
		if (second == null)
		{
			return new NSMutableOrderedSet<TKey>(first);
		}
		NSMutableOrderedSet<TKey> nSMutableOrderedSet = new NSMutableOrderedSet<TKey>(first);
		nSMutableOrderedSet.MinusSet(second);
		return nSMutableOrderedSet;
	}

	public static NSMutableOrderedSet<TKey>operator -(NSMutableOrderedSet<TKey> first, NSSet<TKey> second)
	{
		if (first == null)
		{
			return null;
		}
		if (second == null)
		{
			return new NSMutableOrderedSet<TKey>(first);
		}
		NSMutableOrderedSet<TKey> nSMutableOrderedSet = new NSMutableOrderedSet<TKey>(first);
		nSMutableOrderedSet.MinusSet(second);
		return nSMutableOrderedSet;
	}

	public static NSMutableOrderedSet<TKey>operator -(NSMutableOrderedSet<TKey> first, NSOrderedSet<TKey> second)
	{
		if (first == null)
		{
			return null;
		}
		if (second == null)
		{
			return new NSMutableOrderedSet<TKey>(first);
		}
		NSMutableOrderedSet<TKey> nSMutableOrderedSet = new NSMutableOrderedSet<TKey>(first);
		nSMutableOrderedSet.MinusSet(second);
		return nSMutableOrderedSet;
	}
}
[Register("NSMutableOrderedSet", true)]
public class NSMutableOrderedSet : NSOrderedSet
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddObject_ = "addObject:";

	private static readonly IntPtr selAddObject_Handle = Selector.GetHandle("addObject:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddObjectsFromArray_ = "addObjectsFromArray:";

	private static readonly IntPtr selAddObjectsFromArray_Handle = Selector.GetHandle("addObjectsFromArray:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExchangeObjectAtIndex_WithObjectAtIndex_ = "exchangeObjectAtIndex:withObjectAtIndex:";

	private static readonly IntPtr selExchangeObjectAtIndex_WithObjectAtIndex_Handle = Selector.GetHandle("exchangeObjectAtIndex:withObjectAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithArray_ = "initWithArray:";

	private static readonly IntPtr selInitWithArray_Handle = Selector.GetHandle("initWithArray:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCapacity_ = "initWithCapacity:";

	private static readonly IntPtr selInitWithCapacity_Handle = Selector.GetHandle("initWithCapacity:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithObject_ = "initWithObject:";

	private static readonly IntPtr selInitWithObject_Handle = Selector.GetHandle("initWithObject:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithOrderedSet_ = "initWithOrderedSet:";

	private static readonly IntPtr selInitWithOrderedSet_Handle = Selector.GetHandle("initWithOrderedSet:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSet_ = "initWithSet:";

	private static readonly IntPtr selInitWithSet_Handle = Selector.GetHandle("initWithSet:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInsertObject_AtIndex_ = "insertObject:atIndex:";

	private static readonly IntPtr selInsertObject_AtIndex_Handle = Selector.GetHandle("insertObject:atIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInsertObjects_AtIndexes_ = "insertObjects:atIndexes:";

	private static readonly IntPtr selInsertObjects_AtIndexes_Handle = Selector.GetHandle("insertObjects:atIndexes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIntersectOrderedSet_ = "intersectOrderedSet:";

	private static readonly IntPtr selIntersectOrderedSet_Handle = Selector.GetHandle("intersectOrderedSet:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIntersectSet_ = "intersectSet:";

	private static readonly IntPtr selIntersectSet_Handle = Selector.GetHandle("intersectSet:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMinusOrderedSet_ = "minusOrderedSet:";

	private static readonly IntPtr selMinusOrderedSet_Handle = Selector.GetHandle("minusOrderedSet:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMinusSet_ = "minusSet:";

	private static readonly IntPtr selMinusSet_Handle = Selector.GetHandle("minusSet:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMoveObjectsAtIndexes_ToIndex_ = "moveObjectsAtIndexes:toIndex:";

	private static readonly IntPtr selMoveObjectsAtIndexes_ToIndex_Handle = Selector.GetHandle("moveObjectsAtIndexes:toIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveAllObjects = "removeAllObjects";

	private static readonly IntPtr selRemoveAllObjectsHandle = Selector.GetHandle("removeAllObjects");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveObject_ = "removeObject:";

	private static readonly IntPtr selRemoveObject_Handle = Selector.GetHandle("removeObject:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveObjectAtIndex_ = "removeObjectAtIndex:";

	private static readonly IntPtr selRemoveObjectAtIndex_Handle = Selector.GetHandle("removeObjectAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveObjectsAtIndexes_ = "removeObjectsAtIndexes:";

	private static readonly IntPtr selRemoveObjectsAtIndexes_Handle = Selector.GetHandle("removeObjectsAtIndexes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveObjectsInArray_ = "removeObjectsInArray:";

	private static readonly IntPtr selRemoveObjectsInArray_Handle = Selector.GetHandle("removeObjectsInArray:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveObjectsInRange_ = "removeObjectsInRange:";

	private static readonly IntPtr selRemoveObjectsInRange_Handle = Selector.GetHandle("removeObjectsInRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReplaceObjectAtIndex_WithObject_ = "replaceObjectAtIndex:withObject:";

	private static readonly IntPtr selReplaceObjectAtIndex_WithObject_Handle = Selector.GetHandle("replaceObjectAtIndex:withObject:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReplaceObjectsAtIndexes_WithObjects_ = "replaceObjectsAtIndexes:withObjects:";

	private static readonly IntPtr selReplaceObjectsAtIndexes_WithObjects_Handle = Selector.GetHandle("replaceObjectsAtIndexes:withObjects:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetObject_AtIndex_ = "setObject:atIndex:";

	private static readonly IntPtr selSetObject_AtIndex_Handle = Selector.GetHandle("setObject:atIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSortRange_Options_UsingComparator_ = "sortRange:options:usingComparator:";

	private static readonly IntPtr selSortRange_Options_UsingComparator_Handle = Selector.GetHandle("sortRange:options:usingComparator:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSortUsingComparator_ = "sortUsingComparator:";

	private static readonly IntPtr selSortUsingComparator_Handle = Selector.GetHandle("sortUsingComparator:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSortWithOptions_UsingComparator_ = "sortWithOptions:usingComparator:";

	private static readonly IntPtr selSortWithOptions_UsingComparator_Handle = Selector.GetHandle("sortWithOptions:usingComparator:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnionOrderedSet_ = "unionOrderedSet:";

	private static readonly IntPtr selUnionOrderedSet_Handle = Selector.GetHandle("unionOrderedSet:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnionSet_ = "unionSet:";

	private static readonly IntPtr selUnionSet_Handle = Selector.GetHandle("unionSet:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSMutableOrderedSet");

	public new NSObject this[nint idx]
	{
		get
		{
			return GetObject(idx);
		}
		set
		{
			SetObject(value, idx);
		}
	}

	public override IntPtr ClassHandle => class_ptr;

	public NSMutableOrderedSet(params NSObject[] objs)
		: this(NSArray.FromNSObjects(objs))
	{
	}

	public NSMutableOrderedSet(params object[] objs)
		: this(NSArray.FromObjects(objs))
	{
	}

	public NSMutableOrderedSet(params string[] strings)
		: this(NSArray.FromStrings(strings))
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSMutableOrderedSet()
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
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSMutableOrderedSet(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSMutableOrderedSet(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSMutableOrderedSet(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithObject:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSMutableOrderedSet(NSObject start)
		: base(NSObjectFlag.Empty)
	{
		if (start == null)
		{
			throw new ArgumentNullException("start");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithObject_Handle, start.Handle), "initWithObject:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithObject_Handle, start.Handle), "initWithObject:");
		}
	}

	[Export("initWithSet:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSMutableOrderedSet(NSSet source)
		: base(NSObjectFlag.Empty)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithSet_Handle, source.Handle), "initWithSet:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithSet_Handle, source.Handle), "initWithSet:");
		}
	}

	[Export("initWithOrderedSet:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSMutableOrderedSet(NSOrderedSet source)
		: base(NSObjectFlag.Empty)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithOrderedSet_Handle, source.Handle), "initWithOrderedSet:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithOrderedSet_Handle, source.Handle), "initWithOrderedSet:");
		}
	}

	[Export("initWithCapacity:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSMutableOrderedSet(nint capacity)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_nint(base.Handle, selInitWithCapacity_Handle, capacity), "initWithCapacity:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_nint(base.SuperHandle, selInitWithCapacity_Handle, capacity), "initWithCapacity:");
		}
	}

	[Export("initWithArray:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal NSMutableOrderedSet(NSArray array)
		: base(NSObjectFlag.Empty)
	{
		if (array == null)
		{
			throw new ArgumentNullException("array");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithArray_Handle, array.Handle), "initWithArray:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithArray_Handle, array.Handle), "initWithArray:");
		}
	}

	[Export("addObject:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Add(NSObject obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddObject_Handle, obj.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddObject_Handle, obj.Handle);
		}
	}

	[Export("addObjectsFromArray:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddObjects(NSObject[] source)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		NSArray nSArray = NSArray.FromNSObjects(source);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddObjectsFromArray_Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddObjectsFromArray_Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[Export("exchangeObjectAtIndex:withObjectAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ExchangeObject(nint first, nint second)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nint_nint(base.Handle, selExchangeObjectAtIndex_WithObjectAtIndex_Handle, first, second);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nint_nint(base.SuperHandle, selExchangeObjectAtIndex_WithObjectAtIndex_Handle, first, second);
		}
	}

	[Export("insertObject:atIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Insert(NSObject obj, nint atIndex)
	{
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nint(base.Handle, selInsertObject_AtIndex_Handle, obj.Handle, atIndex);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nint(base.SuperHandle, selInsertObject_AtIndex_Handle, obj.Handle, atIndex);
		}
	}

	[Export("insertObjects:atIndexes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void InsertObjects(NSObject[] objects, NSIndexSet atIndexes)
	{
		if (objects == null)
		{
			throw new ArgumentNullException("objects");
		}
		if (atIndexes == null)
		{
			throw new ArgumentNullException("atIndexes");
		}
		NSArray nSArray = NSArray.FromNSObjects(objects);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selInsertObjects_AtIndexes_Handle, nSArray.Handle, atIndexes.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInsertObjects_AtIndexes_Handle, nSArray.Handle, atIndexes.Handle);
		}
		nSArray.Dispose();
	}

	[Export("intersectOrderedSet:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Intersect(NSOrderedSet intersectWith)
	{
		if (intersectWith == null)
		{
			throw new ArgumentNullException("intersectWith");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selIntersectOrderedSet_Handle, intersectWith.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selIntersectOrderedSet_Handle, intersectWith.Handle);
		}
	}

	[Export("intersectSet:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Intersect(NSSet intersectWith)
	{
		if (intersectWith == null)
		{
			throw new ArgumentNullException("intersectWith");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selIntersectSet_Handle, intersectWith.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selIntersectSet_Handle, intersectWith.Handle);
		}
	}

	[Export("minusSet:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual void MinusSet(NSSet other)
	{
		if (other == null)
		{
			throw new ArgumentNullException("other");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selMinusSet_Handle, other.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selMinusSet_Handle, other.Handle);
		}
	}

	[Export("minusOrderedSet:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual void MinusSet(NSOrderedSet other)
	{
		if (other == null)
		{
			throw new ArgumentNullException("other");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selMinusOrderedSet_Handle, other.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selMinusOrderedSet_Handle, other.Handle);
		}
	}

	[Export("moveObjectsAtIndexes:toIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void MoveObjects(NSIndexSet indexSet, nint destination)
	{
		if (indexSet == null)
		{
			throw new ArgumentNullException("indexSet");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nint(base.Handle, selMoveObjectsAtIndexes_ToIndex_Handle, indexSet.Handle, destination);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nint(base.SuperHandle, selMoveObjectsAtIndexes_ToIndex_Handle, indexSet.Handle, destination);
		}
	}

	[Export("removeObjectAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Remove(nint index)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nint(base.Handle, selRemoveObjectAtIndex_Handle, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selRemoveObjectAtIndex_Handle, index);
		}
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

	[Export("removeObject:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveObject(NSObject obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveObject_Handle, obj.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveObject_Handle, obj.Handle);
		}
	}

	[Export("removeObjectsAtIndexes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveObjects(NSIndexSet indexSet)
	{
		if (indexSet == null)
		{
			throw new ArgumentNullException("indexSet");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveObjectsAtIndexes_Handle, indexSet.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveObjectsAtIndexes_Handle, indexSet.Handle);
		}
	}

	[Export("removeObjectsInRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveObjects(NSRange range)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_NSRange(base.Handle, selRemoveObjectsInRange_Handle, range);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_NSRange(base.SuperHandle, selRemoveObjectsInRange_Handle, range);
		}
	}

	[Export("removeObjectsInArray:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveObjects(NSObject[] objects)
	{
		if (objects == null)
		{
			throw new ArgumentNullException("objects");
		}
		NSArray nSArray = NSArray.FromNSObjects(objects);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveObjectsInArray_Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveObjectsInArray_Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[Export("replaceObjectAtIndex:withObject:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Replace(nint objectAtIndex, NSObject newObject)
	{
		if (newObject == null)
		{
			throw new ArgumentNullException("newObject");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nint_IntPtr(base.Handle, selReplaceObjectAtIndex_WithObject_Handle, objectAtIndex, newObject.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nint_IntPtr(base.SuperHandle, selReplaceObjectAtIndex_WithObject_Handle, objectAtIndex, newObject.Handle);
		}
	}

	[Export("replaceObjectsAtIndexes:withObjects:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ReplaceObjects(NSIndexSet indexSet, NSObject[] replacementObjects)
	{
		if (indexSet == null)
		{
			throw new ArgumentNullException("indexSet");
		}
		if (replacementObjects == null)
		{
			throw new ArgumentNullException("replacementObjects");
		}
		NSArray nSArray = NSArray.FromNSObjects(replacementObjects);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selReplaceObjectsAtIndexes_WithObjects_Handle, indexSet.Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selReplaceObjectsAtIndexes_WithObjects_Handle, indexSet.Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[Export("setObject:atIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetObject(NSObject obj, nint index)
	{
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nint(base.Handle, selSetObject_AtIndex_Handle, obj.Handle, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nint(base.SuperHandle, selSetObject_AtIndex_Handle, obj.Handle, index);
		}
	}

	[Export("sortUsingComparator:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void Sort([BlockProxy(typeof(Trampolines.NIDNSComparator))] NSComparator comparator)
	{
		if (comparator == null)
		{
			throw new ArgumentNullException("comparator");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDNSComparator.Handler, comparator);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSortUsingComparator_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSortUsingComparator_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("sortWithOptions:usingComparator:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void Sort(NSSortOptions sortOptions, [BlockProxy(typeof(Trampolines.NIDNSComparator))] NSComparator comparator)
	{
		if (comparator == null)
		{
			throw new ArgumentNullException("comparator");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDNSComparator.Handler, comparator);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt64_IntPtr(base.Handle, selSortWithOptions_UsingComparator_Handle, (ulong)sortOptions, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt64_IntPtr(base.SuperHandle, selSortWithOptions_UsingComparator_Handle, (ulong)sortOptions, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("sortRange:options:usingComparator:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void SortRange(NSRange range, NSSortOptions sortOptions, [BlockProxy(typeof(Trampolines.NIDNSComparator))] NSComparator comparator)
	{
		if (comparator == null)
		{
			throw new ArgumentNullException("comparator");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDNSComparator.Handler, comparator);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_NSRange_UInt64_IntPtr(base.Handle, selSortRange_Options_UsingComparator_Handle, range, (ulong)sortOptions, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_NSRange_UInt64_IntPtr(base.SuperHandle, selSortRange_Options_UsingComparator_Handle, range, (ulong)sortOptions, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("unionSet:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual void UnionSet(NSSet other)
	{
		if (other == null)
		{
			throw new ArgumentNullException("other");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selUnionSet_Handle, other.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selUnionSet_Handle, other.Handle);
		}
	}

	[Export("unionOrderedSet:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual void UnionSet(NSOrderedSet other)
	{
		if (other == null)
		{
			throw new ArgumentNullException("other");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selUnionOrderedSet_Handle, other.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selUnionOrderedSet_Handle, other.Handle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal void _Add(IntPtr obj)
	{
		Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddObject_Handle, obj);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal void _AddObjects(NSArray source)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddObjectsFromArray_Handle, source.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal void _Insert(IntPtr obj, nint atIndex)
	{
		Messaging.void_objc_msgSend_IntPtr_nint(base.Handle, selInsertObject_AtIndex_Handle, obj, atIndex);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal void _InsertObjects(NSArray objects, NSIndexSet atIndexes)
	{
		if (objects == null)
		{
			throw new ArgumentNullException("objects");
		}
		if (atIndexes == null)
		{
			throw new ArgumentNullException("atIndexes");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selInsertObjects_AtIndexes_Handle, objects.Handle, atIndexes.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal void _RemoveObject(IntPtr obj)
	{
		Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveObject_Handle, obj);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal void _RemoveObjects(NSArray objects)
	{
		if (objects == null)
		{
			throw new ArgumentNullException("objects");
		}
		Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveObjectsInArray_Handle, objects.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal void _Replace(nint objectAtIndex, IntPtr newObject)
	{
		Messaging.void_objc_msgSend_nint_IntPtr(base.Handle, selReplaceObjectAtIndex_WithObject_Handle, objectAtIndex, newObject);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal void _ReplaceObjects(NSIndexSet indexSet, NSArray replacementObjects)
	{
		if (indexSet == null)
		{
			throw new ArgumentNullException("indexSet");
		}
		if (replacementObjects == null)
		{
			throw new ArgumentNullException("replacementObjects");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selReplaceObjectsAtIndexes_WithObjects_Handle, indexSet.Handle, replacementObjects.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal void _SetObject(IntPtr obj, nint index)
	{
		Messaging.void_objc_msgSend_IntPtr_nint(base.Handle, selSetObject_AtIndex_Handle, obj, index);
	}
}
