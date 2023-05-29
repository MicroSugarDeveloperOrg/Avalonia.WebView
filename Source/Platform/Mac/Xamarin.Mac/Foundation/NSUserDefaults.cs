using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSUserDefaults", true)]
public class NSUserDefaults : NSObject
{
	private static readonly IntPtr selStandardUserDefaultsHandle = Selector.GetHandle("standardUserDefaults");

	private static readonly IntPtr selResetStandardUserDefaultsHandle = Selector.GetHandle("resetStandardUserDefaults");

	private static readonly IntPtr selInitWithUser_Handle = Selector.GetHandle("initWithUser:");

	private static readonly IntPtr selObjectForKey_Handle = Selector.GetHandle("objectForKey:");

	private static readonly IntPtr selSetObjectForKey_Handle = Selector.GetHandle("setObject:forKey:");

	private static readonly IntPtr selRemoveObjectForKey_Handle = Selector.GetHandle("removeObjectForKey:");

	private static readonly IntPtr selStringForKey_Handle = Selector.GetHandle("stringForKey:");

	private static readonly IntPtr selArrayForKey_Handle = Selector.GetHandle("arrayForKey:");

	private static readonly IntPtr selDictionaryForKey_Handle = Selector.GetHandle("dictionaryForKey:");

	private static readonly IntPtr selDataForKey_Handle = Selector.GetHandle("dataForKey:");

	private static readonly IntPtr selStringArrayForKey_Handle = Selector.GetHandle("stringArrayForKey:");

	private static readonly IntPtr selIntegerForKey_Handle = Selector.GetHandle("integerForKey:");

	private static readonly IntPtr selFloatForKey_Handle = Selector.GetHandle("floatForKey:");

	private static readonly IntPtr selDoubleForKey_Handle = Selector.GetHandle("doubleForKey:");

	private static readonly IntPtr selBoolForKey_Handle = Selector.GetHandle("boolForKey:");

	private static readonly IntPtr selSetIntegerForKey_Handle = Selector.GetHandle("setInteger:forKey:");

	private static readonly IntPtr selSetFloatForKey_Handle = Selector.GetHandle("setFloat:forKey:");

	private static readonly IntPtr selSetDoubleForKey_Handle = Selector.GetHandle("setDouble:forKey:");

	private static readonly IntPtr selSetBoolForKey_Handle = Selector.GetHandle("setBool:forKey:");

	private static readonly IntPtr selRegisterDefaults_Handle = Selector.GetHandle("registerDefaults:");

	private static readonly IntPtr selAddSuiteNamed_Handle = Selector.GetHandle("addSuiteNamed:");

	private static readonly IntPtr selRemoveSuiteNamed_Handle = Selector.GetHandle("removeSuiteNamed:");

	private static readonly IntPtr selDictionaryRepresentationHandle = Selector.GetHandle("dictionaryRepresentation");

	private static readonly IntPtr selVolatileDomainNamesHandle = Selector.GetHandle("volatileDomainNames");

	private static readonly IntPtr selVolatileDomainForName_Handle = Selector.GetHandle("volatileDomainForName:");

	private static readonly IntPtr selSetVolatileDomainForName_Handle = Selector.GetHandle("setVolatileDomain:forName:");

	private static readonly IntPtr selRemoveVolatileDomainForName_Handle = Selector.GetHandle("removeVolatileDomainForName:");

	private static readonly IntPtr selPersistentDomainNamesHandle = Selector.GetHandle("persistentDomainNames");

	private static readonly IntPtr selPersistentDomainForName_Handle = Selector.GetHandle("persistentDomainForName:");

	private static readonly IntPtr selSetPersistentDomainForName_Handle = Selector.GetHandle("setPersistentDomain:forName:");

	private static readonly IntPtr selRemovePersistentDomainForName_Handle = Selector.GetHandle("removePersistentDomainForName:");

	private static readonly IntPtr selSynchronizeHandle = Selector.GetHandle("synchronize");

	private static readonly IntPtr selObjectIsForcedForKey_Handle = Selector.GetHandle("objectIsForcedForKey:");

	private static readonly IntPtr selObjectIsForcedForKeyInDomain_Handle = Selector.GetHandle("objectIsForcedForKey:inDomain:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSUserDefaults");

	private static object __mt_StandardUserDefaults_var_static;

	private static NSString _GlobalDomain;

	private static NSString _ArgumentDomain;

	private static NSString _RegistrationDomain;

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

	public static NSUserDefaults StandardUserDefaults
	{
		[Export("standardUserDefaults")]
		get
		{
			return (NSUserDefaults)(__mt_StandardUserDefaults_var_static = (NSUserDefaults)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selStandardUserDefaultsHandle)));
		}
	}

	[Field("NSGlobalDomain", "Foundation")]
	public static NSString GlobalDomain
	{
		get
		{
			if (_GlobalDomain == null)
			{
				_GlobalDomain = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSGlobalDomain");
			}
			return _GlobalDomain;
		}
	}

	[Field("NSArgumentDomain", "Foundation")]
	public static NSString ArgumentDomain
	{
		get
		{
			if (_ArgumentDomain == null)
			{
				_ArgumentDomain = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSArgumentDomain");
			}
			return _ArgumentDomain;
		}
	}

	[Field("NSRegistrationDomain", "Foundation")]
	public static NSString RegistrationDomain
	{
		get
		{
			if (_RegistrationDomain == null)
			{
				_RegistrationDomain = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSRegistrationDomain");
			}
			return _RegistrationDomain;
		}
	}

	public void SetString(string value, string defaultName)
	{
		NSString nSString = new NSString(value);
		SetObjectForKey(nSString, defaultName);
		nSString.Dispose();
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSUserDefaults()
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
	public NSUserDefaults(NSCoder coder)
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
	public NSUserDefaults(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSUserDefaults(IntPtr handle)
		: base(handle)
	{
	}

	[Export("resetStandardUserDefaults")]
	public static void ResetStandardUserDefaults()
	{
		Messaging.void_objc_msgSend(class_ptr, selResetStandardUserDefaultsHandle);
	}

	[Export("initWithUser:")]
	public NSUserDefaults(string username)
		: base(NSObjectFlag.Empty)
	{
		if (username == null)
		{
			throw new ArgumentNullException("username");
		}
		IntPtr arg = NSString.CreateNative(username);
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithUser_Handle, arg);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithUser_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("objectForKey:")]
	internal virtual NSObject ObjectForKey(string defaultName)
	{
		if (defaultName == null)
		{
			throw new ArgumentNullException("defaultName");
		}
		IntPtr arg = NSString.CreateNative(defaultName);
		NSObject result = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selObjectForKey_Handle, arg)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selObjectForKey_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("setObject:forKey:")]
	internal virtual void SetObjectForKey(NSObject value, string defaultName)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		if (defaultName == null)
		{
			throw new ArgumentNullException("defaultName");
		}
		IntPtr arg = NSString.CreateNative(defaultName);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetObjectForKey_Handle, value.Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetObjectForKey_Handle, value.Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("removeObjectForKey:")]
	public virtual void RemoveObject(string defaultName)
	{
		if (defaultName == null)
		{
			throw new ArgumentNullException("defaultName");
		}
		IntPtr arg = NSString.CreateNative(defaultName);
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
	public virtual string StringForKey(string defaultName)
	{
		if (defaultName == null)
		{
			throw new ArgumentNullException("defaultName");
		}
		IntPtr arg = NSString.CreateNative(defaultName);
		string result = ((!IsDirectBinding) ? NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selStringForKey_Handle, arg)) : NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selStringForKey_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("arrayForKey:")]
	public virtual NSObject[] ArrayForKey(string defaultName)
	{
		if (defaultName == null)
		{
			throw new ArgumentNullException("defaultName");
		}
		IntPtr arg = NSString.CreateNative(defaultName);
		NSObject[] result = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selArrayForKey_Handle, arg)) : NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selArrayForKey_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("dictionaryForKey:")]
	public virtual NSDictionary DictionaryForKey(string defaultName)
	{
		if (defaultName == null)
		{
			throw new ArgumentNullException("defaultName");
		}
		IntPtr arg = NSString.CreateNative(defaultName);
		NSDictionary result = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selDictionaryForKey_Handle, arg))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selDictionaryForKey_Handle, arg))));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("dataForKey:")]
	public virtual NSData DataForKey(string defaultName)
	{
		if (defaultName == null)
		{
			throw new ArgumentNullException("defaultName");
		}
		IntPtr arg = NSString.CreateNative(defaultName);
		NSData result = ((!IsDirectBinding) ? ((NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selDataForKey_Handle, arg))) : ((NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selDataForKey_Handle, arg))));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("stringArrayForKey:")]
	public virtual string[] StringArrayForKey(string defaultName)
	{
		if (defaultName == null)
		{
			throw new ArgumentNullException("defaultName");
		}
		IntPtr arg = NSString.CreateNative(defaultName);
		string[] result = ((!IsDirectBinding) ? NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selStringArrayForKey_Handle, arg)) : NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selStringArrayForKey_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("integerForKey:")]
	public virtual int IntForKey(string defaultName)
	{
		if (defaultName == null)
		{
			throw new ArgumentNullException("defaultName");
		}
		IntPtr arg = NSString.CreateNative(defaultName);
		int result = ((!IsDirectBinding) ? Messaging.int_objc_msgSendSuper_IntPtr(base.SuperHandle, selIntegerForKey_Handle, arg) : Messaging.int_objc_msgSend_IntPtr(base.Handle, selIntegerForKey_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("floatForKey:")]
	public virtual float FloatForKey(string defaultName)
	{
		if (defaultName == null)
		{
			throw new ArgumentNullException("defaultName");
		}
		IntPtr arg = NSString.CreateNative(defaultName);
		float result = ((!IsDirectBinding) ? Messaging.float_objc_msgSendSuper_IntPtr(base.SuperHandle, selFloatForKey_Handle, arg) : Messaging.float_objc_msgSend_IntPtr(base.Handle, selFloatForKey_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("doubleForKey:")]
	public virtual double DoubleForKey(string defaultName)
	{
		if (defaultName == null)
		{
			throw new ArgumentNullException("defaultName");
		}
		IntPtr arg = NSString.CreateNative(defaultName);
		double result = ((!IsDirectBinding) ? Messaging.Double_objc_msgSendSuper_IntPtr(base.SuperHandle, selDoubleForKey_Handle, arg) : Messaging.Double_objc_msgSend_IntPtr(base.Handle, selDoubleForKey_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("boolForKey:")]
	public virtual bool BoolForKey(string defaultName)
	{
		if (defaultName == null)
		{
			throw new ArgumentNullException("defaultName");
		}
		IntPtr arg = NSString.CreateNative(defaultName);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selBoolForKey_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selBoolForKey_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("setInteger:forKey:")]
	public virtual void SetInt(int value, string defaultName)
	{
		if (defaultName == null)
		{
			throw new ArgumentNullException("defaultName");
		}
		IntPtr arg = NSString.CreateNative(defaultName);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_int_IntPtr(base.Handle, selSetIntegerForKey_Handle, value, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_int_IntPtr(base.SuperHandle, selSetIntegerForKey_Handle, value, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("setFloat:forKey:")]
	public virtual void SetFloat(float value, string defaultName)
	{
		if (defaultName == null)
		{
			throw new ArgumentNullException("defaultName");
		}
		IntPtr arg = NSString.CreateNative(defaultName);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_float_IntPtr(base.Handle, selSetFloatForKey_Handle, value, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_float_IntPtr(base.SuperHandle, selSetFloatForKey_Handle, value, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("setDouble:forKey:")]
	public virtual void SetDouble(double value, string defaultName)
	{
		if (defaultName == null)
		{
			throw new ArgumentNullException("defaultName");
		}
		IntPtr arg = NSString.CreateNative(defaultName);
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
	public virtual void SetBool(bool value, string defaultName)
	{
		if (defaultName == null)
		{
			throw new ArgumentNullException("defaultName");
		}
		IntPtr arg = NSString.CreateNative(defaultName);
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

	[Export("registerDefaults:")]
	public virtual void RegisterDefaults(NSDictionary registrationDictionary)
	{
		if (registrationDictionary == null)
		{
			throw new ArgumentNullException("registrationDictionary");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRegisterDefaults_Handle, registrationDictionary.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRegisterDefaults_Handle, registrationDictionary.Handle);
		}
	}

	[Export("addSuiteNamed:")]
	public virtual void AddSuite(string suiteName)
	{
		if (suiteName == null)
		{
			throw new ArgumentNullException("suiteName");
		}
		IntPtr arg = NSString.CreateNative(suiteName);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddSuiteNamed_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddSuiteNamed_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("removeSuiteNamed:")]
	public virtual void RemoveSuite(string suiteName)
	{
		if (suiteName == null)
		{
			throw new ArgumentNullException("suiteName");
		}
		IntPtr arg = NSString.CreateNative(suiteName);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveSuiteNamed_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveSuiteNamed_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("dictionaryRepresentation")]
	public virtual NSDictionary AsDictionary()
	{
		if (IsDirectBinding)
		{
			return (NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDictionaryRepresentationHandle));
		}
		return (NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDictionaryRepresentationHandle));
	}

	[Export("volatileDomainNames")]
	public virtual string[] VolatileDomainNames()
	{
		if (IsDirectBinding)
		{
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selVolatileDomainNamesHandle));
		}
		return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selVolatileDomainNamesHandle));
	}

	[Export("volatileDomainForName:")]
	public virtual NSDictionary GetVolatileDomain(string domainName)
	{
		if (domainName == null)
		{
			throw new ArgumentNullException("domainName");
		}
		IntPtr arg = NSString.CreateNative(domainName);
		NSDictionary result = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selVolatileDomainForName_Handle, arg))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selVolatileDomainForName_Handle, arg))));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("setVolatileDomain:forName:")]
	public virtual void SetVolatileDomain(NSDictionary domain, string domainName)
	{
		if (domain == null)
		{
			throw new ArgumentNullException("domain");
		}
		if (domainName == null)
		{
			throw new ArgumentNullException("domainName");
		}
		IntPtr arg = NSString.CreateNative(domainName);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetVolatileDomainForName_Handle, domain.Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetVolatileDomainForName_Handle, domain.Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("removeVolatileDomainForName:")]
	public virtual void RemoveVolatileDomain(string domainName)
	{
		if (domainName == null)
		{
			throw new ArgumentNullException("domainName");
		}
		IntPtr arg = NSString.CreateNative(domainName);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveVolatileDomainForName_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveVolatileDomainForName_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("persistentDomainNames")]
	public virtual string[] PersistentDomainNames()
	{
		if (IsDirectBinding)
		{
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selPersistentDomainNamesHandle));
		}
		return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPersistentDomainNamesHandle));
	}

	[Export("persistentDomainForName:")]
	public virtual NSDictionary PersistentDomainForName(string domainName)
	{
		if (domainName == null)
		{
			throw new ArgumentNullException("domainName");
		}
		IntPtr arg = NSString.CreateNative(domainName);
		NSDictionary result = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selPersistentDomainForName_Handle, arg))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selPersistentDomainForName_Handle, arg))));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("setPersistentDomain:forName:")]
	public virtual void SetPersistentDomain(NSDictionary domain, string domainName)
	{
		if (domain == null)
		{
			throw new ArgumentNullException("domain");
		}
		if (domainName == null)
		{
			throw new ArgumentNullException("domainName");
		}
		IntPtr arg = NSString.CreateNative(domainName);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetPersistentDomainForName_Handle, domain.Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetPersistentDomainForName_Handle, domain.Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("removePersistentDomainForName:")]
	public virtual void RemovePersistentDomain(string domainName)
	{
		if (domainName == null)
		{
			throw new ArgumentNullException("domainName");
		}
		IntPtr arg = NSString.CreateNative(domainName);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemovePersistentDomainForName_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemovePersistentDomainForName_Handle, arg);
		}
		NSString.ReleaseNative(arg);
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

	[Export("objectIsForcedForKey:")]
	public virtual bool ObjectIsForced(string key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selObjectIsForcedForKey_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selObjectIsForcedForKey_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("objectIsForcedForKey:inDomain:")]
	public virtual bool ObjectIsForced(string key, string domain)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (domain == null)
		{
			throw new ArgumentNullException("domain");
		}
		IntPtr arg = NSString.CreateNative(key);
		IntPtr arg2 = NSString.CreateNative(domain);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selObjectIsForcedForKeyInDomain_Handle, arg, arg2) : Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selObjectIsForcedForKeyInDomain_Handle, arg, arg2));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}
}
