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

    #region
    private const string selMember_ = "member:";
    private static readonly IntPtr selMember_Handle = Selector.GetHandle(selMember_);

    private const string selSetWithArray_ = "setWithArray:";
    private static readonly IntPtr selSetWithArray_Handle = Selector.GetHandle(selSetWithArray_);

    #endregion

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
				return Messaging.UInt64_objc_msgSend(Handle, selCountHandle);
			}
			return Messaging.UInt64_objc_msgSendSuper(SuperHandle, selCountHandle);
		}
	}

	public virtual NSObject AnyObject
	{
		[Export("anyObject")]
		get
		{
			return (NSObject)(__mt_AnyObject_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(SuperHandle, selAnyObjectHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(Handle, selAnyObjectHandle))));
		}
	}

    internal IntPtr _AnyObject
    {
        get
        {
            if (IsDirectBinding)
                return Messaging.IntPtr_objc_msgSend(Handle, selAnyObjectHandle);

            return Messaging.IntPtr_objc_msgSendSuper(SuperHandle, selAnyObjectHandle);
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
			Handle = Messaging.IntPtr_objc_msgSend(Handle, Selector.Init);
		}
		else
		{
			Handle = Messaging.IntPtr_objc_msgSendSuper(SuperHandle, Selector.Init);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSSet(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			Handle = Messaging.IntPtr_objc_msgSend_IntPtr(Handle, Selector.InitWithCoder, coder.Handle);
		}
		else
		{
			Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(SuperHandle, Selector.InitWithCoder, coder.Handle);
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
			Handle = Messaging.IntPtr_objc_msgSend_IntPtr(Handle, selInitWithSet_Handle, other.Handle);
		}
		else
		{
			Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(SuperHandle, selInitWithSet_Handle, other.Handle);
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
			Handle = Messaging.IntPtr_objc_msgSend_IntPtr(Handle, selInitWithArray_Handle, other.Handle);
		}
		else
		{
			Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(SuperHandle, selInitWithArray_Handle, other.Handle);
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
			return Messaging.bool_objc_msgSend_IntPtr(Handle, selContainsObject_Handle, id.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(SuperHandle, selContainsObject_Handle, id.Handle);
	}

	[Export("allObjects")]
	internal virtual IntPtr _AllObjects()
	{
		if (IsDirectBinding)
		{
			return Messaging.IntPtr_objc_msgSend(Handle, selAllObjectsHandle);
		}
		return Messaging.IntPtr_objc_msgSendSuper(SuperHandle, selAllObjectsHandle);
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
			return Messaging.bool_objc_msgSend_IntPtr(Handle, selIsEqualToSet_Handle, other.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(SuperHandle, selIsEqualToSet_Handle, other.Handle);
	}

	[Export("objectEnumerator")]
	internal virtual NSEnumerator _GetEnumerator()
	{
		if (IsDirectBinding)
		{
			return (NSEnumerator)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(Handle, selObjectEnumeratorHandle));
		}
		return (NSEnumerator)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(SuperHandle, selObjectEnumeratorHandle));
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
			return Messaging.bool_objc_msgSend_IntPtr(Handle, selIsSubsetOfSet_Handle, other.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(SuperHandle, selIsSubsetOfSet_Handle, other.Handle);
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
			Messaging.void_objc_msgSend_IntPtr(Handle, selEnumerateObjectsUsingBlock_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(SuperHandle, selEnumerateObjectsUsingBlock_Handle, (IntPtr)ptr);
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
			return (NSSet)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(Handle, selSetByAddingObjectsFromSet_Handle, other.Handle));
		}
		return (NSSet)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(SuperHandle, selSetByAddingObjectsFromSet_Handle, other.Handle));
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
			return Messaging.bool_objc_msgSend_IntPtr(Handle, selIntersectsSet_Handle, other.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(SuperHandle, selIntersectsSet_Handle, other.Handle);
	}

    #region

    public T[] ToNativeArray<T>() where T : class, INativeObject
    {
        IntPtr intPtr = _AllObjects();
        return NSArray.ArrayFromNativeHandle<T>(intPtr);
    }

    public static NSSet MakeNativeSet<T>(T[] values) where T : class, INativeObject
    {
        using NSArray nSArray = NSArray.FromNativeObjectsTx(values);
        return Runtime.GetNativeObject<NSSet>(_SetWithArray(nSArray.Handle));
    }

    [Export("setWithArray:")]
    internal static IntPtr _SetWithArray(IntPtr array)
    {
        return Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selSetWithArray_Handle, array);
    }

    internal IntPtr _LookupMember(IntPtr probe)
    {
        return Messaging.IntPtr_objc_msgSend_IntPtr(Handle, selMember_Handle, probe);
    }

    internal bool _Contains(IntPtr id)
    {
        return Messaging.bool_objc_msgSend_IntPtr(Handle, selContainsObject_Handle, id);
    }

    internal IntPtr _SetByAddingObjectsFromSet(IntPtr other)
    {
        return Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selSetByAddingObjectsFromSet_Handle, other);
    }

    #endregion

    protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (Handle == IntPtr.Zero)
		{
			__mt_AnyObject_var = null;
		}
	}
}

[Register("NSSet", SkipRegistration = true)]
public sealed class NSSet<TKey> : NSSet, IEnumerable<TKey>, IEnumerable where TKey : class, INativeObject
{
    public new TKey AnyObject => Runtime.GetNativeObject<TKey>(_AnyObject);

    public NSSet()
    {
    }

    public NSSet(NSCoder coder)
        : base(coder)
    {
    }

    internal NSSet(IntPtr handle)
        : base(handle)
    {
    }

    public NSSet(params TKey[] objs)
        : base(objs)
    {
    }

    public NSSet(NSSet<TKey> other)
        : base(other)
    {
    }

    public NSSet(NSMutableSet<TKey> other)
        : base(other)
    {
    }

    public TKey LookupMember(TKey probe)
    {
        if (probe == null)
            throw new ArgumentNullException("probe");

        return Runtime.GetNativeObject<TKey>(_LookupMember(probe.Handle));
    }

    public bool Contains(TKey obj)
    {
        if (obj == null)
        {
            throw new ArgumentNullException("obj");
        }
        return _Contains(obj.Handle);
    }

    public TKey[] ToArray()
    {
        return ToNativeArray<TKey>();
    }

    public static NSSet<TKey> operator +(NSSet<TKey> first, NSSet<TKey> second)
    {
        if (first == null || first.Count == (byte)0)
        {
            return new NSSet<TKey>(second);
        }
        if (second == null || second.Count == (byte)0)
        {
            return new NSSet<TKey>(first);
        }
        return new NSSet<TKey>(first._SetByAddingObjectsFromSet(second.Handle));
    }

    public static NSSet<TKey> operator -(NSSet<TKey> first, NSSet<TKey> second)
    {
        if (first == null || first.Count == (byte)0)
        {
            return null;
        }
        if (second == null || second.Count == (byte)0)
        {
            return new NSSet<TKey>(first);
        }
        NSMutableSet<TKey> nSMutableSet = new NSMutableSet<TKey>(first);
        nSMutableSet.MinusSet(second);
        return new NSSet<TKey>(nSMutableSet);
    }

    IEnumerator<TKey> IEnumerable<TKey>.GetEnumerator()
    {
        return new NSFastEnumerator<TKey>(this);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return new NSFastEnumerator<TKey>(this);
    }
}
