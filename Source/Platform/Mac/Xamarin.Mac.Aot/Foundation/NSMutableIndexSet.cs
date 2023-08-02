using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSMutableIndexSet", true)]
public class NSMutableIndexSet : NSIndexSet
{
	private static readonly IntPtr selInitWithIndex_Handle = Selector.GetHandle("initWithIndex:");

	private static readonly IntPtr selInitWithIndexSet_Handle = Selector.GetHandle("initWithIndexSet:");

	private static readonly IntPtr selAddIndexes_Handle = Selector.GetHandle("addIndexes:");

	private static readonly IntPtr selRemoveIndexes_Handle = Selector.GetHandle("removeIndexes:");

	private static readonly IntPtr selRemoveAllIndexesHandle = Selector.GetHandle("removeAllIndexes");

	private static readonly IntPtr selAddIndex_Handle = Selector.GetHandle("addIndex:");

	private static readonly IntPtr selRemoveIndex_Handle = Selector.GetHandle("removeIndex:");

	private static readonly IntPtr selShiftIndexesStartingAtIndexBy_Handle = Selector.GetHandle("shiftIndexesStartingAtIndex:by:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSMutableIndexSet");

	public override IntPtr ClassHandle => class_ptr;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSMutableIndexSet()
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
	public NSMutableIndexSet(NSCoder coder)
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
	public NSMutableIndexSet(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSMutableIndexSet(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithIndex:")]
	public NSMutableIndexSet(ulong index)
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
	public NSMutableIndexSet(NSIndexSet other)
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

	[Export("addIndexes:")]
	public virtual void Add(NSIndexSet other)
	{
		if (other == null)
		{
			throw new ArgumentNullException("other");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddIndexes_Handle, other.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddIndexes_Handle, other.Handle);
		}
	}

	[Export("removeIndexes:")]
	public virtual void Remove(NSIndexSet other)
	{
		if (other == null)
		{
			throw new ArgumentNullException("other");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveIndexes_Handle, other.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveIndexes_Handle, other.Handle);
		}
	}

	[Export("removeAllIndexes")]
	public virtual void Clear()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRemoveAllIndexesHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRemoveAllIndexesHandle);
		}
	}

	[Export("addIndex:")]
	public virtual void Add(ulong index)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt64(base.Handle, selAddIndex_Handle, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selAddIndex_Handle, index);
		}
	}

	[Export("removeIndex:")]
	public virtual void Remove(ulong index)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt64(base.Handle, selRemoveIndex_Handle, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selRemoveIndex_Handle, index);
		}
	}

	[Export("shiftIndexesStartingAtIndex:by:")]
	public virtual void ShiftIndexes(ulong startIndex, long delta)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt64_Int64(base.Handle, selShiftIndexesStartingAtIndexBy_Handle, startIndex, delta);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt64_Int64(base.SuperHandle, selShiftIndexesStartingAtIndexBy_Handle, startIndex, delta);
		}
	}
}
