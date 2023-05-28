using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace Foundation;

[Register("NSMutableSet", true)]
public class NSMutableSet : NSSet, IEnumerable<NSObject>, IEnumerable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddObject_ = "addObject:";

	private static readonly IntPtr selAddObject_Handle = Selector.GetHandle("addObject:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddObjectsFromArray_ = "addObjectsFromArray:";

	private static readonly IntPtr selAddObjectsFromArray_Handle = Selector.GetHandle("addObjectsFromArray:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithArray_ = "initWithArray:";

	private static readonly IntPtr selInitWithArray_Handle = Selector.GetHandle("initWithArray:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCapacity_ = "initWithCapacity:";

	private static readonly IntPtr selInitWithCapacity_Handle = Selector.GetHandle("initWithCapacity:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSet_ = "initWithSet:";

	private static readonly IntPtr selInitWithSet_Handle = Selector.GetHandle("initWithSet:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMinusSet_ = "minusSet:";

	private static readonly IntPtr selMinusSet_Handle = Selector.GetHandle("minusSet:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveAllObjects = "removeAllObjects";

	private static readonly IntPtr selRemoveAllObjectsHandle = Selector.GetHandle("removeAllObjects");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveObject_ = "removeObject:";

	private static readonly IntPtr selRemoveObject_Handle = Selector.GetHandle("removeObject:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnionSet_ = "unionSet:";

	private static readonly IntPtr selUnionSet_Handle = Selector.GetHandle("unionSet:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSMutableSet");

	public override IntPtr ClassHandle => class_ptr;

	public NSMutableSet(params NSObject[] objs)
		: this(NSArray.FromNSObjects(objs))
	{
	}

	public NSMutableSet(params string[] strings)
		: this(NSArray.FromStrings(strings))
	{
	}

	internal NSMutableSet(params INativeObject[] objs)
		: this(NSArray.FromNSObjects(objs))
	{
	}

	public static NSMutableSet operator +(NSMutableSet first, NSMutableSet second)
	{
		if (first == null || first.Count == (byte)0)
		{
			return new NSMutableSet(second);
		}
		if (second == null || second.Count == (byte)0)
		{
			return new NSMutableSet(first);
		}
		NSMutableSet nSMutableSet = new NSMutableSet(first);
		nSMutableSet.UnionSet(second);
		return nSMutableSet;
	}

	public static NSMutableSet operator -(NSMutableSet first, NSMutableSet second)
	{
		if (first == null || first.Count == (byte)0)
		{
			return null;
		}
		if (second == null || second.Count == (byte)0)
		{
			return new NSMutableSet(first);
		}
		NSMutableSet nSMutableSet = new NSMutableSet(first);
		nSMutableSet.MinusSet(second);
		return nSMutableSet;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSMutableSet()
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
	public NSMutableSet(NSCoder coder)
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
	protected NSMutableSet(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSMutableSet(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithArray:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSMutableSet(NSArray other)
		: base(NSObjectFlag.Empty)
	{
		if (other == null)
		{
			throw new ArgumentNullException("other");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithArray_Handle, other.Handle), "initWithArray:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithArray_Handle, other.Handle), "initWithArray:");
		}
	}

	[Export("initWithSet:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSMutableSet(NSSet other)
		: base(NSObjectFlag.Empty)
	{
		if (other == null)
		{
			throw new ArgumentNullException("other");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithSet_Handle, other.Handle), "initWithSet:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithSet_Handle, other.Handle), "initWithSet:");
		}
	}

	[Export("initWithCapacity:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSMutableSet(nint capacity)
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

	[Export("addObject:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Add(NSObject nso)
	{
		if (nso == null)
		{
			throw new ArgumentNullException("nso");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddObject_Handle, nso.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddObject_Handle, nso.Handle);
		}
	}

	[Export("addObjectsFromArray:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddObjects(NSObject[] objects)
	{
		if (objects == null)
		{
			throw new ArgumentNullException("objects");
		}
		NSArray nSArray = NSArray.FromNSObjects(objects);
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

	[Export("removeObject:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Remove(NSObject nso)
	{
		if (nso == null)
		{
			throw new ArgumentNullException("nso");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveObject_Handle, nso.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveObject_Handle, nso.Handle);
		}
	}

	[Export("removeAllObjects")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveAll()
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal void _Add(IntPtr obj)
	{
		Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddObject_Handle, obj);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal void _AddObjects(IntPtr objects)
	{
		Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddObjectsFromArray_Handle, objects);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal void _Remove(IntPtr nso)
	{
		Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveObject_Handle, nso);
	}
}
[Register("NSMutableSet", SkipRegistration = true)]
public sealed class NSMutableSet<TKey> : NSMutableSet, IEnumerable<TKey>, IEnumerable where TKey : class, INativeObject
{
	public new TKey AnyObject => Runtime.GetINativeObject<TKey>(base._AnyObject, owns: false);

	public NSMutableSet()
	{
	}

	public NSMutableSet(NSCoder coder)
		: base(coder)
	{
	}

	internal NSMutableSet(IntPtr handle)
		: base(handle)
	{
	}

	public NSMutableSet(params TKey[] objs)
		: base(objs)
	{
	}

	public NSMutableSet(NSSet<TKey> other)
		: base(other)
	{
	}

	public NSMutableSet(NSMutableSet<TKey> other)
		: base(other)
	{
	}

	public NSMutableSet(nint capacity)
		: base(capacity)
	{
	}

	public TKey LookupMember(TKey probe)
	{
		if (probe == null)
		{
			throw new ArgumentNullException("probe");
		}
		return Runtime.GetINativeObject<TKey>(_LookupMember(probe.Handle), owns: false);
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
		return ToArray<TKey>();
	}

	public static NSMutableSet<TKey>operator +(NSMutableSet<TKey> first, NSMutableSet<TKey> second)
	{
		if (first == null || first.Count == (byte)0)
		{
			return new NSMutableSet<TKey>(second);
		}
		if (second == null || second.Count == (byte)0)
		{
			return new NSMutableSet<TKey>(first);
		}
		return new NSMutableSet<TKey>(first._SetByAddingObjectsFromSet(second.Handle));
	}

	public static NSMutableSet<TKey>operator -(NSMutableSet<TKey> first, NSMutableSet<TKey> second)
	{
		if (first == null || first.Count == (byte)0)
		{
			return null;
		}
		if (second == null || second.Count == (byte)0)
		{
			return new NSMutableSet<TKey>(first);
		}
		NSMutableSet<TKey> nSMutableSet = new NSMutableSet<TKey>(first);
		nSMutableSet.MinusSet(second);
		return nSMutableSet;
	}

	public void Add(TKey obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		_Add(obj.Handle);
	}

	public void Remove(TKey obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		_Remove(obj.Handle);
	}

	public void AddObjects(params TKey[] objects)
	{
		if (objects == null)
		{
			throw new ArgumentNullException("objects");
		}
		for (int i = 0; i < objects.Length; i++)
		{
			if (objects[i] == null)
			{
				throw new ArgumentNullException("objects[" + i + "]");
			}
		}
		using NSArray nSArray = NSArray.From(objects, -1L);
		_AddObjects(nSArray.Handle);
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
