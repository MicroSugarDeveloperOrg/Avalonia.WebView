using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSMutableOrderedSet", true)]
public class NSMutableOrderedSet : NSOrderedSet
{
	private static readonly IntPtr selInitWithObject_Handle = Selector.GetHandle("initWithObject:");

	private static readonly IntPtr selInitWithSet_Handle = Selector.GetHandle("initWithSet:");

	private static readonly IntPtr selInitWithOrderedSet_Handle = Selector.GetHandle("initWithOrderedSet:");

	private static readonly IntPtr selInitWithCapacity_Handle = Selector.GetHandle("initWithCapacity:");

	private static readonly IntPtr selInitWithArray_Handle = Selector.GetHandle("initWithArray:");

	private static readonly IntPtr selUnionSet_Handle = Selector.GetHandle("unionSet:");

	private static readonly IntPtr selMinusSet_Handle = Selector.GetHandle("minusSet:");

	private static readonly IntPtr selInsertObjectAtIndex_Handle = Selector.GetHandle("insertObject:atIndex:");

	private static readonly IntPtr selRemoveObjectAtIndex_Handle = Selector.GetHandle("removeObjectAtIndex:");

	private static readonly IntPtr selReplaceObjectAtIndexWithObject_Handle = Selector.GetHandle("replaceObjectAtIndex:withObject:");

	private static readonly IntPtr selAddObject_Handle = Selector.GetHandle("addObject:");

	private static readonly IntPtr selAddObjectsFromArray_Handle = Selector.GetHandle("addObjectsFromArray:");

	private static readonly IntPtr selInsertObjectsAtIndexes_Handle = Selector.GetHandle("insertObjects:atIndexes:");

	private static readonly IntPtr selRemoveObjectsAtIndexes_Handle = Selector.GetHandle("removeObjectsAtIndexes:");

	private static readonly IntPtr selExchangeObjectAtIndexWithObjectAtIndex_Handle = Selector.GetHandle("exchangeObjectAtIndex:withObjectAtIndex:");

	private static readonly IntPtr selMoveObjectsAtIndexesToIndex_Handle = Selector.GetHandle("moveObjectsAtIndexes:toIndex:");

	private static readonly IntPtr selSetObjectAtIndex_Handle = Selector.GetHandle("setObject:atIndex:");

	private static readonly IntPtr selReplaceObjectsAtIndexesWithObjects_Handle = Selector.GetHandle("replaceObjectsAtIndexes:withObjects:");

	private static readonly IntPtr selRemoveObjectsInRange_Handle = Selector.GetHandle("removeObjectsInRange:");

	private static readonly IntPtr selRemoveAllObjectsHandle = Selector.GetHandle("removeAllObjects");

	private static readonly IntPtr selRemoveObject_Handle = Selector.GetHandle("removeObject:");

	private static readonly IntPtr selRemoveObjectsInArray_Handle = Selector.GetHandle("removeObjectsInArray:");

	private static readonly IntPtr selIntersectOrderedSet_Handle = Selector.GetHandle("intersectOrderedSet:");

	private static readonly IntPtr selSortUsingComparator_Handle = Selector.GetHandle("sortUsingComparator:");

	private static readonly IntPtr selSortWithOptionsUsingComparator_Handle = Selector.GetHandle("sortWithOptions:usingComparator:");

	private static readonly IntPtr selSortRangeOptionsUsingComparator_Handle = Selector.GetHandle("sortRange:options:usingComparator:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSMutableOrderedSet");

	public new NSObject this[int idx]
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

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSMutableOrderedSet()
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
	public NSMutableOrderedSet(NSCoder coder)
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
	public NSMutableOrderedSet(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSMutableOrderedSet(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithObject:")]
	public NSMutableOrderedSet(NSObject start)
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

	[Export("initWithSet:")]
	public NSMutableOrderedSet(NSSet source)
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
	public NSMutableOrderedSet(NSOrderedSet source)
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

	[Export("initWithCapacity:")]
	public NSMutableOrderedSet(int capacity)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_int(base.Handle, selInitWithCapacity_Handle, capacity);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_int(base.SuperHandle, selInitWithCapacity_Handle, capacity);
		}
	}

	[Export("initWithArray:")]
	internal NSMutableOrderedSet(NSArray array)
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

	[Export("unionSet:")]
	internal virtual void UnionSet(NSSet other)
	{
		if (other == null)
		{
			throw new ArgumentNullException("other");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selUnionSet_Handle, other.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selUnionSet_Handle, other.Handle);
		}
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

	[Export("insertObject:atIndex:")]
	public virtual void Insert(NSObject obj, int atIndex)
	{
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_int(base.Handle, selInsertObjectAtIndex_Handle, obj.Handle, atIndex);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_int(base.SuperHandle, selInsertObjectAtIndex_Handle, obj.Handle, atIndex);
		}
	}

	[Export("removeObjectAtIndex:")]
	public virtual void Remove(int index)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_int(base.Handle, selRemoveObjectAtIndex_Handle, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selRemoveObjectAtIndex_Handle, index);
		}
	}

	[Export("replaceObjectAtIndex:withObject:")]
	public virtual void Replace(int objectAtIndex, NSObject newObject)
	{
		if (newObject == null)
		{
			throw new ArgumentNullException("newObject");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_int_IntPtr(base.Handle, selReplaceObjectAtIndexWithObject_Handle, objectAtIndex, newObject.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_int_IntPtr(base.SuperHandle, selReplaceObjectAtIndexWithObject_Handle, objectAtIndex, newObject.Handle);
		}
	}

	[Export("addObject:")]
	public virtual void Add(NSObject obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddObject_Handle, obj.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddObject_Handle, obj.Handle);
		}
	}

	[Export("addObjectsFromArray:")]
	public virtual void AddObjects(NSObject[] source)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		NSArray nSArray = NSArray.FromNSObjects(source);
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

	[Export("insertObjects:atIndexes:")]
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
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selInsertObjectsAtIndexes_Handle, nSArray.Handle, atIndexes.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInsertObjectsAtIndexes_Handle, nSArray.Handle, atIndexes.Handle);
		}
		nSArray.Dispose();
	}

	[Export("removeObjectsAtIndexes:")]
	public virtual void RemoveObjects(NSIndexSet indexSet)
	{
		if (indexSet == null)
		{
			throw new ArgumentNullException("indexSet");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveObjectsAtIndexes_Handle, indexSet.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveObjectsAtIndexes_Handle, indexSet.Handle);
		}
	}

	[Export("exchangeObjectAtIndex:withObjectAtIndex:")]
	public virtual void ExchangeObject(int first, int second)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_int_int(base.Handle, selExchangeObjectAtIndexWithObjectAtIndex_Handle, first, second);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_int_int(base.SuperHandle, selExchangeObjectAtIndexWithObjectAtIndex_Handle, first, second);
		}
	}

	[Export("moveObjectsAtIndexes:toIndex:")]
	public virtual void MoveObjects(NSIndexSet indexSet, int destination)
	{
		if (indexSet == null)
		{
			throw new ArgumentNullException("indexSet");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_int(base.Handle, selMoveObjectsAtIndexesToIndex_Handle, indexSet.Handle, destination);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_int(base.SuperHandle, selMoveObjectsAtIndexesToIndex_Handle, indexSet.Handle, destination);
		}
	}

	[Export("setObject:atIndex:")]
	public virtual void SetObject(NSObject obj, int index)
	{
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_int(base.Handle, selSetObjectAtIndex_Handle, obj.Handle, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_int(base.SuperHandle, selSetObjectAtIndex_Handle, obj.Handle, index);
		}
	}

	[Export("replaceObjectsAtIndexes:withObjects:")]
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
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selReplaceObjectsAtIndexesWithObjects_Handle, indexSet.Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selReplaceObjectsAtIndexesWithObjects_Handle, indexSet.Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[Export("removeObjectsInRange:")]
	public virtual void RemoveObjects(NSRange range)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_NSRange(base.Handle, selRemoveObjectsInRange_Handle, range);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_NSRange(base.SuperHandle, selRemoveObjectsInRange_Handle, range);
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

	[Export("removeObject:")]
	public virtual void RemoveObject(NSObject obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveObject_Handle, obj.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveObject_Handle, obj.Handle);
		}
	}

	[Export("removeObjectsInArray:")]
	public virtual void RemoveObjects(NSObject[] objects)
	{
		if (objects == null)
		{
			throw new ArgumentNullException("objects");
		}
		NSArray nSArray = NSArray.FromNSObjects(objects);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveObjectsInArray_Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveObjectsInArray_Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[Export("intersectOrderedSet:")]
	public virtual void Intersect(NSOrderedSet intersectWith)
	{
		if (intersectWith == null)
		{
			throw new ArgumentNullException("intersectWith");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selIntersectOrderedSet_Handle, intersectWith.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selIntersectOrderedSet_Handle, intersectWith.Handle);
		}
	}

	[Export("sortUsingComparator:")]
	public unsafe virtual void Sort(NSComparator comparator)
	{
		if (comparator == null)
		{
			throw new ArgumentNullException("comparator");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlock(Trampolines.SDNSComparator.Handler, comparator);
		if (IsDirectBinding)
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
	public unsafe virtual void Sort(NSSortOptions sortOptions, NSComparator comparator)
	{
		if (comparator == null)
		{
			throw new ArgumentNullException("comparator");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlock(Trampolines.SDNSComparator.Handler, comparator);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt64_IntPtr(base.Handle, selSortWithOptionsUsingComparator_Handle, (ulong)sortOptions, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt64_IntPtr(base.SuperHandle, selSortWithOptionsUsingComparator_Handle, (ulong)sortOptions, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("sortRange:options:usingComparator:")]
	public unsafe virtual void SortRange(NSRange range, NSSortOptions sortOptions, NSComparator comparator)
	{
		if (comparator == null)
		{
			throw new ArgumentNullException("comparator");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlock(Trampolines.SDNSComparator.Handler, comparator);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_NSRange_UInt64_IntPtr(base.Handle, selSortRangeOptionsUsingComparator_Handle, range, (ulong)sortOptions, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_NSRange_UInt64_IntPtr(base.SuperHandle, selSortRangeOptionsUsingComparator_Handle, range, (ulong)sortOptions, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}
}
