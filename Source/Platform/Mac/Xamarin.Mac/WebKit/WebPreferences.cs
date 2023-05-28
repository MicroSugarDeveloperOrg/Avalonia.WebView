using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace WebKit;

[Register("WebPreferences", true)]
[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "No longer supported.")]
public class WebPreferences : NSObject, INSCoding, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllowsAnimatedImageLooping = "allowsAnimatedImageLooping";

	private static readonly IntPtr selAllowsAnimatedImageLoopingHandle = Selector.GetHandle("allowsAnimatedImageLooping");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllowsAnimatedImages = "allowsAnimatedImages";

	private static readonly IntPtr selAllowsAnimatedImagesHandle = Selector.GetHandle("allowsAnimatedImages");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selArePlugInsEnabled = "arePlugInsEnabled";

	private static readonly IntPtr selArePlugInsEnabledHandle = Selector.GetHandle("arePlugInsEnabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAutosaves = "autosaves";

	private static readonly IntPtr selAutosavesHandle = Selector.GetHandle("autosaves");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCacheModel = "cacheModel";

	private static readonly IntPtr selCacheModelHandle = Selector.GetHandle("cacheModel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCursiveFontFamily = "cursiveFontFamily";

	private static readonly IntPtr selCursiveFontFamilyHandle = Selector.GetHandle("cursiveFontFamily");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDefaultFixedFontSize = "defaultFixedFontSize";

	private static readonly IntPtr selDefaultFixedFontSizeHandle = Selector.GetHandle("defaultFixedFontSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDefaultFontSize = "defaultFontSize";

	private static readonly IntPtr selDefaultFontSizeHandle = Selector.GetHandle("defaultFontSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDefaultTextEncodingName = "defaultTextEncodingName";

	private static readonly IntPtr selDefaultTextEncodingNameHandle = Selector.GetHandle("defaultTextEncodingName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFantasyFontFamily = "fantasyFontFamily";

	private static readonly IntPtr selFantasyFontFamilyHandle = Selector.GetHandle("fantasyFontFamily");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFixedFontFamily = "fixedFontFamily";

	private static readonly IntPtr selFixedFontFamilyHandle = Selector.GetHandle("fixedFontFamily");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIdentifier = "identifier";

	private static readonly IntPtr selIdentifierHandle = Selector.GetHandle("identifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithIdentifier_ = "initWithIdentifier:";

	private static readonly IntPtr selInitWithIdentifier_Handle = Selector.GetHandle("initWithIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsJavaEnabled = "isJavaEnabled";

	private static readonly IntPtr selIsJavaEnabledHandle = Selector.GetHandle("isJavaEnabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsJavaScriptEnabled = "isJavaScriptEnabled";

	private static readonly IntPtr selIsJavaScriptEnabledHandle = Selector.GetHandle("isJavaScriptEnabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selJavaScriptCanOpenWindowsAutomatically = "javaScriptCanOpenWindowsAutomatically";

	private static readonly IntPtr selJavaScriptCanOpenWindowsAutomaticallyHandle = Selector.GetHandle("javaScriptCanOpenWindowsAutomatically");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLoadsImagesAutomatically = "loadsImagesAutomatically";

	private static readonly IntPtr selLoadsImagesAutomaticallyHandle = Selector.GetHandle("loadsImagesAutomatically");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMinimumFontSize = "minimumFontSize";

	private static readonly IntPtr selMinimumFontSizeHandle = Selector.GetHandle("minimumFontSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMinimumLogicalFontSize = "minimumLogicalFontSize";

	private static readonly IntPtr selMinimumLogicalFontSizeHandle = Selector.GetHandle("minimumLogicalFontSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrivateBrowsingEnabled = "privateBrowsingEnabled";

	private static readonly IntPtr selPrivateBrowsingEnabledHandle = Selector.GetHandle("privateBrowsingEnabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSansSerifFontFamily = "sansSerifFontFamily";

	private static readonly IntPtr selSansSerifFontFamilyHandle = Selector.GetHandle("sansSerifFontFamily");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSerifFontFamily = "serifFontFamily";

	private static readonly IntPtr selSerifFontFamilyHandle = Selector.GetHandle("serifFontFamily");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAllowsAnimatedImageLooping_ = "setAllowsAnimatedImageLooping:";

	private static readonly IntPtr selSetAllowsAnimatedImageLooping_Handle = Selector.GetHandle("setAllowsAnimatedImageLooping:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAllowsAnimatedImages_ = "setAllowsAnimatedImages:";

	private static readonly IntPtr selSetAllowsAnimatedImages_Handle = Selector.GetHandle("setAllowsAnimatedImages:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAutosaves_ = "setAutosaves:";

	private static readonly IntPtr selSetAutosaves_Handle = Selector.GetHandle("setAutosaves:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCacheModel_ = "setCacheModel:";

	private static readonly IntPtr selSetCacheModel_Handle = Selector.GetHandle("setCacheModel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCursiveFontFamily_ = "setCursiveFontFamily:";

	private static readonly IntPtr selSetCursiveFontFamily_Handle = Selector.GetHandle("setCursiveFontFamily:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDefaultFixedFontSize_ = "setDefaultFixedFontSize:";

	private static readonly IntPtr selSetDefaultFixedFontSize_Handle = Selector.GetHandle("setDefaultFixedFontSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDefaultFontSize_ = "setDefaultFontSize:";

	private static readonly IntPtr selSetDefaultFontSize_Handle = Selector.GetHandle("setDefaultFontSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDefaultTextEncodingName_ = "setDefaultTextEncodingName:";

	private static readonly IntPtr selSetDefaultTextEncodingName_Handle = Selector.GetHandle("setDefaultTextEncodingName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFantasyFontFamily_ = "setFantasyFontFamily:";

	private static readonly IntPtr selSetFantasyFontFamily_Handle = Selector.GetHandle("setFantasyFontFamily:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFixedFontFamily_ = "setFixedFontFamily:";

	private static readonly IntPtr selSetFixedFontFamily_Handle = Selector.GetHandle("setFixedFontFamily:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetJavaEnabled_ = "setJavaEnabled:";

	private static readonly IntPtr selSetJavaEnabled_Handle = Selector.GetHandle("setJavaEnabled:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetJavaScriptCanOpenWindowsAutomatically_ = "setJavaScriptCanOpenWindowsAutomatically:";

	private static readonly IntPtr selSetJavaScriptCanOpenWindowsAutomatically_Handle = Selector.GetHandle("setJavaScriptCanOpenWindowsAutomatically:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetJavaScriptEnabled_ = "setJavaScriptEnabled:";

	private static readonly IntPtr selSetJavaScriptEnabled_Handle = Selector.GetHandle("setJavaScriptEnabled:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLoadsImagesAutomatically_ = "setLoadsImagesAutomatically:";

	private static readonly IntPtr selSetLoadsImagesAutomatically_Handle = Selector.GetHandle("setLoadsImagesAutomatically:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMinimumFontSize_ = "setMinimumFontSize:";

	private static readonly IntPtr selSetMinimumFontSize_Handle = Selector.GetHandle("setMinimumFontSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMinimumLogicalFontSize_ = "setMinimumLogicalFontSize:";

	private static readonly IntPtr selSetMinimumLogicalFontSize_Handle = Selector.GetHandle("setMinimumLogicalFontSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPlugInsEnabled_ = "setPlugInsEnabled:";

	private static readonly IntPtr selSetPlugInsEnabled_Handle = Selector.GetHandle("setPlugInsEnabled:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPrivateBrowsingEnabled_ = "setPrivateBrowsingEnabled:";

	private static readonly IntPtr selSetPrivateBrowsingEnabled_Handle = Selector.GetHandle("setPrivateBrowsingEnabled:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSansSerifFontFamily_ = "setSansSerifFontFamily:";

	private static readonly IntPtr selSetSansSerifFontFamily_Handle = Selector.GetHandle("setSansSerifFontFamily:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSerifFontFamily_ = "setSerifFontFamily:";

	private static readonly IntPtr selSetSerifFontFamily_Handle = Selector.GetHandle("setSerifFontFamily:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetShouldPrintBackgrounds_ = "setShouldPrintBackgrounds:";

	private static readonly IntPtr selSetShouldPrintBackgrounds_Handle = Selector.GetHandle("setShouldPrintBackgrounds:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetStandardFontFamily_ = "setStandardFontFamily:";

	private static readonly IntPtr selSetStandardFontFamily_Handle = Selector.GetHandle("setStandardFontFamily:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTabsToLinks_ = "setTabsToLinks:";

	private static readonly IntPtr selSetTabsToLinks_Handle = Selector.GetHandle("setTabsToLinks:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetUserStyleSheetEnabled_ = "setUserStyleSheetEnabled:";

	private static readonly IntPtr selSetUserStyleSheetEnabled_Handle = Selector.GetHandle("setUserStyleSheetEnabled:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetUserStyleSheetLocation_ = "setUserStyleSheetLocation:";

	private static readonly IntPtr selSetUserStyleSheetLocation_Handle = Selector.GetHandle("setUserStyleSheetLocation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetUsesPageCache_ = "setUsesPageCache:";

	private static readonly IntPtr selSetUsesPageCache_Handle = Selector.GetHandle("setUsesPageCache:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShouldPrintBackgrounds = "shouldPrintBackgrounds";

	private static readonly IntPtr selShouldPrintBackgroundsHandle = Selector.GetHandle("shouldPrintBackgrounds");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStandardFontFamily = "standardFontFamily";

	private static readonly IntPtr selStandardFontFamilyHandle = Selector.GetHandle("standardFontFamily");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStandardPreferences = "standardPreferences";

	private static readonly IntPtr selStandardPreferencesHandle = Selector.GetHandle("standardPreferences");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTabsToLinks = "tabsToLinks";

	private static readonly IntPtr selTabsToLinksHandle = Selector.GetHandle("tabsToLinks");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUserStyleSheetEnabled = "userStyleSheetEnabled";

	private static readonly IntPtr selUserStyleSheetEnabledHandle = Selector.GetHandle("userStyleSheetEnabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUserStyleSheetLocation = "userStyleSheetLocation";

	private static readonly IntPtr selUserStyleSheetLocationHandle = Selector.GetHandle("userStyleSheetLocation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUsesPageCache = "usesPageCache";

	private static readonly IntPtr selUsesPageCacheHandle = Selector.GetHandle("usesPageCache");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("WebPreferences");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AllowsAnimatedImageLooping
	{
		[Export("allowsAnimatedImageLooping")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsAnimatedImageLoopingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsAnimatedImageLoopingHandle);
		}
		[Export("setAllowsAnimatedImageLooping:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAllowsAnimatedImageLooping_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAllowsAnimatedImageLooping_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AllowsAnimatedImages
	{
		[Export("allowsAnimatedImages")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsAnimatedImagesHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsAnimatedImagesHandle);
		}
		[Export("setAllowsAnimatedImages:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAllowsAnimatedImages_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAllowsAnimatedImages_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Autosaves
	{
		[Export("autosaves")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAutosavesHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAutosavesHandle);
		}
		[Export("setAutosaves:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAutosaves_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAutosaves_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual WebCacheModel CacheModel
	{
		[Export("cacheModel")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (WebCacheModel)Messaging.UInt64_objc_msgSend(base.Handle, selCacheModelHandle);
			}
			return (WebCacheModel)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selCacheModelHandle);
		}
		[Export("setCacheModel:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetCacheModel_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetCacheModel_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string CursiveFontFamily
	{
		[Export("cursiveFontFamily")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selCursiveFontFamilyHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCursiveFontFamilyHandle));
		}
		[Export("setCursiveFontFamily:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetCursiveFontFamily_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetCursiveFontFamily_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual int DefaultFixedFontSize
	{
		[Export("defaultFixedFontSize")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selDefaultFixedFontSizeHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selDefaultFixedFontSizeHandle);
		}
		[Export("setDefaultFixedFontSize:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_int(base.Handle, selSetDefaultFixedFontSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selSetDefaultFixedFontSize_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual int DefaultFontSize
	{
		[Export("defaultFontSize")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selDefaultFontSizeHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selDefaultFontSizeHandle);
		}
		[Export("setDefaultFontSize:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_int(base.Handle, selSetDefaultFontSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selSetDefaultFontSize_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string DefaultTextEncodingName
	{
		[Export("defaultTextEncodingName")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selDefaultTextEncodingNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDefaultTextEncodingNameHandle));
		}
		[Export("setDefaultTextEncodingName:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDefaultTextEncodingName_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDefaultTextEncodingName_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string FantasyFontFamily
	{
		[Export("fantasyFontFamily")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selFantasyFontFamilyHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFantasyFontFamilyHandle));
		}
		[Export("setFantasyFontFamily:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetFantasyFontFamily_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetFantasyFontFamily_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string FixedFontFamily
	{
		[Export("fixedFontFamily")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selFixedFontFamilyHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFixedFontFamilyHandle));
		}
		[Export("setFixedFontFamily:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetFixedFontFamily_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetFixedFontFamily_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Identifier
	{
		[Export("identifier")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selIdentifierHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selIdentifierHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool JavaEnabled
	{
		[Export("isJavaEnabled")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsJavaEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsJavaEnabledHandle);
		}
		[Export("setJavaEnabled:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetJavaEnabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetJavaEnabled_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool JavaScriptCanOpenWindowsAutomatically
	{
		[Export("javaScriptCanOpenWindowsAutomatically")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selJavaScriptCanOpenWindowsAutomaticallyHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selJavaScriptCanOpenWindowsAutomaticallyHandle);
		}
		[Export("setJavaScriptCanOpenWindowsAutomatically:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetJavaScriptCanOpenWindowsAutomatically_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetJavaScriptCanOpenWindowsAutomatically_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool JavaScriptEnabled
	{
		[Export("isJavaScriptEnabled")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsJavaScriptEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsJavaScriptEnabledHandle);
		}
		[Export("setJavaScriptEnabled:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetJavaScriptEnabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetJavaScriptEnabled_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool LoadsImagesAutomatically
	{
		[Export("loadsImagesAutomatically")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selLoadsImagesAutomaticallyHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selLoadsImagesAutomaticallyHandle);
		}
		[Export("setLoadsImagesAutomatically:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetLoadsImagesAutomatically_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetLoadsImagesAutomatically_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual int MinimumFontSize
	{
		[Export("minimumFontSize")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selMinimumFontSizeHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selMinimumFontSizeHandle);
		}
		[Export("setMinimumFontSize:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_int(base.Handle, selSetMinimumFontSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selSetMinimumFontSize_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual int MinimumLogicalFontSize
	{
		[Export("minimumLogicalFontSize")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selMinimumLogicalFontSizeHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selMinimumLogicalFontSizeHandle);
		}
		[Export("setMinimumLogicalFontSize:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_int(base.Handle, selSetMinimumLogicalFontSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selSetMinimumLogicalFontSize_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool PlugInsEnabled
	{
		[Export("arePlugInsEnabled")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selArePlugInsEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selArePlugInsEnabledHandle);
		}
		[Export("setPlugInsEnabled:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetPlugInsEnabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetPlugInsEnabled_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool PrivateBrowsingEnabled
	{
		[Export("privateBrowsingEnabled")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selPrivateBrowsingEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selPrivateBrowsingEnabledHandle);
		}
		[Export("setPrivateBrowsingEnabled:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetPrivateBrowsingEnabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetPrivateBrowsingEnabled_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string SansSerifFontFamily
	{
		[Export("sansSerifFontFamily")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selSansSerifFontFamilyHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSansSerifFontFamilyHandle));
		}
		[Export("setSansSerifFontFamily:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSansSerifFontFamily_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSansSerifFontFamily_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string SerifFontFamily
	{
		[Export("serifFontFamily")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selSerifFontFamilyHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSerifFontFamilyHandle));
		}
		[Export("setSerifFontFamily:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSerifFontFamily_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSerifFontFamily_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldPrintBackgrounds
	{
		[Export("shouldPrintBackgrounds")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShouldPrintBackgroundsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShouldPrintBackgroundsHandle);
		}
		[Export("setShouldPrintBackgrounds:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetShouldPrintBackgrounds_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetShouldPrintBackgrounds_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string StandardFontFamily
	{
		[Export("standardFontFamily")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selStandardFontFamilyHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selStandardFontFamilyHandle));
		}
		[Export("setStandardFontFamily:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetStandardFontFamily_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetStandardFontFamily_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static WebPreferences StandardPreferences
	{
		[Export("standardPreferences")]
		get
		{
			return Runtime.GetNSObject<WebPreferences>(Messaging.IntPtr_objc_msgSend(class_ptr, selStandardPreferencesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool TabsToLinks
	{
		[Export("tabsToLinks")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selTabsToLinksHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selTabsToLinksHandle);
		}
		[Export("setTabsToLinks:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetTabsToLinks_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetTabsToLinks_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool UserStyleSheetEnabled
	{
		[Export("userStyleSheetEnabled")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selUserStyleSheetEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selUserStyleSheetEnabledHandle);
		}
		[Export("setUserStyleSheetEnabled:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetUserStyleSheetEnabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetUserStyleSheetEnabled_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl UserStyleSheetLocation
	{
		[Export("userStyleSheetLocation", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend(base.Handle, selUserStyleSheetLocationHandle));
			}
			return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUserStyleSheetLocationHandle));
		}
		[Export("setUserStyleSheetLocation:", ArgumentSemantic.Retain)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetUserStyleSheetLocation_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetUserStyleSheetLocation_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool UsesPageCache
	{
		[Export("usesPageCache")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selUsesPageCacheHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selUsesPageCacheHandle);
		}
		[Export("setUsesPageCache:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetUsesPageCache_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetUsesPageCache_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public WebPreferences()
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
	public WebPreferences(NSCoder coder)
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
	protected WebPreferences(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal WebPreferences(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithIdentifier:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public WebPreferences(string identifier)
		: base(NSObjectFlag.Empty)
	{
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		IntPtr arg = NSString.CreateNative(identifier);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithIdentifier_Handle, arg), "initWithIdentifier:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithIdentifier_Handle, arg), "initWithIdentifier:");
		}
		NSString.ReleaseNative(arg);
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
}
