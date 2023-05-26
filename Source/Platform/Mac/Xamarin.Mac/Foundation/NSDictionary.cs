using CoreData;
using ObjCRuntime;
using System.Collections;
using System.ComponentModel;

namespace Foundation;

[Register("NSDictionary", true)]
public class NSDictionary : NSObject, IDictionary, ICollection, IEnumerable, IDictionary<NSObject, NSObject>, ICollection<KeyValuePair<NSObject, NSObject>>, IEnumerable<KeyValuePair<NSObject, NSObject>>, INSCoding, INativeObject, IDisposable, INSCopying, INSMutableCopying, INSSecureCoding, INSFetchRequestResult
{
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selAllKeys = "allKeys";

    private static readonly IntPtr selAllKeysHandle = Selector.GetHandle("allKeys");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selAllKeysForObject_ = "allKeysForObject:";

    private static readonly IntPtr selAllKeysForObject_Handle = Selector.GetHandle("allKeysForObject:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selAllValues = "allValues";

    private static readonly IntPtr selAllValuesHandle = Selector.GetHandle("allValues");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selCopyWithZone_ = "copyWithZone:";

    private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selCount = "count";

    private static readonly IntPtr selCountHandle = Selector.GetHandle("count");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selDescriptionInStringsFileFormat = "descriptionInStringsFileFormat";

    private static readonly IntPtr selDescriptionInStringsFileFormatHandle = Selector.GetHandle("descriptionInStringsFileFormat");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selDictionaryWithContentsOfFile_ = "dictionaryWithContentsOfFile:";

    private static readonly IntPtr selDictionaryWithContentsOfFile_Handle = Selector.GetHandle("dictionaryWithContentsOfFile:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selDictionaryWithContentsOfURL_ = "dictionaryWithContentsOfURL:";

    private static readonly IntPtr selDictionaryWithContentsOfURL_Handle = Selector.GetHandle("dictionaryWithContentsOfURL:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selDictionaryWithContentsOfURL_Error_ = "dictionaryWithContentsOfURL:error:";

    private static readonly IntPtr selDictionaryWithContentsOfURL_Error_Handle = Selector.GetHandle("dictionaryWithContentsOfURL:error:");

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
    private const string selEncodeWithCoder_ = "encodeWithCoder:";

    private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selInitWithCoder_ = "initWithCoder:";

    private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selInitWithContentsOfFile_ = "initWithContentsOfFile:";

    private static readonly IntPtr selInitWithContentsOfFile_Handle = Selector.GetHandle("initWithContentsOfFile:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selInitWithContentsOfURL_ = "initWithContentsOfURL:";

    private static readonly IntPtr selInitWithContentsOfURL_Handle = Selector.GetHandle("initWithContentsOfURL:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selInitWithContentsOfURL_Error_ = "initWithContentsOfURL:error:";

    private static readonly IntPtr selInitWithContentsOfURL_Error_Handle = Selector.GetHandle("initWithContentsOfURL:error:");

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
    private const string selIsEqualToDictionary_ = "isEqualToDictionary:";

    private static readonly IntPtr selIsEqualToDictionary_Handle = Selector.GetHandle("isEqualToDictionary:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selMutableCopyWithZone_ = "mutableCopyWithZone:";

    private static readonly IntPtr selMutableCopyWithZone_Handle = Selector.GetHandle("mutableCopyWithZone:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selObjectEnumerator = "objectEnumerator";

    private static readonly IntPtr selObjectEnumeratorHandle = Selector.GetHandle("objectEnumerator");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selObjectForKey_ = "objectForKey:";

    private static readonly IntPtr selObjectForKey_Handle = Selector.GetHandle("objectForKey:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selObjectsForKeys_NotFoundMarker_ = "objectsForKeys:notFoundMarker:";

    private static readonly IntPtr selObjectsForKeys_NotFoundMarker_Handle = Selector.GetHandle("objectsForKeys:notFoundMarker:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selSharedKeySetForKeys_ = "sharedKeySetForKeys:";

    private static readonly IntPtr selSharedKeySetForKeys_Handle = Selector.GetHandle("sharedKeySetForKeys:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selWriteToFile_Atomically_ = "writeToFile:atomically:";

    private static readonly IntPtr selWriteToFile_Atomically_Handle = Selector.GetHandle("writeToFile:atomically:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selWriteToURL_Atomically_ = "writeToURL:atomically:";

    private static readonly IntPtr selWriteToURL_Atomically_Handle = Selector.GetHandle("writeToURL:atomically:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSDictionary");

    int ICollection.Count => (int)Count;

    bool ICollection.IsSynchronized => false;

    object ICollection.SyncRoot => this;

    int ICollection<KeyValuePair<NSObject, NSObject>>.Count => (int)Count;

    bool ICollection<KeyValuePair<NSObject, NSObject>>.IsReadOnly => true;

    bool IDictionary.IsFixedSize => true;

    bool IDictionary.IsReadOnly => true;

    object IDictionary.this[object key]
    {
        get
        {
            if (!(key is NSObject key2))
            {
                return null;
            }
            return ObjectForKey(key2);
        }
        set
        {
            throw new NotSupportedException();
        }
    }

    ICollection IDictionary.Keys => Keys;

    ICollection IDictionary.Values => Values;

    public virtual NSObject this[NSObject key]
    {
        get
        {
            return ObjectForKey(key);
        }
        set
        {
            throw new NotSupportedException();
        }
    }

    public virtual NSObject this[NSString key]
    {
        get
        {
            return ObjectForKey(key);
        }
        set
        {
            throw new NotSupportedException();
        }
    }

    public virtual NSObject this[string key]
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
            throw new NotSupportedException();
        }
    }

    ICollection<NSObject> IDictionary<NSObject, NSObject>.Keys => Keys;

    ICollection<NSObject> IDictionary<NSObject, NSObject>.Values => Values;

    public override IntPtr ClassHandle => class_ptr;

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
    public virtual string DescriptionInStringsFileFormat
    {
        [Export("descriptionInStringsFileFormat")]
        get
        {
            if (base.IsDirectBinding)
            {
                return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selDescriptionInStringsFileFormatHandle));
            }
            return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDescriptionInStringsFileFormatHandle));
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual NSObject[] Keys
    {
        [Export("allKeys")]
        get
        {
            using (new NSAutoreleasePool())
            {
                if (base.IsDirectBinding)
                {
                    return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selAllKeysHandle));
                }
                return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAllKeysHandle));
            }
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual NSEnumerator ObjectEnumerator
    {
        [Export("objectEnumerator")]
        get
        {
            if (base.IsDirectBinding)
            {
                return Runtime.GetNSObject<NSEnumerator>(Messaging.IntPtr_objc_msgSend(base.Handle, selObjectEnumeratorHandle));
            }
            return Runtime.GetNSObject<NSEnumerator>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selObjectEnumeratorHandle));
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual NSObject[] Values
    {
        [Export("allValues")]
        get
        {
            using (new NSAutoreleasePool())
            {
                if (base.IsDirectBinding)
                {
                    return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selAllValuesHandle));
                }
                return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAllValuesHandle));
            }
        }
    }

    public NSDictionary(NSObject first, NSObject second, params NSObject[] args)
        : this(PickOdd(second, args), PickEven(first, args))
    {
    }

    public NSDictionary(object first, object second, params object[] args)
        : this(PickOdd(second, args), PickEven(first, args))
    {
    }

    internal NSDictionary(IntPtr handle, bool alloced)
        : base(handle, alloced)
    {
    }

    internal static NSArray PickEven(NSObject f, NSObject[] args)
    {
        int num = args.Length;
        if (num % 2 != 0)
        {
            throw new ArgumentException("The arguments to NSDictionary should be a multiple of two", "args");
        }
        NSObject[] array = new NSObject[1 + num / 2];
        array[0] = f;
        int i = 0;
        int num2 = 1;
        for (; i < num; i += 2)
        {
            array[num2++] = args[i];
        }
        return NSArray.FromNSObjects(array);
    }

    internal static NSArray PickOdd(NSObject f, NSObject[] args)
    {
        NSObject[] array = new NSObject[1 + args.Length / 2];
        array[0] = f;
        int i = 1;
        int num = 1;
        for (; i < args.Length; i += 2)
        {
            array[num++] = args[i];
        }
        return NSArray.FromNSObjects(array);
    }

    internal static NSArray PickEven(object f, object[] args)
    {
        int num = args.Length;
        if (num % 2 != 0)
        {
            throw new ArgumentException("The arguments to NSDictionary should be a multiple of two", "args");
        }
        object[] array = new object[1 + num / 2];
        array[0] = f;
        int i = 0;
        int num2 = 1;
        for (; i < num; i += 2)
        {
            array[num2++] = args[i];
        }
        return NSArray.FromObjects(array);
    }

    internal static NSArray PickOdd(object f, object[] args)
    {
        object[] array = new object[1 + args.Length / 2];
        array[0] = f;
        int i = 1;
        int num = 1;
        for (; i < args.Length; i += 2)
        {
            array[num++] = args[i];
        }
        return NSArray.FromObjects(array);
    }

    public static NSDictionary FromObjectsAndKeys(NSObject[] objects, NSObject[] keys)
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

    public static NSDictionary FromObjectsAndKeys(object[] objects, object[] keys)
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

    public static NSDictionary FromObjectsAndKeys(NSObject[] objects, NSObject[] keys, nint count)
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
        using NSArray objects2 = NSArray.FromNativeObjects(objects, count);
        using NSArray keys2 = NSArray.FromNativeObjects(keys, count);
        return FromObjectsAndKeysInternal(objects2, keys2);
    }

    public static NSDictionary FromObjectsAndKeys(object[] objects, object[] keys, nint count)
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
        using NSArray objects2 = NSArray.FromObjects(count, objects);
        using NSArray keys2 = NSArray.FromObjects(count, keys);
        return FromObjectsAndKeysInternal(objects2, keys2);
    }

    internal bool ContainsKeyValuePair(KeyValuePair<NSObject, NSObject> pair)
    {
        if (!TryGetValue(pair.Key, out var value))
        {
            return false;
        }
        return EqualityComparer<NSObject>.Default.Equals(pair.Value, value);
    }

    void ICollection.CopyTo(Array array, int arrayIndex)
    {
        if (array == null)
        {
            throw new ArgumentNullException("array");
        }
        if (arrayIndex < 0)
        {
            throw new ArgumentOutOfRangeException("arrayIndex");
        }
        if (array.Rank > 1)
        {
            throw new ArgumentException("array is multidimensional");
        }
        if (array.Length > 0 && arrayIndex >= array.Length)
        {
            throw new ArgumentException("arrayIndex is equal to or greater than array.Length");
        }
        if (arrayIndex + (int)Count > array.Length)
        {
            throw new ArgumentException("Not enough room from arrayIndex to end of array for this Hashtable");
        }
        IDictionaryEnumerator enumerator = ((IDictionary)this).GetEnumerator();
        int num = arrayIndex;
        while (enumerator.MoveNext())
        {
            array.SetValue(enumerator.Entry, num++);
        }
    }

    void ICollection<KeyValuePair<NSObject, NSObject>>.Add(KeyValuePair<NSObject, NSObject> item)
    {
        throw new NotSupportedException();
    }

    void ICollection<KeyValuePair<NSObject, NSObject>>.Clear()
    {
        throw new NotSupportedException();
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
        throw new NotSupportedException();
    }

    void IDictionary.Add(object key, object value)
    {
        throw new NotSupportedException();
    }

    void IDictionary.Clear()
    {
        throw new NotSupportedException();
    }

    bool IDictionary.Contains(object key)
    {
        if (key == null)
        {
            throw new ArgumentNullException("key");
        }
        if (!(key is NSObject key2))
        {
            return false;
        }
        return ContainsKey(key2);
    }

    IDictionaryEnumerator IDictionary.GetEnumerator()
    {
        return (IDictionaryEnumerator)((IEnumerable<KeyValuePair<NSObject, NSObject>>)this).GetEnumerator();
    }

    void IDictionary.Remove(object key)
    {
        throw new NotSupportedException();
    }

    void IDictionary<NSObject, NSObject>.Add(NSObject key, NSObject value)
    {
        throw new NotSupportedException();
    }

    public bool ContainsKey(NSObject key)
    {
        return ObjectForKey(key) != null;
    }

    internal bool ContainsKey(IntPtr key)
    {
        return LowlevelObjectForKey(key) != IntPtr.Zero;
    }

    bool IDictionary<NSObject, NSObject>.Remove(NSObject key)
    {
        throw new NotSupportedException();
    }

    internal bool TryGetValue<T>(INativeObject key, out T value) where T : class, INativeObject
    {
        if (key == null)
        {
            throw new ArgumentNullException("key");
        }
        value = null;
        IntPtr intPtr = _ObjectForKey(key.Handle);
        if (intPtr == IntPtr.Zero)
        {
            return false;
        }
        value = Runtime.GetINativeObject<T>(intPtr, owns: false);
        return true;
    }

    public bool TryGetValue(NSObject key, out NSObject value)
    {
        value = ObjectForKey(key);
        return value != null;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public IEnumerator<KeyValuePair<NSObject, NSObject>> GetEnumerator()
    {
        NSObject[] keys = Keys;
        foreach (NSObject key in keys)
        {
            yield return new KeyValuePair<NSObject, NSObject>(key, ObjectForKey(key));
        }
    }

    public IntPtr LowlevelObjectForKey(IntPtr key)
    {
        return Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selObjectForKey_Handle, key);
    }

    public NSFileAttributes ToFileAttributes()
    {
        return NSFileAttributes.FromDictionary(this);
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    [DesignatedInitializer]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [Export("init")]
    public NSDictionary()
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
    public NSDictionary(NSCoder coder)
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
    protected NSDictionary(NSObjectFlag t)
        : base(t)
    {
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected internal NSDictionary(IntPtr handle)
        : base(handle)
    {
    }

    [Export("initWithDictionary:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public NSDictionary(NSDictionary other)
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
    public NSDictionary(NSDictionary other, bool copyItems)
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
    [Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use 'NSMutableDictionary(string)' constructor instead.")]
    [Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use 'NSMutableDictionary(string)' constructor instead.")]
    [Deprecated(PlatformName.WatchOS, 6, 0, PlatformArchitecture.None, "Use 'NSMutableDictionary(string)' constructor instead.")]
    [Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "Use 'NSMutableDictionary(string)' constructor instead.")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public NSDictionary(string fileName)
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

    [Export("initWithObjects:forKeys:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    internal NSDictionary(NSArray objects, NSArray keys)
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

    [Export("initWithContentsOfURL:")]
    [Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use 'NSMutableDictionary(NSUrl)' constructor instead.")]
    [Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use 'NSMutableDictionary(NSUrl)' constructor instead.")]
    [Deprecated(PlatformName.WatchOS, 6, 0, PlatformArchitecture.None, "Use 'NSMutableDictionary(NSUrl)' constructor instead.")]
    [Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "Use 'NSMutableDictionary(NSUrl)' constructor instead.")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public NSDictionary(NSUrl url)
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

    [Export("initWithContentsOfURL:error:")]
    [Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
    [Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
    [Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
    [Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public NSDictionary(NSUrl url, out NSError error)
        : base(NSObjectFlag.Empty)
    {
        if (url == null)
        {
            throw new ArgumentNullException("url");
        }
        IntPtr arg = IntPtr.Zero;
        if (base.IsDirectBinding)
        {
            InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selInitWithContentsOfURL_Error_Handle, url.Handle, ref arg), "initWithContentsOfURL:error:");
        }
        else
        {
            InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selInitWithContentsOfURL_Error_Handle, url.Handle, ref arg), "initWithContentsOfURL:error:");
        }
        error = Runtime.GetNSObject<NSError>(arg);
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

    [Export("dictionaryWithDictionary:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public static NSDictionary FromDictionary(NSDictionary source)
    {
        if (source == null)
        {
            throw new ArgumentNullException("source");
        }
        return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selDictionaryWithDictionary_Handle, source.Handle));
    }

    [Export("dictionaryWithContentsOfFile:")]
    [Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use 'NSMutableDictionary.FromFile' instead.")]
    [Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use 'NSMutableDictionary.FromFile' instead.")]
    [Deprecated(PlatformName.WatchOS, 6, 0, PlatformArchitecture.None, "Use 'NSMutableDictionary.FromFile' instead.")]
    [Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "Use 'NSMutableDictionary.FromFile' instead.")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public static NSDictionary FromFile(string path)
    {
        if (path == null)
        {
            throw new ArgumentNullException("path");
        }
        IntPtr arg = NSString.CreateNative(path);
        NSDictionary nSObject = Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selDictionaryWithContentsOfFile_Handle, arg));
        NSString.ReleaseNative(arg);
        return nSObject;
    }

    [Export("dictionaryWithObject:forKey:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public static NSDictionary FromObjectAndKey(NSObject obj, NSObject key)
    {
        if (obj == null)
        {
            throw new ArgumentNullException("obj");
        }
        if (key == null)
        {
            throw new ArgumentNullException("key");
        }
        return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selDictionaryWithObject_ForKey_Handle, obj.Handle, key.Handle));
    }

    [Export("dictionaryWithObjects:forKeys:count:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    internal static NSDictionary FromObjectsAndKeysInternal(NSArray? objects, NSArray? keys, nint count)
    {
        return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_nint(class_ptr, selDictionaryWithObjects_ForKeys_Count_Handle, objects?.Handle ?? IntPtr.Zero, keys?.Handle ?? IntPtr.Zero, count));
    }

    [Export("dictionaryWithObjects:forKeys:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    internal static NSDictionary FromObjectsAndKeysInternal(NSArray? objects, NSArray? keys)
    {
        return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selDictionaryWithObjects_ForKeys_Handle, objects?.Handle ?? IntPtr.Zero, keys?.Handle ?? IntPtr.Zero));
    }

    [Export("dictionaryWithContentsOfURL:")]
    [Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use 'NSMutableDictionary.FromUrl' instead.")]
    [Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use 'NSMutableDictionary.FromUrl' instead.")]
    [Deprecated(PlatformName.WatchOS, 6, 0, PlatformArchitecture.None, "Use 'NSMutableDictionary.FromUrl' instead.")]
    [Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "Use 'NSMutableDictionary.FromUrl' instead.")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public static NSDictionary FromUrl(NSUrl url)
    {
        if (url == null)
        {
            throw new ArgumentNullException("url");
        }
        return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selDictionaryWithContentsOfURL_Handle, url.Handle));
    }

    [Export("dictionaryWithContentsOfURL:error:")]
    [Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
    [Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
    [Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
    [Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public static NSDictionary<NSString, NSObject>? FromUrl(NSUrl url, out NSError error)
    {
        if (url == null)
        {
            throw new ArgumentNullException("url");
        }
        IntPtr arg = IntPtr.Zero;
        NSDictionary<NSString, NSObject> nSObject = Runtime.GetNSObject<NSDictionary<NSString, NSObject>>(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(class_ptr, selDictionaryWithContentsOfURL_Error_Handle, url.Handle, ref arg));
        error = Runtime.GetNSObject<NSError>(arg);
        return nSObject;
    }

    [Export("sharedKeySetForKeys:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public static NSObject GetSharedKeySetForKeys(NSObject[] keys)
    {
        if (keys == null)
        {
            throw new ArgumentNullException("keys");
        }
        NSArray nSArray = NSArray.FromNSObjects(keys);
        NSObject nSObject = Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selSharedKeySetForKeys_Handle, nSArray.Handle));
        nSArray.Dispose();
        return nSObject;
    }

    [Export("isEqualToDictionary:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual bool IsEqualToDictionary(NSDictionary other)
    {
        if (other == null)
        {
            throw new ArgumentNullException("other");
        }
        if (base.IsDirectBinding)
        {
            return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIsEqualToDictionary_Handle, other.Handle);
        }
        return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIsEqualToDictionary_Handle, other.Handle);
    }

    [Export("allKeysForObject:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual NSObject[] KeysForObject(NSObject obj)
    {
        using (new NSAutoreleasePool())
        {
            if (obj == null)
            {
                throw new ArgumentNullException("obj");
            }
            if (base.IsDirectBinding)
            {
                return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selAllKeysForObject_Handle, obj.Handle));
            }
            return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selAllKeysForObject_Handle, obj.Handle));
        }
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

    [Export("objectForKey:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual NSObject ObjectForKey(NSObject key)
    {
        if (key == null)
        {
            throw new ArgumentNullException("key");
        }
        if (base.IsDirectBinding)
        {
            return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selObjectForKey_Handle, key.Handle));
        }
        return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selObjectForKey_Handle, key.Handle));
    }

    [Export("objectsForKeys:notFoundMarker:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual NSObject[] ObjectsForKeys(NSArray keys, NSObject marker)
    {
        using (new NSAutoreleasePool())
        {
            if (keys == null)
            {
                throw new ArgumentNullException("keys");
            }
            if (marker == null)
            {
                throw new ArgumentNullException("marker");
            }
            if (base.IsDirectBinding)
            {
                return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selObjectsForKeys_NotFoundMarker_Handle, keys.Handle, marker.Handle));
            }
            return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selObjectsForKeys_NotFoundMarker_Handle, keys.Handle, marker.Handle));
        }
    }

    [Export("writeToFile:atomically:")]
    [Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, null)]
    [Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, null)]
    [Deprecated(PlatformName.WatchOS, 6, 0, PlatformArchitecture.None, null)]
    [Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, null)]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual bool WriteToFile(string path, bool useAuxiliaryFile)
    {
        if (path == null)
        {
            throw new ArgumentNullException("path");
        }
        IntPtr arg = NSString.CreateNative(path);
        bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_bool(base.SuperHandle, selWriteToFile_Atomically_Handle, arg, useAuxiliaryFile) : Messaging.bool_objc_msgSend_IntPtr_bool(base.Handle, selWriteToFile_Atomically_Handle, arg, useAuxiliaryFile));
        NSString.ReleaseNative(arg);
        return result;
    }

    [Export("writeToURL:atomically:")]
    [Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, null)]
    [Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, null)]
    [Deprecated(PlatformName.WatchOS, 6, 0, PlatformArchitecture.None, null)]
    [Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, null)]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual bool WriteToUrl(NSUrl url, bool atomically)
    {
        if (url == null)
        {
            throw new ArgumentNullException("url");
        }
        if (base.IsDirectBinding)
        {
            return Messaging.bool_objc_msgSend_IntPtr_bool(base.Handle, selWriteToURL_Atomically_Handle, url.Handle, atomically);
        }
        return Messaging.bool_objc_msgSendSuper_IntPtr_bool(base.SuperHandle, selWriteToURL_Atomically_Handle, url.Handle, atomically);
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    internal IntPtr _AllKeys()
    {
        return Messaging.IntPtr_objc_msgSend(base.Handle, selAllKeysHandle);
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    internal IntPtr _AllKeysForObject(IntPtr obj)
    {
        return Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selAllKeysForObject_Handle, obj);
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    internal IntPtr _AllValues()
    {
        return Messaging.IntPtr_objc_msgSend(base.Handle, selAllValuesHandle);
    }

    [Export("dictionaryWithObjects:forKeys:count:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    internal static IntPtr _FromObjectsAndKeysInternal(IntPtr objects, IntPtr keys, nint count)
    {
        return Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_nint(class_ptr, selDictionaryWithObjects_ForKeys_Count_Handle, objects, keys, count);
    }

    [Export("dictionaryWithObjects:forKeys:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    internal static IntPtr _FromObjectsAndKeysInternal(IntPtr objects, IntPtr keys)
    {
        return Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selDictionaryWithObjects_ForKeys_Handle, objects, keys);
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    internal IntPtr _ObjectForKey(IntPtr key)
    {
        return Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selObjectForKey_Handle, key);
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    internal IntPtr _ObjectsForKeys(IntPtr keys, IntPtr marker)
    {
        return Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selObjectsForKeys_NotFoundMarker_Handle, keys, marker);
    }
}
[Register("NSDictionary", SkipRegistration = true)]
public sealed class NSDictionary<TKey, TValue> : NSDictionary, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable where TKey : class, INativeObject where TValue : class, INativeObject
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

    public TValue this[TKey key] => ObjectForKey(key);

    TValue IDictionary<TKey, TValue>.this[TKey key]
    {
        get
        {
            return this[key];
        }
        set
        {
            throw new NotSupportedException();
        }
    }

    ICollection<TKey> IDictionary<TKey, TValue>.Keys => Keys;

    ICollection<TValue> IDictionary<TKey, TValue>.Values => Values;

    int ICollection<KeyValuePair<TKey, TValue>>.Count => (int)base.Count;

    bool ICollection<KeyValuePair<TKey, TValue>>.IsReadOnly => true;

    public NSDictionary()
    {
    }

    public NSDictionary(NSCoder coder)
        : base(coder)
    {
    }

    public NSDictionary(string filename)
        : base(filename)
    {
    }

    public NSDictionary(NSUrl url)
        : base(url)
    {
    }

    internal NSDictionary(IntPtr handle)
        : base(handle)
    {
    }

    public NSDictionary(NSDictionary<TKey, TValue> other)
        : base(other)
    {
    }

    internal static bool ValidateKeysAndValues(TKey[] keys, TValue[] values)
    {
        if (keys == null)
        {
            throw new ArgumentNullException("keys");
        }
        if (values == null)
        {
            throw new ArgumentNullException("values");
        }
        if (values.Length != keys.Length)
        {
            throw new ArgumentException("values and keys arrays have different sizes");
        }
        return true;
    }

    private NSDictionary(TKey[] keys, TValue[] values, bool validation)
        : base(NSArray.FromNSObjects(values), NSArray.FromNSObjects(keys))
    {
    }

    public NSDictionary(TKey[] keys, TValue[] values)
        : this(keys, values, ValidateKeysAndValues(keys, values))
    {
    }

    public NSDictionary(TKey key, TValue value)
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
        using (new NSAutoreleasePool())
        {
            return NSArray.ArrayFromHandle<TValue>(_ObjectsForKeys(NSArray.From(keys, -1L).Handle, marker.Handle));
        }
    }

    private static NSDictionary<TKey, TValue> GenericFromObjectsAndKeysInternal(NSArray objects, NSArray keys)
    {
        return Runtime.GetNSObject<NSDictionary<TKey, TValue>>(NSDictionary._FromObjectsAndKeysInternal(objects.Handle, keys.Handle));
    }

    public static NSDictionary<TKey, TValue> FromObjectsAndKeys(TValue[] objects, TKey[] keys, nint count)
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
        using NSArray objects2 = NSArray.FromNativeObjects(objects, count);
        using NSArray keys2 = NSArray.FromNativeObjects(keys, count);
        return GenericFromObjectsAndKeysInternal(objects2, keys2);
    }

    [Obsolete("'TKey' and 'TValue' are inversed and won't work unless both types are identical. Use the generic overload that takes a count parameter instead.")]
    public static NSDictionary<TKey, TValue> FromObjectsAndKeys(TKey[] objects, TValue[] keys)
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

    public new static NSDictionary<TKey, TValue> FromObjectsAndKeys(object[] objects, object[] keys)
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

    public new static NSDictionary<TKey, TValue> FromObjectsAndKeys(NSObject[] objects, NSObject[] keys, nint count)
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
        using NSArray objects2 = NSArray.FromNativeObjects(objects, count);
        using NSArray keys2 = NSArray.FromNativeObjects(keys, count);
        return GenericFromObjectsAndKeysInternal(objects2, keys2);
    }

    public new static NSDictionary<TKey, TValue> FromObjectsAndKeys(object[] objects, object[] keys, nint count)
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
        using NSArray objects2 = NSArray.FromObjects(count, objects);
        using NSArray keys2 = NSArray.FromObjects(count, keys);
        return GenericFromObjectsAndKeysInternal(objects2, keys2);
    }

    public bool ContainsKey(TKey key)
    {
        if (key == null)
        {
            throw new ArgumentNullException("key");
        }
        return _ObjectForKey(key.Handle) != IntPtr.Zero;
    }

    public bool TryGetValue(TKey key, out TValue value)
    {
        return (value = ObjectForKey(key)) != null;
    }

    bool IDictionary<TKey, TValue>.ContainsKey(TKey key)
    {
        return ContainsKey(key);
    }

    void IDictionary<TKey, TValue>.Add(TKey key, TValue value)
    {
        throw new NotSupportedException();
    }

    bool IDictionary<TKey, TValue>.Remove(TKey key)
    {
        throw new NotSupportedException();
    }

    bool IDictionary<TKey, TValue>.TryGetValue(TKey key, out TValue value)
    {
        return TryGetValue(key, out value);
    }

    void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> item)
    {
        throw new NotSupportedException();
    }

    void ICollection<KeyValuePair<TKey, TValue>>.Clear()
    {
        throw new NotSupportedException();
    }

    bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> item)
    {
        if (!TryGetValue((INativeObject)item.Key, out TValue value))
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
        throw new NotSupportedException();
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
        return GetEnumerator();
    }
}

