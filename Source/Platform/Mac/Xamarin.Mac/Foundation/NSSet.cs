using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSSet", true)]
public class NSSet : NSObject, IEnumerable<NSObject>, IEnumerable
{
	internal const string selSetWithArray = "setWithArray:";

	private static readonly IntPtr selCountHandle = Selector.GetHandle("count");

	private static readonly IntPtr selAnyObjectHandle = Selector.GetHandle("anyObject");

	private static readonly IntPtr selSetHandle = Selector.GetHandle("set");

	private static readonly IntPtr selInitWithSet_Handle = Selector.GetHandle("initWithSet:");

	private static readonly IntPtr selInitWithArray_Handle = Selector.GetHandle("initWithArray:");

	private static readonly IntPtr selContainsObject_Handle = Selector.GetHandle("containsObject:");

	private static readonly IntPtr selAllObjectsHandle = Selector.GetHandle("allObjects");

	private static readonly IntPtr selIsEqualToSet_Handle = Selector.GetHandle("isEqualToSet:");

	private static readonly IntPtr selObjectEnumeratorHandle = Selector.GetHandle("objectEnumerator");

	private static readonly IntPtr selIsSubsetOfSet_Handle = Selector.GetHandle("isSubsetOfSet:");

	private static readonly IntPtr selEnumerateObjectsUsingBlock_Handle = Selector.GetHandle("enumerateObjectsUsingBlock:");

	private static readonly IntPtr selSetByAddingObjectsFromSet_Handle = Selector.GetHandle("setByAddingObjectsFromSet:");

	private static readonly IntPtr selIntersectsSet_Handle = Selector.GetHandle("intersectsSet:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSSet");

	private object __mt_AnyObject_var;

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

	public virtual NSObject AnyObject
	{
		[Export("anyObject")]
		get
		{
			return (NSObject)(__mt_AnyObject_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAnyObjectHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAnyObjectHandle))));
		}
	}

	public NSSet(params NSObject[] objs)
		: this(NSArray.FromNSObjects(objs))
	{
	}

	public NSSet(params object[] objs)
		: this(NSArray.FromObjects(objs))
	{
	}

	public NSSet(params string[] strings)
		: this(NSArray.FromStrings(strings))
	{
	}

	public T[] ToArray<T>() where T : NSObject
	{
		return NSArray.ArrayFromHandle<T>(_AllObjects());
	}

	public static NSSet MakeNSObjectSet<T>(T[] values) where T : NSObject
	{
		NSArray nSArray = NSArray.FromNSObjects(values);
		return (NSSet)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, Selector.GetHandle("setWithArray:"), nSArray.Handle));
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

	public static NSSet operator +(NSSet first, NSSet second)
	{
		if (first == null)
		{
			return second;
		}
		if (second == null)
		{
			return first;
		}
		return first.SetByAddingObjectsFromSet(second);
	}

	public static NSSet operator -(NSSet first, NSSet second)
	{
		if (first == null)
		{
			return null;
		}
		if (second == null)
		{
			return first;
		}
		NSMutableSet nSMutableSet = new NSMutableSet(first);
		nSMutableSet.MinusSet(second);
		return nSMutableSet;
	}

	public bool Contains(object obj)
	{
		return Contains(NSObject.FromObject(obj));
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSSet()
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
	public NSSet(NSCoder coder)
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
	public NSSet(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSSet(IntPtr handle)
		: base(handle)
	{
	}

	[Export("set")]
	public static NSSet CreateSet()
	{
		return (NSSet)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selSetHandle));
	}

	[Export("initWithSet:")]
	public NSSet(NSSet other)
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

	[Export("initWithArray:")]
	public NSSet(NSArray other)
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

	[Export("containsObject:")]
	public virtual bool Contains(NSObject id)
	{
		if (id == null)
		{
			throw new ArgumentNullException("id");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selContainsObject_Handle, id.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selContainsObject_Handle, id.Handle);
	}

	[Export("allObjects")]
	internal virtual IntPtr _AllObjects()
	{
		if (IsDirectBinding)
		{
			return Messaging.IntPtr_objc_msgSend(base.Handle, selAllObjectsHandle);
		}
		return Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAllObjectsHandle);
	}

	[Export("isEqualToSet:")]
	public virtual bool IsEqualToSet(NSSet other)
	{
		if (other == null)
		{
			throw new ArgumentNullException("other");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIsEqualToSet_Handle, other.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIsEqualToSet_Handle, other.Handle);
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

	[Export("isSubsetOfSet:")]
	public virtual bool IsSubsetOf(NSSet other)
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

	[Export("enumerateObjectsUsingBlock:")]
	public unsafe virtual void Enumerate(NSSetEnumerator enumerator)
	{
		if (enumerator == null)
		{
			throw new ArgumentNullException("enumerator");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlock(Trampolines.SDNSSetEnumerator.Handler, enumerator);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEnumerateObjectsUsingBlock_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEnumerateObjectsUsingBlock_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("setByAddingObjectsFromSet:")]
	internal virtual NSSet SetByAddingObjectsFromSet(NSSet other)
	{
		if (other == null)
		{
			throw new ArgumentNullException("other");
		}
		if (IsDirectBinding)
		{
			return (NSSet)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selSetByAddingObjectsFromSet_Handle, other.Handle));
		}
		return (NSSet)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetByAddingObjectsFromSet_Handle, other.Handle));
	}

	[Export("intersectsSet:")]
	public virtual bool IntersectsSet(NSSet other)
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

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_AnyObject_var = null;
		}
	}
}
