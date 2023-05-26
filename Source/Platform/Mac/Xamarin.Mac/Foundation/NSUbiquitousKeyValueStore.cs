using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSUbiquitousKeyValueStore", true)]
public class NSUbiquitousKeyValueStore : NSObject
{
	public static class Notifications
	{
		public static NSObject ObserveDidChangeExternally(EventHandler<NSUbiquitousKeyValueStoreChangeEventArgs> handler)
		{
			return NSNotificationCenter.DefaultCenter.AddObserver(DidChangeExternallyNotification, delegate(NSNotification notification)
			{
				handler(null, new NSUbiquitousKeyValueStoreChangeEventArgs(notification));
			});
		}
	}

	private static readonly IntPtr selDefaultStoreHandle = Selector.GetHandle("defaultStore");

	private static readonly IntPtr selObjectForKey_Handle = Selector.GetHandle("objectForKey:");

	private static readonly IntPtr selSetObjectForKey_Handle = Selector.GetHandle("setObject:forKey:");

	private static readonly IntPtr selRemoveObjectForKey_Handle = Selector.GetHandle("removeObjectForKey:");

	private static readonly IntPtr selStringForKey_Handle = Selector.GetHandle("stringForKey:");

	private static readonly IntPtr selArrayForKey_Handle = Selector.GetHandle("arrayForKey:");

	private static readonly IntPtr selDictionaryForKey_Handle = Selector.GetHandle("dictionaryForKey:");

	private static readonly IntPtr selDataForKey_Handle = Selector.GetHandle("dataForKey:");

	private static readonly IntPtr selLongLongForKey_Handle = Selector.GetHandle("longLongForKey:");

	private static readonly IntPtr selDoubleForKey_Handle = Selector.GetHandle("doubleForKey:");

	private static readonly IntPtr selBoolForKey_Handle = Selector.GetHandle("boolForKey:");

	private static readonly IntPtr selSetStringForKey_Handle = Selector.GetHandle("setString:forKey:");

	private static readonly IntPtr selSetDataForKey_Handle = Selector.GetHandle("setData:forKey:");

	private static readonly IntPtr selSetArrayForKey_Handle = Selector.GetHandle("setArray:forKey:");

	private static readonly IntPtr selSetDictionaryForKey_Handle = Selector.GetHandle("setDictionary:forKey:");

	private static readonly IntPtr selSetLongLongForKey_Handle = Selector.GetHandle("setLongLong:forKey:");

	private static readonly IntPtr selSetDoubleForKey_Handle = Selector.GetHandle("setDouble:forKey:");

	private static readonly IntPtr selSetBoolForKey_Handle = Selector.GetHandle("setBool:forKey:");

	private static readonly IntPtr selDictionaryRepresentationHandle = Selector.GetHandle("dictionaryRepresentation");

	private static readonly IntPtr selSynchronizeHandle = Selector.GetHandle("synchronize");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSUbiquitousKeyValueStore");

	private static object __mt_DefaultStore_var_static;

	private static NSString _DidChangeExternallyNotification;

	private static NSString _ChangeReasonKey;

	private static NSString _ChangedKeysKey;

	public NSObject this[NSString key]
	{
		get
		{
			return ObjectForKey(key);
		}
		set
		{
			SetObjectForKey(value, key);
		}
	}

	public override IntPtr ClassHandle => class_ptr;

	public static NSUbiquitousKeyValueStore DefaultStore
	{
		[Export("defaultStore")]
		get
		{
			return (NSUbiquitousKeyValueStore)(__mt_DefaultStore_var_static = (NSUbiquitousKeyValueStore)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selDefaultStoreHandle)));
		}
	}

	[Field("NSUbiquitousKeyValueStoreDidChangeExternallyNotification", "Foundation")]
	public static NSString DidChangeExternallyNotification
	{
		get
		{
			if (_DidChangeExternallyNotification == null)
			{
				_DidChangeExternallyNotification = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSUbiquitousKeyValueStoreDidChangeExternallyNotification");
			}
			return _DidChangeExternallyNotification;
		}
	}

	[Field("NSUbiquitousKeyValueStoreChangeReasonKey", "Foundation")]
	public static NSString ChangeReasonKey
	{
		get
		{
			if (_ChangeReasonKey == null)
			{
				_ChangeReasonKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSUbiquitousKeyValueStoreChangeReasonKey");
			}
			return _ChangeReasonKey;
		}
	}

	[Field("NSUbiquitousKeyValueStoreChangedKeysKey", "Foundation")]
	public static NSString ChangedKeysKey
	{
		get
		{
			if (_ChangedKeysKey == null)
			{
				_ChangedKeysKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSUbiquitousKeyValueStoreChangedKeysKey");
			}
			return _ChangedKeysKey;
		}
	}

	public void SetString(string key, string value)
	{
		_SetString(value, key);
	}

	public void SetData(string key, NSData value)
	{
		_SetData(value, key);
	}

	public void SetArray(string key, NSObject[] value)
	{
		_SetArray(value, key);
	}

	public void SetDictionary(string key, NSDictionary value)
	{
		_SetDictionary(value, key);
	}

	public void SetLong(string key, long value)
	{
		_SetLong(value, key);
	}

	public void SetDouble(string key, double value)
	{
		_SetDouble(value, key);
	}

	public void SetBool(string key, bool value)
	{
		_SetBool(value, key);
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSUbiquitousKeyValueStore()
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
	public NSUbiquitousKeyValueStore(NSCoder coder)
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
	public NSUbiquitousKeyValueStore(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSUbiquitousKeyValueStore(IntPtr handle)
		: base(handle)
	{
	}

	[Export("objectForKey:")]
	internal virtual NSObject ObjectForKey(string aKey)
	{
		if (aKey == null)
		{
			throw new ArgumentNullException("aKey");
		}
		IntPtr arg = NSString.CreateNative(aKey);
		NSObject result = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selObjectForKey_Handle, arg)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selObjectForKey_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("setObject:forKey:")]
	internal virtual void SetObjectForKey(NSObject anObject, string aKey)
	{
		if (anObject == null)
		{
			throw new ArgumentNullException("anObject");
		}
		if (aKey == null)
		{
			throw new ArgumentNullException("aKey");
		}
		IntPtr arg = NSString.CreateNative(aKey);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetObjectForKey_Handle, anObject.Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetObjectForKey_Handle, anObject.Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("removeObjectForKey:")]
	public virtual void Remove(string aKey)
	{
		if (aKey == null)
		{
			throw new ArgumentNullException("aKey");
		}
		IntPtr arg = NSString.CreateNative(aKey);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveObjectForKey_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveObjectForKey_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("stringForKey:")]
	public virtual string GetString(string aKey)
	{
		if (aKey == null)
		{
			throw new ArgumentNullException("aKey");
		}
		IntPtr arg = NSString.CreateNative(aKey);
		string result = ((!IsDirectBinding) ? NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selStringForKey_Handle, arg)) : NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selStringForKey_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("arrayForKey:")]
	public virtual NSObject[] GetArray(string aKey)
	{
		if (aKey == null)
		{
			throw new ArgumentNullException("aKey");
		}
		IntPtr arg = NSString.CreateNative(aKey);
		NSObject[] result = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selArrayForKey_Handle, arg)) : NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selArrayForKey_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("dictionaryForKey:")]
	public virtual NSDictionary GetDictionary(string aKey)
	{
		if (aKey == null)
		{
			throw new ArgumentNullException("aKey");
		}
		IntPtr arg = NSString.CreateNative(aKey);
		NSDictionary result = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selDictionaryForKey_Handle, arg))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selDictionaryForKey_Handle, arg))));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("dataForKey:")]
	public virtual NSData GetData(string aKey)
	{
		if (aKey == null)
		{
			throw new ArgumentNullException("aKey");
		}
		IntPtr arg = NSString.CreateNative(aKey);
		NSData result = ((!IsDirectBinding) ? ((NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selDataForKey_Handle, arg))) : ((NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selDataForKey_Handle, arg))));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("longLongForKey:")]
	public virtual long GetLong(string aKey)
	{
		if (aKey == null)
		{
			throw new ArgumentNullException("aKey");
		}
		IntPtr arg = NSString.CreateNative(aKey);
		long result = ((!IsDirectBinding) ? Messaging.Int64_objc_msgSendSuper_IntPtr(base.SuperHandle, selLongLongForKey_Handle, arg) : Messaging.Int64_objc_msgSend_IntPtr(base.Handle, selLongLongForKey_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("doubleForKey:")]
	public virtual double GetDouble(string aKey)
	{
		if (aKey == null)
		{
			throw new ArgumentNullException("aKey");
		}
		IntPtr arg = NSString.CreateNative(aKey);
		double result = ((!IsDirectBinding) ? Messaging.Double_objc_msgSendSuper_IntPtr(base.SuperHandle, selDoubleForKey_Handle, arg) : Messaging.Double_objc_msgSend_IntPtr(base.Handle, selDoubleForKey_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("boolForKey:")]
	public virtual bool GetBool(string aKey)
	{
		if (aKey == null)
		{
			throw new ArgumentNullException("aKey");
		}
		IntPtr arg = NSString.CreateNative(aKey);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selBoolForKey_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selBoolForKey_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("setString:forKey:")]
	internal virtual void _SetString(string aString, string aKey)
	{
		if (aString == null)
		{
			throw new ArgumentNullException("aString");
		}
		if (aKey == null)
		{
			throw new ArgumentNullException("aKey");
		}
		IntPtr arg = NSString.CreateNative(aString);
		IntPtr arg2 = NSString.CreateNative(aKey);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetStringForKey_Handle, arg, arg2);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetStringForKey_Handle, arg, arg2);
		}
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
	}

	[Export("setData:forKey:")]
	internal virtual void _SetData(NSData data, string key)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetDataForKey_Handle, data.Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetDataForKey_Handle, data.Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("setArray:forKey:")]
	internal virtual void _SetArray(NSObject[] array, string key)
	{
		if (array == null)
		{
			throw new ArgumentNullException("array");
		}
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		NSArray nSArray = NSArray.FromNSObjects(array);
		IntPtr arg = NSString.CreateNative(key);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetArrayForKey_Handle, nSArray.Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetArrayForKey_Handle, nSArray.Handle, arg);
		}
		nSArray.Dispose();
		NSString.ReleaseNative(arg);
	}

	[Export("setDictionary:forKey:")]
	internal virtual void _SetDictionary(NSDictionary aDictionary, string aKey)
	{
		if (aDictionary == null)
		{
			throw new ArgumentNullException("aDictionary");
		}
		if (aKey == null)
		{
			throw new ArgumentNullException("aKey");
		}
		IntPtr arg = NSString.CreateNative(aKey);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetDictionaryForKey_Handle, aDictionary.Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetDictionaryForKey_Handle, aDictionary.Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("setLongLong:forKey:")]
	internal virtual void _SetLong(long value, string aKey)
	{
		if (aKey == null)
		{
			throw new ArgumentNullException("aKey");
		}
		IntPtr arg = NSString.CreateNative(aKey);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Int64_IntPtr(base.Handle, selSetLongLongForKey_Handle, value, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64_IntPtr(base.SuperHandle, selSetLongLongForKey_Handle, value, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("setDouble:forKey:")]
	internal virtual void _SetDouble(double value, string aKey)
	{
		if (aKey == null)
		{
			throw new ArgumentNullException("aKey");
		}
		IntPtr arg = NSString.CreateNative(aKey);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Double_IntPtr(base.Handle, selSetDoubleForKey_Handle, value, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Double_IntPtr(base.SuperHandle, selSetDoubleForKey_Handle, value, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("setBool:forKey:")]
	internal virtual void _SetBool(bool value, string aKey)
	{
		if (aKey == null)
		{
			throw new ArgumentNullException("aKey");
		}
		IntPtr arg = NSString.CreateNative(aKey);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_bool_IntPtr(base.Handle, selSetBoolForKey_Handle, value, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_bool_IntPtr(base.SuperHandle, selSetBoolForKey_Handle, value, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("dictionaryRepresentation")]
	public virtual NSDictionary DictionaryRepresentation()
	{
		if (IsDirectBinding)
		{
			return (NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDictionaryRepresentationHandle));
		}
		return (NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDictionaryRepresentationHandle));
	}

	[Export("synchronize")]
	public virtual bool Synchronize()
	{
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selSynchronizeHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selSynchronizeHandle);
	}
}
