using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSDictionary", true)]
public class NSDictionary : NSObject, IDictionary, ICollection, IEnumerable, IDictionary<NSObject, NSObject>, ICollection<KeyValuePair<NSObject, NSObject>>, IEnumerable<KeyValuePair<NSObject, NSObject>>
{
	private class ShimEnumerator : IDictionaryEnumerator, IEnumerator, IDisposable
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

		public ShimEnumerator(NSDictionary host)
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

	private static readonly IntPtr selCountHandle = Selector.GetHandle("count");

	private static readonly IntPtr selAllKeysHandle = Selector.GetHandle("allKeys");

	private static readonly IntPtr selAllValuesHandle = Selector.GetHandle("allValues");

	private static readonly IntPtr selDescriptionInStringsFileFormatHandle = Selector.GetHandle("descriptionInStringsFileFormat");

	private static readonly IntPtr selObjectEnumeratorHandle = Selector.GetHandle("objectEnumerator");

	private static readonly IntPtr selDictionaryWithContentsOfFile_Handle = Selector.GetHandle("dictionaryWithContentsOfFile:");

	private static readonly IntPtr selDictionaryWithContentsOfURL_Handle = Selector.GetHandle("dictionaryWithContentsOfURL:");

	private static readonly IntPtr selDictionaryWithObjectForKey_Handle = Selector.GetHandle("dictionaryWithObject:forKey:");

	private static readonly IntPtr selDictionaryWithDictionary_Handle = Selector.GetHandle("dictionaryWithDictionary:");

	private static readonly IntPtr selDictionaryWithObjectsForKeysCount_Handle = Selector.GetHandle("dictionaryWithObjects:forKeys:count:");

	private static readonly IntPtr selDictionaryWithObjectsForKeys_Handle = Selector.GetHandle("dictionaryWithObjects:forKeys:");

	private static readonly IntPtr selInitWithDictionary_Handle = Selector.GetHandle("initWithDictionary:");

	private static readonly IntPtr selInitWithContentsOfFile_Handle = Selector.GetHandle("initWithContentsOfFile:");

	private static readonly IntPtr selInitWithObjectsForKeys_Handle = Selector.GetHandle("initWithObjects:forKeys:");

	private static readonly IntPtr selInitWithContentsOfURL_Handle = Selector.GetHandle("initWithContentsOfURL:");

	private static readonly IntPtr selObjectForKey_Handle = Selector.GetHandle("objectForKey:");

	private static readonly IntPtr selAllKeysForObject_Handle = Selector.GetHandle("allKeysForObject:");

	private static readonly IntPtr selIsEqualToDictionary_Handle = Selector.GetHandle("isEqualToDictionary:");

	private static readonly IntPtr selObjectsForKeysNotFoundMarker_Handle = Selector.GetHandle("objectsForKeys:notFoundMarker:");

	private static readonly IntPtr selWriteToFileAtomically_Handle = Selector.GetHandle("writeToFile:atomically:");

	private static readonly IntPtr selWriteToURLAtomically_Handle = Selector.GetHandle("writeToURL:atomically:");

	private static readonly IntPtr selSharedKeySetForKeys_Handle = Selector.GetHandle("sharedKeySetForKeys:");

    #region

    private const string selObjectsForKeys_NotFoundMarker_ = "objectsForKeys:notFoundMarker:";
    private static readonly IntPtr selObjectsForKeys_NotFoundMarker_Handle = Selector.GetHandle(selObjectsForKeys_NotFoundMarker_);

    private const string selDictionaryWithObjects_ForKeys_ = "dictionaryWithObjects:forKeys:";
    private static readonly IntPtr selDictionaryWithObjects_ForKeys_Handle = Selector.GetHandle(selDictionaryWithObjects_ForKeys_);

    private const string selDictionaryWithObjects_ForKeys_Count_ = "dictionaryWithObjects:forKeys:count:";
    private static readonly IntPtr selDictionaryWithObjects_ForKeys_Count_Handle = Selector.GetHandle(selDictionaryWithObjects_ForKeys_Count_);

    #endregion


    private static readonly IntPtr class_ptr = Class.GetHandle("NSDictionary");

	private object __mt_Keys_var;

	private object __mt_Values_var;

	private object __mt_ObjectEnumerator_var;

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
			if (key == null)
			{
				throw new ArgumentNullException("key");
			}
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
			if (key == null)
			{
				throw new ArgumentNullException("key");
			}
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
			using NSString key2 = new NSString(key);
			return ObjectForKey(key2);
		}
		set
		{
			throw new NotSupportedException();
		}
	}

	ICollection<NSObject> IDictionary<NSObject, NSObject>.Keys => Keys;

	ICollection<NSObject> IDictionary<NSObject, NSObject>.Values => Values;

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

	public virtual NSObject[] Keys
	{
		[Export("allKeys")]
		get
		{
			using (new NSAutoreleasePool())
			{
				return (NSObject[])(__mt_Keys_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(SuperHandle, selAllKeysHandle)) : NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(Handle, selAllKeysHandle))));
			}
		}
	}

	public virtual NSObject[] Values
	{
		[Export("allValues")]
		get
		{
			using (new NSAutoreleasePool())
			{
				return (NSObject[])(__mt_Values_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(SuperHandle, selAllValuesHandle)) : NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(Handle, selAllValuesHandle))));
			}
		}
	}

	public virtual string DescriptionInStringsFileFormat
	{
		[Export("descriptionInStringsFileFormat")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(Handle, selDescriptionInStringsFileFormatHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(SuperHandle, selDescriptionInStringsFileFormatHandle));
		}
	}

	public virtual NSEnumerator ObjectEnumerator
	{
		[Export("objectEnumerator")]
		get
		{
			return (NSEnumerator)(__mt_ObjectEnumerator_var = ((!IsDirectBinding) ? ((NSEnumerator)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(SuperHandle, selObjectEnumeratorHandle))) : ((NSEnumerator)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(Handle, selObjectEnumeratorHandle)))));
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

	private static NSArray PickEven(NSObject f, NSObject[] args)
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

	private static NSArray PickOdd(NSObject f, NSObject[] args)
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

	private static NSArray PickEven(object f, object[] args)
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

	private static NSArray PickOdd(object f, object[] args)
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
		if (objects.Length != keys.Length)
		{
			throw new ArgumentException("objects and keys arrays have different sizes");
		}
		NSArray nSArray = NSArray.FromNSObjects(objects);
		NSArray nSArray2 = NSArray.FromNSObjects(keys);
		NSDictionary result = FromObjectsAndKeysInternal(nSArray, nSArray2);
		nSArray.Dispose();
		nSArray2.Dispose();
		return result;
	}

	public static NSDictionary FromObjectsAndKeys(object[] objects, object[] keys)
	{
		if (objects.Length != keys.Length)
		{
			throw new ArgumentException("objects and keys arrays have different sizes");
		}
		NSArray nSArray = NSArray.FromObjects(objects);
		NSArray nSArray2 = NSArray.FromObjects(keys);
		NSDictionary result = FromObjectsAndKeysInternal(nSArray, nSArray2);
		nSArray.Dispose();
		nSArray2.Dispose();
		return result;
	}

	public static NSDictionary FromObjectsAndKeys(NSObject[] objects, NSObject[] keys, int count)
	{
		if (objects.Length != keys.Length)
		{
			throw new ArgumentException("objects and keys arrays have different sizes");
		}
		if (count < 1 || objects.Length < count || keys.Length < count)
		{
			throw new ArgumentException("count");
		}
		NSArray nSArray = NSArray.FromNSObjects(objects, count);
		NSArray nSArray2 = NSArray.FromNSObjects(keys, count);
		NSDictionary result = FromObjectsAndKeysInternal(nSArray, nSArray2);
		nSArray.Dispose();
		nSArray2.Dispose();
		return result;
	}

	public static NSDictionary FromObjectsAndKeys(object[] objects, object[] keys, int count)
	{
		if (objects.Length != keys.Length)
		{
			throw new ArgumentException("objects and keys arrays have different sizes");
		}
		if (count < 1 || objects.Length < count || keys.Length < count)
		{
			throw new ArgumentException("count");
		}
		NSArray nSArray = NSArray.FromObjects(count, objects);
		NSArray nSArray2 = NSArray.FromObjects(count, keys);
		NSDictionary result = FromObjectsAndKeysInternal(nSArray, nSArray2);
		nSArray.Dispose();
		nSArray2.Dispose();
		return result;
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
		return new ShimEnumerator(this);
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
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		return ObjectForKey(key) != null;
	}

	bool IDictionary<NSObject, NSObject>.Remove(NSObject key)
	{
		throw new NotSupportedException();
	}

	public bool TryGetValue(NSObject key, out NSObject value)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		value = ObjectForKey(key);
		if (value == null)
		{
			return false;
		}
		return true;
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
		return Messaging.IntPtr_objc_msgSend_IntPtr(Handle, selObjectForKey_Handle, key);
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSDictionary()
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
	public NSDictionary(NSCoder coder)
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
	public NSDictionary(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSDictionary(IntPtr handle)
		: base(handle)
	{
	}

	[Export("dictionaryWithContentsOfFile:")]
	public static NSDictionary FromFile(string path)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = NSString.CreateNative(path);
		NSDictionary result = (NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selDictionaryWithContentsOfFile_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("dictionaryWithContentsOfURL:")]
	public static NSDictionary FromUrl(NSUrl url)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		return (NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selDictionaryWithContentsOfURL_Handle, url.Handle));
	}

	[Export("dictionaryWithObject:forKey:")]
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
		return (NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selDictionaryWithObjectForKey_Handle, obj.Handle, key.Handle));
	}

	[Export("dictionaryWithDictionary:")]
	public static NSDictionary FromDictionary(NSDictionary source)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		return (NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selDictionaryWithDictionary_Handle, source.Handle));
	}

	[Export("dictionaryWithObjects:forKeys:count:")]
	internal static NSDictionary FromObjectsAndKeysInternal(NSArray objects, NSArray keys, ulong count)
	{
		return (NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_UInt64(class_ptr, selDictionaryWithObjectsForKeysCount_Handle, objects?.Handle ?? IntPtr.Zero, keys?.Handle ?? IntPtr.Zero, count));
	}

	[Export("dictionaryWithObjects:forKeys:")]
	internal static NSDictionary FromObjectsAndKeysInternal(NSArray objects, NSArray keys)
	{
		return (NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selDictionaryWithObjectsForKeys_Handle, objects?.Handle ?? IntPtr.Zero, keys?.Handle ?? IntPtr.Zero));
	}

	[Export("initWithDictionary:")]
	public NSDictionary(NSDictionary other)
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
	public NSDictionary(string fileName)
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

	[Export("initWithObjects:forKeys:")]
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
		if (IsDirectBinding)
		{
			Handle = Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(Handle, selInitWithObjectsForKeys_Handle, objects.Handle, keys.Handle);
		}
		else
		{
			Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(SuperHandle, selInitWithObjectsForKeys_Handle, objects.Handle, keys.Handle);
		}
	}

	[Export("initWithContentsOfURL:")]
	public NSDictionary(NSUrl url)
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

	[Export("objectForKey:")]
	public virtual NSObject ObjectForKey(NSObject key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(Handle, selObjectForKey_Handle, key.Handle));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(SuperHandle, selObjectForKey_Handle, key.Handle));
	}

	[Export("allKeysForObject:")]
	public virtual NSObject[] KeysForObject(NSObject obj)
	{
		using (new NSAutoreleasePool())
		{
			if (obj == null)
			{
				throw new ArgumentNullException("obj");
			}
			if (IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend_IntPtr(Handle, selAllKeysForObject_Handle, obj.Handle));
			}
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(SuperHandle, selAllKeysForObject_Handle, obj.Handle));
		}
	}

	[Export("isEqualToDictionary:")]
	public virtual bool IsEqualToDictionary(NSDictionary other)
	{
		if (other == null)
		{
			throw new ArgumentNullException("other");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(Handle, selIsEqualToDictionary_Handle, other.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(SuperHandle, selIsEqualToDictionary_Handle, other.Handle);
	}

	[Export("objectsForKeys:notFoundMarker:")]
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
			if (IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(Handle, selObjectsForKeysNotFoundMarker_Handle, keys.Handle, marker.Handle));
			}
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(SuperHandle, selObjectsForKeysNotFoundMarker_Handle, keys.Handle, marker.Handle));
		}
	}

	[Export("writeToFile:atomically:")]
	public virtual bool WriteToFile(string path, bool useAuxiliaryFile)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = NSString.CreateNative(path);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_bool(SuperHandle, selWriteToFileAtomically_Handle, arg, useAuxiliaryFile) : Messaging.bool_objc_msgSend_IntPtr_bool(Handle, selWriteToFileAtomically_Handle, arg, useAuxiliaryFile));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("writeToURL:atomically:")]
	public virtual bool WriteToUrl(NSUrl url, bool atomically)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr_bool(Handle, selWriteToURLAtomically_Handle, url.Handle, atomically);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr_bool(SuperHandle, selWriteToURLAtomically_Handle, url.Handle, atomically);
	}

	[Export("sharedKeySetForKeys:")]
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

    #region

    internal IntPtr _AllKeys()
    {
        return Messaging.IntPtr_objc_msgSend(Handle, selAllKeysHandle);
    }

    internal IntPtr _AllKeysForObject(IntPtr obj)
    {
        return Messaging.IntPtr_objc_msgSend_IntPtr(Handle, selAllKeysForObject_Handle, obj);
    }

    internal IntPtr _AllValues()
    {
        return Messaging.IntPtr_objc_msgSend(Handle, selAllValuesHandle);
    }

    internal IntPtr _ObjectForKey(IntPtr key)
    {
        return Messaging.IntPtr_objc_msgSend_IntPtr(Handle, selObjectForKey_Handle, key);
    }

    internal IntPtr _ObjectsForKeys(IntPtr keys, IntPtr marker)
    {
        return Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selObjectsForKeys_NotFoundMarker_Handle, keys, marker);
    }

    [Export(selDictionaryWithObjects_ForKeys_)]
    internal static IntPtr _FromObjectsAndKeysInternal(IntPtr objects, IntPtr keys)
    {
        return Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selDictionaryWithObjects_ForKeys_Handle, objects, keys);
    }

    [Export(selDictionaryWithObjects_ForKeys_Count_)]
    internal static IntPtr _FromObjectsAndKeysInternal(IntPtr objects, IntPtr keys, long count)
    {
        return Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_long(class_ptr, selDictionaryWithObjects_ForKeys_Count_Handle, objects, keys, count);
    }

    internal bool TryGetValueTx<T>(INativeObject key, out T value) where T : class, INativeObject
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
        value = Runtime.GetNativeObject<T>(intPtr);
        return true;
    }

    #endregion


    protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (Handle == IntPtr.Zero)
		{
			__mt_Keys_var = null;
			__mt_Values_var = null;
			__mt_ObjectEnumerator_var = null;
		}
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

    int ICollection<KeyValuePair<TKey, TValue>>.Count => (int)Count;

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
        : base(NSArray.FromNativeObjectsTx(values), NSArray.FromNativeObjectsTx(keys))
    {
    }

    public NSDictionary(TKey[] keys, TValue[] values)
        : this(keys, values, ValidateKeysAndValues(keys, values))
    {
    }

    public NSDictionary(TKey key, TValue value)
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
        using (new NSAutoreleasePool())
        {
            return NSArray.ArrayFromNativeHandle<TValue>(_ObjectsForKeys(NSArray.From(keys, -1L).Handle, marker.Handle));
        }
    }

    private static NSDictionary<TKey, TValue> GenericFromObjectsAndKeysInternal(NSArray objects, NSArray keys)
    {
        return Runtime.GetNativeObject<NSDictionary<TKey, TValue>>(NSDictionary._FromObjectsAndKeysInternal(objects.Handle, keys.Handle));
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
        using NSArray objects2 = NSArray.FromNativeObjectsTx(objects, count);
        using NSArray keys2 = NSArray.FromNativeObjectsTx(keys, count);
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
        using NSArray objects2 = NSArray.FromNativeObjectsTx(objects);
        using NSArray keys2 = NSArray.FromNativeObjectsTx(keys);
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

    public static NSDictionary<TKey, TValue> FromObjectsAndKeys(NSObject[] objects, NSObject[] keys, long count)
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
        using NSArray objects2 = NSArray.FromNativeObjectsTx(objects, count);
        using NSArray keys2 = NSArray.FromNativeObjectsTx(keys, count);
        return GenericFromObjectsAndKeysInternal(objects2, keys2);
    }

    public static NSDictionary<TKey, TValue> FromObjectsAndKeys(object[] objects, object[] keys, long count)
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
        if (!TryGetValueTx((INativeObject)item.Key, out TValue value))
            return false;

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