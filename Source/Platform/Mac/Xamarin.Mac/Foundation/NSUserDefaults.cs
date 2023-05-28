using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSUserDefaults", true)]
public class NSUserDefaults : NSObject
{
	public static class Notifications
	{
		public static NSObject ObserveDidChange(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveDidChange(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selURLForKey_ = "URLForKey:";

	private static readonly IntPtr selURLForKey_Handle = Selector.GetHandle("URLForKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddSuiteNamed_ = "addSuiteNamed:";

	private static readonly IntPtr selAddSuiteNamed_Handle = Selector.GetHandle("addSuiteNamed:");

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
	private const string selDictionaryForKey_ = "dictionaryForKey:";

	private static readonly IntPtr selDictionaryForKey_Handle = Selector.GetHandle("dictionaryForKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDictionaryRepresentation = "dictionaryRepresentation";

	private static readonly IntPtr selDictionaryRepresentationHandle = Selector.GetHandle("dictionaryRepresentation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDoubleForKey_ = "doubleForKey:";

	private static readonly IntPtr selDoubleForKey_Handle = Selector.GetHandle("doubleForKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFloatForKey_ = "floatForKey:";

	private static readonly IntPtr selFloatForKey_Handle = Selector.GetHandle("floatForKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSuiteName_ = "initWithSuiteName:";

	private static readonly IntPtr selInitWithSuiteName_Handle = Selector.GetHandle("initWithSuiteName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithUser_ = "initWithUser:";

	private static readonly IntPtr selInitWithUser_Handle = Selector.GetHandle("initWithUser:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIntegerForKey_ = "integerForKey:";

	private static readonly IntPtr selIntegerForKey_Handle = Selector.GetHandle("integerForKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selObjectForKey_ = "objectForKey:";

	private static readonly IntPtr selObjectForKey_Handle = Selector.GetHandle("objectForKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selObjectIsForcedForKey_ = "objectIsForcedForKey:";

	private static readonly IntPtr selObjectIsForcedForKey_Handle = Selector.GetHandle("objectIsForcedForKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selObjectIsForcedForKey_InDomain_ = "objectIsForcedForKey:inDomain:";

	private static readonly IntPtr selObjectIsForcedForKey_InDomain_Handle = Selector.GetHandle("objectIsForcedForKey:inDomain:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPersistentDomainForName_ = "persistentDomainForName:";

	private static readonly IntPtr selPersistentDomainForName_Handle = Selector.GetHandle("persistentDomainForName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPersistentDomainNames = "persistentDomainNames";

	private static readonly IntPtr selPersistentDomainNamesHandle = Selector.GetHandle("persistentDomainNames");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRegisterDefaults_ = "registerDefaults:";

	private static readonly IntPtr selRegisterDefaults_Handle = Selector.GetHandle("registerDefaults:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveObjectForKey_ = "removeObjectForKey:";

	private static readonly IntPtr selRemoveObjectForKey_Handle = Selector.GetHandle("removeObjectForKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemovePersistentDomainForName_ = "removePersistentDomainForName:";

	private static readonly IntPtr selRemovePersistentDomainForName_Handle = Selector.GetHandle("removePersistentDomainForName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveSuiteNamed_ = "removeSuiteNamed:";

	private static readonly IntPtr selRemoveSuiteNamed_Handle = Selector.GetHandle("removeSuiteNamed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveVolatileDomainForName_ = "removeVolatileDomainForName:";

	private static readonly IntPtr selRemoveVolatileDomainForName_Handle = Selector.GetHandle("removeVolatileDomainForName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResetStandardUserDefaults = "resetStandardUserDefaults";

	private static readonly IntPtr selResetStandardUserDefaultsHandle = Selector.GetHandle("resetStandardUserDefaults");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBool_ForKey_ = "setBool:forKey:";

	private static readonly IntPtr selSetBool_ForKey_Handle = Selector.GetHandle("setBool:forKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDouble_ForKey_ = "setDouble:forKey:";

	private static readonly IntPtr selSetDouble_ForKey_Handle = Selector.GetHandle("setDouble:forKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFloat_ForKey_ = "setFloat:forKey:";

	private static readonly IntPtr selSetFloat_ForKey_Handle = Selector.GetHandle("setFloat:forKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetInteger_ForKey_ = "setInteger:forKey:";

	private static readonly IntPtr selSetInteger_ForKey_Handle = Selector.GetHandle("setInteger:forKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetObject_ForKey_ = "setObject:forKey:";

	private static readonly IntPtr selSetObject_ForKey_Handle = Selector.GetHandle("setObject:forKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPersistentDomain_ForName_ = "setPersistentDomain:forName:";

	private static readonly IntPtr selSetPersistentDomain_ForName_Handle = Selector.GetHandle("setPersistentDomain:forName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetURL_ForKey_ = "setURL:forKey:";

	private static readonly IntPtr selSetURL_ForKey_Handle = Selector.GetHandle("setURL:forKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetVolatileDomain_ForName_ = "setVolatileDomain:forName:";

	private static readonly IntPtr selSetVolatileDomain_ForName_Handle = Selector.GetHandle("setVolatileDomain:forName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStandardUserDefaults = "standardUserDefaults";

	private static readonly IntPtr selStandardUserDefaultsHandle = Selector.GetHandle("standardUserDefaults");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStringArrayForKey_ = "stringArrayForKey:";

	private static readonly IntPtr selStringArrayForKey_Handle = Selector.GetHandle("stringArrayForKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStringForKey_ = "stringForKey:";

	private static readonly IntPtr selStringForKey_Handle = Selector.GetHandle("stringForKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSynchronize = "synchronize";

	private static readonly IntPtr selSynchronizeHandle = Selector.GetHandle("synchronize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVolatileDomainForName_ = "volatileDomainForName:";

	private static readonly IntPtr selVolatileDomainForName_Handle = Selector.GetHandle("volatileDomainForName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVolatileDomainNames = "volatileDomainNames";

	private static readonly IntPtr selVolatileDomainNamesHandle = Selector.GetHandle("volatileDomainNames");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSUserDefaults");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ArgumentDomain;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DidChangeNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GlobalDomain;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _RegistrationDomain;

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
	public static NSUserDefaults StandardUserDefaults
	{
		[Export("standardUserDefaults", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<NSUserDefaults>(Messaging.IntPtr_objc_msgSend(class_ptr, selStandardUserDefaultsHandle));
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

	[Field("NSUserDefaultsDidChangeNotification", "Foundation")]
	[Advice("Use NSUserDefaults.Notifications.ObserveDidChange helper method instead.")]
	public static NSString DidChangeNotification
	{
		get
		{
			if (_DidChangeNotification == null)
			{
				_DidChangeNotification = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSUserDefaultsDidChangeNotification");
			}
			return _DidChangeNotification;
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

	[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.None, null)]
	[Mac(10, 9)]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, null)]
	public NSUserDefaults(string name)
		: this(name, NSUserDefaultsType.UserName)
	{
	}

	[iOS(7, 0)]
	public NSUserDefaults(string name, NSUserDefaultsType type)
	{
		switch (type)
		{
		case NSUserDefaultsType.UserName:
			base.Handle = InitWithUserName(name);
			break;
		case NSUserDefaultsType.SuiteName:
			base.Handle = InitWithSuiteName(name);
			break;
		default:
			throw new ArgumentException("type");
		}
	}

	public void SetString(string value, string defaultName)
	{
		NSString nSString = new NSString(value);
		SetObjectForKey(nSString, defaultName);
		nSString.Dispose();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSUserDefaults()
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
	protected NSUserDefaults(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSUserDefaults(IntPtr handle)
		: base(handle)
	{
	}

	[Export("addSuiteNamed:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddSuite(string suiteName)
	{
		if (suiteName == null)
		{
			throw new ArgumentNullException("suiteName");
		}
		IntPtr arg = NSString.CreateNative(suiteName);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddSuiteNamed_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddSuiteNamed_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("arrayForKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject[] ArrayForKey(string defaultName)
	{
		if (defaultName == null)
		{
			throw new ArgumentNullException("defaultName");
		}
		IntPtr arg = NSString.CreateNative(defaultName);
		NSObject[] result = ((!base.IsDirectBinding) ? NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selArrayForKey_Handle, arg)) : NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selArrayForKey_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("boolForKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool BoolForKey(string defaultName)
	{
		if (defaultName == null)
		{
			throw new ArgumentNullException("defaultName");
		}
		IntPtr arg = NSString.CreateNative(defaultName);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selBoolForKey_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selBoolForKey_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("dataForKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSData DataForKey(string defaultName)
	{
		if (defaultName == null)
		{
			throw new ArgumentNullException("defaultName");
		}
		IntPtr arg = NSString.CreateNative(defaultName);
		NSData result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selDataForKey_Handle, arg)) : Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selDataForKey_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("dictionaryForKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary DictionaryForKey(string defaultName)
	{
		if (defaultName == null)
		{
			throw new ArgumentNullException("defaultName");
		}
		IntPtr arg = NSString.CreateNative(defaultName);
		NSDictionary result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selDictionaryForKey_Handle, arg)) : Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selDictionaryForKey_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("doubleForKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double DoubleForKey(string defaultName)
	{
		if (defaultName == null)
		{
			throw new ArgumentNullException("defaultName");
		}
		IntPtr arg = NSString.CreateNative(defaultName);
		double result = ((!base.IsDirectBinding) ? Messaging.Double_objc_msgSendSuper_IntPtr(base.SuperHandle, selDoubleForKey_Handle, arg) : Messaging.Double_objc_msgSend_IntPtr(base.Handle, selDoubleForKey_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("floatForKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float FloatForKey(string defaultName)
	{
		if (defaultName == null)
		{
			throw new ArgumentNullException("defaultName");
		}
		IntPtr arg = NSString.CreateNative(defaultName);
		float result = ((!base.IsDirectBinding) ? Messaging.float_objc_msgSendSuper_IntPtr(base.SuperHandle, selFloatForKey_Handle, arg) : Messaging.float_objc_msgSend_IntPtr(base.Handle, selFloatForKey_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("volatileDomainForName:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary GetVolatileDomain(string domainName)
	{
		if (domainName == null)
		{
			throw new ArgumentNullException("domainName");
		}
		IntPtr arg = NSString.CreateNative(domainName);
		NSDictionary result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selVolatileDomainForName_Handle, arg)) : Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selVolatileDomainForName_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("initWithSuiteName:")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual IntPtr InitWithSuiteName(string suiteName)
	{
		if (suiteName == null)
		{
			throw new ArgumentNullException("suiteName");
		}
		IntPtr arg = NSString.CreateNative(suiteName);
		IntPtr result = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithSuiteName_Handle, arg) : Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithSuiteName_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("initWithUser:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual IntPtr InitWithUserName(string username)
	{
		if (username == null)
		{
			throw new ArgumentNullException("username");
		}
		IntPtr arg = NSString.CreateNative(username);
		IntPtr result = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithUser_Handle, arg) : Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithUser_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("integerForKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint IntForKey(string defaultName)
	{
		if (defaultName == null)
		{
			throw new ArgumentNullException("defaultName");
		}
		IntPtr arg = NSString.CreateNative(defaultName);
		nint result = ((!base.IsDirectBinding) ? Messaging.nint_objc_msgSendSuper_IntPtr(base.SuperHandle, selIntegerForKey_Handle, arg) : Messaging.nint_objc_msgSend_IntPtr(base.Handle, selIntegerForKey_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("objectForKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual NSObject ObjectForKey(string defaultName)
	{
		if (defaultName == null)
		{
			throw new ArgumentNullException("defaultName");
		}
		IntPtr arg = NSString.CreateNative(defaultName);
		NSObject result = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selObjectForKey_Handle, arg)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selObjectForKey_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("objectIsForcedForKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ObjectIsForced(string key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selObjectIsForcedForKey_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selObjectIsForcedForKey_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("objectIsForcedForKey:inDomain:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selObjectIsForcedForKey_InDomain_Handle, arg, arg2) : Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selObjectIsForcedForKey_InDomain_Handle, arg, arg2));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	[Export("persistentDomainForName:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary PersistentDomainForName(string domainName)
	{
		if (domainName == null)
		{
			throw new ArgumentNullException("domainName");
		}
		IntPtr arg = NSString.CreateNative(domainName);
		NSDictionary result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selPersistentDomainForName_Handle, arg)) : Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selPersistentDomainForName_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("persistentDomainNames")]
	[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.MacOSX, 10, 9, PlatformArchitecture.None, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] PersistentDomainNames()
	{
		if (base.IsDirectBinding)
		{
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selPersistentDomainNamesHandle));
		}
		return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPersistentDomainNamesHandle));
	}

	[Export("registerDefaults:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RegisterDefaults(NSDictionary registrationDictionary)
	{
		if (registrationDictionary == null)
		{
			throw new ArgumentNullException("registrationDictionary");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRegisterDefaults_Handle, registrationDictionary.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRegisterDefaults_Handle, registrationDictionary.Handle);
		}
	}

	[Export("removeObjectForKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveObject(string defaultName)
	{
		if (defaultName == null)
		{
			throw new ArgumentNullException("defaultName");
		}
		IntPtr arg = NSString.CreateNative(defaultName);
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

	[Export("removePersistentDomainForName:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemovePersistentDomain(string domainName)
	{
		if (domainName == null)
		{
			throw new ArgumentNullException("domainName");
		}
		IntPtr arg = NSString.CreateNative(domainName);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemovePersistentDomainForName_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemovePersistentDomainForName_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("removeSuiteNamed:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveSuite(string suiteName)
	{
		if (suiteName == null)
		{
			throw new ArgumentNullException("suiteName");
		}
		IntPtr arg = NSString.CreateNative(suiteName);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveSuiteNamed_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveSuiteNamed_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("removeVolatileDomainForName:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveVolatileDomain(string domainName)
	{
		if (domainName == null)
		{
			throw new ArgumentNullException("domainName");
		}
		IntPtr arg = NSString.CreateNative(domainName);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveVolatileDomainForName_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveVolatileDomainForName_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("resetStandardUserDefaults")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void ResetStandardUserDefaults()
	{
		Messaging.void_objc_msgSend(class_ptr, selResetStandardUserDefaultsHandle);
	}

	[Export("setBool:forKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetBool(bool value, string defaultName)
	{
		if (defaultName == null)
		{
			throw new ArgumentNullException("defaultName");
		}
		IntPtr arg = NSString.CreateNative(defaultName);
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

	[Export("setDouble:forKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetDouble(double value, string defaultName)
	{
		if (defaultName == null)
		{
			throw new ArgumentNullException("defaultName");
		}
		IntPtr arg = NSString.CreateNative(defaultName);
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

	[Export("setFloat:forKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetFloat(float value, string defaultName)
	{
		if (defaultName == null)
		{
			throw new ArgumentNullException("defaultName");
		}
		IntPtr arg = NSString.CreateNative(defaultName);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_float_IntPtr(base.Handle, selSetFloat_ForKey_Handle, value, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_float_IntPtr(base.SuperHandle, selSetFloat_ForKey_Handle, value, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("setInteger:forKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetInt(nint value, string defaultName)
	{
		if (defaultName == null)
		{
			throw new ArgumentNullException("defaultName");
		}
		IntPtr arg = NSString.CreateNative(defaultName);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nint_IntPtr(base.Handle, selSetInteger_ForKey_Handle, value, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nint_IntPtr(base.SuperHandle, selSetInteger_ForKey_Handle, value, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("setObject:forKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetObject_ForKey_Handle, value.Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetObject_ForKey_Handle, value.Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("setPersistentDomain:forName:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetPersistentDomain_ForName_Handle, domain.Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetPersistentDomain_ForName_Handle, domain.Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("setURL:forKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetURL(NSUrl? url, string defaultName)
	{
		if (defaultName == null)
		{
			throw new ArgumentNullException("defaultName");
		}
		IntPtr arg = NSString.CreateNative(defaultName);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetURL_ForKey_Handle, (url == null) ? IntPtr.Zero : url.Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetURL_ForKey_Handle, (url == null) ? IntPtr.Zero : url.Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("setVolatileDomain:forName:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetVolatileDomain_ForName_Handle, domain.Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetVolatileDomain_ForName_Handle, domain.Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("stringArrayForKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] StringArrayForKey(string defaultName)
	{
		if (defaultName == null)
		{
			throw new ArgumentNullException("defaultName");
		}
		IntPtr arg = NSString.CreateNative(defaultName);
		string[] result = ((!base.IsDirectBinding) ? NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selStringArrayForKey_Handle, arg)) : NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selStringArrayForKey_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("stringForKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string StringForKey(string defaultName)
	{
		if (defaultName == null)
		{
			throw new ArgumentNullException("defaultName");
		}
		IntPtr arg = NSString.CreateNative(defaultName);
		string result = ((!base.IsDirectBinding) ? NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selStringForKey_Handle, arg)) : NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selStringForKey_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
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

	[Export("URLForKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl? URLForKey(string defaultName)
	{
		if (defaultName == null)
		{
			throw new ArgumentNullException("defaultName");
		}
		IntPtr arg = NSString.CreateNative(defaultName);
		NSUrl result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selURLForKey_Handle, arg)) : Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selURLForKey_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("volatileDomainNames")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] VolatileDomainNames()
	{
		if (base.IsDirectBinding)
		{
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selVolatileDomainNamesHandle));
		}
		return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selVolatileDomainNamesHandle));
	}
}
