using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace Foundation;

[Register("NSOrderedSet", true)]
public class NSOrderedSet : NSObject, IEnumerable<NSObject>, IEnumerable, INSCoding, INativeObject, IDisposable, INSCopying, INSMutableCopying, INSSecureCoding
{
	internal const string selSetWithArray = "orderedSetWithArray:";

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selArray = "array";

	private static readonly IntPtr selArrayHandle = Selector.GetHandle("array");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContainsObject_ = "containsObject:";

	private static readonly IntPtr selContainsObject_Handle = Selector.GetHandle("containsObject:");

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
	private const string selFirstObject = "firstObject";

	private static readonly IntPtr selFirstObjectHandle = Selector.GetHandle("firstObject");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIndexOfObject_ = "indexOfObject:";

	private static readonly IntPtr selIndexOfObject_Handle = Selector.GetHandle("indexOfObject:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithArray_ = "initWithArray:";

	private static readonly IntPtr selInitWithArray_Handle = Selector.GetHandle("initWithArray:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

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
	private const string selIntersectsOrderedSet_ = "intersectsOrderedSet:";

	private static readonly IntPtr selIntersectsOrderedSet_Handle = Selector.GetHandle("intersectsOrderedSet:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIntersectsSet_ = "intersectsSet:";

	private static readonly IntPtr selIntersectsSet_Handle = Selector.GetHandle("intersectsSet:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsEqualToOrderedSet_ = "isEqualToOrderedSet:";

	private static readonly IntPtr selIsEqualToOrderedSet_Handle = Selector.GetHandle("isEqualToOrderedSet:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsSubsetOfOrderedSet_ = "isSubsetOfOrderedSet:";

	private static readonly IntPtr selIsSubsetOfOrderedSet_Handle = Selector.GetHandle("isSubsetOfOrderedSet:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsSubsetOfSet_ = "isSubsetOfSet:";

	private static readonly IntPtr selIsSubsetOfSet_Handle = Selector.GetHandle("isSubsetOfSet:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLastObject = "lastObject";

	private static readonly IntPtr selLastObjectHandle = Selector.GetHandle("lastObject");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMutableCopyWithZone_ = "mutableCopyWithZone:";

	private static readonly IntPtr selMutableCopyWithZone_Handle = Selector.GetHandle("mutableCopyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selObjectAtIndex_ = "objectAtIndex:";

	private static readonly IntPtr selObjectAtIndex_Handle = Selector.GetHandle("objectAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selObjectEnumerator = "objectEnumerator";

	private static readonly IntPtr selObjectEnumeratorHandle = Selector.GetHandle("objectEnumerator");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReversedOrderedSet = "reversedOrderedSet";

	private static readonly IntPtr selReversedOrderedSetHandle = Selector.GetHandle("reversedOrderedSet");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSet = "set";

	private static readonly IntPtr selSetHandle = Selector.GetHandle("set");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSOrderedSet");

	public NSObject this[nint idx] => GetObject(idx);

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

	public NSOrderedSet(params NSObject[] objs)
		: this(NSArray.FromNSObjects(objs))
	{
	}

	public NSOrderedSet(params object[] objs)
		: this(NSArray.FromObjects(objs))
	{
	}

	public NSOrderedSet(params string[] strings)
		: this(NSArray.FromStrings(strings))
	{
	}

	public T[] ToArray<T>() where T : class, INativeObject
	{
		IntPtr intPtr = _ToArray();
		return NSArray.ArrayFromHandle<T>(intPtr);
	}

	public static NSOrderedSet MakeNSOrderedSet<T>(T[] values) where T : NSObject
	{
		NSArray nSArray = NSArray.FromNSObjects(values);
		return (NSOrderedSet)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, Selector.GetHandle("orderedSetWithArray:"), nSArray.Handle));
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

	public static NSOrderedSet operator +(NSOrderedSet first, NSOrderedSet second)
	{
		if (first == null)
		{
			return new NSOrderedSet(second);
		}
		if (second == null)
		{
			return new NSOrderedSet(first);
		}
		NSMutableOrderedSet nSMutableOrderedSet = new NSMutableOrderedSet(first);
		nSMutableOrderedSet.UnionSet(second);
		return nSMutableOrderedSet;
	}

	public static NSOrderedSet operator +(NSOrderedSet first, NSSet second)
	{
		if (first == null)
		{
			return new NSOrderedSet(second);
		}
		if (second == null)
		{
			return new NSOrderedSet(first);
		}
		NSMutableOrderedSet nSMutableOrderedSet = new NSMutableOrderedSet(first);
		nSMutableOrderedSet.UnionSet(second);
		return nSMutableOrderedSet;
	}

	public static NSOrderedSet operator -(NSOrderedSet first, NSOrderedSet second)
	{
		if (first == null)
		{
			return null;
		}
		if (second == null)
		{
			return new NSOrderedSet(first);
		}
		NSMutableOrderedSet nSMutableOrderedSet = new NSMutableOrderedSet(first);
		nSMutableOrderedSet.MinusSet(second);
		return nSMutableOrderedSet;
	}

	public static NSOrderedSet operator -(NSOrderedSet first, NSSet second)
	{
		if (first == null)
		{
			return null;
		}
		if (second == null)
		{
			return new NSOrderedSet(first);
		}
		NSMutableOrderedSet nSMutableOrderedSet = new NSMutableOrderedSet(first);
		nSMutableOrderedSet.MinusSet(second);
		return nSMutableOrderedSet;
	}

	public static bool operator ==(NSOrderedSet first, NSOrderedSet second)
	{
		if ((object)first == null)
		{
			return (object)second == null;
		}
		if ((object)second == null)
		{
			return false;
		}
		return first.IsEqualToOrderedSet(second);
	}

	public static bool operator !=(NSOrderedSet first, NSOrderedSet second)
	{
		if ((object)first == null)
		{
			return (object)second != null;
		}
		if ((object)second == null)
		{
			return true;
		}
		return !first.IsEqualToOrderedSet(second);
	}

	public override bool Equals(object other)
	{
		NSOrderedSet nSOrderedSet = other as NSOrderedSet;
		if (nSOrderedSet == null)
		{
			return false;
		}
		return IsEqualToOrderedSet(nSOrderedSet);
	}

	public override int GetHashCode()
	{
		return (int)GetNativeHash();
	}

	public bool Contains(object obj)
	{
		return Contains(NSObject.FromObject(obj));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSOrderedSet()
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
	public NSOrderedSet(NSCoder coder)
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
	protected NSOrderedSet(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSOrderedSet(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithObject:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSOrderedSet(NSObject start)
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

	[Export("initWithArray:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal NSOrderedSet(NSArray array)
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

	[Export("initWithSet:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSOrderedSet(NSSet source)
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
	public NSOrderedSet(NSOrderedSet source)
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

	[Export("set")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSSet AsSet()
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSSet>(Messaging.IntPtr_objc_msgSend(base.Handle, selSetHandle));
		}
		return Runtime.GetNSObject<NSSet>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSetHandle));
	}

	[Export("containsObject:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Contains(NSObject obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selContainsObject_Handle, obj.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selContainsObject_Handle, obj.Handle);
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

	[Export("firstObject")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject FirstObject()
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selFirstObjectHandle));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFirstObjectHandle));
	}

	[Export("objectAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual NSObject GetObject(nint idx)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_nint(base.Handle, selObjectAtIndex_Handle, idx));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_nint(base.SuperHandle, selObjectAtIndex_Handle, idx));
	}

	[Export("reversedOrderedSet")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSOrderedSet GetReverseOrderedSet()
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSOrderedSet>(Messaging.IntPtr_objc_msgSend(base.Handle, selReversedOrderedSetHandle));
		}
		return Runtime.GetNSObject<NSOrderedSet>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selReversedOrderedSetHandle));
	}

	[Export("indexOfObject:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint IndexOf(NSObject obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.nint_objc_msgSend_IntPtr(base.Handle, selIndexOfObject_Handle, obj.Handle);
		}
		return Messaging.nint_objc_msgSendSuper_IntPtr(base.SuperHandle, selIndexOfObject_Handle, obj.Handle);
	}

	[Export("intersectsOrderedSet:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Intersects(NSOrderedSet other)
	{
		if (other == null)
		{
			throw new ArgumentNullException("other");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIntersectsOrderedSet_Handle, other.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIntersectsOrderedSet_Handle, other.Handle);
	}

	[Export("intersectsSet:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Intersects(NSSet other)
	{
		if (other == null)
		{
			throw new ArgumentNullException("other");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIntersectsSet_Handle, other.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIntersectsSet_Handle, other.Handle);
	}

	[Export("isEqualToOrderedSet:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsEqualToOrderedSet(NSOrderedSet other)
	{
		if (other == null)
		{
			throw new ArgumentNullException("other");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIsEqualToOrderedSet_Handle, other.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIsEqualToOrderedSet_Handle, other.Handle);
	}

	[Export("isSubsetOfOrderedSet:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsSubset(NSOrderedSet other)
	{
		if (other == null)
		{
			throw new ArgumentNullException("other");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIsSubsetOfOrderedSet_Handle, other.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIsSubsetOfOrderedSet_Handle, other.Handle);
	}

	[Export("isSubsetOfSet:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsSubset(NSSet other)
	{
		if (other == null)
		{
			throw new ArgumentNullException("other");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIsSubsetOfSet_Handle, other.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIsSubsetOfSet_Handle, other.Handle);
	}

	[Export("lastObject")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject LastObject()
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selLastObjectHandle));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLastObjectHandle));
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal IntPtr _AsSet()
	{
		return Messaging.IntPtr_objc_msgSend(base.Handle, selSetHandle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal bool _Contains(IntPtr obj)
	{
		return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selContainsObject_Handle, obj);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal IntPtr _FirstObject()
	{
		return Messaging.IntPtr_objc_msgSend(base.Handle, selFirstObjectHandle);
	}

	[Export("objectEnumerator")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual NSEnumerator _GetEnumerator()
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSEnumerator>(Messaging.IntPtr_objc_msgSend(base.Handle, selObjectEnumeratorHandle));
		}
		return Runtime.GetNSObject<NSEnumerator>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selObjectEnumeratorHandle));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal IntPtr _GetObject(nint idx)
	{
		return Messaging.IntPtr_objc_msgSend_nint(base.Handle, selObjectAtIndex_Handle, idx);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal nint _IndexOf(IntPtr obj)
	{
		return Messaging.nint_objc_msgSend_IntPtr(base.Handle, selIndexOfObject_Handle, obj);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal IntPtr _LastObject()
	{
		return Messaging.IntPtr_objc_msgSend(base.Handle, selLastObjectHandle);
	}

	[Export("array")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual IntPtr _ToArray()
	{
		if (base.IsDirectBinding)
		{
			return Messaging.IntPtr_objc_msgSend(base.Handle, selArrayHandle);
		}
		return Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selArrayHandle);
	}
}
[Register("NSOrderedSet", SkipRegistration = true)]
public sealed class NSOrderedSet<TKey> : NSOrderedSet, IEnumerable<TKey>, IEnumerable where TKey : class, INativeObject
{
	public new TKey this[nint idx]
	{
		get
		{
			IntPtr ptr = _GetObject(idx);
			return Runtime.GetINativeObject<TKey>(ptr, owns: false);
		}
	}

	public NSOrderedSet()
	{
	}

	public NSOrderedSet(NSCoder coder)
		: base(coder)
	{
	}

	internal NSOrderedSet(IntPtr handle)
		: base(handle)
	{
	}

	public NSOrderedSet(TKey start)
		: base(start)
	{
	}

	public NSOrderedSet(params TKey[] objs)
		: base(objs)
	{
	}

	public NSOrderedSet(NSSet<TKey> source)
		: base(source)
	{
	}

	public NSOrderedSet(NSOrderedSet<TKey> other)
		: base(other)
	{
	}

	public NSOrderedSet(NSMutableOrderedSet<TKey> other)
		: base(other)
	{
	}

	public TKey[] ToArray()
	{
		return ToArray<TKey>();
	}

	public bool Contains(TKey obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		return _Contains(obj.Handle);
	}

	public nint IndexOf(TKey obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		return _IndexOf(obj.Handle);
	}

	public new TKey FirstObject()
	{
		IntPtr ptr = _FirstObject();
		return Runtime.GetINativeObject<TKey>(ptr, owns: false);
	}

	public new TKey LastObject()
	{
		IntPtr ptr = _LastObject();
		return Runtime.GetINativeObject<TKey>(ptr, owns: false);
	}

	public new NSSet<TKey> AsSet()
	{
		IntPtr ptr = _AsSet();
		return Runtime.GetINativeObject<NSSet<TKey>>(ptr, owns: false);
	}

	IEnumerator<TKey> IEnumerable<TKey>.GetEnumerator()
	{
		return new NSFastEnumerator<TKey>(this);
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return new NSFastEnumerator<TKey>(this);
	}

	public static NSOrderedSet<TKey>operator +(NSOrderedSet<TKey> first, NSOrderedSet<TKey> second)
	{
		if (first == null)
		{
			return (second != null) ? new NSOrderedSet<TKey>(second) : null;
		}
		if (second == null)
		{
			return new NSOrderedSet<TKey>(first);
		}
		NSMutableOrderedSet<TKey> nSMutableOrderedSet = new NSMutableOrderedSet<TKey>(first);
		nSMutableOrderedSet.UnionSet(second);
		return new NSOrderedSet<TKey>(nSMutableOrderedSet);
	}

	public static NSOrderedSet<TKey>operator +(NSOrderedSet<TKey> first, NSSet<TKey> second)
	{
		if (first == null)
		{
			return (second != null) ? new NSOrderedSet<TKey>(second) : null;
		}
		if (second == null)
		{
			return new NSOrderedSet<TKey>(first);
		}
		NSMutableOrderedSet<TKey> nSMutableOrderedSet = new NSMutableOrderedSet<TKey>(first);
		nSMutableOrderedSet.UnionSet(second);
		return new NSOrderedSet<TKey>(nSMutableOrderedSet);
	}

	public static NSOrderedSet<TKey>operator -(NSOrderedSet<TKey> first, NSOrderedSet<TKey> second)
	{
		if (first == null)
		{
			return null;
		}
		if (second == null)
		{
			return new NSOrderedSet<TKey>(first);
		}
		NSMutableOrderedSet<TKey> nSMutableOrderedSet = new NSMutableOrderedSet<TKey>(first);
		nSMutableOrderedSet.MinusSet(second);
		return new NSOrderedSet<TKey>(nSMutableOrderedSet);
	}

	public static NSOrderedSet<TKey>operator -(NSOrderedSet<TKey> first, NSSet<TKey> second)
	{
		if (first == null)
		{
			return null;
		}
		if (second == null)
		{
			return new NSOrderedSet<TKey>(first);
		}
		NSMutableOrderedSet<TKey> nSMutableOrderedSet = new NSMutableOrderedSet<TKey>(first);
		nSMutableOrderedSet.MinusSet(second);
		return new NSOrderedSet<TKey>(nSMutableOrderedSet);
	}

	public static bool operator ==(NSOrderedSet<TKey> first, NSOrderedSet<TKey> second)
	{
		if ((object)first == null)
		{
			return (object)second == null;
		}
		if ((object)second == null)
		{
			return false;
		}
		return first.IsEqualToOrderedSet(second);
	}

	public static bool operator !=(NSOrderedSet<TKey> first, NSOrderedSet<TKey> second)
	{
		if ((object)first == null)
		{
			return (object)second != null;
		}
		if ((object)second == null)
		{
			return true;
		}
		return !first.IsEqualToOrderedSet(second);
	}

	public override bool Equals(object other)
	{
		NSOrderedSet<TKey> nSOrderedSet = other as NSOrderedSet<TKey>;
		if (nSOrderedSet == null)
		{
			return false;
		}
		return IsEqualToOrderedSet(nSOrderedSet);
	}

	public override int GetHashCode()
	{
		return (int)GetNativeHash();
	}
}
