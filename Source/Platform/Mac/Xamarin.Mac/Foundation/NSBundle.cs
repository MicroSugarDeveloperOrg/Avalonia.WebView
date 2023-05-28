using System;
using System.ComponentModel;
using AppKit;
using ObjCRuntime;

namespace Foundation;

[Register("NSBundle", true)]
public class NSBundle : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selURLForAuxiliaryExecutable_ = "URLForAuxiliaryExecutable:";

	private static readonly IntPtr selURLForAuxiliaryExecutable_Handle = Selector.GetHandle("URLForAuxiliaryExecutable:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selURLForImageResource_ = "URLForImageResource:";

	private static readonly IntPtr selURLForImageResource_Handle = Selector.GetHandle("URLForImageResource:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selURLForResource_WithExtension_ = "URLForResource:withExtension:";

	private static readonly IntPtr selURLForResource_WithExtension_Handle = Selector.GetHandle("URLForResource:withExtension:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selURLForResource_WithExtension_Subdirectory_ = "URLForResource:withExtension:subdirectory:";

	private static readonly IntPtr selURLForResource_WithExtension_Subdirectory_Handle = Selector.GetHandle("URLForResource:withExtension:subdirectory:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selURLForResource_WithExtension_Subdirectory_InBundleWithURL_ = "URLForResource:withExtension:subdirectory:inBundleWithURL:";

	private static readonly IntPtr selURLForResource_WithExtension_Subdirectory_InBundleWithURL_Handle = Selector.GetHandle("URLForResource:withExtension:subdirectory:inBundleWithURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selURLForResource_WithExtension_Subdirectory_Localization_ = "URLForResource:withExtension:subdirectory:localization:";

	private static readonly IntPtr selURLForResource_WithExtension_Subdirectory_Localization_Handle = Selector.GetHandle("URLForResource:withExtension:subdirectory:localization:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selURLsForResourcesWithExtension_Subdirectory_ = "URLsForResourcesWithExtension:subdirectory:";

	private static readonly IntPtr selURLsForResourcesWithExtension_Subdirectory_Handle = Selector.GetHandle("URLsForResourcesWithExtension:subdirectory:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selURLsForResourcesWithExtension_Subdirectory_InBundleWithURL_ = "URLsForResourcesWithExtension:subdirectory:inBundleWithURL:";

	private static readonly IntPtr selURLsForResourcesWithExtension_Subdirectory_InBundleWithURL_Handle = Selector.GetHandle("URLsForResourcesWithExtension:subdirectory:inBundleWithURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selURLsForResourcesWithExtension_Subdirectory_Localization_ = "URLsForResourcesWithExtension:subdirectory:localization:";

	private static readonly IntPtr selURLsForResourcesWithExtension_Subdirectory_Localization_Handle = Selector.GetHandle("URLsForResourcesWithExtension:subdirectory:localization:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllBundles = "allBundles";

	private static readonly IntPtr selAllBundlesHandle = Selector.GetHandle("allBundles");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllFrameworks = "allFrameworks";

	private static readonly IntPtr selAllFrameworksHandle = Selector.GetHandle("allFrameworks");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAppStoreReceiptURL = "appStoreReceiptURL";

	private static readonly IntPtr selAppStoreReceiptURLHandle = Selector.GetHandle("appStoreReceiptURL");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBuiltInPlugInsPath = "builtInPlugInsPath";

	private static readonly IntPtr selBuiltInPlugInsPathHandle = Selector.GetHandle("builtInPlugInsPath");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBuiltInPlugInsURL = "builtInPlugInsURL";

	private static readonly IntPtr selBuiltInPlugInsURLHandle = Selector.GetHandle("builtInPlugInsURL");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBundleForClass_ = "bundleForClass:";

	private static readonly IntPtr selBundleForClass_Handle = Selector.GetHandle("bundleForClass:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBundleIdentifier = "bundleIdentifier";

	private static readonly IntPtr selBundleIdentifierHandle = Selector.GetHandle("bundleIdentifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBundlePath = "bundlePath";

	private static readonly IntPtr selBundlePathHandle = Selector.GetHandle("bundlePath");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBundleURL = "bundleURL";

	private static readonly IntPtr selBundleURLHandle = Selector.GetHandle("bundleURL");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBundleWithIdentifier_ = "bundleWithIdentifier:";

	private static readonly IntPtr selBundleWithIdentifier_Handle = Selector.GetHandle("bundleWithIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBundleWithPath_ = "bundleWithPath:";

	private static readonly IntPtr selBundleWithPath_Handle = Selector.GetHandle("bundleWithPath:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBundleWithURL_ = "bundleWithURL:";

	private static readonly IntPtr selBundleWithURL_Handle = Selector.GetHandle("bundleWithURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selClassNamed_ = "classNamed:";

	private static readonly IntPtr selClassNamed_Handle = Selector.GetHandle("classNamed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContextHelpForKey_ = "contextHelpForKey:";

	private static readonly IntPtr selContextHelpForKey_Handle = Selector.GetHandle("contextHelpForKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDevelopmentLocalization = "developmentLocalization";

	private static readonly IntPtr selDevelopmentLocalizationHandle = Selector.GetHandle("developmentLocalization");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExecutablePath = "executablePath";

	private static readonly IntPtr selExecutablePathHandle = Selector.GetHandle("executablePath");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExecutableURL = "executableURL";

	private static readonly IntPtr selExecutableURLHandle = Selector.GetHandle("executableURL");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageForResource_ = "imageForResource:";

	private static readonly IntPtr selImageForResource_Handle = Selector.GetHandle("imageForResource:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInfoDictionary = "infoDictionary";

	private static readonly IntPtr selInfoDictionaryHandle = Selector.GetHandle("infoDictionary");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithPath_ = "initWithPath:";

	private static readonly IntPtr selInitWithPath_Handle = Selector.GetHandle("initWithPath:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithURL_ = "initWithURL:";

	private static readonly IntPtr selInitWithURL_Handle = Selector.GetHandle("initWithURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsLoaded = "isLoaded";

	private static readonly IntPtr selIsLoadedHandle = Selector.GetHandle("isLoaded");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLoad = "load";

	private static readonly IntPtr selLoadHandle = Selector.GetHandle("load");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLoadNibNamed_Owner_ = "loadNibNamed:owner:";

	private static readonly IntPtr selLoadNibNamed_Owner_Handle = Selector.GetHandle("loadNibNamed:owner:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLoadNibNamed_Owner_TopLevelObjects_ = "loadNibNamed:owner:topLevelObjects:";

	private static readonly IntPtr selLoadNibNamed_Owner_TopLevelObjects_Handle = Selector.GetHandle("loadNibNamed:owner:topLevelObjects:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLocalizations = "localizations";

	private static readonly IntPtr selLocalizationsHandle = Selector.GetHandle("localizations");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLocalizedStringForKey_Value_Table_ = "localizedStringForKey:value:table:";

	private static readonly IntPtr selLocalizedStringForKey_Value_Table_Handle = Selector.GetHandle("localizedStringForKey:value:table:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMainBundle = "mainBundle";

	private static readonly IntPtr selMainBundleHandle = Selector.GetHandle("mainBundle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selObjectForInfoDictionaryKey_ = "objectForInfoDictionaryKey:";

	private static readonly IntPtr selObjectForInfoDictionaryKey_Handle = Selector.GetHandle("objectForInfoDictionaryKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPathForAuxiliaryExecutable_ = "pathForAuxiliaryExecutable:";

	private static readonly IntPtr selPathForAuxiliaryExecutable_Handle = Selector.GetHandle("pathForAuxiliaryExecutable:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPathForImageResource_ = "pathForImageResource:";

	private static readonly IntPtr selPathForImageResource_Handle = Selector.GetHandle("pathForImageResource:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPathForResource_OfType_ = "pathForResource:ofType:";

	private static readonly IntPtr selPathForResource_OfType_Handle = Selector.GetHandle("pathForResource:ofType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPathForResource_OfType_InDirectory_ = "pathForResource:ofType:inDirectory:";

	private static readonly IntPtr selPathForResource_OfType_InDirectory_Handle = Selector.GetHandle("pathForResource:ofType:inDirectory:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPathForResource_OfType_InDirectory_ForLocalization_ = "pathForResource:ofType:inDirectory:forLocalization:";

	private static readonly IntPtr selPathForResource_OfType_InDirectory_ForLocalization_Handle = Selector.GetHandle("pathForResource:ofType:inDirectory:forLocalization:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPathForSoundResource_ = "pathForSoundResource:";

	private static readonly IntPtr selPathForSoundResource_Handle = Selector.GetHandle("pathForSoundResource:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPathsForResourcesOfType_InDirectory_ = "pathsForResourcesOfType:inDirectory:";

	private static readonly IntPtr selPathsForResourcesOfType_InDirectory_Handle = Selector.GetHandle("pathsForResourcesOfType:inDirectory:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPathsForResourcesOfType_InDirectory_ForLocalization_ = "pathsForResourcesOfType:inDirectory:forLocalization:";

	private static readonly IntPtr selPathsForResourcesOfType_InDirectory_ForLocalization_Handle = Selector.GetHandle("pathsForResourcesOfType:inDirectory:forLocalization:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreferredLocalizations = "preferredLocalizations";

	private static readonly IntPtr selPreferredLocalizationsHandle = Selector.GetHandle("preferredLocalizations");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrincipalClass = "principalClass";

	private static readonly IntPtr selPrincipalClassHandle = Selector.GetHandle("principalClass");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrivateFrameworksPath = "privateFrameworksPath";

	private static readonly IntPtr selPrivateFrameworksPathHandle = Selector.GetHandle("privateFrameworksPath");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrivateFrameworksURL = "privateFrameworksURL";

	private static readonly IntPtr selPrivateFrameworksURLHandle = Selector.GetHandle("privateFrameworksURL");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResourcePath = "resourcePath";

	private static readonly IntPtr selResourcePathHandle = Selector.GetHandle("resourcePath");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResourceURL = "resourceURL";

	private static readonly IntPtr selResourceURLHandle = Selector.GetHandle("resourceURL");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSharedFrameworksPath = "sharedFrameworksPath";

	private static readonly IntPtr selSharedFrameworksPathHandle = Selector.GetHandle("sharedFrameworksPath");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSharedFrameworksURL = "sharedFrameworksURL";

	private static readonly IntPtr selSharedFrameworksURLHandle = Selector.GetHandle("sharedFrameworksURL");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSharedSupportPath = "sharedSupportPath";

	private static readonly IntPtr selSharedSupportPathHandle = Selector.GetHandle("sharedSupportPath");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSharedSupportURL = "sharedSupportURL";

	private static readonly IntPtr selSharedSupportURLHandle = Selector.GetHandle("sharedSupportURL");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnload = "unload";

	private static readonly IntPtr selUnloadHandle = Selector.GetHandle("unload");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSBundle");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSBundle[] AllFrameworks
	{
		[Export("allFrameworks")]
		get
		{
			return NSArray.ArrayFromHandle<NSBundle>(Messaging.IntPtr_objc_msgSend(class_ptr, selAllFrameworksHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	public virtual NSUrl AppStoreReceiptUrl
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Export("appStoreReceiptURL")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend(base.Handle, selAppStoreReceiptURLHandle));
			}
			return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAppStoreReceiptURLHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl BuiltInPluginsUrl
	{
		[Export("builtInPlugInsURL")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend(base.Handle, selBuiltInPlugInsURLHandle));
			}
			return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBuiltInPlugInsURLHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string BuiltinPluginsPath
	{
		[Export("builtInPlugInsPath")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selBuiltInPlugInsPathHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBuiltInPlugInsPathHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string BundleIdentifier
	{
		[Export("bundleIdentifier")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selBundleIdentifierHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBundleIdentifierHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string BundlePath
	{
		[Export("bundlePath")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selBundlePathHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBundlePathHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl BundleUrl
	{
		[Export("bundleURL")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend(base.Handle, selBundleURLHandle));
			}
			return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBundleURLHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string DevelopmentLocalization
	{
		[Export("developmentLocalization")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selDevelopmentLocalizationHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDevelopmentLocalizationHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string ExecutablePath
	{
		[Export("executablePath")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selExecutablePathHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selExecutablePathHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl ExecutableUrl
	{
		[Export("executableURL")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend(base.Handle, selExecutableURLHandle));
			}
			return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selExecutableURLHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary InfoDictionary
	{
		[Export("infoDictionary")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selInfoDictionaryHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInfoDictionaryHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsLoaded
	{
		[Export("isLoaded")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsLoadedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsLoadedHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] Localizations
	{
		[Export("localizations")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selLocalizationsHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLocalizationsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSBundle MainBundle
	{
		[Export("mainBundle")]
		get
		{
			return Runtime.GetNSObject<NSBundle>(Messaging.IntPtr_objc_msgSend(class_ptr, selMainBundleHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] PreferredLocalizations
	{
		[Export("preferredLocalizations")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selPreferredLocalizationsHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPreferredLocalizationsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Class PrincipalClass
	{
		[Export("principalClass")]
		get
		{
			IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPrincipalClassHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selPrincipalClassHandle));
			return (intPtr == IntPtr.Zero) ? null : new Class(intPtr);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string PrivateFrameworksPath
	{
		[Export("privateFrameworksPath")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selPrivateFrameworksPathHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPrivateFrameworksPathHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl PrivateFrameworksUrl
	{
		[Export("privateFrameworksURL")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend(base.Handle, selPrivateFrameworksURLHandle));
			}
			return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPrivateFrameworksURLHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string ResourcePath
	{
		[Export("resourcePath")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selResourcePathHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selResourcePathHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl ResourceUrl
	{
		[Export("resourceURL")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend(base.Handle, selResourceURLHandle));
			}
			return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selResourceURLHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string SharedFrameworksPath
	{
		[Export("sharedFrameworksPath")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selSharedFrameworksPathHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSharedFrameworksPathHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl SharedFrameworksUrl
	{
		[Export("sharedFrameworksURL")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend(base.Handle, selSharedFrameworksURLHandle));
			}
			return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSharedFrameworksURLHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string SharedSupportPath
	{
		[Export("sharedSupportPath")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selSharedSupportPathHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSharedSupportPathHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl SharedSupportUrl
	{
		[Export("sharedSupportURL")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend(base.Handle, selSharedSupportURLHandle));
			}
			return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSharedSupportURLHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSBundle[] _AllBundles
	{
		[Export("allBundles")]
		get
		{
			return NSArray.ArrayFromHandle<NSBundle>(Messaging.IntPtr_objc_msgSend(class_ptr, selAllBundlesHandle));
		}
	}

	[Obsolete("Use 'GetLocalizedString' instead.")]
	public virtual string LocalizedString(string key, string value, string table)
	{
		return GetLocalizedString((NSString)key, (NSString)value, (NSString)table);
	}

	[Obsolete("Use 'GetLocalizedString' instead.")]
	public string LocalizedString(string key, string comment)
	{
		return LocalizedString(key, "", "");
	}

	[Obsolete("Use 'GetLocalizedString' instead.")]
	public string LocalizedString(string key, string val, string table, string comment)
	{
		return LocalizedString(key, val, table);
	}

	public NSString GetLocalizedString(string key, string value = null, string table = null)
	{
		return GetLocalizedString((NSString)key, (NSString)value, (NSString)table);
	}

	public string[] PathsForResources(string fileExtension)
	{
		return PathsForResources(fileExtension, null);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSBundle(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSBundle(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithPath:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSBundle(string path)
		: base(NSObjectFlag.Empty)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = NSString.CreateNative(path);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithPath_Handle, arg), "initWithPath:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithPath_Handle, arg), "initWithPath:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("initWithURL:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSBundle(NSUrl url)
		: base(NSObjectFlag.Empty)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithURL_Handle, url.Handle), "initWithURL:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithURL_Handle, url.Handle), "initWithURL:");
		}
	}

	[Export("classNamed:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Class ClassNamed(string className)
	{
		if (className == null)
		{
			throw new ArgumentNullException("className");
		}
		IntPtr arg = NSString.CreateNative(className);
		IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selClassNamed_Handle, arg) : Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selClassNamed_Handle, arg));
		NSString.ReleaseNative(arg);
		return (intPtr == IntPtr.Zero) ? null : new Class(intPtr);
	}

	[Export("bundleForClass:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSBundle FromClass(Class c)
	{
		if (c == null)
		{
			throw new ArgumentNullException("c");
		}
		return Runtime.GetNSObject<NSBundle>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selBundleForClass_Handle, c.Handle));
	}

	[Export("bundleWithIdentifier:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSBundle FromIdentifier(string str)
	{
		if (str == null)
		{
			throw new ArgumentNullException("str");
		}
		IntPtr arg = NSString.CreateNative(str);
		NSBundle nSObject = Runtime.GetNSObject<NSBundle>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selBundleWithIdentifier_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("bundleWithPath:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSBundle FromPath(string path)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = NSString.CreateNative(path);
		NSBundle nSObject = Runtime.GetNSObject<NSBundle>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selBundleWithPath_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("bundleWithURL:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSBundle FromUrl(NSUrl url)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		return Runtime.GetNSObject<NSBundle>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selBundleWithURL_Handle, url.Handle));
	}

	[Export("contextHelpForKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSAttributedString GetContextHelp(string key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		NSAttributedString result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSAttributedString>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selContextHelpForKey_Handle, arg)) : Runtime.GetNSObject<NSAttributedString>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selContextHelpForKey_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("localizedStringForKey:value:table:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSString GetLocalizedString(NSString? key, NSString? value, NSString? table)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selLocalizedStringForKey_Value_Table_Handle, (key == null) ? IntPtr.Zero : key.Handle, (value == null) ? IntPtr.Zero : value.Handle, (table == null) ? IntPtr.Zero : table.Handle));
		}
		return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selLocalizedStringForKey_Value_Table_Handle, (key == null) ? IntPtr.Zero : key.Handle, (value == null) ? IntPtr.Zero : value.Handle, (table == null) ? IntPtr.Zero : table.Handle));
	}

	[Export("pathsForResourcesOfType:inDirectory:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		string[] result = NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selPathsForResourcesOfType_InDirectory_Handle, arg, arg2));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	[Export("URLForImageResource:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl GetUrlForImageResource(string resource)
	{
		if (resource == null)
		{
			throw new ArgumentNullException("resource");
		}
		IntPtr arg = NSString.CreateNative(resource);
		NSUrl result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selURLForImageResource_Handle, arg)) : Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selURLForImageResource_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("URLForResource:withExtension:subdirectory:inBundleWithURL:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUrl GetUrlForResource(string name, string fileExtension, string? subdirectory, NSUrl bundleURL)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (fileExtension == null)
		{
			throw new ArgumentNullException("fileExtension");
		}
		if (bundleURL == null)
		{
			throw new ArgumentNullException("bundleURL");
		}
		IntPtr arg = NSString.CreateNative(name);
		IntPtr arg2 = NSString.CreateNative(fileExtension);
		IntPtr arg3 = NSString.CreateNative(subdirectory);
		NSUrl nSObject = Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(class_ptr, selURLForResource_WithExtension_Subdirectory_InBundleWithURL_Handle, arg, arg2, arg3, bundleURL.Handle));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		NSString.ReleaseNative(arg3);
		return nSObject;
	}

	[Export("URLForResource:withExtension:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl GetUrlForResource(string name, string fileExtension)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (fileExtension == null)
		{
			throw new ArgumentNullException("fileExtension");
		}
		IntPtr arg = NSString.CreateNative(name);
		IntPtr arg2 = NSString.CreateNative(fileExtension);
		NSUrl result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selURLForResource_WithExtension_Handle, arg, arg2)) : Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selURLForResource_WithExtension_Handle, arg, arg2)));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	[Export("URLForResource:withExtension:subdirectory:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl GetUrlForResource(string name, string fileExtension, string? subdirectory)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (fileExtension == null)
		{
			throw new ArgumentNullException("fileExtension");
		}
		IntPtr arg = NSString.CreateNative(name);
		IntPtr arg2 = NSString.CreateNative(fileExtension);
		IntPtr arg3 = NSString.CreateNative(subdirectory);
		NSUrl result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selURLForResource_WithExtension_Subdirectory_Handle, arg, arg2, arg3)) : Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selURLForResource_WithExtension_Subdirectory_Handle, arg, arg2, arg3)));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		NSString.ReleaseNative(arg3);
		return result;
	}

	[Export("URLForResource:withExtension:subdirectory:localization:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl GetUrlForResource(string name, string fileExtension, string? subdirectory, string? localizationName)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (fileExtension == null)
		{
			throw new ArgumentNullException("fileExtension");
		}
		IntPtr arg = NSString.CreateNative(name);
		IntPtr arg2 = NSString.CreateNative(fileExtension);
		IntPtr arg3 = NSString.CreateNative(subdirectory);
		IntPtr arg4 = NSString.CreateNative(localizationName);
		NSUrl result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selURLForResource_WithExtension_Subdirectory_Localization_Handle, arg, arg2, arg3, arg4)) : Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selURLForResource_WithExtension_Subdirectory_Localization_Handle, arg, arg2, arg3, arg4)));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		NSString.ReleaseNative(arg3);
		NSString.ReleaseNative(arg4);
		return result;
	}

	[Export("URLsForResourcesWithExtension:subdirectory:inBundleWithURL:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUrl[] GetUrlsForResourcesWithExtension(string fileExtension, string? subdirectory, NSUrl bundleURL)
	{
		if (fileExtension == null)
		{
			throw new ArgumentNullException("fileExtension");
		}
		if (bundleURL == null)
		{
			throw new ArgumentNullException("bundleURL");
		}
		IntPtr arg = NSString.CreateNative(fileExtension);
		IntPtr arg2 = NSString.CreateNative(subdirectory);
		NSUrl[] result = NSArray.ArrayFromHandle<NSUrl>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(class_ptr, selURLsForResourcesWithExtension_Subdirectory_InBundleWithURL_Handle, arg, arg2, bundleURL.Handle));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	[Export("URLsForResourcesWithExtension:subdirectory:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl[] GetUrlsForResourcesWithExtension(string fileExtension, string? subdirectory)
	{
		if (fileExtension == null)
		{
			throw new ArgumentNullException("fileExtension");
		}
		IntPtr arg = NSString.CreateNative(fileExtension);
		IntPtr arg2 = NSString.CreateNative(subdirectory);
		NSUrl[] result = ((!base.IsDirectBinding) ? NSArray.ArrayFromHandle<NSUrl>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selURLsForResourcesWithExtension_Subdirectory_Handle, arg, arg2)) : NSArray.ArrayFromHandle<NSUrl>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selURLsForResourcesWithExtension_Subdirectory_Handle, arg, arg2)));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	[Export("URLsForResourcesWithExtension:subdirectory:localization:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl[] GetUrlsForResourcesWithExtension(string fileExtension, string? subdirectory, string? localizationName)
	{
		if (fileExtension == null)
		{
			throw new ArgumentNullException("fileExtension");
		}
		IntPtr arg = NSString.CreateNative(fileExtension);
		IntPtr arg2 = NSString.CreateNative(subdirectory);
		IntPtr arg3 = NSString.CreateNative(localizationName);
		NSUrl[] result = ((!base.IsDirectBinding) ? NSArray.ArrayFromHandle<NSUrl>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selURLsForResourcesWithExtension_Subdirectory_Localization_Handle, arg, arg2, arg3)) : NSArray.ArrayFromHandle<NSUrl>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selURLsForResourcesWithExtension_Subdirectory_Localization_Handle, arg, arg2, arg3)));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		NSString.ReleaseNative(arg3);
		return result;
	}

	[Export("imageForResource:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSImage ImageForResource(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		NSImage result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSImage>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selImageForResource_Handle, arg)) : Runtime.GetNSObject<NSImage>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selImageForResource_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("load")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Load()
	{
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selLoadHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selLoadHandle);
	}

	[Export("loadNibNamed:owner:")]
	[Deprecated(PlatformName.MacOSX, 10, 8, PlatformArchitecture.None, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		bool result = Messaging.bool_objc_msgSend_IntPtr_IntPtr(class_ptr, selLoadNibNamed_Owner_Handle, arg, owner.Handle);
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("loadNibNamed:owner:topLevelObjects:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool LoadNibNamed(string nibName, NSObject? owner, out NSArray topLevelObjects)
	{
		if (nibName == null)
		{
			throw new ArgumentNullException("nibName");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr arg2 = NSString.CreateNative(nibName);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_ref_IntPtr(base.SuperHandle, selLoadNibNamed_Owner_TopLevelObjects_Handle, arg2, owner?.Handle ?? IntPtr.Zero, ref arg) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(base.Handle, selLoadNibNamed_Owner_TopLevelObjects_Handle, arg2, owner?.Handle ?? IntPtr.Zero, ref arg));
		NSString.ReleaseNative(arg2);
		topLevelObjects = Runtime.GetNSObject<NSArray>(arg);
		return result;
	}

	[Export("objectForInfoDictionaryKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject ObjectForInfoDictionary(string key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		NSObject result = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selObjectForInfoDictionaryKey_Handle, arg)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selObjectForInfoDictionaryKey_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("pathForAuxiliaryExecutable:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string PathForAuxiliaryExecutable(string s)
	{
		if (s == null)
		{
			throw new ArgumentNullException("s");
		}
		IntPtr arg = NSString.CreateNative(s);
		string result = ((!base.IsDirectBinding) ? NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selPathForAuxiliaryExecutable_Handle, arg)) : NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selPathForAuxiliaryExecutable_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("pathForImageResource:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string PathForImageResource(string resource)
	{
		if (resource == null)
		{
			throw new ArgumentNullException("resource");
		}
		IntPtr arg = NSString.CreateNative(resource);
		string result = ((!base.IsDirectBinding) ? NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selPathForImageResource_Handle, arg)) : NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selPathForImageResource_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("pathForResource:ofType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string PathForResource(string name, string? ofType)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		IntPtr arg2 = NSString.CreateNative(ofType);
		string result = ((!base.IsDirectBinding) ? NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selPathForResource_OfType_Handle, arg, arg2)) : NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selPathForResource_OfType_Handle, arg, arg2)));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	[Export("pathForResource:ofType:inDirectory:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string PathForResource(string name, string? ofType, string? subpath)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		IntPtr arg2 = NSString.CreateNative(ofType);
		IntPtr arg3 = NSString.CreateNative(subpath);
		string result = ((!base.IsDirectBinding) ? NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selPathForResource_OfType_InDirectory_Handle, arg, arg2, arg3)) : NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selPathForResource_OfType_InDirectory_Handle, arg, arg2, arg3)));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		NSString.ReleaseNative(arg3);
		return result;
	}

	[Export("pathForResource:ofType:inDirectory:forLocalization:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string PathForResource(string name, string? ofType, string subpath, string localizationName)
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
		string result = ((!base.IsDirectBinding) ? NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selPathForResource_OfType_InDirectory_ForLocalization_Handle, arg, arg2, arg3, arg4)) : NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selPathForResource_OfType_InDirectory_ForLocalization_Handle, arg, arg2, arg3, arg4)));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		NSString.ReleaseNative(arg3);
		NSString.ReleaseNative(arg4);
		return result;
	}

	[Export("pathForResource:ofType:inDirectory:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string PathForResourceAbsolute(string name, string? ofType, string bundleDirectory)
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
		string result = NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(class_ptr, selPathForResource_OfType_InDirectory_Handle, arg, arg2, arg3));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		NSString.ReleaseNative(arg3);
		return result;
	}

	[Export("pathForSoundResource:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string PathForSoundResource(string resource)
	{
		if (resource == null)
		{
			throw new ArgumentNullException("resource");
		}
		IntPtr arg = NSString.CreateNative(resource);
		string result = ((!base.IsDirectBinding) ? NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selPathForSoundResource_Handle, arg)) : NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selPathForSoundResource_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("pathsForResourcesOfType:inDirectory:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] PathsForResources(string fileExtension, string? subDirectory)
	{
		if (fileExtension == null)
		{
			throw new ArgumentNullException("fileExtension");
		}
		IntPtr arg = NSString.CreateNative(fileExtension);
		IntPtr arg2 = NSString.CreateNative(subDirectory);
		string[] result = ((!base.IsDirectBinding) ? NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selPathsForResourcesOfType_InDirectory_Handle, arg, arg2)) : NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selPathsForResourcesOfType_InDirectory_Handle, arg, arg2)));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	[Export("pathsForResourcesOfType:inDirectory:forLocalization:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] PathsForResources(string fileExtension, string? subDirectory, string? localizationName)
	{
		if (fileExtension == null)
		{
			throw new ArgumentNullException("fileExtension");
		}
		IntPtr arg = NSString.CreateNative(fileExtension);
		IntPtr arg2 = NSString.CreateNative(subDirectory);
		IntPtr arg3 = NSString.CreateNative(localizationName);
		string[] result = ((!base.IsDirectBinding) ? NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selPathsForResourcesOfType_InDirectory_ForLocalization_Handle, arg, arg2, arg3)) : NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selPathsForResourcesOfType_InDirectory_ForLocalization_Handle, arg, arg2, arg3)));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		NSString.ReleaseNative(arg3);
		return result;
	}

	[Export("unload")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Unload()
	{
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selUnloadHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selUnloadHandle);
	}

	[Export("URLForAuxiliaryExecutable:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl UrlForAuxiliaryExecutable(string executable)
	{
		if (executable == null)
		{
			throw new ArgumentNullException("executable");
		}
		IntPtr arg = NSString.CreateNative(executable);
		NSUrl result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selURLForAuxiliaryExecutable_Handle, arg)) : Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selURLForAuxiliaryExecutable_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}
}
