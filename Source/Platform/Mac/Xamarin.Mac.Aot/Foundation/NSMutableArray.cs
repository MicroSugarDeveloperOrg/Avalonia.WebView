using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSMutableArray", true)]
public class NSMutableArray : NSArray
{
	private static readonly IntPtr selInitWithCapacity_Handle = Selector.GetHandle("initWithCapacity:");

	private static readonly IntPtr selAddObject_Handle = Selector.GetHandle("addObject:");

	private static readonly IntPtr selInsertObjectAtIndex_Handle = Selector.GetHandle("insertObject:atIndex:");

	private static readonly IntPtr selRemoveLastObjectHandle = Selector.GetHandle("removeLastObject");

	private static readonly IntPtr selRemoveObjectAtIndex_Handle = Selector.GetHandle("removeObjectAtIndex:");

	private static readonly IntPtr selReplaceObjectAtIndexWithObject_Handle = Selector.GetHandle("replaceObjectAtIndex:withObject:");

	private static readonly IntPtr selRemoveAllObjectsHandle = Selector.GetHandle("removeAllObjects");

	private static readonly IntPtr selAddObjectsFromArray_Handle = Selector.GetHandle("addObjectsFromArray:");

	private static readonly IntPtr selInsertObjectsAtIndexes_Handle = Selector.GetHandle("insertObjects:atIndexes:");

	private static readonly IntPtr selRemoveObjectsAtIndexes_Handle = Selector.GetHandle("removeObjectsAtIndexes:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSMutableArray");

	public override IntPtr ClassHandle => class_ptr;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSMutableArray()
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
	public NSMutableArray(NSCoder coder)
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
	public NSMutableArray(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSMutableArray(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithCapacity:")]
	public NSMutableArray(ulong capacity)
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

	[Export("insertObject:atIndex:")]
	public virtual void Insert(NSObject obj, ulong index)
	{
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_UInt64(base.Handle, selInsertObjectAtIndex_Handle, obj.Handle, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_UInt64(base.SuperHandle, selInsertObjectAtIndex_Handle, obj.Handle, index);
		}
	}

	[Export("removeLastObject")]
	public virtual void RemoveLastObject()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRemoveLastObjectHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRemoveLastObjectHandle);
		}
	}

	[Export("removeObjectAtIndex:")]
	public virtual void RemoveObject(ulong index)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt64(base.Handle, selRemoveObjectAtIndex_Handle, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selRemoveObjectAtIndex_Handle, index);
		}
	}

	[Export("replaceObjectAtIndex:withObject:")]
	public virtual void ReplaceObject(ulong index, NSObject withObject)
	{
		if (withObject == null)
		{
			throw new ArgumentNullException("withObject");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt64_IntPtr(base.Handle, selReplaceObjectAtIndexWithObject_Handle, index, withObject.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt64_IntPtr(base.SuperHandle, selReplaceObjectAtIndexWithObject_Handle, index, withObject.Handle);
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
	public virtual void RemoveObjectsAtIndexes(NSIndexSet indexSet)
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
}
