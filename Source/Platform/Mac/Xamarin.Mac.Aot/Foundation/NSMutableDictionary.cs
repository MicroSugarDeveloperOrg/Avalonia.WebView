using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSMutableDictionary", true)]
public class NSMutableDictionary : NSDictionary, IDictionary, ICollection, IEnumerable, IDictionary<NSObject, NSObject>, ICollection<KeyValuePair<NSObject, NSObject>>, IEnumerable<KeyValuePair<NSObject, NSObject>>
{
	private class ShimEnumerator : IDictionaryEnumerator, IEnumerator
	{
		private IEnumerator<KeyValuePair<NSObject, NSObject>> e;

		public DictionaryEntry Entry
		{
			get
			{
				DictionaryEntry result = default(DictionaryEntry);
				result.Key = e.Current.Key;
				result.Value = e.Current.Value;
				return result;
			}
		}

		public object Key => e.Current.Key;

		public object Value => e.Current.Value;

		public object Current => Entry;

		public ShimEnumerator(NSMutableDictionary host)
		{
			e = host.GetEnumerator();
		}

		public void Dispose()
		{
			e.Dispose();
		}

		public bool MoveNext()
		{
			return e.MoveNext();
		}

		public void Reset()
		{
			e.Reset();
		}
	}

	private static readonly NSObject marker = new NSObject();

	private static readonly IntPtr selDictionaryWithContentsOfFile_Handle = Selector.GetHandle("dictionaryWithContentsOfFile:");

	private static readonly IntPtr selDictionaryWithContentsOfURL_Handle = Selector.GetHandle("dictionaryWithContentsOfURL:");

	private static readonly IntPtr selDictionaryWithObjectForKey_Handle = Selector.GetHandle("dictionaryWithObject:forKey:");

	private static readonly IntPtr selDictionaryWithDictionary_Handle = Selector.GetHandle("dictionaryWithDictionary:");

	private static readonly IntPtr selDictionaryWithObjectsForKeysCount_Handle = Selector.GetHandle("dictionaryWithObjects:forKeys:count:");

	private static readonly IntPtr selDictionaryWithObjectsForKeys_Handle = Selector.GetHandle("dictionaryWithObjects:forKeys:");

	private static readonly IntPtr selInitWithDictionary_Handle = Selector.GetHandle("initWithDictionary:");

	private static readonly IntPtr selInitWithContentsOfFile_Handle = Selector.GetHandle("initWithContentsOfFile:");

	private static readonly IntPtr selInitWithContentsOfURL_Handle = Selector.GetHandle("initWithContentsOfURL:");

	private static readonly IntPtr selRemoveAllObjectsHandle = Selector.GetHandle("removeAllObjects");

	private static readonly IntPtr selRemoveObjectForKey_Handle = Selector.GetHandle("removeObjectForKey:");

	private static readonly IntPtr selSetObjectForKey_Handle = Selector.GetHandle("setObject:forKey:");

	private static readonly IntPtr selDictionaryWithSharedKeySet_Handle = Selector.GetHandle("dictionaryWithSharedKeySet:");

    #region

    private const string selSetObject_ForKey_ = "setObject:forKey:";
    private static readonly IntPtr selSetObject_ForKey_Handle = Selector.GetHandle(selSetObject_ForKey_);

    private const string selInitWithObjects_ForKeys_ = "initWithObjects:forKeys:";
    private static readonly IntPtr selInitWithObjects_ForKeys_Handle = Selector.GetHandle(selInitWithObjects_ForKeys_);

    #endregion

    private static readonly IntPtr class_ptr = Class.GetHandle("NSMutableDictionary");


    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [Export("init")]
    public NSMutableDictionary()
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
    public NSMutableDictionary(NSCoder coder)
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
    public NSMutableDictionary(NSObjectFlag t)
        : base(t)
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public NSMutableDictionary(IntPtr handle)
        : base(handle)
    {
    }

    #region

    [Export(selInitWithObjects_ForKeys_)]
    internal NSMutableDictionary(NSArray objects, NSArray keys)
    : base(NSObjectFlag.Empty)
    {
        if (objects == null)
            throw new ArgumentNullException("objects");

        if (keys == null)
            throw new ArgumentNullException("keys");

        if (IsDirectBinding)
            InitializeWithHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(Handle, selInitWithObjects_ForKeys_Handle, objects.Handle, keys.Handle));
        else
            InitializeWithHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(SuperHandle, selInitWithObjects_ForKeys_Handle, objects.Handle, keys.Handle));
    }

    #endregion

    int ICollection<KeyValuePair<NSObject, NSObject>>.Count => (int)Count;

	bool ICollection<KeyValuePair<NSObject, NSObject>>.IsReadOnly => false;

	bool IDictionary.IsFixedSize => false;

	bool IDictionary.IsReadOnly => false;

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
			NSObject nSObject = key as NSObject;
			NSObject nSObject2 = value as NSObject;
			if (nSObject == null || nSObject2 == null)
			{
				throw new ArgumentException("You can only use NSObjects for keys and values in an NSMutableDictionary");
			}
			SetObject(nSObject2, nSObject);
		}
	}

	ICollection IDictionary.Keys => Keys;

	ICollection IDictionary.Values => Values;

	public override NSObject this[NSObject key]
	{
		get
		{
			if (key == null)
			{
				throw new ArgumentNullException("key");
			}
			return ObjectForKey(key);
		}
		set
		{
			if (key == null)
			{
				throw new ArgumentNullException("key");
			}
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr_IntPtr(Handle, selSetObjectForKey_Handle, value.Handle, key.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(SuperHandle, selSetObjectForKey_Handle, value.Handle, key.Handle);
			}
		}
	}

	public override NSObject this[NSString key]
	{
		get
		{
			if (key == null)
			{
				throw new ArgumentNullException("key");
			}
			return ObjectForKey(key);
		}
		set
		{
			if (key == null)
			{
				throw new ArgumentNullException("key");
			}
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr_IntPtr(Handle, selSetObjectForKey_Handle, value.Handle, key.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(SuperHandle, selSetObjectForKey_Handle, value.Handle, key.Handle);
			}
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
			using NSString key2 = new NSString(key);
			return ObjectForKey(key2);
		}
		set
		{
			if (key == null)
			{
				throw new ArgumentNullException("key");
			}
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			using NSString nSString = new NSString(key);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr_IntPtr(Handle, selSetObjectForKey_Handle, value.Handle, nSString.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(SuperHandle, selSetObjectForKey_Handle, value.Handle, nSString.Handle);
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
			Release();
		}
	}

	public new static NSMutableDictionary FromObjectsAndKeys(NSObject[] objects, NSObject[] keys)
	{
		if (objects.Length != keys.Length)
		{
			throw new ArgumentException("objects and keys arrays have different sizes");
		}
		NSArray nSArray = NSArray.FromNSObjects(objects);
		NSArray nSArray2 = NSArray.FromNSObjects(keys);
		NSMutableDictionary result = FromObjectsAndKeysInternal(nSArray, nSArray2);
		nSArray.Dispose();
		nSArray2.Dispose();
		return result;
	}

	public new static NSMutableDictionary FromObjectsAndKeys(object[] objects, object[] keys)
	{
		if (objects.Length != keys.Length)
		{
			throw new ArgumentException("objects and keys arrays have different sizes");
		}
		NSArray nSArray = NSArray.FromObjects(objects);
		NSArray nSArray2 = NSArray.FromObjects(keys);
		NSMutableDictionary result = FromObjectsAndKeysInternal(nSArray, nSArray2);
		nSArray.Dispose();
		nSArray2.Dispose();
		return result;
	}

	public new static NSMutableDictionary FromObjectsAndKeys(NSObject[] objects, NSObject[] keys, int count)
	{
		if (objects.Length != keys.Length)
		{
			throw new ArgumentException("objects and keys arrays have different sizes");
		}
		if (count < 1 || objects.Length < count || keys.Length < count)
		{
			throw new ArgumentException("count");
		}
		NSArray nSArray = NSArray.FromNSObjects(objects);
		NSArray nSArray2 = NSArray.FromNSObjects(keys);
		NSMutableDictionary result = FromObjectsAndKeysInternal(nSArray, nSArray2);
		nSArray.Dispose();
		nSArray2.Dispose();
		return result;
	}

	public new static NSMutableDictionary FromObjectsAndKeys(object[] objects, object[] keys, int count)
	{
		if (objects.Length != keys.Length)
		{
			throw new ArgumentException("objects and keys arrays have different sizes");
		}
		if (count < 1 || objects.Length < count || keys.Length < count)
		{
			throw new ArgumentException("count");
		}
		NSArray nSArray = NSArray.FromObjects(objects);
		NSArray nSArray2 = NSArray.FromObjects(keys);
		NSMutableDictionary result = FromObjectsAndKeysInternal(nSArray, nSArray2);
		nSArray.Dispose();
		nSArray2.Dispose();
		return result;
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
		ulong count = Count;
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
		if (!(key is NSObject key2))
		{
			return false;
		}
		return ContainsKey(key2);
	}

	IDictionaryEnumerator IDictionary.GetEnumerator()
	{
		return new ShimEnumerator(this);
	}

	void IDictionary.Remove(object key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (!(key is NSObject key2))
		{
			throw new ArgumentException("The key must be an NSObject");
		}
		RemoveObjectForKey(key2);
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
		ulong count = Count;
		RemoveObjectForKey(key);
		return count != Count;
	}

	public new bool TryGetValue(NSObject key, out NSObject value)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		NSArray keys = NSArray.FromNSObjects(key);
		NSObject[] array = ObjectsForKeys(keys, marker);
		if (marker == array[0])
		{
			value = null;
			return false;
		}
		value = array[0];
		return true;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
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
		return (NSMutableDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selDictionaryWithObjectForKey_Handle, obj, key));
	}

	public void LowlevelSetObject(IntPtr obj, IntPtr key)
	{
		Messaging.void_objc_msgSend_IntPtr_IntPtr(Handle, selSetObjectForKey_Handle, obj, key);
	}

	public void LowlevelSetObject(NSObject obj, IntPtr key)
	{
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(Handle, selSetObjectForKey_Handle, obj.Handle, key);
	}

	[Export("dictionaryWithContentsOfFile:")]
	public new static NSMutableDictionary FromFile(string path)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = NSString.CreateNative(path);
		NSMutableDictionary result = (NSMutableDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selDictionaryWithContentsOfFile_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("dictionaryWithContentsOfURL:")]
	public new static NSMutableDictionary FromUrl(NSUrl url)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		return (NSMutableDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selDictionaryWithContentsOfURL_Handle, url.Handle));
	}

	[Export("dictionaryWithObject:forKey:")]
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
		return (NSMutableDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selDictionaryWithObjectForKey_Handle, obj.Handle, key.Handle));
	}

	[Export("dictionaryWithDictionary:")]
	public new static NSMutableDictionary FromDictionary(NSDictionary source)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		return (NSMutableDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selDictionaryWithDictionary_Handle, source.Handle));
	}

	[Export("dictionaryWithObjects:forKeys:count:")]
	internal static NSMutableDictionary FromObjectsAndKeysInternalCount(NSArray objects, NSArray keys, ulong count)
	{
		if (objects == null)
		{
			throw new ArgumentNullException("objects");
		}
		if (keys == null)
		{
			throw new ArgumentNullException("keys");
		}
		return (NSMutableDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_UInt64(class_ptr, selDictionaryWithObjectsForKeysCount_Handle, objects.Handle, keys.Handle, count));
	}

	[Export("dictionaryWithObjects:forKeys:")]
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
		return (NSMutableDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selDictionaryWithObjectsForKeys_Handle, objects.Handle, Keys.Handle));
	}

	[Export("initWithDictionary:")]
	public NSMutableDictionary(NSDictionary other)
		: base(NSObjectFlag.Empty)
	{
		if (other == null)
		{
			throw new ArgumentNullException("other");
		}
		if (IsDirectBinding)
		{
			Handle = Messaging.IntPtr_objc_msgSend_IntPtr(Handle, selInitWithDictionary_Handle, other.Handle);
		}
		else
		{
			Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(SuperHandle, selInitWithDictionary_Handle, other.Handle);
		}
	}

	[Export("initWithContentsOfFile:")]
	public NSMutableDictionary(string fileName)
		: base(NSObjectFlag.Empty)
	{
		if (fileName == null)
		{
			throw new ArgumentNullException("fileName");
		}
		IntPtr arg = NSString.CreateNative(fileName);
		if (IsDirectBinding)
		{
			Handle = Messaging.IntPtr_objc_msgSend_IntPtr(Handle, selInitWithContentsOfFile_Handle, arg);
		}
		else
		{
			Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(SuperHandle, selInitWithContentsOfFile_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("initWithContentsOfURL:")]
	public NSMutableDictionary(NSUrl url)
		: base(NSObjectFlag.Empty)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (IsDirectBinding)
		{
			Handle = Messaging.IntPtr_objc_msgSend_IntPtr(Handle, selInitWithContentsOfURL_Handle, url.Handle);
		}
		else
		{
			Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(SuperHandle, selInitWithContentsOfURL_Handle, url.Handle);
		}
	}

	[Export("removeAllObjects")]
	internal virtual void RemoveAllObjects()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(Handle, selRemoveAllObjectsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(SuperHandle, selRemoveAllObjectsHandle);
		}
	}

	[Export("removeObjectForKey:")]
	internal virtual void RemoveObjectForKey(NSObject key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(Handle, selRemoveObjectForKey_Handle, key.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(SuperHandle, selRemoveObjectForKey_Handle, key.Handle);
		}
	}

	[Export("setObject:forKey:")]
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
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(Handle, selSetObjectForKey_Handle, obj.Handle, key.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(SuperHandle, selSetObjectForKey_Handle, obj.Handle, key.Handle);
		}
	}

	[Export("dictionaryWithSharedKeySet:")]
	public static NSDictionary FromSharedKeySet(NSObject sharedKeyToken)
	{
		if (sharedKeyToken == null)
		{
			throw new ArgumentNullException("sharedKeyToken");
		}
		return (NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selDictionaryWithSharedKeySet_Handle, sharedKeyToken.Handle));
	}

    #region

    internal void _RemoveObjectForKey(IntPtr key)
    {
        Messaging.void_objc_msgSend_IntPtr(Handle, selRemoveObjectForKey_Handle, key);
    }

    internal void _SetObject(IntPtr obj, IntPtr key)
    {
        Messaging.void_objc_msgSend_IntPtr_IntPtr(Handle, selSetObject_ForKey_Handle, obj, key);
    }

    #endregion

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
                return NSArray.ArrayFromNativeHandle<TKey>(_AllKeys());
            }
        }
    }

    public new TValue[] Values
    {
        get
        {
            using (new NSAutoreleasePool())
            {
                return NSArray.ArrayFromNativeHandle<TValue>(_AllValues());
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

    int ICollection<KeyValuePair<TKey, TValue>>.Count => (int)Count;

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
        : base(NSArray.FromNSObjectsTx(values), NSArray.FromNSObjectsTx(keys))
    {
    }

    public NSMutableDictionary(TKey[] keys, TValue[] values)
        : this(keys, values, NSDictionary<TKey, TValue>.ValidateKeysAndValues(keys, values))
    {
    }

    public NSMutableDictionary(TKey key, TValue value)
        : base(NSArray.FromNSObjectsTx<TValue>(value), NSArray.FromNSObjectsTx<TKey>(key))
    {
    }

    public TValue ObjectForKey(TKey key)
    {
        if (key == null)
        {
            throw new ArgumentNullException("key");
        }
        return Runtime.GetNativeObject<TValue>(_ObjectForKey(key.Handle));
    }

    public TKey[] KeysForObject(TValue obj)
    {
        if (obj == null)
        {
            throw new ArgumentNullException("obj");
        }
        using (new NSAutoreleasePool())
        {
            return NSArray.ArrayFromNativeHandle<TKey>(_AllKeysForObject(obj.Handle));
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
        return NSArray.ArrayFromNativeHandle<TValue>(_ObjectsForKeys(NSArray.From(keys, -1L).Handle, marker.Handle));
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
        ulong count = Count;
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
        return Runtime.GetNativeObject<NSMutableDictionary<TKey, TValue>>(NSDictionary._FromObjectsAndKeysInternal(objects.Handle, keys.Handle));
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
        using NSArray objects2 = NSArray.FromNSObjectsTx(objects);
        using NSArray keys2 = NSArray.FromNSObjectsTx(keys);
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
        using NSArray objects2 = NSArray.FromNSObjectsTx(objects);
        using NSArray keys2 = NSArray.FromNSObjectsTx(keys);
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