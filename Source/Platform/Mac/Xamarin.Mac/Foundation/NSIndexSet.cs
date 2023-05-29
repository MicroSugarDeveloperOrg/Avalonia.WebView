using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSIndexSet", true)]
public class NSIndexSet : NSObject, IEnumerable, IEnumerable<ulong>
{
	private static readonly IntPtr selCountHandle = Selector.GetHandle("count");

	private static readonly IntPtr selFirstIndexHandle = Selector.GetHandle("firstIndex");

	private static readonly IntPtr selLastIndexHandle = Selector.GetHandle("lastIndex");

	private static readonly IntPtr selIndexSetWithIndex_Handle = Selector.GetHandle("indexSetWithIndex:");

	private static readonly IntPtr selIndexSetWithIndexesInRange_Handle = Selector.GetHandle("indexSetWithIndexesInRange:");

	private static readonly IntPtr selInitWithIndex_Handle = Selector.GetHandle("initWithIndex:");

	private static readonly IntPtr selInitWithIndexSet_Handle = Selector.GetHandle("initWithIndexSet:");

	private static readonly IntPtr selIsEqualToIndexSet_Handle = Selector.GetHandle("isEqualToIndexSet:");

	private static readonly IntPtr selIndexGreaterThanIndex_Handle = Selector.GetHandle("indexGreaterThanIndex:");

	private static readonly IntPtr selIndexLessThanIndex_Handle = Selector.GetHandle("indexLessThanIndex:");

	private static readonly IntPtr selIndexGreaterThanOrEqualToIndex_Handle = Selector.GetHandle("indexGreaterThanOrEqualToIndex:");

	private static readonly IntPtr selIndexLessThanOrEqualToIndex_Handle = Selector.GetHandle("indexLessThanOrEqualToIndex:");

	private static readonly IntPtr selContainsIndex_Handle = Selector.GetHandle("containsIndex:");

	private static readonly IntPtr selContainsIndexes_Handle = Selector.GetHandle("containsIndexes:");

	private static readonly IntPtr selEnumerateRangesUsingBlock_Handle = Selector.GetHandle("enumerateRangesUsingBlock:");

	private static readonly IntPtr selEnumerateRangesWithOptionsUsingBlock_Handle = Selector.GetHandle("enumerateRangesWithOptions:usingBlock:");

	private static readonly IntPtr selEnumerateRangesInRangeOptionsUsingBlock_Handle = Selector.GetHandle("enumerateRangesInRange:options:usingBlock:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSIndexSet");

	public override IntPtr ClassHandle => class_ptr;

	public virtual ulong Count
	{
		[Export("count")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.UInt64_objc_msgSend(base.Handle, selCountHandle);
			}
			return Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selCountHandle);
		}
	}

	public virtual ulong FirstIndex
	{
		[Export("firstIndex")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.UInt64_objc_msgSend(base.Handle, selFirstIndexHandle);
			}
			return Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selFirstIndexHandle);
		}
	}

	public virtual ulong LastIndex
	{
		[Export("lastIndex")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.UInt64_objc_msgSend(base.Handle, selLastIndexHandle);
			}
			return Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selLastIndexHandle);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		for (ulong i = FirstIndex; i <= LastIndex; i = IndexGreaterThan(i))
		{
			yield return i;
		}
	}

	public IEnumerator<ulong> GetEnumerator()
	{
		for (ulong i = FirstIndex; i <= LastIndex; i = IndexGreaterThan(i))
		{
			yield return i;
		}
	}

	public ulong[] ToArray()
	{
		ulong[] array = new ulong[Count];
		int num = 0;
		for (ulong num2 = FirstIndex; num2 <= LastIndex; num2 = IndexGreaterThan(num2))
		{
			array[num++] = num2;
		}
		return array;
	}

	public static NSIndexSet FromArray(ulong[] items)
	{
		if (items == null)
		{
			return new NSIndexSet();
		}
		NSMutableIndexSet nSMutableIndexSet = new NSMutableIndexSet();
		foreach (ulong index in items)
		{
			nSMutableIndexSet.Add(index);
		}
		return nSMutableIndexSet;
	}

	public static NSIndexSet FromArray(int[] items)
	{
		if (items == null)
		{
			return new NSIndexSet();
		}
		NSMutableIndexSet nSMutableIndexSet = new NSMutableIndexSet();
		foreach (int num in items)
		{
			if (num < 0)
			{
				throw new ArgumentException("One of the items values is negative");
			}
			nSMutableIndexSet.Add((uint)num);
		}
		return nSMutableIndexSet;
	}

	public NSIndexSet(int value)
		: this((uint)value)
	{
		if (value < 0)
		{
			throw new ArgumentException("value must be positive");
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSIndexSet()
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
	public NSIndexSet(NSCoder coder)
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
	public NSIndexSet(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSIndexSet(IntPtr handle)
		: base(handle)
	{
	}

	[Export("indexSetWithIndex:")]
	public static NSIndexSet FromIndex(ulong idx)
	{
		return (NSIndexSet)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_UInt64(class_ptr, selIndexSetWithIndex_Handle, idx));
	}

	[Export("indexSetWithIndexesInRange:")]
	public static NSIndexSet FromNSRange(NSRange indexRange)
	{
		return (NSIndexSet)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_NSRange(class_ptr, selIndexSetWithIndexesInRange_Handle, indexRange));
	}

	[Export("initWithIndex:")]
	public NSIndexSet(ulong index)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_UInt64(base.Handle, selInitWithIndex_Handle, index);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_UInt64(base.SuperHandle, selInitWithIndex_Handle, index);
		}
	}

	[Export("initWithIndexSet:")]
	public NSIndexSet(NSIndexSet other)
		: base(NSObjectFlag.Empty)
	{
		if (other == null)
		{
			throw new ArgumentNullException("other");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithIndexSet_Handle, other.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithIndexSet_Handle, other.Handle);
		}
	}

	[Export("isEqualToIndexSet:")]
	public virtual bool IsEqual(NSIndexSet other)
	{
		if (other == null)
		{
			throw new ArgumentNullException("other");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIsEqualToIndexSet_Handle, other.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIsEqualToIndexSet_Handle, other.Handle);
	}

	[Export("indexGreaterThanIndex:")]
	public virtual ulong IndexGreaterThan(ulong index)
	{
		if (IsDirectBinding)
		{
			return Messaging.UInt64_objc_msgSend_UInt64(base.Handle, selIndexGreaterThanIndex_Handle, index);
		}
		return Messaging.UInt64_objc_msgSendSuper_UInt64(base.SuperHandle, selIndexGreaterThanIndex_Handle, index);
	}

	[Export("indexLessThanIndex:")]
	public virtual ulong IndexLessThan(ulong index)
	{
		if (IsDirectBinding)
		{
			return Messaging.UInt64_objc_msgSend_UInt64(base.Handle, selIndexLessThanIndex_Handle, index);
		}
		return Messaging.UInt64_objc_msgSendSuper_UInt64(base.SuperHandle, selIndexLessThanIndex_Handle, index);
	}

	[Export("indexGreaterThanOrEqualToIndex:")]
	public virtual ulong IndexGreaterThanOrEqual(ulong index)
	{
		if (IsDirectBinding)
		{
			return Messaging.UInt64_objc_msgSend_UInt64(base.Handle, selIndexGreaterThanOrEqualToIndex_Handle, index);
		}
		return Messaging.UInt64_objc_msgSendSuper_UInt64(base.SuperHandle, selIndexGreaterThanOrEqualToIndex_Handle, index);
	}

	[Export("indexLessThanOrEqualToIndex:")]
	public virtual ulong IndexLessThanOrEqual(ulong index)
	{
		if (IsDirectBinding)
		{
			return Messaging.UInt64_objc_msgSend_UInt64(base.Handle, selIndexLessThanOrEqualToIndex_Handle, index);
		}
		return Messaging.UInt64_objc_msgSendSuper_UInt64(base.SuperHandle, selIndexLessThanOrEqualToIndex_Handle, index);
	}

	[Export("containsIndex:")]
	public virtual bool Contains(ulong index)
	{
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_UInt64(base.Handle, selContainsIndex_Handle, index);
		}
		return Messaging.bool_objc_msgSendSuper_UInt64(base.SuperHandle, selContainsIndex_Handle, index);
	}

	[Export("containsIndexes:")]
	public virtual bool Contains(NSIndexSet indexes)
	{
		if (indexes == null)
		{
			throw new ArgumentNullException("indexes");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selContainsIndexes_Handle, indexes.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selContainsIndexes_Handle, indexes.Handle);
	}

	[Export("enumerateRangesUsingBlock:")]
	public unsafe virtual void EnumerateRanges(NSRangeIterator iterator)
	{
		if (iterator == null)
		{
			throw new ArgumentNullException("iterator");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlock(Trampolines.SDNSRangeIterator.Handler, iterator);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEnumerateRangesUsingBlock_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEnumerateRangesUsingBlock_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("enumerateRangesWithOptions:usingBlock:")]
	public unsafe virtual void EnumerateRanges(NSEnumerationOptions opts, NSRangeIterator iterator)
	{
		if (iterator == null)
		{
			throw new ArgumentNullException("iterator");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlock(Trampolines.SDNSRangeIterator.Handler, iterator);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt64_IntPtr(base.Handle, selEnumerateRangesWithOptionsUsingBlock_Handle, (ulong)opts, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt64_IntPtr(base.SuperHandle, selEnumerateRangesWithOptionsUsingBlock_Handle, (ulong)opts, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("enumerateRangesInRange:options:usingBlock:")]
	public unsafe virtual void EnumerateRanges(NSRange range, NSEnumerationOptions opts, NSRangeIterator iterator)
	{
		if (iterator == null)
		{
			throw new ArgumentNullException("iterator");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlock(Trampolines.SDNSRangeIterator.Handler, iterator);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_NSRange_UInt64_IntPtr(base.Handle, selEnumerateRangesInRangeOptionsUsingBlock_Handle, range, (ulong)opts, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_NSRange_UInt64_IntPtr(base.SuperHandle, selEnumerateRangesInRangeOptionsUsingBlock_Handle, range, (ulong)opts, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}
}
