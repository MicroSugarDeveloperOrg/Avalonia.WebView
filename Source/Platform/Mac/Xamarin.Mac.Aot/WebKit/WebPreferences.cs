using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace WebKit;

[Register("WebPreferences", true)]
public class WebPreferences : NSObject
{
	private static readonly IntPtr selStandardPreferencesHandle = Selector.GetHandle("standardPreferences");

	private static readonly IntPtr selIdentifierHandle = Selector.GetHandle("identifier");

	private static readonly IntPtr selArePlugInsEnabledHandle = Selector.GetHandle("arePlugInsEnabled");

	private static readonly IntPtr selSetPlugInsEnabled_Handle = Selector.GetHandle("setPlugInsEnabled:");

	private static readonly IntPtr selStandardFontFamilyHandle = Selector.GetHandle("standardFontFamily");

	private static readonly IntPtr selSetStandardFontFamily_Handle = Selector.GetHandle("setStandardFontFamily:");

	private static readonly IntPtr selFixedFontFamilyHandle = Selector.GetHandle("fixedFontFamily");

	private static readonly IntPtr selSetFixedFontFamily_Handle = Selector.GetHandle("setFixedFontFamily:");

	private static readonly IntPtr selSerifFontFamilyHandle = Selector.GetHandle("serifFontFamily");

	private static readonly IntPtr selSetSerifFontFamily_Handle = Selector.GetHandle("setSerifFontFamily:");

	private static readonly IntPtr selSansSerifFontFamilyHandle = Selector.GetHandle("sansSerifFontFamily");

	private static readonly IntPtr selSetSansSerifFontFamily_Handle = Selector.GetHandle("setSansSerifFontFamily:");

	private static readonly IntPtr selCursiveFontFamilyHandle = Selector.GetHandle("cursiveFontFamily");

	private static readonly IntPtr selSetCursiveFontFamily_Handle = Selector.GetHandle("setCursiveFontFamily:");

	private static readonly IntPtr selFantasyFontFamilyHandle = Selector.GetHandle("fantasyFontFamily");

	private static readonly IntPtr selSetFantasyFontFamily_Handle = Selector.GetHandle("setFantasyFontFamily:");

	private static readonly IntPtr selDefaultFontSizeHandle = Selector.GetHandle("defaultFontSize");

	private static readonly IntPtr selSetDefaultFontSize_Handle = Selector.GetHandle("setDefaultFontSize:");

	private static readonly IntPtr selDefaultFixedFontSizeHandle = Selector.GetHandle("defaultFixedFontSize");

	private static readonly IntPtr selSetDefaultFixedFontSize_Handle = Selector.GetHandle("setDefaultFixedFontSize:");

	private static readonly IntPtr selMinimumFontSizeHandle = Selector.GetHandle("minimumFontSize");

	private static readonly IntPtr selSetMinimumFontSize_Handle = Selector.GetHandle("setMinimumFontSize:");

	private static readonly IntPtr selMinimumLogicalFontSizeHandle = Selector.GetHandle("minimumLogicalFontSize");

	private static readonly IntPtr selSetMinimumLogicalFontSize_Handle = Selector.GetHandle("setMinimumLogicalFontSize:");

	private static readonly IntPtr selDefaultTextEncodingNameHandle = Selector.GetHandle("defaultTextEncodingName");

	private static readonly IntPtr selSetDefaultTextEncodingName_Handle = Selector.GetHandle("setDefaultTextEncodingName:");

	private static readonly IntPtr selUserStyleSheetEnabledHandle = Selector.GetHandle("userStyleSheetEnabled");

	private static readonly IntPtr selSetUserStyleSheetEnabled_Handle = Selector.GetHandle("setUserStyleSheetEnabled:");

	private static readonly IntPtr selUserStyleSheetLocationHandle = Selector.GetHandle("userStyleSheetLocation");

	private static readonly IntPtr selSetUserStyleSheetLocation_Handle = Selector.GetHandle("setUserStyleSheetLocation:");

	private static readonly IntPtr selIsJavaEnabledHandle = Selector.GetHandle("isJavaEnabled");

	private static readonly IntPtr selSetJavaEnabled_Handle = Selector.GetHandle("setJavaEnabled:");

	private static readonly IntPtr selIsJavaScriptEnabledHandle = Selector.GetHandle("isJavaScriptEnabled");

	private static readonly IntPtr selSetJavaScriptEnabled_Handle = Selector.GetHandle("setJavaScriptEnabled:");

	private static readonly IntPtr selJavaScriptCanOpenWindowsAutomaticallyHandle = Selector.GetHandle("javaScriptCanOpenWindowsAutomatically");

	private static readonly IntPtr selSetJavaScriptCanOpenWindowsAutomatically_Handle = Selector.GetHandle("setJavaScriptCanOpenWindowsAutomatically:");

	private static readonly IntPtr selAllowsAnimatedImagesHandle = Selector.GetHandle("allowsAnimatedImages");

	private static readonly IntPtr selSetAllowsAnimatedImages_Handle = Selector.GetHandle("setAllowsAnimatedImages:");

	private static readonly IntPtr selAllowsAnimatedImageLoopingHandle = Selector.GetHandle("allowsAnimatedImageLooping");

	private static readonly IntPtr selSetAllowsAnimatedImageLooping_Handle = Selector.GetHandle("setAllowsAnimatedImageLooping:");

	private static readonly IntPtr selLoadsImagesAutomaticallyHandle = Selector.GetHandle("loadsImagesAutomatically");

	private static readonly IntPtr selSetLoadsImagesAutomatically_Handle = Selector.GetHandle("setLoadsImagesAutomatically:");

	private static readonly IntPtr selAutosavesHandle = Selector.GetHandle("autosaves");

	private static readonly IntPtr selSetAutosaves_Handle = Selector.GetHandle("setAutosaves:");

	private static readonly IntPtr selShouldPrintBackgroundsHandle = Selector.GetHandle("shouldPrintBackgrounds");

	private static readonly IntPtr selSetShouldPrintBackgrounds_Handle = Selector.GetHandle("setShouldPrintBackgrounds:");

	private static readonly IntPtr selPrivateBrowsingEnabledHandle = Selector.GetHandle("privateBrowsingEnabled");

	private static readonly IntPtr selSetPrivateBrowsingEnabled_Handle = Selector.GetHandle("setPrivateBrowsingEnabled:");

	private static readonly IntPtr selTabsToLinksHandle = Selector.GetHandle("tabsToLinks");

	private static readonly IntPtr selSetTabsToLinks_Handle = Selector.GetHandle("setTabsToLinks:");

	private static readonly IntPtr selUsesPageCacheHandle = Selector.GetHandle("usesPageCache");

	private static readonly IntPtr selSetUsesPageCache_Handle = Selector.GetHandle("setUsesPageCache:");

	private static readonly IntPtr selCacheModelHandle = Selector.GetHandle("cacheModel");

	private static readonly IntPtr selSetCacheModel_Handle = Selector.GetHandle("setCacheModel:");

	private static readonly IntPtr selInitWithIdentifier_Handle = Selector.GetHandle("initWithIdentifier:");

	private static readonly IntPtr class_ptr = Class.GetHandle("WebPreferences");

	private static object __mt_StandardPreferences_var_static;

	private object __mt_UserStyleSheetLocation_var;

	public override IntPtr ClassHandle => class_ptr;

	public static WebPreferences StandardPreferences
	{
		[Export("standardPreferences")]
		get
		{
			return (WebPreferences)(__mt_StandardPreferences_var_static = (WebPreferences)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selStandardPreferencesHandle)));
		}
	}

	public virtual string Identifier
	{
		[Export("identifier")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selIdentifierHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selIdentifierHandle));
		}
	}

	public virtual bool PlugInsEnabled
	{
		[Export("arePlugInsEnabled")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selArePlugInsEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selArePlugInsEnabledHandle);
		}
		[Export("setPlugInsEnabled:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetPlugInsEnabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetPlugInsEnabled_Handle, value);
			}
		}
	}

	public virtual string StandardFontFamily
	{
		[Export("standardFontFamily")]
		get
		{
			if (IsDirectBinding)
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
			if (IsDirectBinding)
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

	public virtual string FixedFontFamily
	{
		[Export("fixedFontFamily")]
		get
		{
			if (IsDirectBinding)
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
			if (IsDirectBinding)
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

	public virtual string SerifFontFamily
	{
		[Export("serifFontFamily")]
		get
		{
			if (IsDirectBinding)
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
			if (IsDirectBinding)
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

	public virtual string SansSerifFontFamily
	{
		[Export("sansSerifFontFamily")]
		get
		{
			if (IsDirectBinding)
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
			if (IsDirectBinding)
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

	public virtual string CursiveFontFamily
	{
		[Export("cursiveFontFamily")]
		get
		{
			if (IsDirectBinding)
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
			if (IsDirectBinding)
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

	public virtual string FantasyFontFamily
	{
		[Export("fantasyFontFamily")]
		get
		{
			if (IsDirectBinding)
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
			if (IsDirectBinding)
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

	public virtual int DefaultFontSize
	{
		[Export("defaultFontSize")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selDefaultFontSizeHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selDefaultFontSizeHandle);
		}
		[Export("setDefaultFontSize:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_int(base.Handle, selSetDefaultFontSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selSetDefaultFontSize_Handle, value);
			}
		}
	}

	public virtual int DefaultFixedFontSize
	{
		[Export("defaultFixedFontSize")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selDefaultFixedFontSizeHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selDefaultFixedFontSizeHandle);
		}
		[Export("setDefaultFixedFontSize:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_int(base.Handle, selSetDefaultFixedFontSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selSetDefaultFixedFontSize_Handle, value);
			}
		}
	}

	public virtual int MinimumFontSize
	{
		[Export("minimumFontSize")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selMinimumFontSizeHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selMinimumFontSizeHandle);
		}
		[Export("setMinimumFontSize:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_int(base.Handle, selSetMinimumFontSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selSetMinimumFontSize_Handle, value);
			}
		}
	}

	public virtual int MinimumLogicalFontSize
	{
		[Export("minimumLogicalFontSize")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selMinimumLogicalFontSizeHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selMinimumLogicalFontSizeHandle);
		}
		[Export("setMinimumLogicalFontSize:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_int(base.Handle, selSetMinimumLogicalFontSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selSetMinimumLogicalFontSize_Handle, value);
			}
		}
	}

	public virtual string DefaultTextEncodingName
	{
		[Export("defaultTextEncodingName")]
		get
		{
			if (IsDirectBinding)
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
			if (IsDirectBinding)
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

	public virtual bool UserStyleSheetEnabled
	{
		[Export("userStyleSheetEnabled")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selUserStyleSheetEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selUserStyleSheetEnabledHandle);
		}
		[Export("setUserStyleSheetEnabled:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetUserStyleSheetEnabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetUserStyleSheetEnabled_Handle, value);
			}
		}
	}

	public virtual NSUrl UserStyleSheetLocation
	{
		[Export("userStyleSheetLocation")]
		get
		{
			return (NSUrl)(__mt_UserStyleSheetLocation_var = ((!IsDirectBinding) ? ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUserStyleSheetLocationHandle))) : ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selUserStyleSheetLocationHandle)))));
		}
		[Export("setUserStyleSheetLocation:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetUserStyleSheetLocation_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetUserStyleSheetLocation_Handle, value.Handle);
			}
			__mt_UserStyleSheetLocation_var = value;
		}
	}

	public virtual bool JavaEnabled
	{
		[Export("isJavaEnabled")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsJavaEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsJavaEnabledHandle);
		}
		[Export("setJavaEnabled:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetJavaEnabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetJavaEnabled_Handle, value);
			}
		}
	}

	public virtual bool JavaScriptEnabled
	{
		[Export("isJavaScriptEnabled")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsJavaScriptEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsJavaScriptEnabledHandle);
		}
		[Export("setJavaScriptEnabled:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetJavaScriptEnabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetJavaScriptEnabled_Handle, value);
			}
		}
	}

	public virtual bool JavaScriptCanOpenWindowsAutomatically
	{
		[Export("javaScriptCanOpenWindowsAutomatically")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selJavaScriptCanOpenWindowsAutomaticallyHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selJavaScriptCanOpenWindowsAutomaticallyHandle);
		}
		[Export("setJavaScriptCanOpenWindowsAutomatically:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetJavaScriptCanOpenWindowsAutomatically_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetJavaScriptCanOpenWindowsAutomatically_Handle, value);
			}
		}
	}

	public virtual bool AllowsAnimatedImages
	{
		[Export("allowsAnimatedImages")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsAnimatedImagesHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsAnimatedImagesHandle);
		}
		[Export("setAllowsAnimatedImages:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAllowsAnimatedImages_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAllowsAnimatedImages_Handle, value);
			}
		}
	}

	public virtual bool AllowsAnimatedImageLooping
	{
		[Export("allowsAnimatedImageLooping")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsAnimatedImageLoopingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsAnimatedImageLoopingHandle);
		}
		[Export("setAllowsAnimatedImageLooping:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAllowsAnimatedImageLooping_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAllowsAnimatedImageLooping_Handle, value);
			}
		}
	}

	public virtual bool LoadsImagesAutomatically
	{
		[Export("loadsImagesAutomatically")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selLoadsImagesAutomaticallyHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selLoadsImagesAutomaticallyHandle);
		}
		[Export("setLoadsImagesAutomatically:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetLoadsImagesAutomatically_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetLoadsImagesAutomatically_Handle, value);
			}
		}
	}

	public virtual bool Autosaves
	{
		[Export("autosaves")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAutosavesHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAutosavesHandle);
		}
		[Export("setAutosaves:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAutosaves_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAutosaves_Handle, value);
			}
		}
	}

	public virtual bool ShouldPrintBackgrounds
	{
		[Export("shouldPrintBackgrounds")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShouldPrintBackgroundsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShouldPrintBackgroundsHandle);
		}
		[Export("setShouldPrintBackgrounds:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetShouldPrintBackgrounds_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetShouldPrintBackgrounds_Handle, value);
			}
		}
	}

	public virtual bool PrivateBrowsingEnabled
	{
		[Export("privateBrowsingEnabled")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selPrivateBrowsingEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selPrivateBrowsingEnabledHandle);
		}
		[Export("setPrivateBrowsingEnabled:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetPrivateBrowsingEnabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetPrivateBrowsingEnabled_Handle, value);
			}
		}
	}

	public virtual bool TabsToLinks
	{
		[Export("tabsToLinks")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selTabsToLinksHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selTabsToLinksHandle);
		}
		[Export("setTabsToLinks:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetTabsToLinks_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetTabsToLinks_Handle, value);
			}
		}
	}

	public virtual bool UsesPageCache
	{
		[Export("usesPageCache")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selUsesPageCacheHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selUsesPageCacheHandle);
		}
		[Export("setUsesPageCache:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetUsesPageCache_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetUsesPageCache_Handle, value);
			}
		}
	}

	public virtual WebCacheModel CacheModel
	{
		[Export("cacheModel")]
		get
		{
			if (IsDirectBinding)
			{
				return (WebCacheModel)Messaging.int_objc_msgSend(base.Handle, selCacheModelHandle);
			}
			return (WebCacheModel)Messaging.int_objc_msgSendSuper(base.SuperHandle, selCacheModelHandle);
		}
		[Export("setCacheModel:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_int(base.Handle, selSetCacheModel_Handle, (int)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selSetCacheModel_Handle, (int)value);
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public WebPreferences()
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
	public WebPreferences(NSCoder coder)
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
	public WebPreferences(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public WebPreferences(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithIdentifier:")]
	public WebPreferences(string identifier)
		: base(NSObjectFlag.Empty)
	{
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		IntPtr arg = NSString.CreateNative(identifier);
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithIdentifier_Handle, arg);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithIdentifier_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_UserStyleSheetLocation_var = null;
		}
	}
}
