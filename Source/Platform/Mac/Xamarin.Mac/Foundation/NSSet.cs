using ObjCRuntime;
using System.Collections;
using System.ComponentModel;

namespace Foundation;

[Register("NSSet", true)]
public class NSSet : NSObject, IEnumerable<NSObject>, IEnumerable, INSCoding, INativeObject, IDisposable, INSCopying, INSMutableCopying, INSSecureCoding
{
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selAllObjects = "allObjects";

    private static readonly IntPtr selAllObjectsHandle = Selector.GetHandle("allObjects");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selAnyObject = "anyObject";

    private static readonly IntPtr selAnyObjectHandle = Selector.GetHandle("anyObject");

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
    private const string selEnumerateObjectsUsingBlock_ = "enumerateObjectsUsingBlock:";

    private static readonly IntPtr selEnumerateObjectsUsingBlock_Handle = Selector.GetHandle("enumerateObjectsUsingBlock:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selInitWithArray_ = "initWithArray:";

    private static readonly IntPtr selInitWithArray_Handle = Selector.GetHandle("initWithArray:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selInitWithCoder_ = "initWithCoder:";

    private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selInitWithSet_ = "initWithSet:";

    private static readonly IntPtr selInitWithSet_Handle = Selector.GetHandle("initWithSet:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selIntersectsSet_ = "intersectsSet:";

    private static readonly IntPtr selIntersectsSet_Handle = Selector.GetHandle("intersectsSet:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selIsEqualToSet_ = "isEqualToSet:";

    private static readonly IntPtr selIsEqualToSet_Handle = Selector.GetHandle("isEqualToSet:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selIsSubsetOfSet_ = "isSubsetOfSet:";

    private static readonly IntPtr selIsSubsetOfSet_Handle = Selector.GetHandle("isSubsetOfSet:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selMember_ = "member:";

    private static readonly IntPtr selMember_Handle = Selector.GetHandle("member:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selMutableCopyWithZone_ = "mutableCopyWithZone:";

    private static readonly IntPtr selMutableCopyWithZone_Handle = Selector.GetHandle("mutableCopyWithZone:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selObjectEnumerator = "objectEnumerator";

    private static readonly IntPtr selObjectEnumeratorHandle = Selector.GetHandle("objectEnumerator");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selSet = "set";

    private static readonly IntPtr selSetHandle = Selector.GetHandle("set");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selSetByAddingObjectsFromSet_ = "setByAddingObjectsFromSet:";

    private static readonly IntPtr selSetByAddingObjectsFromSet_Handle = Selector.GetHandle("setByAddingObjectsFromSet:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selSetWithArray_ = "setWithArray:";

    private static readonly IntPtr selSetWithArray_Handle = Selector.GetHandle("setWithArray:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSSet");

    public override IntPtr ClassHandle => class_ptr;

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual NSObject AnyObject
    {
        [Export("anyObject")]
        get
        {
            if (base.IsDirectBinding)
            {
                return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAnyObjectHandle));
            }
            return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAnyObjectHandle));
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual nuint Count
    {
        [Export("count")]
        get
        {
            if (base.IsDirectBinding)
            {
                return Messaging.nuint_objc_msgSend(base.Handle, selCountHandle);
            }
            return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selCountHandle);
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    internal IntPtr _AnyObject
    {
        get
        {
            if (base.IsDirectBinding)
            {
                return Messaging.IntPtr_objc_msgSend(base.Handle, selAnyObjectHandle);
            }
            return Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAnyObjectHandle);
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

    public T[] ToArray<T>() where T : class, INativeObject
    {
        IntPtr intPtr = _AllObjects();
        return NSArray.ArrayFromHandle<T>(intPtr);
    }

    public static NSSet MakeNSObjectSet<T>(T[] values) where T : class, INativeObject
    {
        using NSArray nSArray = NSArray.FromNSObjects(values);
        return Runtime.GetNSObject<NSSet>(_SetWithArray(nSArray.Handle));
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
        return ((IEnumerable<NSObject>)this).GetEnumerator();
    }

    public static NSSet operator +(NSSet first, NSSet second)
    {
        if (first == null)
        {
            return new NSSet(second);
        }
        if (second == null)
        {
            return new NSSet(first);
        }
        return first.SetByAddingObjectsFromSet(second);
    }

    public static NSSet operator +(NSSet first, NSOrderedSet second)
    {
        if (first == null)
        {
            return new NSSet(second.AsSet());
        }
        if (second == null)
        {
            return new NSSet(first);
        }
        NSMutableSet nSMutableSet = new NSMutableSet(first);
        nSMutableSet.UnionSet(second.AsSet());
        return nSMutableSet;
    }

    public static NSSet operator -(NSSet first, NSSet second)
    {
        if (first == null)
        {
            return null;
        }
        if (second == null)
        {
            return new NSSet(first);
        }
        NSMutableSet nSMutableSet = new NSMutableSet(first);
        nSMutableSet.MinusSet(second);
        return nSMutableSet;
    }

    public static NSSet operator -(NSSet first, NSOrderedSet second)
    {
        if (first == null)
        {
            return null;
        }
        if (second == null)
        {
            return new NSSet(first);
        }
        NSMutableSet nSMutableSet = new NSMutableSet(first);
        nSMutableSet.MinusSet(second.AsSet());
        return nSMutableSet;
    }

    public bool Contains(object obj)
    {
        return Contains(NSObject.FromObject(obj));
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    [DesignatedInitializer]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [Export("init")]
    public NSSet()
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
    public NSSet(NSCoder coder)
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
    protected NSSet(NSObjectFlag t)
        : base(t)
    {
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected internal NSSet(IntPtr handle)
        : base(handle)
    {
    }

    [Export("initWithSet:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public NSSet(NSSet other)
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

    [Export("initWithArray:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public NSSet(NSArray other)
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

    [Export("containsObject:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual bool Contains(NSObject id)
    {
        if (id == null)
        {
            throw new ArgumentNullException("id");
        }
        if (base.IsDirectBinding)
        {
            return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selContainsObject_Handle, id.Handle);
        }
        return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selContainsObject_Handle, id.Handle);
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

    [Export("set")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public static NSSet CreateSet()
    {
        return Runtime.GetNSObject<NSSet>(Messaging.IntPtr_objc_msgSend(class_ptr, selSetHandle));
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

    [Export("enumerateObjectsUsingBlock:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public unsafe virtual void Enumerate([BlockProxy(typeof(Trampolines.NIDNSSetEnumerator))] NSSetEnumerator enumerator)
    {
        if (enumerator == null)
        {
            throw new ArgumentNullException("enumerator");
        }
        BlockLiteral blockLiteral = default(BlockLiteral);
        BlockLiteral* ptr = &blockLiteral;
        blockLiteral.SetupBlockUnsafe(Trampolines.SDNSSetEnumerator.Handler, enumerator);
        if (base.IsDirectBinding)
        {
            Messaging.void_objc_msgSend_IntPtr(base.Handle, selEnumerateObjectsUsingBlock_Handle, (IntPtr)ptr);
        }
        else
        {
            Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEnumerateObjectsUsingBlock_Handle, (IntPtr)ptr);
        }
        ptr->CleanupBlock();
    }

    [Export("intersectsSet:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual bool IntersectsSet(NSSet other)
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

    [Export("isEqualToSet:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual bool IsEqualToSet(NSSet other)
    {
        if (other == null)
        {
            throw new ArgumentNullException("other");
        }
        if (base.IsDirectBinding)
        {
            return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIsEqualToSet_Handle, other.Handle);
        }
        return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIsEqualToSet_Handle, other.Handle);
    }

    [Export("isSubsetOfSet:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual bool IsSubsetOf(NSSet other)
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

    [Export("member:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual NSObject LookupMember(NSObject probe)
    {
        if (probe == null)
        {
            throw new ArgumentNullException("probe");
        }
        if (base.IsDirectBinding)
        {
            return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selMember_Handle, probe.Handle));
        }
        return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selMember_Handle, probe.Handle));
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

    [Export("setByAddingObjectsFromSet:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    internal virtual NSSet SetByAddingObjectsFromSet(NSSet other)
    {
        if (other == null)
        {
            throw new ArgumentNullException("other");
        }
        if (base.IsDirectBinding)
        {
            return Runtime.GetNSObject<NSSet>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selSetByAddingObjectsFromSet_Handle, other.Handle));
        }
        return Runtime.GetNSObject<NSSet>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetByAddingObjectsFromSet_Handle, other.Handle));
    }

    [Export("allObjects")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    internal virtual IntPtr _AllObjects()
    {
        if (base.IsDirectBinding)
        {
            return Messaging.IntPtr_objc_msgSend(base.Handle, selAllObjectsHandle);
        }
        return Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAllObjectsHandle);
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    internal bool _Contains(IntPtr id)
    {
        return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selContainsObject_Handle, id);
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
    internal IntPtr _LookupMember(IntPtr probe)
    {
        return Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selMember_Handle, probe);
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    internal IntPtr _SetByAddingObjectsFromSet(IntPtr other)
    {
        return Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selSetByAddingObjectsFromSet_Handle, other);
    }

    [Export("setWithArray:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    internal static IntPtr _SetWithArray(IntPtr array)
    {
        return Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selSetWithArray_Handle, array);
    }
}
[Register("NSSet", SkipRegistration = true)]
public sealed class NSSet<TKey> : NSSet, IEnumerable<TKey>, IEnumerable where TKey : class, INativeObject
{
    public new TKey AnyObject => Runtime.GetINativeObject<TKey>(base._AnyObject, owns: false);

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
