using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSBundle", true)]
public class NSBundle : NSObject
{
	private static readonly IntPtr selMainBundleHandle = Selector.GetHandle("mainBundle");

	private static readonly IntPtr selAllBundlesHandle = Selector.GetHandle("allBundles");

	private static readonly IntPtr selAllFrameworksHandle = Selector.GetHandle("allFrameworks");

	private static readonly IntPtr selIsLoadedHandle = Selector.GetHandle("isLoaded");

	private static readonly IntPtr selBundlePathHandle = Selector.GetHandle("bundlePath");

	private static readonly IntPtr selResourcePathHandle = Selector.GetHandle("resourcePath");

	private static readonly IntPtr selExecutablePathHandle = Selector.GetHandle("executablePath");

	private static readonly IntPtr selPrivateFrameworksPathHandle = Selector.GetHandle("privateFrameworksPath");

	private static readonly IntPtr selSharedFrameworksPathHandle = Selector.GetHandle("sharedFrameworksPath");

	private static readonly IntPtr selSharedSupportPathHandle = Selector.GetHandle("sharedSupportPath");

	private static readonly IntPtr selBuiltInPlugInsPathHandle = Selector.GetHandle("builtInPlugInsPath");

	private static readonly IntPtr selBundleIdentifierHandle = Selector.GetHandle("bundleIdentifier");

	private static readonly IntPtr selPrincipalClassHandle = Selector.GetHandle("principalClass");

	private static readonly IntPtr selDevelopmentLocalizationHandle = Selector.GetHandle("developmentLocalization");

	private static readonly IntPtr selInfoDictionaryHandle = Selector.GetHandle("infoDictionary");

	private static readonly IntPtr selAppStoreReceiptURLHandle = Selector.GetHandle("appStoreReceiptURL");

	private static readonly IntPtr selBundleURLHandle = Selector.GetHandle("bundleURL");

	private static readonly IntPtr selResourceURLHandle = Selector.GetHandle("resourceURL");

	private static readonly IntPtr selExecutableURLHandle = Selector.GetHandle("executableURL");

	private static readonly IntPtr selPrivateFrameworksURLHandle = Selector.GetHandle("privateFrameworksURL");

	private static readonly IntPtr selSharedFrameworksURLHandle = Selector.GetHandle("sharedFrameworksURL");

	private static readonly IntPtr selSharedSupportURLHandle = Selector.GetHandle("sharedSupportURL");

	private static readonly IntPtr selBuiltInPlugInsURLHandle = Selector.GetHandle("builtInPlugInsURL");

	private static readonly IntPtr selPreferredLocalizationsHandle = Selector.GetHandle("preferredLocalizations");

	private static readonly IntPtr selLocalizationsHandle = Selector.GetHandle("localizations");

	private static readonly IntPtr selBundleWithPath_Handle = Selector.GetHandle("bundleWithPath:");

	private static readonly IntPtr selInitWithPath_Handle = Selector.GetHandle("initWithPath:");

	private static readonly IntPtr selBundleForClass_Handle = Selector.GetHandle("bundleForClass:");

	private static readonly IntPtr selBundleWithIdentifier_Handle = Selector.GetHandle("bundleWithIdentifier:");

	private static readonly IntPtr selLoadHandle = Selector.GetHandle("load");

	private static readonly IntPtr selUnloadHandle = Selector.GetHandle("unload");

	private static readonly IntPtr selPathForAuxiliaryExecutable_Handle = Selector.GetHandle("pathForAuxiliaryExecutable:");

	private static readonly IntPtr selClassNamed_Handle = Selector.GetHandle("classNamed:");

	private static readonly IntPtr selPathForResourceOfTypeInDirectory_Handle = Selector.GetHandle("pathForResource:ofType:inDirectory:");

	private static readonly IntPtr selPathForResourceOfType_Handle = Selector.GetHandle("pathForResource:ofType:");

	private static readonly IntPtr selPathForResourceOfTypeInDirectoryForLocalization_Handle = Selector.GetHandle("pathForResource:ofType:inDirectory:forLocalization:");

	private static readonly IntPtr selLocalizedStringForKeyValueTable_Handle = Selector.GetHandle("localizedStringForKey:value:table:");

	private static readonly IntPtr selObjectForInfoDictionaryKey_Handle = Selector.GetHandle("objectForInfoDictionaryKey:");

	private static readonly IntPtr selLoadNibNamedOwner_Handle = Selector.GetHandle("loadNibNamed:owner:");

	private static readonly IntPtr selPathForImageResource_Handle = Selector.GetHandle("pathForImageResource:");

	private static readonly IntPtr selPathForSoundResource_Handle = Selector.GetHandle("pathForSoundResource:");

	private static readonly IntPtr selURLForAuxiliaryExecutable_Handle = Selector.GetHandle("URLForAuxiliaryExecutable:");

	private static readonly IntPtr selInitWithURL_Handle = Selector.GetHandle("initWithURL:");

	private static readonly IntPtr selBundleWithURL_Handle = Selector.GetHandle("bundleWithURL:");

	private static readonly IntPtr selPathsForResourcesOfTypeInDirectory_Handle = Selector.GetHandle("pathsForResourcesOfType:inDirectory:");

	private static readonly IntPtr selPathsForResourcesOfTypeInDirectoryForLocalization_Handle = Selector.GetHandle("pathsForResourcesOfType:inDirectory:forLocalization:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSBundle");

	private static object __mt_MainBundle_var_static;

	private static object __mt__AllBundles_var_static;

	private static object __mt_AllFrameworks_var_static;

	private object __mt_InfoDictionary_var;

	private object __mt_AppStoreReceiptUrl_var;

	private object __mt_BundleUrl_var;

	private object __mt_ResourceUrl_var;

	private object __mt_ExecutableUrl_var;

	private object __mt_PrivateFrameworksUrl_var;

	private object __mt_SharedFrameworksUrl_var;

	private object __mt_SharedSupportUrl_var;

	private object __mt_BuiltInPluginsUrl_var;

	public override IntPtr ClassHandle => class_ptr;

	public static NSBundle MainBundle
	{
		[Export("mainBundle")]
		get
		{
			return (NSBundle)(__mt_MainBundle_var_static = (NSBundle)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selMainBundleHandle)));
		}
	}

	public static NSBundle[] _AllBundles
	{
		[Export("allBundles")]
		get
		{
			return (NSBundle[])(__mt__AllBundles_var_static = NSArray.ArrayFromHandle<NSBundle>(Messaging.IntPtr_objc_msgSend(class_ptr, selAllBundlesHandle)));
		}
	}

	public static NSBundle[] AllFrameworks
	{
		[Export("allFrameworks")]
		get
		{
			return (NSBundle[])(__mt_AllFrameworks_var_static = NSArray.ArrayFromHandle<NSBundle>(Messaging.IntPtr_objc_msgSend(class_ptr, selAllFrameworksHandle)));
		}
	}

	public virtual bool IsLoaded
	{
		[Export("isLoaded")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsLoadedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsLoadedHandle);
		}
	}

	public virtual string BundlePath
	{
		[Export("bundlePath")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selBundlePathHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBundlePathHandle));
		}
	}

	public virtual string ResourcePath
	{
		[Export("resourcePath")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selResourcePathHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selResourcePathHandle));
		}
	}

	public virtual string ExecutablePath
	{
		[Export("executablePath")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selExecutablePathHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selExecutablePathHandle));
		}
	}

	public virtual string PrivateFrameworksPath
	{
		[Export("privateFrameworksPath")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selPrivateFrameworksPathHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPrivateFrameworksPathHandle));
		}
	}

	public virtual string SharedFrameworksPath
	{
		[Export("sharedFrameworksPath")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selSharedFrameworksPathHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSharedFrameworksPathHandle));
		}
	}

	public virtual string SharedSupportPath
	{
		[Export("sharedSupportPath")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selSharedSupportPathHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSharedSupportPathHandle));
		}
	}

	public virtual string BuiltinPluginsPath
	{
		[Export("builtInPlugInsPath")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selBuiltInPlugInsPathHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBuiltInPlugInsPathHandle));
		}
	}

	public virtual string BundleIdentifier
	{
		[Export("bundleIdentifier")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selBundleIdentifierHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBundleIdentifierHandle));
		}
	}

	public virtual Class PrincipalClass
	{
		[Export("principalClass")]
		get
		{
			if (IsDirectBinding)
			{
				return new Class(Messaging.IntPtr_objc_msgSend(base.Handle, selPrincipalClassHandle));
			}
			return new Class(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPrincipalClassHandle));
		}
	}

	public virtual string DevelopmentLocalization
	{
		[Export("developmentLocalization")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selDevelopmentLocalizationHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDevelopmentLocalizationHandle));
		}
	}

	public virtual NSDictionary InfoDictionary
	{
		[Export("infoDictionary")]
		get
		{
			return (NSDictionary)(__mt_InfoDictionary_var = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInfoDictionaryHandle))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selInfoDictionaryHandle)))));
		}
	}

	public virtual NSUrl AppStoreReceiptUrl
	{
		[Export("appStoreReceiptURL")]
		get
		{
			return (NSUrl)(__mt_AppStoreReceiptUrl_var = ((!IsDirectBinding) ? ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAppStoreReceiptURLHandle))) : ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAppStoreReceiptURLHandle)))));
		}
	}

	[Since(4, 0)]
	public virtual NSUrl BundleUrl
	{
		[Export("bundleURL")]
		get
		{
			return (NSUrl)(__mt_BundleUrl_var = ((!IsDirectBinding) ? ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBundleURLHandle))) : ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selBundleURLHandle)))));
		}
	}

	[Since(4, 0)]
	public virtual NSUrl ResourceUrl
	{
		[Export("resourceURL")]
		get
		{
			return (NSUrl)(__mt_ResourceUrl_var = ((!IsDirectBinding) ? ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selResourceURLHandle))) : ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selResourceURLHandle)))));
		}
	}

	[Since(4, 0)]
	public virtual NSUrl ExecutableUrl
	{
		[Export("executableURL")]
		get
		{
			return (NSUrl)(__mt_ExecutableUrl_var = ((!IsDirectBinding) ? ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selExecutableURLHandle))) : ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selExecutableURLHandle)))));
		}
	}

	[Since(4, 0)]
	public virtual NSUrl PrivateFrameworksUrl
	{
		[Export("privateFrameworksURL")]
		get
		{
			return (NSUrl)(__mt_PrivateFrameworksUrl_var = ((!IsDirectBinding) ? ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPrivateFrameworksURLHandle))) : ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selPrivateFrameworksURLHandle)))));
		}
	}

	[Since(4, 0)]
	public virtual NSUrl SharedFrameworksUrl
	{
		[Export("sharedFrameworksURL")]
		get
		{
			return (NSUrl)(__mt_SharedFrameworksUrl_var = ((!IsDirectBinding) ? ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSharedFrameworksURLHandle))) : ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selSharedFrameworksURLHandle)))));
		}
	}

	[Since(4, 0)]
	public virtual NSUrl SharedSupportUrl
	{
		[Export("sharedSupportURL")]
		get
		{
			return (NSUrl)(__mt_SharedSupportUrl_var = ((!IsDirectBinding) ? ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSharedSupportURLHandle))) : ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selSharedSupportURLHandle)))));
		}
	}

	[Since(4, 0)]
	public virtual NSUrl BuiltInPluginsUrl
	{
		[Export("builtInPlugInsURL")]
		get
		{
			return (NSUrl)(__mt_BuiltInPluginsUrl_var = ((!IsDirectBinding) ? ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBuiltInPlugInsURLHandle))) : ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selBuiltInPlugInsURLHandle)))));
		}
	}

	public virtual string[] PreferredLocalizations
	{
		[Export("preferredLocalizations")]
		get
		{
			if (IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selPreferredLocalizationsHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPreferredLocalizationsHandle));
		}
	}

	public virtual string[] Localizations
	{
		[Export("localizations")]
		get
		{
			if (IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selLocalizationsHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLocalizationsHandle));
		}
	}

	public string LocalizedString(string key, string comment)
	{
		return LocalizedString(key, "", "");
	}

	public string LocalizedString(string key, string val, string table, string comment)
	{
		return LocalizedString(key, val, table);
	}

	public string[] PathsForResources(string fileExtension)
	{
		return PathsForResources(fileExtension, null);
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSBundle(NSCoder coder)
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
	public NSBundle(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSBundle(IntPtr handle)
		: base(handle)
	{
	}

	[Export("bundleWithPath:")]
	public static NSBundle FromPath(string path)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = NSString.CreateNative(path);
		NSBundle result = (NSBundle)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selBundleWithPath_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("initWithPath:")]
	public NSBundle(string path)
		: base(NSObjectFlag.Empty)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = NSString.CreateNative(path);
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithPath_Handle, arg);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithPath_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("bundleForClass:")]
	public static NSBundle FromClass(Class c)
	{
		if (c == null)
		{
			throw new ArgumentNullException("c");
		}
		return (NSBundle)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selBundleForClass_Handle, c.Handle));
	}

	[Export("bundleWithIdentifier:")]
	public static NSBundle FromIdentifier(string str)
	{
		if (str == null)
		{
			throw new ArgumentNullException("str");
		}
		IntPtr arg = NSString.CreateNative(str);
		NSBundle result = (NSBundle)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selBundleWithIdentifier_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("load")]
	public virtual bool Load()
	{
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selLoadHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selLoadHandle);
	}

	[Export("unload")]
	public virtual bool Unload()
	{
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selUnloadHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selUnloadHandle);
	}

	[Export("pathForAuxiliaryExecutable:")]
	public virtual string PathForAuxiliaryExecutable(string s)
	{
		if (s == null)
		{
			throw new ArgumentNullException("s");
		}
		IntPtr arg = NSString.CreateNative(s);
		string result = ((!IsDirectBinding) ? NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selPathForAuxiliaryExecutable_Handle, arg)) : NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selPathForAuxiliaryExecutable_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("classNamed:")]
	public virtual Class ClassNamed(string className)
	{
		if (className == null)
		{
			throw new ArgumentNullException("className");
		}
		IntPtr arg = NSString.CreateNative(className);
		Class result = ((!IsDirectBinding) ? new Class(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selClassNamed_Handle, arg)) : new Class(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selClassNamed_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("pathForResource:ofType:inDirectory:")]
	public static string PathForResourceAbsolute(string name, string ofType, string bundleDirectory)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (bundleDirectory == null)
		{
			throw new ArgumentNullException("bundleDirectory");
		}
		IntPtr arg = NSString.CreateNative(name);
		IntPtr arg2 = NSString.CreateNative(ofType);
		IntPtr arg3 = NSString.CreateNative(bundleDirectory);
		string result = NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(class_ptr, selPathForResourceOfTypeInDirectory_Handle, arg, arg2, arg3));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		NSString.ReleaseNative(arg3);
		return result;
	}

	[Export("pathForResource:ofType:")]
	public virtual string PathForResource(string name, string ofType)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		IntPtr arg2 = NSString.CreateNative(ofType);
		string result = ((!IsDirectBinding) ? NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selPathForResourceOfType_Handle, arg, arg2)) : NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selPathForResourceOfType_Handle, arg, arg2)));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	[Export("pathForResource:ofType:inDirectory:forLocalization:")]
	public virtual string PathForResource(string name, string ofType, string subpath, string localizationName)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (subpath == null)
		{
			throw new ArgumentNullException("subpath");
		}
		if (localizationName == null)
		{
			throw new ArgumentNullException("localizationName");
		}
		IntPtr arg = NSString.CreateNative(name);
		IntPtr arg2 = NSString.CreateNative(ofType);
		IntPtr arg3 = NSString.CreateNative(subpath);
		IntPtr arg4 = NSString.CreateNative(localizationName);
		string result = ((!IsDirectBinding) ? NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selPathForResourceOfTypeInDirectoryForLocalization_Handle, arg, arg2, arg3, arg4)) : NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selPathForResourceOfTypeInDirectoryForLocalization_Handle, arg, arg2, arg3, arg4)));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		NSString.ReleaseNative(arg3);
		NSString.ReleaseNative(arg4);
		return result;
	}

	[Export("localizedStringForKey:value:table:")]
	public virtual string LocalizedString(string key, string value, string table)
	{
		IntPtr arg = NSString.CreateNative(key);
		IntPtr arg2 = NSString.CreateNative(value);
		IntPtr arg3 = NSString.CreateNative(table);
		string result = ((!IsDirectBinding) ? NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selLocalizedStringForKeyValueTable_Handle, arg, arg2, arg3)) : NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selLocalizedStringForKeyValueTable_Handle, arg, arg2, arg3)));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		NSString.ReleaseNative(arg3);
		return result;
	}

	[Export("objectForInfoDictionaryKey:")]
	public virtual NSObject ObjectForInfoDictionary(string key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		NSObject result = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selObjectForInfoDictionaryKey_Handle, arg)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selObjectForInfoDictionaryKey_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("loadNibNamed:owner:")]
	public static bool LoadNib(string nibName, NSObject owner)
	{
		if (nibName == null)
		{
			throw new ArgumentNullException("nibName");
		}
		if (owner == null)
		{
			throw new ArgumentNullException("owner");
		}
		IntPtr arg = NSString.CreateNative(nibName);
		bool result = Messaging.bool_objc_msgSend_IntPtr_IntPtr(class_ptr, selLoadNibNamedOwner_Handle, arg, owner.Handle);
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("pathForImageResource:")]
	public virtual string PathForImageResource(string resource)
	{
		if (resource == null)
		{
			throw new ArgumentNullException("resource");
		}
		IntPtr arg = NSString.CreateNative(resource);
		string result = ((!IsDirectBinding) ? NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selPathForImageResource_Handle, arg)) : NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selPathForImageResource_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("pathForSoundResource:")]
	public virtual string PathForSoundResource(string resource)
	{
		if (resource == null)
		{
			throw new ArgumentNullException("resource");
		}
		IntPtr arg = NSString.CreateNative(resource);
		string result = ((!IsDirectBinding) ? NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selPathForSoundResource_Handle, arg)) : NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selPathForSoundResource_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("URLForAuxiliaryExecutable:")]
	public virtual NSUrl UrlForAuxiliaryExecutable(string executable)
	{
		if (executable == null)
		{
			throw new ArgumentNullException("executable");
		}
		IntPtr arg = NSString.CreateNative(executable);
		NSUrl result = ((!IsDirectBinding) ? ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selURLForAuxiliaryExecutable_Handle, arg))) : ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selURLForAuxiliaryExecutable_Handle, arg))));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("initWithURL:")]
	public NSBundle(NSUrl url)
		: base(NSObjectFlag.Empty)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithURL_Handle, url.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithURL_Handle, url.Handle);
		}
	}

	[Export("bundleWithURL:")]
	public static NSBundle FromUrl(NSUrl url)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		return (NSBundle)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selBundleWithURL_Handle, url.Handle));
	}

	[Export("pathsForResourcesOfType:inDirectory:")]
	public virtual string[] PathsForResources(string fileExtension, string subDirectory)
	{
		if (fileExtension == null)
		{
			throw new ArgumentNullException("fileExtension");
		}
		IntPtr arg = NSString.CreateNative(fileExtension);
		IntPtr arg2 = NSString.CreateNative(subDirectory);
		string[] result = ((!IsDirectBinding) ? NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selPathsForResourcesOfTypeInDirectory_Handle, arg, arg2)) : NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selPathsForResourcesOfTypeInDirectory_Handle, arg, arg2)));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	[Export("pathsForResourcesOfType:inDirectory:forLocalization:")]
	public virtual string[] PathsForResources(string fileExtension, string subDirectory, string localizationName)
	{
		if (fileExtension == null)
		{
			throw new ArgumentNullException("fileExtension");
		}
		IntPtr arg = NSString.CreateNative(fileExtension);
		IntPtr arg2 = NSString.CreateNative(subDirectory);
		IntPtr arg3 = NSString.CreateNative(localizationName);
		string[] result = ((!IsDirectBinding) ? NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selPathsForResourcesOfTypeInDirectoryForLocalization_Handle, arg, arg2, arg3)) : NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selPathsForResourcesOfTypeInDirectoryForLocalization_Handle, arg, arg2, arg3)));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		NSString.ReleaseNative(arg3);
		return result;
	}

	[Export("pathsForResourcesOfType:inDirectory:")]
	public static string[] GetPathsForResources(string fileExtension, string bundlePath)
	{
		if (fileExtension == null)
		{
			throw new ArgumentNullException("fileExtension");
		}
		if (bundlePath == null)
		{
			throw new ArgumentNullException("bundlePath");
		}
		IntPtr arg = NSString.CreateNative(fileExtension);
		IntPtr arg2 = NSString.CreateNative(bundlePath);
		string[] result = NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selPathsForResourcesOfTypeInDirectory_Handle, arg, arg2));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_InfoDictionary_var = null;
			__mt_AppStoreReceiptUrl_var = null;
			__mt_BundleUrl_var = null;
			__mt_ResourceUrl_var = null;
			__mt_ExecutableUrl_var = null;
			__mt_PrivateFrameworksUrl_var = null;
			__mt_SharedFrameworksUrl_var = null;
			__mt_SharedSupportUrl_var = null;
			__mt_BuiltInPluginsUrl_var = null;
		}
	}
}
