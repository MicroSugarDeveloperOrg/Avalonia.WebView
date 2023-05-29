using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using ObjCRuntime;

namespace Foundation;

[Register("NSIndexPath", true)]
public class NSIndexPath : NSObject
{
	private static readonly IntPtr selLengthHandle = Selector.GetHandle("length");

	private static readonly IntPtr selIndexPathWithIndex_Handle = Selector.GetHandle("indexPathWithIndex:");

	private static readonly IntPtr selIndexPathWithIndexesLength_Handle = Selector.GetHandle("indexPathWithIndexes:length:");

	private static readonly IntPtr selIndexPathByAddingIndex_Handle = Selector.GetHandle("indexPathByAddingIndex:");

	private static readonly IntPtr selIndexPathByRemovingLastIndexHandle = Selector.GetHandle("indexPathByRemovingLastIndex");

	private static readonly IntPtr selIndexAtPosition_Handle = Selector.GetHandle("indexAtPosition:");

	private static readonly IntPtr selGetIndexes_Handle = Selector.GetHandle("getIndexes:");

	private static readonly IntPtr selCompare_Handle = Selector.GetHandle("compare:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSIndexPath");

	public override IntPtr ClassHandle => class_ptr;

	public virtual ulong Length
	{
		[Export("length")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.UInt64_objc_msgSend(base.Handle, selLengthHandle);
			}
			return Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selLengthHandle);
		}
	}

	[Advice("Use NSIndexPath.Create (int[]) instead")]
	public NSIndexPath FromIndexes(uint[] indexes)
	{
		if (indexes == null)
		{
			throw new ArgumentNullException("indexes");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4 * indexes.Length);
		for (int i = 0; i < indexes.Length; i++)
		{
			Marshal.WriteInt32(intPtr, i * 4, (int)indexes[i]);
		}
		NSIndexPath result = _FromIndex(intPtr, (ulong)indexes.Length);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	public static NSIndexPath Create(params int[] indexes)
	{
		if (indexes == null)
		{
			throw new ArgumentNullException("indexes");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4 * indexes.Length);
		for (int i = 0; i < indexes.Length; i++)
		{
			Marshal.WriteInt32(intPtr, i * 4, indexes[i]);
		}
		NSIndexPath result = _FromIndex(intPtr, (ulong)indexes.Length);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	public static NSIndexPath Create(params uint[] indexes)
	{
		if (indexes == null)
		{
			throw new ArgumentNullException("indexes");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4 * indexes.Length);
		for (int i = 0; i < indexes.Length; i++)
		{
			Marshal.WriteInt32(intPtr, i * 4, (int)indexes[i]);
		}
		NSIndexPath result = _FromIndex(intPtr, (ulong)indexes.Length);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	public uint[] GetIndexes()
	{
		int num = (int)Length;
		IntPtr intPtr = Marshal.AllocHGlobal(4 * num);
		uint[] array = new uint[num];
		for (int i = 0; i < num; i++)
		{
			array[i] = (uint)Marshal.ReadInt32(intPtr, i * 4);
		}
		Marshal.FreeHGlobal(intPtr);
		return array;
	}

	public override bool Equals(object obj)
	{
		if (obj == null)
		{
			return false;
		}
		if (!(obj is NSIndexPath other))
		{
			return false;
		}
		return Compare(other) == 0;
	}

	public override int GetHashCode()
	{
		return (int)Length;
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSIndexPath()
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
	public NSIndexPath(NSCoder coder)
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
	public NSIndexPath(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSIndexPath(IntPtr handle)
		: base(handle)
	{
	}

	[Export("indexPathWithIndex:")]
	public static NSIndexPath FromIndex(ulong index)
	{
		return (NSIndexPath)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_UInt64(class_ptr, selIndexPathWithIndex_Handle, index));
	}

	[Export("indexPathWithIndexes:length:")]
	internal static NSIndexPath _FromIndex(IntPtr indexes, ulong len)
	{
		return (NSIndexPath)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_UInt64(class_ptr, selIndexPathWithIndexesLength_Handle, indexes, len));
	}

	[Export("indexPathByAddingIndex:")]
	public virtual NSIndexPath IndexPathByAddingIndex(ulong index)
	{
		if (IsDirectBinding)
		{
			return (NSIndexPath)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_UInt64(base.Handle, selIndexPathByAddingIndex_Handle, index));
		}
		return (NSIndexPath)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_UInt64(base.SuperHandle, selIndexPathByAddingIndex_Handle, index));
	}

	[Export("indexPathByRemovingLastIndex")]
	public virtual NSIndexPath IndexPathByRemovingLastIndex()
	{
		if (IsDirectBinding)
		{
			return (NSIndexPath)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selIndexPathByRemovingLastIndexHandle));
		}
		return (NSIndexPath)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selIndexPathByRemovingLastIndexHandle));
	}

	[Export("indexAtPosition:")]
	public virtual ulong IndexAtPosition(ulong position)
	{
		if (IsDirectBinding)
		{
			return Messaging.UInt64_objc_msgSend_UInt64(base.Handle, selIndexAtPosition_Handle, position);
		}
		return Messaging.UInt64_objc_msgSendSuper_UInt64(base.SuperHandle, selIndexAtPosition_Handle, position);
	}

	[Export("getIndexes:")]
	internal virtual void _GetIndexes(IntPtr target)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selGetIndexes_Handle, target);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selGetIndexes_Handle, target);
		}
	}

	[Export("compare:")]
	public virtual long Compare(NSIndexPath other)
	{
		if (other == null)
		{
			throw new ArgumentNullException("other");
		}
		if (IsDirectBinding)
		{
			return Messaging.Int64_objc_msgSend_IntPtr(base.Handle, selCompare_Handle, other.Handle);
		}
		return Messaging.Int64_objc_msgSendSuper_IntPtr(base.SuperHandle, selCompare_Handle, other.Handle);
	}
}
