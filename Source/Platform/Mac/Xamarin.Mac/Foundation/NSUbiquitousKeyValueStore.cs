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
			EventHandler<NSUbiquitousKeyValueStoreChangeEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidChangeExternallyNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSUbiquitousKeyValueStoreChangeEventArgs(notification));
			});
		}

		public static NSObject ObserveDidChangeExternally(NSObject objectToObserve, EventHandler<NSUbiquitousKeyValueStoreChangeEventArgs> handler)
		{
			EventHandler<NSUbiquitousKeyValueStoreChangeEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidChangeExternallyNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSUbiquitousKeyValueStoreChangeEventArgs(notification));
			}, objectToObserve);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selArrayForKey_ = "arrayForKey:";

	private static readonly IntPtr selArrayForKey_Handle = Selector.GetHandle("arrayForKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBoolForKey_ = "boolForKey:";

	private static readonly IntPtr selBoolForKey_Handle = Selector.GetHandle("boolForKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDataForKey_ = "dataForKey:";

	private static readonly IntPtr selDataForKey_Handle = Selector.GetHandle("dataForKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDefaultStore = "defaultStore";

	private static readonly IntPtr selDefaultStoreHandle = Selector.GetHandle("defaultStore");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDictionaryForKey_ = "dictionaryForKey:";

	private static readonly IntPtr selDictionaryForKey_Handle = Selector.GetHandle("dictionaryForKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDictionaryRepresentation = "dictionaryRepresentation";

	private static readonly IntPtr selDictionaryRepresentationHandle = Selector.GetHandle("dictionaryRepresentation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDoubleForKey_ = "doubleForKey:";

	private static readonly IntPtr selDoubleForKey_Handle = Selector.GetHandle("doubleForKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLongLongForKey_ = "longLongForKey:";

	private static readonly IntPtr selLongLongForKey_Handle = Selector.GetHandle("longLongForKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selObjectForKey_ = "objectForKey:";

	private static readonly IntPtr selObjectForKey_Handle = Selector.GetHandle("objectForKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveObjectForKey_ = "removeObjectForKey:";

	private static readonly IntPtr selRemoveObjectForKey_Handle = Selector.GetHandle("removeObjectForKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetArray_ForKey_ = "setArray:forKey:";

	private static readonly IntPtr selSetArray_ForKey_Handle = Selector.GetHandle("setArray:forKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBool_ForKey_ = "setBool:forKey:";

	private static readonly IntPtr selSetBool_ForKey_Handle = Selector.GetHandle("setBool:forKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetData_ForKey_ = "setData:forKey:";

	private static readonly IntPtr selSetData_ForKey_Handle = Selector.GetHandle("setData:forKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDictionary_ForKey_ = "setDictionary:forKey:";

	private static readonly IntPtr selSetDictionary_ForKey_Handle = Selector.GetHandle("setDictionary:forKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDouble_ForKey_ = "setDouble:forKey:";

	private static readonly IntPtr selSetDouble_ForKey_Handle = Selector.GetHandle("setDouble:forKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLongLong_ForKey_ = "setLongLong:forKey:";

	private static readonly IntPtr selSetLongLong_ForKey_Handle = Selector.GetHandle("setLongLong:forKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetObject_ForKey_ = "setObject:forKey:";

	private static readonly IntPtr selSetObject_ForKey_Handle = Selector.GetHandle("setObject:forKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetString_ForKey_ = "setString:forKey:";

	private static readonly IntPtr selSetString_ForKey_Handle = Selector.GetHandle("setString:forKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStringForKey_ = "stringForKey:";

	private static readonly IntPtr selStringForKey_Handle = Selector.GetHandle("stringForKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSynchronize = "synchronize";

	private static readonly IntPtr selSynchronizeHandle = Selector.GetHandle("synchronize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSUbiquitousKeyValueStore");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ChangeReasonKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ChangedKeysKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DidChangeExternallyNotification;

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

	public NSObject this[string key]
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUbiquitousKeyValueStore DefaultStore
	{
		[Export("defaultStore")]
		get
		{
			return Runtime.GetNSObject<NSUbiquitousKeyValueStore>(Messaging.IntPtr_objc_msgSend(class_ptr, selDefaultStoreHandle));
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

	[Field("NSUbiquitousKeyValueStoreDidChangeExternallyNotification", "Foundation")]
	[Advice("Use NSUbiquitousKeyValueStore.Notifications.ObserveDidChangeExternally helper method instead.")]
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSUbiquitousKeyValueStore()
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
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSUbiquitousKeyValueStore(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSUbiquitousKeyValueStore(IntPtr handle)
		: base(handle)
	{
	}

	[Export("arrayForKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject[] GetArray(string aKey)
	{
		if (aKey == null)
		{
			throw new ArgumentNullException("aKey");
		}
		IntPtr arg = NSString.CreateNative(aKey);
		NSObject[] result = ((!base.IsDirectBinding) ? NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selArrayForKey_Handle, arg)) : NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selArrayForKey_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("boolForKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool GetBool(string aKey)
	{
		if (aKey == null)
		{
			throw new ArgumentNullException("aKey");
		}
		IntPtr arg = NSString.CreateNative(aKey);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selBoolForKey_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selBoolForKey_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("dataForKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSData GetData(string aKey)
	{
		if (aKey == null)
		{
			throw new ArgumentNullException("aKey");
		}
		IntPtr arg = NSString.CreateNative(aKey);
		NSData result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selDataForKey_Handle, arg)) : Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selDataForKey_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("dictionaryForKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary GetDictionary(string aKey)
	{
		if (aKey == null)
		{
			throw new ArgumentNullException("aKey");
		}
		IntPtr arg = NSString.CreateNative(aKey);
		NSDictionary result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selDictionaryForKey_Handle, arg)) : Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selDictionaryForKey_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("doubleForKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double GetDouble(string aKey)
	{
		if (aKey == null)
		{
			throw new ArgumentNullException("aKey");
		}
		IntPtr arg = NSString.CreateNative(aKey);
		double result = ((!base.IsDirectBinding) ? Messaging.Double_objc_msgSendSuper_IntPtr(base.SuperHandle, selDoubleForKey_Handle, arg) : Messaging.Double_objc_msgSend_IntPtr(base.Handle, selDoubleForKey_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("longLongForKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual long GetLong(string aKey)
	{
		if (aKey == null)
		{
			throw new ArgumentNullException("aKey");
		}
		IntPtr arg = NSString.CreateNative(aKey);
		long result = ((!base.IsDirectBinding) ? Messaging.Int64_objc_msgSendSuper_IntPtr(base.SuperHandle, selLongLongForKey_Handle, arg) : Messaging.Int64_objc_msgSend_IntPtr(base.Handle, selLongLongForKey_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("stringForKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string GetString(string aKey)
	{
		if (aKey == null)
		{
			throw new ArgumentNullException("aKey");
		}
		IntPtr arg = NSString.CreateNative(aKey);
		string result = ((!base.IsDirectBinding) ? NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selStringForKey_Handle, arg)) : NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selStringForKey_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("objectForKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual NSObject ObjectForKey(string aKey)
	{
		if (aKey == null)
		{
			throw new ArgumentNullException("aKey");
		}
		IntPtr arg = NSString.CreateNative(aKey);
		NSObject result = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selObjectForKey_Handle, arg)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selObjectForKey_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("removeObjectForKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Remove(string aKey)
	{
		if (aKey == null)
		{
			throw new ArgumentNullException("aKey");
		}
		IntPtr arg = NSString.CreateNative(aKey);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveObjectForKey_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveObjectForKey_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("setObject:forKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetObject_ForKey_Handle, anObject.Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetObject_ForKey_Handle, anObject.Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("synchronize")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Synchronize()
	{
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selSynchronizeHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selSynchronizeHandle);
	}

	[Export("dictionaryRepresentation")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary ToDictionary()
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selDictionaryRepresentationHandle));
		}
		return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDictionaryRepresentationHandle));
	}

	[Export("setArray:forKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetArray_ForKey_Handle, nSArray.Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetArray_ForKey_Handle, nSArray.Handle, arg);
		}
		nSArray.Dispose();
		NSString.ReleaseNative(arg);
	}

	[Export("setBool:forKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual void _SetBool(bool value, string aKey)
	{
		if (aKey == null)
		{
			throw new ArgumentNullException("aKey");
		}
		IntPtr arg = NSString.CreateNative(aKey);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_bool_IntPtr(base.Handle, selSetBool_ForKey_Handle, value, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_bool_IntPtr(base.SuperHandle, selSetBool_ForKey_Handle, value, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("setData:forKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetData_ForKey_Handle, data.Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetData_ForKey_Handle, data.Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("setDictionary:forKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetDictionary_ForKey_Handle, aDictionary.Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetDictionary_ForKey_Handle, aDictionary.Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("setDouble:forKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual void _SetDouble(double value, string aKey)
	{
		if (aKey == null)
		{
			throw new ArgumentNullException("aKey");
		}
		IntPtr arg = NSString.CreateNative(aKey);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Double_IntPtr(base.Handle, selSetDouble_ForKey_Handle, value, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Double_IntPtr(base.SuperHandle, selSetDouble_ForKey_Handle, value, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("setLongLong:forKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual void _SetLong(long value, string aKey)
	{
		if (aKey == null)
		{
			throw new ArgumentNullException("aKey");
		}
		IntPtr arg = NSString.CreateNative(aKey);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Int64_IntPtr(base.Handle, selSetLongLong_ForKey_Handle, value, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64_IntPtr(base.SuperHandle, selSetLongLong_ForKey_Handle, value, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("setString:forKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetString_ForKey_Handle, arg, arg2);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetString_ForKey_Handle, arg, arg2);
		}
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
	}
}
