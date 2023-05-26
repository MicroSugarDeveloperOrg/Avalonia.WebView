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

	private static readonly IntPtr class_ptr = Class.GetHandle("NSMutableDictionary");

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
				Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetObjectForKey_Handle, value.Handle, key.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetObjectForKey_Handle, value.Handle, key.Handle);
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
				Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetObjectForKey_Handle, value.Handle, key.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetObjectForKey_Handle, value.Handle, key.Handle);
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
				Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetObjectForKey_Handle, value.Handle, nSString.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetObjectForKey_Handle, value.Handle, nSString.Handle);
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
		Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetObjectForKey_Handle, obj, key);
	}

	public void LowlevelSetObject(NSObject obj, IntPtr key)
	{
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetObjectForKey_Handle, obj.Handle, key);
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSMutableDictionary()
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
	public NSMutableDictionary(NSCoder coder)
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
	public NSMutableDictionary(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSMutableDictionary(IntPtr handle)
		: base(handle)
	{
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
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithDictionary_Handle, other.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithDictionary_Handle, other.Handle);
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
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithContentsOfFile_Handle, arg);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithContentsOfFile_Handle, arg);
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
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithContentsOfURL_Handle, url.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithContentsOfURL_Handle, url.Handle);
		}
	}

	[Export("removeAllObjects")]
	internal virtual void RemoveAllObjects()
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

	[Export("removeObjectForKey:")]
	internal virtual void RemoveObjectForKey(NSObject key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveObjectForKey_Handle, key.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveObjectForKey_Handle, key.Handle);
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
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetObjectForKey_Handle, obj.Handle, key.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetObjectForKey_Handle, obj.Handle, key.Handle);
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
}
