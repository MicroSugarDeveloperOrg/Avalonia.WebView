using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace WebKit;

[Register("WKWebViewConfiguration", true)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
public class WKWebViewConfiguration : NSObject, INSCoding, INativeObject, IDisposable, INSCopying, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllowsAirPlayForMediaPlayback = "allowsAirPlayForMediaPlayback";

	private static readonly IntPtr selAllowsAirPlayForMediaPlaybackHandle = Selector.GetHandle("allowsAirPlayForMediaPlayback");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selApplicationNameForUserAgent = "applicationNameForUserAgent";

	private static readonly IntPtr selApplicationNameForUserAgentHandle = Selector.GetHandle("applicationNameForUserAgent");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDefaultWebpagePreferences = "defaultWebpagePreferences";

	private static readonly IntPtr selDefaultWebpagePreferencesHandle = Selector.GetHandle("defaultWebpagePreferences");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMediaTypesRequiringUserActionForPlayback = "mediaTypesRequiringUserActionForPlayback";

	private static readonly IntPtr selMediaTypesRequiringUserActionForPlaybackHandle = Selector.GetHandle("mediaTypesRequiringUserActionForPlayback");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreferences = "preferences";

	private static readonly IntPtr selPreferencesHandle = Selector.GetHandle("preferences");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selProcessPool = "processPool";

	private static readonly IntPtr selProcessPoolHandle = Selector.GetHandle("processPool");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAllowsAirPlayForMediaPlayback_ = "setAllowsAirPlayForMediaPlayback:";

	private static readonly IntPtr selSetAllowsAirPlayForMediaPlayback_Handle = Selector.GetHandle("setAllowsAirPlayForMediaPlayback:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetApplicationNameForUserAgent_ = "setApplicationNameForUserAgent:";

	private static readonly IntPtr selSetApplicationNameForUserAgent_Handle = Selector.GetHandle("setApplicationNameForUserAgent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDefaultWebpagePreferences_ = "setDefaultWebpagePreferences:";

	private static readonly IntPtr selSetDefaultWebpagePreferences_Handle = Selector.GetHandle("setDefaultWebpagePreferences:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMediaTypesRequiringUserActionForPlayback_ = "setMediaTypesRequiringUserActionForPlayback:";

	private static readonly IntPtr selSetMediaTypesRequiringUserActionForPlayback_Handle = Selector.GetHandle("setMediaTypesRequiringUserActionForPlayback:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPreferences_ = "setPreferences:";

	private static readonly IntPtr selSetPreferences_Handle = Selector.GetHandle("setPreferences:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetProcessPool_ = "setProcessPool:";

	private static readonly IntPtr selSetProcessPool_Handle = Selector.GetHandle("setProcessPool:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSuppressesIncrementalRendering_ = "setSuppressesIncrementalRendering:";

	private static readonly IntPtr selSetSuppressesIncrementalRendering_Handle = Selector.GetHandle("setSuppressesIncrementalRendering:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetURLSchemeHandler_ForURLScheme_ = "setURLSchemeHandler:forURLScheme:";

	private static readonly IntPtr selSetURLSchemeHandler_ForURLScheme_Handle = Selector.GetHandle("setURLSchemeHandler:forURLScheme:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetUserContentController_ = "setUserContentController:";

	private static readonly IntPtr selSetUserContentController_Handle = Selector.GetHandle("setUserContentController:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetWebsiteDataStore_ = "setWebsiteDataStore:";

	private static readonly IntPtr selSetWebsiteDataStore_Handle = Selector.GetHandle("setWebsiteDataStore:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSuppressesIncrementalRendering = "suppressesIncrementalRendering";

	private static readonly IntPtr selSuppressesIncrementalRenderingHandle = Selector.GetHandle("suppressesIncrementalRendering");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUrlSchemeHandlerForURLScheme_ = "urlSchemeHandlerForURLScheme:";

	private static readonly IntPtr selUrlSchemeHandlerForURLScheme_Handle = Selector.GetHandle("urlSchemeHandlerForURLScheme:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUserContentController = "userContentController";

	private static readonly IntPtr selUserContentControllerHandle = Selector.GetHandle("userContentController");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWebsiteDataStore = "websiteDataStore";

	private static readonly IntPtr selWebsiteDataStoreHandle = Selector.GetHandle("websiteDataStore");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("WKWebViewConfiguration");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual bool AllowsAirPlayForMediaPlayback
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("allowsAirPlayForMediaPlayback")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsAirPlayForMediaPlaybackHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsAirPlayForMediaPlaybackHandle);
		}
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("setAllowsAirPlayForMediaPlayback:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAllowsAirPlayForMediaPlayback_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAllowsAirPlayForMediaPlayback_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual string ApplicationNameForUserAgent
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("applicationNameForUserAgent")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selApplicationNameForUserAgentHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selApplicationNameForUserAgentHandle));
		}
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("setApplicationNameForUserAgent:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetApplicationNameForUserAgent_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetApplicationNameForUserAgent_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	public virtual WKWebpagePreferences DefaultWebpagePreferences
	{
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("defaultWebpagePreferences", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<WKWebpagePreferences>(Messaging.IntPtr_objc_msgSend(base.Handle, selDefaultWebpagePreferencesHandle));
			}
			return Runtime.GetNSObject<WKWebpagePreferences>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDefaultWebpagePreferencesHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("setDefaultWebpagePreferences:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDefaultWebpagePreferences_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDefaultWebpagePreferences_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public virtual WKAudiovisualMediaTypes MediaTypesRequiringUserActionForPlayback
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Export("mediaTypesRequiringUserActionForPlayback", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (WKAudiovisualMediaTypes)Messaging.UInt64_objc_msgSend(base.Handle, selMediaTypesRequiringUserActionForPlaybackHandle);
			}
			return (WKAudiovisualMediaTypes)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selMediaTypesRequiringUserActionForPlaybackHandle);
		}
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Export("setMediaTypesRequiringUserActionForPlayback:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetMediaTypesRequiringUserActionForPlayback_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetMediaTypesRequiringUserActionForPlayback_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual WKPreferences Preferences
	{
		[Export("preferences", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<WKPreferences>(Messaging.IntPtr_objc_msgSend(base.Handle, selPreferencesHandle));
			}
			return Runtime.GetNSObject<WKPreferences>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPreferencesHandle));
		}
		[Export("setPreferences:", ArgumentSemantic.Retain)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPreferences_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPreferences_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual WKProcessPool ProcessPool
	{
		[Export("processPool", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<WKProcessPool>(Messaging.IntPtr_objc_msgSend(base.Handle, selProcessPoolHandle));
			}
			return Runtime.GetNSObject<WKProcessPool>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selProcessPoolHandle));
		}
		[Export("setProcessPool:", ArgumentSemantic.Retain)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetProcessPool_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetProcessPool_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool SuppressesIncrementalRendering
	{
		[Export("suppressesIncrementalRendering")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selSuppressesIncrementalRenderingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selSuppressesIncrementalRenderingHandle);
		}
		[Export("setSuppressesIncrementalRendering:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetSuppressesIncrementalRendering_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetSuppressesIncrementalRendering_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual WKUserContentController UserContentController
	{
		[Export("userContentController", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<WKUserContentController>(Messaging.IntPtr_objc_msgSend(base.Handle, selUserContentControllerHandle));
			}
			return Runtime.GetNSObject<WKUserContentController>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUserContentControllerHandle));
		}
		[Export("setUserContentController:", ArgumentSemantic.Retain)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetUserContentController_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetUserContentController_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual WKWebsiteDataStore WebsiteDataStore
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("websiteDataStore", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<WKWebsiteDataStore>(Messaging.IntPtr_objc_msgSend(base.Handle, selWebsiteDataStoreHandle));
			}
			return Runtime.GetNSObject<WKWebsiteDataStore>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selWebsiteDataStoreHandle));
		}
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("setWebsiteDataStore:", ArgumentSemantic.Retain)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetWebsiteDataStore_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetWebsiteDataStore_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public WKWebViewConfiguration()
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
	public WKWebViewConfiguration(NSCoder coder)
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
	protected WKWebViewConfiguration(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal WKWebViewConfiguration(IntPtr handle)
		: base(handle)
	{
	}

	[Export("copyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual NSObject Copy(NSZone? zone)
	{
		NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
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

	[Export("urlSchemeHandlerForURLScheme:")]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IWKUrlSchemeHandler? GetUrlSchemeHandler(string urlScheme)
	{
		if (urlScheme == null)
		{
			throw new ArgumentNullException("urlScheme");
		}
		IntPtr arg = NSString.CreateNative(urlScheme);
		IWKUrlSchemeHandler result = ((!base.IsDirectBinding) ? Runtime.GetINativeObject<IWKUrlSchemeHandler>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selUrlSchemeHandlerForURLScheme_Handle, arg), owns: false) : Runtime.GetINativeObject<IWKUrlSchemeHandler>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selUrlSchemeHandlerForURLScheme_Handle, arg), owns: false));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("setURLSchemeHandler:forURLScheme:")]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetUrlSchemeHandler(IWKUrlSchemeHandler? urlSchemeHandler, string urlScheme)
	{
		if (urlScheme == null)
		{
			throw new ArgumentNullException("urlScheme");
		}
		IntPtr arg = NSString.CreateNative(urlScheme);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetURLSchemeHandler_ForURLScheme_Handle, urlSchemeHandler?.Handle ?? IntPtr.Zero, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetURLSchemeHandler_ForURLScheme_Handle, urlSchemeHandler?.Handle ?? IntPtr.Zero, arg);
		}
		NSString.ReleaseNative(arg);
	}
}
