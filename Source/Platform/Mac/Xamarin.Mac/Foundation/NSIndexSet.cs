using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSIndexSet", true)]
public class NSIndexSet : NSObject, IEnumerable, IEnumerable<nuint>, INSCoding, INativeObject, IDisposable, INSCopying, INSMutableCopying, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContainsIndex_ = "containsIndex:";

	private static readonly IntPtr selContainsIndex_Handle = Selector.GetHandle("containsIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContainsIndexes_ = "containsIndexes:";

	private static readonly IntPtr selContainsIndexes_Handle = Selector.GetHandle("containsIndexes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCount = "count";

	private static readonly IntPtr selCountHandle = Selector.GetHandle("count");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEnumerateIndexesInRange_Options_UsingBlock_ = "enumerateIndexesInRange:options:usingBlock:";

	private static readonly IntPtr selEnumerateIndexesInRange_Options_UsingBlock_Handle = Selector.GetHandle("enumerateIndexesInRange:options:usingBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEnumerateIndexesUsingBlock_ = "enumerateIndexesUsingBlock:";

	private static readonly IntPtr selEnumerateIndexesUsingBlock_Handle = Selector.GetHandle("enumerateIndexesUsingBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEnumerateIndexesWithOptions_UsingBlock_ = "enumerateIndexesWithOptions:usingBlock:";

	private static readonly IntPtr selEnumerateIndexesWithOptions_UsingBlock_Handle = Selector.GetHandle("enumerateIndexesWithOptions:usingBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEnumerateRangesInRange_Options_UsingBlock_ = "enumerateRangesInRange:options:usingBlock:";

	private static readonly IntPtr selEnumerateRangesInRange_Options_UsingBlock_Handle = Selector.GetHandle("enumerateRangesInRange:options:usingBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEnumerateRangesUsingBlock_ = "enumerateRangesUsingBlock:";

	private static readonly IntPtr selEnumerateRangesUsingBlock_Handle = Selector.GetHandle("enumerateRangesUsingBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEnumerateRangesWithOptions_UsingBlock_ = "enumerateRangesWithOptions:usingBlock:";

	private static readonly IntPtr selEnumerateRangesWithOptions_UsingBlock_Handle = Selector.GetHandle("enumerateRangesWithOptions:usingBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFirstIndex = "firstIndex";

	private static readonly IntPtr selFirstIndexHandle = Selector.GetHandle("firstIndex");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIndexGreaterThanIndex_ = "indexGreaterThanIndex:";

	private static readonly IntPtr selIndexGreaterThanIndex_Handle = Selector.GetHandle("indexGreaterThanIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIndexGreaterThanOrEqualToIndex_ = "indexGreaterThanOrEqualToIndex:";

	private static readonly IntPtr selIndexGreaterThanOrEqualToIndex_Handle = Selector.GetHandle("indexGreaterThanOrEqualToIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIndexLessThanIndex_ = "indexLessThanIndex:";

	private static readonly IntPtr selIndexLessThanIndex_Handle = Selector.GetHandle("indexLessThanIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIndexLessThanOrEqualToIndex_ = "indexLessThanOrEqualToIndex:";

	private static readonly IntPtr selIndexLessThanOrEqualToIndex_Handle = Selector.GetHandle("indexLessThanOrEqualToIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIndexSetWithIndex_ = "indexSetWithIndex:";

	private static readonly IntPtr selIndexSetWithIndex_Handle = Selector.GetHandle("indexSetWithIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIndexSetWithIndexesInRange_ = "indexSetWithIndexesInRange:";

	private static readonly IntPtr selIndexSetWithIndexesInRange_Handle = Selector.GetHandle("indexSetWithIndexesInRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithIndex_ = "initWithIndex:";

	private static readonly IntPtr selInitWithIndex_Handle = Selector.GetHandle("initWithIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithIndexSet_ = "initWithIndexSet:";

	private static readonly IntPtr selInitWithIndexSet_Handle = Selector.GetHandle("initWithIndexSet:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsEqualToIndexSet_ = "isEqualToIndexSet:";

	private static readonly IntPtr selIsEqualToIndexSet_Handle = Selector.GetHandle("isEqualToIndexSet:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLastIndex = "lastIndex";

	private static readonly IntPtr selLastIndexHandle = Selector.GetHandle("lastIndex");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMutableCopyWithZone_ = "mutableCopyWithZone:";

	private static readonly IntPtr selMutableCopyWithZone_Handle = Selector.GetHandle("mutableCopyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSIndexSet");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint Count
	{
		[Export("count")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selCountHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selCountHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint FirstIndex
	{
		[Export("firstIndex")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selFirstIndexHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selFirstIndexHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint LastIndex
	{
		[Export("lastIndex")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selLastIndexHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selLastIndexHandle);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		if (!(Count == 0))
		{
			nuint i = FirstIndex;
			while (i <= LastIndex)
			{
				yield return i;
				i = IndexGreaterThan(i);
			}
		}
	}

	public IEnumerator<nuint> GetEnumerator()
	{
		if (!(Count == 0))
		{
			nuint i = FirstIndex;
			while (i <= LastIndex)
			{
				yield return i;
				i = IndexGreaterThan(i);
			}
		}
	}

	public nuint[] ToArray()
	{
		nuint[] array = new nuint[(long)Count];
		if (Count == 0)
		{
			return array;
		}
		int num = 0;
		nuint nuint = FirstIndex;
		while (nuint <= LastIndex)
		{
			array[num++] = nuint;
			nuint = IndexGreaterThan(nuint);
		}
		return array;
	}

	public static NSIndexSet FromArray(nuint[] items)
	{
		if (items == null)
		{
			return new NSIndexSet();
		}
		NSMutableIndexSet nSMutableIndexSet = new NSMutableIndexSet();
		foreach (nuint index in items)
		{
			nSMutableIndexSet.Add(index);
		}
		return nSMutableIndexSet;
	}

	public static NSIndexSet FromArray(uint[] items)
	{
		if (items == null)
		{
			return new NSIndexSet();
		}
		NSMutableIndexSet nSMutableIndexSet = new NSMutableIndexSet();
		foreach (uint num in items)
		{
			nSMutableIndexSet.Add(num);
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

	public NSIndexSet(uint value)
		: this((nuint)value)
	{
	}

	public NSIndexSet(nint value)
		: this((nuint)value)
	{
		if (value < 0)
		{
			throw new ArgumentException("value must be positive");
		}
	}

	public NSIndexSet(int value)
		: this((nuint)(uint)value)
	{
		if (value < 0)
		{
			throw new ArgumentException("value must be positive");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSIndexSet()
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
	public NSIndexSet(NSCoder coder)
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
	protected NSIndexSet(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSIndexSet(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSIndexSet(nuint index)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_nuint(base.Handle, selInitWithIndex_Handle, index), "initWithIndex:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_nuint(base.SuperHandle, selInitWithIndex_Handle, index), "initWithIndex:");
		}
	}

	[Export("initWithIndexSet:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSIndexSet(NSIndexSet other)
		: base(NSObjectFlag.Empty)
	{
		if (other == null)
		{
			throw new ArgumentNullException("other");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithIndexSet_Handle, other.Handle), "initWithIndexSet:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithIndexSet_Handle, other.Handle), "initWithIndexSet:");
		}
	}

	[Export("containsIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Contains(nuint index)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_nuint(base.Handle, selContainsIndex_Handle, index);
		}
		return Messaging.bool_objc_msgSendSuper_nuint(base.SuperHandle, selContainsIndex_Handle, index);
	}

	[Export("containsIndexes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Contains(NSIndexSet indexes)
	{
		if (indexes == null)
		{
			throw new ArgumentNullException("indexes");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selContainsIndexes_Handle, indexes.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selContainsIndexes_Handle, indexes.Handle);
	}

	[Export("copyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual NSObject Copy(NSZone? zone)
	{
		NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeTo(NSCoder encoder)
	{
		if (encoder == null)
		{
			throw new ArgumentNullException("encoder");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEncodeWithCoder_Handle, encoder.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEncodeWithCoder_Handle, encoder.Handle);
		}
	}

	[Export("enumerateIndexesUsingBlock:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void EnumerateIndexes([BlockProxy(typeof(Trampolines.NIDEnumerateIndexSetCallback))] EnumerateIndexSetCallback enumeratorCallback)
	{
		if (enumeratorCallback == null)
		{
			throw new ArgumentNullException("enumeratorCallback");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDEnumerateIndexSetCallback.Handler, enumeratorCallback);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEnumerateIndexesUsingBlock_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEnumerateIndexesUsingBlock_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("enumerateIndexesWithOptions:usingBlock:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void EnumerateIndexes(NSEnumerationOptions opts, [BlockProxy(typeof(Trampolines.NIDEnumerateIndexSetCallback))] EnumerateIndexSetCallback enumeratorCallback)
	{
		if (enumeratorCallback == null)
		{
			throw new ArgumentNullException("enumeratorCallback");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDEnumerateIndexSetCallback.Handler, enumeratorCallback);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt64_IntPtr(base.Handle, selEnumerateIndexesWithOptions_UsingBlock_Handle, (ulong)opts, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt64_IntPtr(base.SuperHandle, selEnumerateIndexesWithOptions_UsingBlock_Handle, (ulong)opts, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("enumerateIndexesInRange:options:usingBlock:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void EnumerateIndexes(NSRange range, NSEnumerationOptions opts, [BlockProxy(typeof(Trampolines.NIDEnumerateIndexSetCallback))] EnumerateIndexSetCallback enumeratorCallback)
	{
		if (enumeratorCallback == null)
		{
			throw new ArgumentNullException("enumeratorCallback");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDEnumerateIndexSetCallback.Handler, enumeratorCallback);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_NSRange_UInt64_IntPtr(base.Handle, selEnumerateIndexesInRange_Options_UsingBlock_Handle, range, (ulong)opts, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_NSRange_UInt64_IntPtr(base.SuperHandle, selEnumerateIndexesInRange_Options_UsingBlock_Handle, range, (ulong)opts, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("enumerateRangesUsingBlock:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void EnumerateRanges([BlockProxy(typeof(Trampolines.NIDNSRangeIterator))] NSRangeIterator iterator)
	{
		if (iterator == null)
		{
			throw new ArgumentNullException("iterator");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDNSRangeIterator.Handler, iterator);
		if (base.IsDirectBinding)
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
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void EnumerateRanges(NSEnumerationOptions opts, [BlockProxy(typeof(Trampolines.NIDNSRangeIterator))] NSRangeIterator iterator)
	{
		if (iterator == null)
		{
			throw new ArgumentNullException("iterator");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDNSRangeIterator.Handler, iterator);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt64_IntPtr(base.Handle, selEnumerateRangesWithOptions_UsingBlock_Handle, (ulong)opts, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt64_IntPtr(base.SuperHandle, selEnumerateRangesWithOptions_UsingBlock_Handle, (ulong)opts, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("enumerateRangesInRange:options:usingBlock:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void EnumerateRanges(NSRange range, NSEnumerationOptions opts, [BlockProxy(typeof(Trampolines.NIDNSRangeIterator))] NSRangeIterator iterator)
	{
		if (iterator == null)
		{
			throw new ArgumentNullException("iterator");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDNSRangeIterator.Handler, iterator);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_NSRange_UInt64_IntPtr(base.Handle, selEnumerateRangesInRange_Options_UsingBlock_Handle, range, (ulong)opts, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_NSRange_UInt64_IntPtr(base.SuperHandle, selEnumerateRangesInRange_Options_UsingBlock_Handle, range, (ulong)opts, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("indexSetWithIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSIndexSet FromIndex(nint idx)
	{
		return Runtime.GetNSObject<NSIndexSet>(Messaging.IntPtr_objc_msgSend_nint(class_ptr, selIndexSetWithIndex_Handle, idx));
	}

	[Export("indexSetWithIndexesInRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSIndexSet FromNSRange(NSRange indexRange)
	{
		return Runtime.GetNSObject<NSIndexSet>(Messaging.IntPtr_objc_msgSend_NSRange(class_ptr, selIndexSetWithIndexesInRange_Handle, indexRange));
	}

	[Export("indexGreaterThanIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint IndexGreaterThan(nuint index)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.nuint_objc_msgSend_nuint(base.Handle, selIndexGreaterThanIndex_Handle, index);
		}
		return Messaging.nuint_objc_msgSendSuper_nuint(base.SuperHandle, selIndexGreaterThanIndex_Handle, index);
	}

	[Export("indexGreaterThanOrEqualToIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint IndexGreaterThanOrEqual(nuint index)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.nuint_objc_msgSend_nuint(base.Handle, selIndexGreaterThanOrEqualToIndex_Handle, index);
		}
		return Messaging.nuint_objc_msgSendSuper_nuint(base.SuperHandle, selIndexGreaterThanOrEqualToIndex_Handle, index);
	}

	[Export("indexLessThanIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint IndexLessThan(nuint index)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.nuint_objc_msgSend_nuint(base.Handle, selIndexLessThanIndex_Handle, index);
		}
		return Messaging.nuint_objc_msgSendSuper_nuint(base.SuperHandle, selIndexLessThanIndex_Handle, index);
	}

	[Export("indexLessThanOrEqualToIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint IndexLessThanOrEqual(nuint index)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.nuint_objc_msgSend_nuint(base.Handle, selIndexLessThanOrEqualToIndex_Handle, index);
		}
		return Messaging.nuint_objc_msgSendSuper_nuint(base.SuperHandle, selIndexLessThanOrEqualToIndex_Handle, index);
	}

	[Export("isEqualToIndexSet:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsEqual(NSIndexSet other)
	{
		if (other == null)
		{
			throw new ArgumentNullException("other");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIsEqualToIndexSet_Handle, other.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIsEqualToIndexSet_Handle, other.Handle);
	}

	[Export("mutableCopyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual NSObject MutableCopy(NSZone? zone)
	{
		NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selMutableCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selMutableCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}
}
