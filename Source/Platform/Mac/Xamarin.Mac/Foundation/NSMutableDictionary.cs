using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSMutableDictionary", true)]
public class NSMutableDictionary : NSDictionary, IDictionary, ICollection, IEnumerable, IDictionary<NSObject, NSObject>, ICollection<KeyValuePair<NSObject, NSObject>>, IEnumerable<KeyValuePair<NSObject, NSObject>>
{
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selAddEntriesFromDictionary_ = "addEntriesFromDictionary:";

    private static readonly IntPtr selAddEntriesFromDictionary_Handle = Selector.GetHandle("addEntriesFromDictionary:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selDictionaryWithContentsOfFile_ = "dictionaryWithContentsOfFile:";

    private static readonly IntPtr selDictionaryWithContentsOfFile_Handle = Selector.GetHandle("dictionaryWithContentsOfFile:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selDictionaryWithContentsOfURL_ = "dictionaryWithContentsOfURL:";

    private static readonly IntPtr selDictionaryWithContentsOfURL_Handle = Selector.GetHandle("dictionaryWithContentsOfURL:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selDictionaryWithDictionary_ = "dictionaryWithDictionary:";

    private static readonly IntPtr selDictionaryWithDictionary_Handle = Selector.GetHandle("dictionaryWithDictionary:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selDictionaryWithObject_ForKey_ = "dictionaryWithObject:forKey:";

    private static readonly IntPtr selDictionaryWithObject_ForKey_Handle = Selector.GetHandle("dictionaryWithObject:forKey:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selDictionaryWithObjects_ForKeys_ = "dictionaryWithObjects:forKeys:";

    private static readonly IntPtr selDictionaryWithObjects_ForKeys_Handle = Selector.GetHandle("dictionaryWithObjects:forKeys:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selDictionaryWithObjects_ForKeys_Count_ = "dictionaryWithObjects:forKeys:count:";

    private static readonly IntPtr selDictionaryWithObjects_ForKeys_Count_Handle = Selector.GetHandle("dictionaryWithObjects:forKeys:count:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selDictionaryWithSharedKeySet_ = "dictionaryWithSharedKeySet:";

    private static readonly IntPtr selDictionaryWithSharedKeySet_Handle = Selector.GetHandle("dictionaryWithSharedKeySet:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selInitWithContentsOfFile_ = "initWithContentsOfFile:";

    private static readonly IntPtr selInitWithContentsOfFile_Handle = Selector.GetHandle("initWithContentsOfFile:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selInitWithContentsOfURL_ = "initWithContentsOfURL:";

    private static readonly IntPtr selInitWithContentsOfURL_Handle = Selector.GetHandle("initWithContentsOfURL:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selInitWithDictionary_ = "initWithDictionary:";

    private static readonly IntPtr selInitWithDictionary_Handle = Selector.GetHandle("initWithDictionary:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selInitWithDictionary_CopyItems_ = "initWithDictionary:copyItems:";

    private static readonly IntPtr selInitWithDictionary_CopyItems_Handle = Selector.GetHandle("initWithDictionary:copyItems:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selInitWithObjects_ForKeys_ = "initWithObjects:forKeys:";

    private static readonly IntPtr selInitWithObjects_ForKeys_Handle = Selector.GetHandle("initWithObjects:forKeys:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selRemoveAllObjects = "removeAllObjects";

    private static readonly IntPtr selRemoveAllObjectsHandle = Selector.GetHandle("removeAllObjects");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selRemoveObjectForKey_ = "removeObjectForKey:";

    private static readonly IntPtr selRemoveObjectForKey_Handle = Selector.GetHandle("removeObjectForKey:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selSetObject_ForKey_ = "setObject:forKey:";

    private static readonly IntPtr selSetObject_ForKey_Handle = Selector.GetHandle("setObject:forKey:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSMutableDictionary");

    int ICollection<KeyValuePair<NSObject, NSObject>>.Count => (int)Count;

    bool ICollection<KeyValuePair<NSObject, NSObject>>.IsReadOnly => false;

    bool IDictionary.IsFixedSize => false;

    bool IDictionary.IsReadOnly => false;

    object IDictionary.this[object key]
    {
        get
        {
            if (!(key is INativeObject nativeObject))
            {
                return null;
            }
            return _ObjectForKey(nativeObject.Handle);
        }
        set
        {
            INativeObject nativeObject = key as INativeObject;
            INativeObject nativeObject2 = value as INativeObject;
            if (nativeObject == null || nativeObject2 == null)
            {
                throw new ArgumentException("You can only use INativeObjects for keys and values in an NSMutableDictionary");
            }
            _SetObject(nativeObject2.Handle, nativeObject.Handle);
        }
    }

    ICollection IDictionary.Keys => Keys;

    ICollection IDictionary.Values => Values;

    public override NSObject this[NSObject key]
    {
        get
        {
            return ObjectForKey(key);
        }
        set
        {
            SetObject(value, key);
        }
    }

    public override NSObject this[NSString key]
    {
        get
        {
            return ObjectForKey(key);
        }
        set
        {
            SetObject(value, key);
        }
    }

    public override NSObject this[string key]
    {
        get
        {
            if (key == null)
            {
                throw new ArgumentNullException("key");
            }
            IntPtr key2 = NSString.CreateNative(key, autorelease: false);
            try
            {
                return Runtime.GetNSObject(LowlevelObjectForKey(key2));
            }
            finally
            {
                NSString.ReleaseNative(key2);
            }
        }
        set
        {
            if (key == null)
            {
                throw new ArgumentNullException("key");
            }
            IntPtr key2 = NSString.CreateNative(key, autorelease: false);
            try
            {
                LowlevelSetObject(value, key2);
            }
            finally
            {
                NSString.ReleaseNative(key2);
            }
        }
    }

    ICollection<NSObject> IDictionary<NSObject, NSObject>.Keys => Keys;

    ICollection<NSObject> IDictionary<NSObject, NSObject>.Values => Values;

    public override IntPtr ClassHandle => class_ptr;

    internal NSMutableDictionary(IntPtr handle, bool owns)
        : base(handle)
    {
        if (!owns)
        {
            DangerousRelease();
        }
    }

    public new static NSMutableDictionary FromObjectsAndKeys(NSObject[] objects, NSObject[] keys)
    {
        if (objects == null)
        {
            throw new ArgumentNullException("objects");
        }
        if (keys == null)
        {
            throw new ArgumentNullException("keys");
        }
        if (objects.Length != keys.Length)
        {
            throw new ArgumentException("objects and keys arrays have different sizes");
        }
        using NSArray objects2 = NSArray.FromNSObjects(objects);
        using NSArray keys2 = NSArray.FromNSObjects(keys);
        return FromObjectsAndKeysInternal(objects2, keys2);
    }

    public new static NSMutableDictionary FromObjectsAndKeys(object[] objects, object[] keys)
    {
        if (objects == null)
        {
            throw new ArgumentNullException("objects");
        }
        if (keys == null)
        {
            throw new ArgumentNullException("keys");
        }
        if (objects.Length != keys.Length)
        {
            throw new ArgumentException("objects and keys arrays have different sizes");
        }
        using NSArray objects2 = NSArray.FromObjects(objects);
        using NSArray keys2 = NSArray.FromObjects(keys);
        return FromObjectsAndKeysInternal(objects2, keys2);
    }

    public new static NSMutableDictionary FromObjectsAndKeys(NSObject[] objects, NSObject[] keys, nint count)
    {
        if (objects == null)
        {
            throw new ArgumentNullException("objects");
        }
        if (keys == null)
        {
            throw new ArgumentNullException("keys");
        }
        if (objects.Length != keys.Length)
        {
            throw new ArgumentException("objects and keys arrays have different sizes");
        }
        if (count < 1 || objects.Length < count || keys.Length < count)
        {
            throw new ArgumentException("count");
        }
        using NSArray objects2 = NSArray.FromNSObjects(objects);
        using NSArray keys2 = NSArray.FromNSObjects(keys);
        return FromObjectsAndKeysInternal(objects2, keys2);
    }

    public new static NSMutableDictionary FromObjectsAndKeys(object[] objects, object[] keys, nint count)
    {
        if (objects == null)
        {
            throw new ArgumentNullException("objects");
        }
        if (keys == null)
        {
            throw new ArgumentNullException("keys");
        }
        if (objects.Length != keys.Length)
        {
            throw new ArgumentException("objects and keys arrays have different sizes");
        }
        if (count < 1 || objects.Length < count || keys.Length < count)
        {
            throw new ArgumentException("count");
        }
        using NSArray objects2 = NSArray.FromObjects(objects);
        using NSArray keys2 = NSArray.FromObjects(keys);
        return FromObjectsAndKeysInternal(objects2, keys2);
    }

    void ICollection<KeyValuePair<NSObject, NSObject>>.Add(KeyValuePair<NSObject, NSObject> item)
    {
        SetObject(item.Value, item.Key);
    }

    public void Clear()
    {
        RemoveAllObjects();
    }

    bool ICollection<KeyValuePair<NSObject, NSObject>>.Contains(KeyValuePair<NSObject, NSObject> keyValuePair)
    {
        return ContainsKeyValuePair(keyValuePair);
    }

    void ICollection<KeyValuePair<NSObject, NSObject>>.CopyTo(KeyValuePair<NSObject, NSObject>[] array, int index)
    {
        if (array == null)
        {
            throw new ArgumentNullException("array");
        }
        if (index < 0)
        {
            throw new ArgumentOutOfRangeException("index");
        }
        if (index > array.Length)
        {
            throw new ArgumentException("index larger than largest valid index of array");
        }
        if (array.Length - index < (int)Count)
        {
            throw new ArgumentException("Destination array cannot hold the requested elements!");
        }
        IEnumerator<KeyValuePair<NSObject, NSObject>> enumerator = GetEnumerator();
        while (enumerator.MoveNext())
        {
            array[index++] = enumerator.Current;
        }
    }

    bool ICollection<KeyValuePair<NSObject, NSObject>>.Remove(KeyValuePair<NSObject, NSObject> keyValuePair)
    {
        nuint count = Count;
        RemoveObjectForKey(keyValuePair.Key);
        return count != Count;
    }

    void IDictionary.Add(object key, object value)
    {
        NSObject nSObject = key as NSObject;
        NSObject nSObject2 = value as NSObject;
        if (nSObject == null || nSObject2 == null)
        {
            throw new ArgumentException("You can only use NSObjects for keys and values in an NSMutableDictionary");
        }
        SetObject(nSObject2, nSObject);
    }

    bool IDictionary.Contains(object key)
    {
        if (key == null)
        {
            throw new ArgumentNullException("key");
        }
        if (!(key is INativeObject nativeObject))
        {
            return false;
        }
        return ContainsKey(nativeObject.Handle);
    }

    IDictionaryEnumerator IDictionary.GetEnumerator()
    {
        return (IDictionaryEnumerator)((IEnumerable<KeyValuePair<NSObject, NSObject>>)this).GetEnumerator();
    }

    void IDictionary.Remove(object key)
    {
        if (key == null)
        {
            throw new ArgumentNullException("key");
        }
        if (!(key is INativeObject nativeObject))
        {
            throw new ArgumentException("The key must be an INativeObject");
        }
        _RemoveObjectForKey(nativeObject.Handle);
    }

    public void Add(NSObject key, NSObject value)
    {
        SetObject(value, key);
    }

    public bool Remove(NSObject key)
    {
        if (key == null)
        {
            throw new ArgumentNullException("key");
        }
        nuint count = Count;
        RemoveObjectForKey(key);
        return count != Count;
    }

    public new bool TryGetValue(NSObject key, out NSObject value)
    {
        return (value = ObjectForKey(key)) != null;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return ((IEnumerable<KeyValuePair<NSObject, NSObject>>)this).GetEnumerator();
    }

    public new IEnumerator<KeyValuePair<NSObject, NSObject>> GetEnumerator()
    {
        NSObject[] keys = Keys;
        foreach (NSObject key in keys)
        {
            yield return new KeyValuePair<NSObject, NSObject>(key, ObjectForKey(key));
        }
    }

    public static NSMutableDictionary LowlevelFromObjectAndKey(IntPtr obj, IntPtr key)
    {
        return (NSMutableDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selDictionaryWithObject_ForKey_Handle, obj, key));
    }

    public void LowlevelSetObject(IntPtr obj, IntPtr key)
    {
        Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetObject_ForKey_Handle, obj, key);
    }

    public void LowlevelSetObject(NSObject obj, IntPtr key)
    {
        if (obj == null)
        {
            throw new ArgumentNullException("obj");
        }
        Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetObject_ForKey_Handle, obj.Handle, key);
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    [DesignatedInitializer]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [Export("init")]
    public NSMutableDictionary()
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
    public NSMutableDictionary(NSCoder coder)
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
    protected NSMutableDictionary(NSObjectFlag t)
        : base(t)
    {
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected internal NSMutableDictionary(IntPtr handle)
        : base(handle)
    {
    }

    [Export("initWithDictionary:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public NSMutableDictionary(NSDictionary other)
        : base(NSObjectFlag.Empty)
    {
        if (other == null)
        {
            throw new ArgumentNullException("other");
        }
        if (base.IsDirectBinding)
        {
            InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithDictionary_Handle, other.Handle), "initWithDictionary:");
        }
        else
        {
            InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithDictionary_Handle, other.Handle), "initWithDictionary:");
        }
    }

    [Export("initWithDictionary:copyItems:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public NSMutableDictionary(NSDictionary other, bool copyItems)
        : base(NSObjectFlag.Empty)
    {
        if (other == null)
        {
            throw new ArgumentNullException("other");
        }
        if (base.IsDirectBinding)
        {
            InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_bool(base.Handle, selInitWithDictionary_CopyItems_Handle, other.Handle, copyItems), "initWithDictionary:copyItems:");
        }
        else
        {
            InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_bool(base.SuperHandle, selInitWithDictionary_CopyItems_Handle, other.Handle, copyItems), "initWithDictionary:copyItems:");
        }
    }

    [Export("initWithContentsOfFile:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public NSMutableDictionary(string fileName)
        : base(NSObjectFlag.Empty)
    {
        if (fileName == null)
        {
            throw new ArgumentNullException("fileName");
        }
        IntPtr arg = NSString.CreateNative(fileName);
        if (base.IsDirectBinding)
        {
            InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithContentsOfFile_Handle, arg), "initWithContentsOfFile:");
        }
        else
        {
            InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithContentsOfFile_Handle, arg), "initWithContentsOfFile:");
        }
        NSString.ReleaseNative(arg);
    }

    [Export("initWithContentsOfURL:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public NSMutableDictionary(NSUrl url)
        : base(NSObjectFlag.Empty)
    {
        if (url == null)
        {
            throw new ArgumentNullException("url");
        }
        if (base.IsDirectBinding)
        {
            InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithContentsOfURL_Handle, url.Handle), "initWithContentsOfURL:");
        }
        else
        {
            InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithContentsOfURL_Handle, url.Handle), "initWithContentsOfURL:");
        }
    }

    [Export("initWithObjects:forKeys:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    internal NSMutableDictionary(NSArray objects, NSArray keys)
        : base(NSObjectFlag.Empty)
    {
        if (objects == null)
        {
            throw new ArgumentNullException("objects");
        }
        if (keys == null)
        {
            throw new ArgumentNullException("keys");
        }
        if (base.IsDirectBinding)
        {
            InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithObjects_ForKeys_Handle, objects.Handle, keys.Handle), "initWithObjects:forKeys:");
        }
        else
        {
            InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithObjects_ForKeys_Handle, objects.Handle, keys.Handle), "initWithObjects:forKeys:");
        }
    }

    [Export("addEntriesFromDictionary:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual void AddEntries(NSDictionary other)
    {
        if (other == null)
        {
            throw new ArgumentNullException("other");
        }
        if (base.IsDirectBinding)
        {
            Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddEntriesFromDictionary_Handle, other.Handle);
        }
        else
        {
            Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddEntriesFromDictionary_Handle, other.Handle);
        }
    }

    [Export("dictionaryWithDictionary:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public new static NSMutableDictionary FromDictionary(NSDictionary source)
    {
        if (source == null)
        {
            throw new ArgumentNullException("source");
        }
        return Runtime.GetNSObject<NSMutableDictionary>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selDictionaryWithDictionary_Handle, source.Handle));
    }

    [Export("dictionaryWithContentsOfFile:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public new static NSMutableDictionary FromFile(string path)
    {
        if (path == null)
        {
            throw new ArgumentNullException("path");
        }
        IntPtr arg = NSString.CreateNative(path);
        NSMutableDictionary nSObject = Runtime.GetNSObject<NSMutableDictionary>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selDictionaryWithContentsOfFile_Handle, arg));
        NSString.ReleaseNative(arg);
        return nSObject;
    }

    [Export("dictionaryWithObject:forKey:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public new static NSMutableDictionary FromObjectAndKey(NSObject obj, NSObject key)
    {
        if (obj == null)
        {
            throw new ArgumentNullException("obj");
        }
        if (key == null)
        {
            throw new ArgumentNullException("key");
        }
        return Runtime.GetNSObject<NSMutableDictionary>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selDictionaryWithObject_ForKey_Handle, obj.Handle, key.Handle));
    }

    [Export("dictionaryWithObjects:forKeys:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    internal new static NSMutableDictionary FromObjectsAndKeysInternal(NSArray objects, NSArray Keys)
    {
        if (objects == null)
        {
            throw new ArgumentNullException("objects");
        }
        if (Keys == null)
        {
            throw new ArgumentNullException("Keys");
        }
        return Runtime.GetNSObject<NSMutableDictionary>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selDictionaryWithObjects_ForKeys_Handle, objects.Handle, Keys.Handle));
    }

    [Export("dictionaryWithObjects:forKeys:count:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    internal static NSMutableDictionary FromObjectsAndKeysInternalCount(NSArray objects, NSArray keys, nint count)
    {
        if (objects == null)
        {
            throw new ArgumentNullException("objects");
        }
        if (keys == null)
        {
            throw new ArgumentNullException("keys");
        }
        return Runtime.GetNSObject<NSMutableDictionary>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_nint(class_ptr, selDictionaryWithObjects_ForKeys_Count_Handle, objects.Handle, keys.Handle, count));
    }

    [Export("dictionaryWithSharedKeySet:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public static NSDictionary FromSharedKeySet(NSObject sharedKeyToken)
    {
        if (sharedKeyToken == null)
        {
            throw new ArgumentNullException("sharedKeyToken");
        }
        return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selDictionaryWithSharedKeySet_Handle, sharedKeyToken.Handle));
    }

    [Export("dictionaryWithContentsOfURL:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public new static NSMutableDictionary FromUrl(NSUrl url)
    {
        if (url == null)
        {
            throw new ArgumentNullException("url");
        }
        return Runtime.GetNSObject<NSMutableDictionary>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selDictionaryWithContentsOfURL_Handle, url.Handle));
    }

    [Export("removeAllObjects")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    internal virtual void RemoveAllObjects()
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

    [Export("removeObjectForKey:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    internal virtual void RemoveObjectForKey(NSObject key)
    {
        if (key == null)
        {
            throw new ArgumentNullException("key");
        }
        if (base.IsDirectBinding)
        {
            Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveObjectForKey_Handle, key.Handle);
        }
        else
        {
            Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveObjectForKey_Handle, key.Handle);
        }
    }

    [Export("setObject:forKey:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    internal virtual void SetObject(NSObject obj, NSObject key)
    {
        if (obj == null)
        {
            throw new ArgumentNullException("obj");
        }
        if (key == null)
        {
            throw new ArgumentNullException("key");
        }
        if (base.IsDirectBinding)
        {
            Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetObject_ForKey_Handle, obj.Handle, key.Handle);
        }
        else
        {
            Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetObject_ForKey_Handle, obj.Handle, key.Handle);
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    internal void _RemoveObjectForKey(IntPtr key)
    {
        Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveObjectForKey_Handle, key);
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    internal void _SetObject(IntPtr obj, IntPtr key)
    {
        Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetObject_ForKey_Handle, obj, key);
    }
}
[Register("NSMutableDictionary", SkipRegistration = true)]
public sealed class NSMutableDictionary<TKey, TValue> : NSMutableDictionary, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable where TKey : class, INativeObject where TValue : class, INativeObject
{
    public new TKey[] Keys
    {
        get
        {
            using (new NSAutoreleasePool())
            {
                return NSArray.ArrayFromHandle<TKey>(_AllKeys());
            }
        }
    }

    public new TValue[] Values
    {
        get
        {
            using (new NSAutoreleasePool())
            {
                return NSArray.ArrayFromHandle<TValue>(_AllValues());
            }
        }
    }

    public TValue this[TKey index]
    {
        get
        {
            return ObjectForKey(index);
        }
        set
        {
            Add(index, value);
        }
    }

    TValue IDictionary<TKey, TValue>.this[TKey index]
    {
        get
        {
            return this[index];
        }
        set
        {
            this[index] = value;
        }
    }

    ICollection<TKey> IDictionary<TKey, TValue>.Keys => Keys;

    ICollection<TValue> IDictionary<TKey, TValue>.Values => Values;

    int ICollection<KeyValuePair<TKey, TValue>>.Count => (int)base.Count;

    bool ICollection<KeyValuePair<TKey, TValue>>.IsReadOnly => false;

    public NSMutableDictionary()
    {
    }

    public NSMutableDictionary(NSCoder coder)
        : base(coder)
    {
    }

    internal NSMutableDictionary(IntPtr handle)
        : base(handle)
    {
    }

    public NSMutableDictionary(NSMutableDictionary<TKey, TValue> other)
        : base(other)
    {
    }

    public NSMutableDictionary(NSDictionary<TKey, TValue> other)
        : base(other)
    {
    }

    private NSMutableDictionary(TKey[] keys, TValue[] values, bool validation)
        : base(NSArray.FromNSObjects(values), NSArray.FromNSObjects(keys))
    {
    }

    public NSMutableDictionary(TKey[] keys, TValue[] values)
        : this(keys, values, NSDictionary<TKey, TValue>.ValidateKeysAndValues(keys, values))
    {
    }

    public NSMutableDictionary(TKey key, TValue value)
        : base(NSArray.FromNSObjects<TValue>(value), NSArray.FromNSObjects<TKey>(key))
    {
    }

    public TValue ObjectForKey(TKey key)
    {
        if (key == null)
        {
            throw new ArgumentNullException("key");
        }
        return Runtime.GetINativeObject<TValue>(_ObjectForKey(key.Handle), owns: false);
    }

    public TKey[] KeysForObject(TValue obj)
    {
        if (obj == null)
        {
            throw new ArgumentNullException("obj");
        }
        using (new NSAutoreleasePool())
        {
            return NSArray.ArrayFromHandle<TKey>(_AllKeysForObject(obj.Handle));
        }
    }

    public TValue[] ObjectsForKeys(TKey[] keys, TValue marker)
    {
        if (keys == null)
        {
            throw new ArgumentNullException("keys");
        }
        if (marker == null)
        {
            throw new ArgumentNullException("marker");
        }
        if (keys.Length == 0)
        {
            return new TValue[0];
        }
        return NSArray.ArrayFromHandle<TValue>(_ObjectsForKeys(NSArray.From(keys, -1L).Handle, marker.Handle));
    }

    public void Add(TKey key, TValue value)
    {
        if (key == null)
        {
            throw new ArgumentNullException("key");
        }
        if (value == null)
        {
            throw new ArgumentNullException("value");
        }
        _SetObject(value.Handle, key.Handle);
    }

    public bool Remove(TKey key)
    {
        if (key == null)
        {
            throw new ArgumentNullException("key");
        }
        nuint count = Count;
        _RemoveObjectForKey(key.Handle);
        return count != Count;
    }

    public bool TryGetValue(TKey key, out TValue value)
    {
        return (value = ObjectForKey(key)) != null;
    }

    public bool ContainsKey(TKey key)
    {
        return ObjectForKey(key) != null;
    }

    private static NSMutableDictionary<TKey, TValue> GenericFromObjectsAndKeysInternal(NSArray objects, NSArray keys)
    {
        return Runtime.GetNSObject<NSMutableDictionary<TKey, TValue>>(NSDictionary._FromObjectsAndKeysInternal(objects.Handle, keys.Handle));
    }

    public static NSMutableDictionary<TKey, TValue> FromObjectsAndKeys(TValue[] objects, TKey[] keys, nint count)
    {
        if (objects == null)
        {
            throw new ArgumentNullException("objects");
        }
        if (keys == null)
        {
            throw new ArgumentNullException("keys");
        }
        if (objects.Length != keys.Length)
        {
            throw new ArgumentException("objects and keys arrays have different sizes");
        }
        if (count < 1 || objects.Length < count)
        {
            throw new ArgumentException("count");
        }
        using NSArray objects2 = NSArray.FromNSObjects(objects);
        using NSArray keys2 = NSArray.FromNSObjects(keys);
        return GenericFromObjectsAndKeysInternal(objects2, keys2);
    }

    [Obsolete("'TKey' and 'TValue' are inversed and won't work unless both types are identical. Use the generic overload that takes a count parameter instead.")]
    public static NSMutableDictionary<TKey, TValue> FromObjectsAndKeys(TKey[] objects, TValue[] keys)
    {
        if (objects == null)
        {
            throw new ArgumentNullException("objects");
        }
        if (keys == null)
        {
            throw new ArgumentNullException("keys");
        }
        if (objects.Length != keys.Length)
        {
            throw new ArgumentException("objects and keys arrays have different sizes");
        }
        using NSArray objects2 = NSArray.FromNSObjects(objects);
        using NSArray keys2 = NSArray.FromNSObjects(keys);
        return GenericFromObjectsAndKeysInternal(objects2, keys2);
    }

    public new static NSMutableDictionary<TKey, TValue> FromObjectsAndKeys(object[] objects, object[] keys)
    {
        if (objects == null)
        {
            throw new ArgumentNullException("objects");
        }
        if (keys == null)
        {
            throw new ArgumentNullException("keys");
        }
        if (objects.Length != keys.Length)
        {
            throw new ArgumentException("objects and keys arrays have different sizes");
        }
        using NSArray objects2 = NSArray.FromObjects(objects);
        using NSArray keys2 = NSArray.FromObjects(keys);
        return GenericFromObjectsAndKeysInternal(objects2, keys2);
    }

    public new static NSMutableDictionary<TKey, TValue> FromObjectsAndKeys(NSObject[] objects, NSObject[] keys, nint count)
    {
        if (objects == null)
        {
            throw new ArgumentNullException("objects");
        }
        if (keys == null)
        {
            throw new ArgumentNullException("keys");
        }
        if (objects.Length != keys.Length)
        {
            throw new ArgumentException("objects and keys arrays have different sizes");
        }
        if (count < 1 || objects.Length < count || keys.Length < count)
        {
            throw new ArgumentException("count");
        }
        using NSArray objects2 = NSArray.FromNSObjects(objects);
        using NSArray keys2 = NSArray.FromNSObjects(keys);
        return GenericFromObjectsAndKeysInternal(objects2, keys2);
    }

    public new static NSMutableDictionary<TKey, TValue> FromObjectsAndKeys(object[] objects, object[] keys, nint count)
    {
        if (objects == null)
        {
            throw new ArgumentNullException("objects");
        }
        if (keys == null)
        {
            throw new ArgumentNullException("keys");
        }
        if (objects.Length != keys.Length)
        {
            throw new ArgumentException("objects and keys arrays have different sizes");
        }
        if (count < 1 || objects.Length < count || keys.Length < count)
        {
            throw new ArgumentException("count");
        }
        using NSArray objects2 = NSArray.FromObjects(objects);
        using NSArray keys2 = NSArray.FromObjects(keys);
        return GenericFromObjectsAndKeysInternal(objects2, keys2);
    }

    void IDictionary<TKey, TValue>.Add(TKey key, TValue value)
    {
        Add(key, value);
    }

    bool IDictionary<TKey, TValue>.Remove(TKey key)
    {
        return Remove(key);
    }

    bool IDictionary<TKey, TValue>.TryGetValue(TKey key, out TValue value)
    {
        return TryGetValue(key, out value);
    }

    bool IDictionary<TKey, TValue>.ContainsKey(TKey key)
    {
        return ContainsKey(key);
    }

    void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> item)
    {
        Add(item.Key, item.Value);
    }

    void ICollection<KeyValuePair<TKey, TValue>>.Clear()
    {
        Clear();
    }

    bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> item)
    {
        if (!TryGetValue(item.Key, out var value))
        {
            return false;
        }
        return value == item.Value;
    }

    void ICollection<KeyValuePair<TKey, TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
    {
        if (array == null)
        {
            throw new ArgumentNullException("array");
        }
        if (arrayIndex < 0)
        {
            throw new ArgumentOutOfRangeException("arrayIndex");
        }
        int num = array.Length;
        if (num > 0 && arrayIndex >= num)
        {
            throw new ArgumentException("arrayIndex is equal to or greater than array.Length");
        }
        if (arrayIndex + (int)Count > num)
        {
            throw new ArgumentException("Not enough room from arrayIndex to end of array for this dictionary");
        }
        int num2 = arrayIndex;
        foreach (KeyValuePair<TKey, TValue> item in (IEnumerable<KeyValuePair<TKey, TValue>>)this)
        {
            array[num2++] = item;
        }
    }

    bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> item)
    {
        if (item.Key == null)
        {
            throw new ArgumentNullException("item.Key");
        }
        if (item.Value == null)
        {
            throw new ArgumentNullException("item.Value");
        }
        if (!TryGetValue(item.Key, out var value))
        {
            return false;
        }
        if (value == item.Value)
        {
            Remove(item.Key);
            return true;
        }
        return false;
    }

    IEnumerator<KeyValuePair<TKey, TValue>> IEnumerable<KeyValuePair<TKey, TValue>>.GetEnumerator()
    {
        TKey[] keys = Keys;
        foreach (TKey key in keys)
        {
            yield return new KeyValuePair<TKey, TValue>(key, ObjectForKey(key));
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return ((IEnumerable<KeyValuePair<TKey, TValue>>)this).GetEnumerator();
    }
}
