using Foundation;
using ObjCRuntime;
using System.ComponentModel;

namespace WebKit;

[Register("WKWebViewConfiguration", true)]
public class WKWebViewConfiguration : NSObject
{
    private const string selAllowsAirPlayForMediaPlayback = "allowsAirPlayForMediaPlayback";
    private static readonly IntPtr selAllowsAirPlayForMediaPlaybackHandle = Selector.GetHandle("allowsAirPlayForMediaPlayback");

    private const string selApplicationNameForUserAgent = "applicationNameForUserAgent";
    private static readonly IntPtr selApplicationNameForUserAgentHandle = Selector.GetHandle("applicationNameForUserAgent");

    private const string selCopyWithZone_ = "copyWithZone:";
    private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

    private const string selDefaultWebpagePreferences = "defaultWebpagePreferences";
    private static readonly IntPtr selDefaultWebpagePreferencesHandle = Selector.GetHandle("defaultWebpagePreferences");

    private const string selEncodeWithCoder_ = "encodeWithCoder:";
    private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

    private const string selInitWithCoder_ = "initWithCoder:";
    private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

    private const string selMediaTypesRequiringUserActionForPlayback = "mediaTypesRequiringUserActionForPlayback";
    private static readonly IntPtr selMediaTypesRequiringUserActionForPlaybackHandle = Selector.GetHandle("mediaTypesRequiringUserActionForPlayback");

    private const string selPreferences = "preferences";
    private static readonly IntPtr selPreferencesHandle = Selector.GetHandle("preferences");

    private const string selProcessPool = "processPool";
    private static readonly IntPtr selProcessPoolHandle = Selector.GetHandle("processPool");

    private const string selSetAllowsAirPlayForMediaPlayback_ = "setAllowsAirPlayForMediaPlayback:";
    private static readonly IntPtr selSetAllowsAirPlayForMediaPlayback_Handle = Selector.GetHandle("setAllowsAirPlayForMediaPlayback:");

    private const string selSetApplicationNameForUserAgent_ = "setApplicationNameForUserAgent:";
    private static readonly IntPtr selSetApplicationNameForUserAgent_Handle = Selector.GetHandle("setApplicationNameForUserAgent:");

    private const string selSetDefaultWebpagePreferences_ = "setDefaultWebpagePreferences:";
    private static readonly IntPtr selSetDefaultWebpagePreferences_Handle = Selector.GetHandle("setDefaultWebpagePreferences:");

    private const string selSetMediaTypesRequiringUserActionForPlayback_ = "setMediaTypesRequiringUserActionForPlayback:";
    private static readonly IntPtr selSetMediaTypesRequiringUserActionForPlayback_Handle = Selector.GetHandle("setMediaTypesRequiringUserActionForPlayback:");

    private const string selSetPreferences_ = "setPreferences:";
    private static readonly IntPtr selSetPreferences_Handle = Selector.GetHandle("setPreferences:");

    private const string selSetProcessPool_ = "setProcessPool:";
    private static readonly IntPtr selSetProcessPool_Handle = Selector.GetHandle("setProcessPool:");

    private const string selSetSuppressesIncrementalRendering_ = "setSuppressesIncrementalRendering:";
    private static readonly IntPtr selSetSuppressesIncrementalRendering_Handle = Selector.GetHandle("setSuppressesIncrementalRendering:");

    private const string selSetURLSchemeHandler_ForURLScheme_ = "setURLSchemeHandler:forURLScheme:";
    private static readonly IntPtr selSetURLSchemeHandler_ForURLScheme_Handle = Selector.GetHandle("setURLSchemeHandler:forURLScheme:");

    private const string selSetUserContentController_ = "setUserContentController:";
    private static readonly IntPtr selSetUserContentController_Handle = Selector.GetHandle("setUserContentController:");

    private const string selSetWebsiteDataStore_ = "setWebsiteDataStore:";
    private static readonly IntPtr selSetWebsiteDataStore_Handle = Selector.GetHandle("setWebsiteDataStore:");

    private const string selSuppressesIncrementalRendering = "suppressesIncrementalRendering";
    private static readonly IntPtr selSuppressesIncrementalRenderingHandle = Selector.GetHandle("suppressesIncrementalRendering");

    private const string selUrlSchemeHandlerForURLScheme_ = "urlSchemeHandlerForURLScheme:";
    private static readonly IntPtr selUrlSchemeHandlerForURLScheme_Handle = Selector.GetHandle("urlSchemeHandlerForURLScheme:");

    private const string selUserContentController = "userContentController";
    private static readonly IntPtr selUserContentControllerHandle = Selector.GetHandle("userContentController");

    private const string selWebsiteDataStore = "websiteDataStore";
    private static readonly IntPtr selWebsiteDataStoreHandle = Selector.GetHandle("websiteDataStore");

    private static readonly IntPtr class_ptr = Class.GetHandle("WKWebViewConfiguration");

    public override IntPtr ClassHandle => class_ptr;

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [Export("init")]
    public WKWebViewConfiguration()
      : base(NSObjectFlag.Empty)
    {
        InitializeHandle(Selector.Init);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [Export("initWithCoder:")]
    public WKWebViewConfiguration(NSCoder coder)
        : base(NSObjectFlag.Empty)
    {
        InitializeHandle(Selector.InitWithCoder, coder);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected WKWebViewConfiguration(NSObjectFlag t)
        : base(t)
    {
    }


    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected internal WKWebViewConfiguration(IntPtr handle)
        : base(handle)
    {
    }


    public virtual bool AllowsAirPlayForMediaPlayback
    {
        [Export("allowsAirPlayForMediaPlayback")]
        get
        {
            if (IsDirectBinding)
                return Messaging.bool_objc_msgSend(Handle, selAllowsAirPlayForMediaPlaybackHandle);

            return Messaging.bool_objc_msgSendSuper(SuperHandle, selAllowsAirPlayForMediaPlaybackHandle);
        }

        [Export("setAllowsAirPlayForMediaPlayback:")]
        set
        {
            if (IsDirectBinding)
                Messaging.void_objc_msgSend_bool(Handle, selSetAllowsAirPlayForMediaPlayback_Handle, value);
            else
                Messaging.void_objc_msgSendSuper_bool(SuperHandle, selSetAllowsAirPlayForMediaPlayback_Handle, value);
        }
    }

    public virtual string ApplicationNameForUserAgent
    {

        [Export("applicationNameForUserAgent")]
        get
        {
            if (IsDirectBinding)
            {
                return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(Handle, selApplicationNameForUserAgentHandle));
            }
            return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(SuperHandle, selApplicationNameForUserAgentHandle));
        }

        [Export("setApplicationNameForUserAgent:")]
        set
        {
            if (value == null)
            {
                throw new ArgumentNullException("value");
            }
            IntPtr arg = NSString.CreateNative(value);
            if (IsDirectBinding)
            {
                Messaging.void_objc_msgSend_IntPtr(Handle, selSetApplicationNameForUserAgent_Handle, arg);
            }
            else
            {
                Messaging.void_objc_msgSendSuper_IntPtr(SuperHandle, selSetApplicationNameForUserAgent_Handle, arg);
            }
            NSString.ReleaseNative(arg);
        }
    }


    public virtual WKWebpagePreferences DefaultWebpagePreferences
    {
        [Export("defaultWebpagePreferences", ArgumentSemantic.Copy)]
        get
        {
            if (IsDirectBinding)
            {
                return Runtime.GetNSObjectTx<WKWebpagePreferences>(Messaging.IntPtr_objc_msgSend(Handle, selDefaultWebpagePreferencesHandle));
            }
            return Runtime.GetNSObjectTx<WKWebpagePreferences>(Messaging.IntPtr_objc_msgSendSuper(SuperHandle, selDefaultWebpagePreferencesHandle));
        }

        [Export("setDefaultWebpagePreferences:", ArgumentSemantic.Copy)]
        set
        {
            if (value == null)
            {
                throw new ArgumentNullException("value");
            }
            if (IsDirectBinding)
            {
                Messaging.void_objc_msgSend_IntPtr(Handle, selSetDefaultWebpagePreferences_Handle, value.Handle);
            }
            else
            {
                Messaging.void_objc_msgSendSuper_IntPtr(SuperHandle, selSetDefaultWebpagePreferences_Handle, value.Handle);
            }
        }
    }

    public virtual WKAudiovisualMediaTypes MediaTypesRequiringUserActionForPlayback
    {
        [Export("mediaTypesRequiringUserActionForPlayback", ArgumentSemantic.Assign)]
        get
        {
            if (IsDirectBinding)
            {
                return (WKAudiovisualMediaTypes)Messaging.UInt64_objc_msgSend(Handle, selMediaTypesRequiringUserActionForPlaybackHandle);
            }
            return (WKAudiovisualMediaTypes)Messaging.UInt64_objc_msgSendSuper(SuperHandle, selMediaTypesRequiringUserActionForPlaybackHandle);
        }

        [Export("setMediaTypesRequiringUserActionForPlayback:", ArgumentSemantic.Assign)]
        set
        {
            if (IsDirectBinding)
            {
                Messaging.void_objc_msgSend_UInt64(Handle, selSetMediaTypesRequiringUserActionForPlayback_Handle, (ulong)value);
            }
            else
            {
                Messaging.void_objc_msgSendSuper_UInt64(SuperHandle, selSetMediaTypesRequiringUserActionForPlayback_Handle, (ulong)value);
            }
        }
    }


    public virtual WKPreferences Preferences
    {
        [Export("preferences", ArgumentSemantic.Retain)]
        get
        {
            if (IsDirectBinding)
            {
                return Runtime.GetNSObjectTx<WKPreferences>(Messaging.IntPtr_objc_msgSend(Handle, selPreferencesHandle));
            }
            return Runtime.GetNSObjectTx<WKPreferences>(Messaging.IntPtr_objc_msgSendSuper(SuperHandle, selPreferencesHandle));
        }
        [Export("setPreferences:", ArgumentSemantic.Retain)]
        set
        {
            if (value == null)
            {
                throw new ArgumentNullException("value");
            }
            if (IsDirectBinding)
            {
                Messaging.void_objc_msgSend_IntPtr(Handle, selSetPreferences_Handle, value.Handle);
            }
            else
            {
                Messaging.void_objc_msgSendSuper_IntPtr(SuperHandle, selSetPreferences_Handle, value.Handle);
            }
        }
    }


    public virtual WKProcessPool ProcessPool
    {
        [Export("processPool", ArgumentSemantic.Retain)]
        get
        {
            if (IsDirectBinding)
            {
                return Runtime.GetNSObjectTx<WKProcessPool>(Messaging.IntPtr_objc_msgSend(Handle, selProcessPoolHandle));
            }
            return Runtime.GetNSObjectTx<WKProcessPool>(Messaging.IntPtr_objc_msgSendSuper(SuperHandle, selProcessPoolHandle));
        }
        [Export("setProcessPool:", ArgumentSemantic.Retain)]
        set
        {
            if (value == null)
            {
                throw new ArgumentNullException("value");
            }
            if (IsDirectBinding)
            {
                Messaging.void_objc_msgSend_IntPtr(Handle, selSetProcessPool_Handle, value.Handle);
            }
            else
            {
                Messaging.void_objc_msgSendSuper_IntPtr(SuperHandle, selSetProcessPool_Handle, value.Handle);
            }
        }
    }


    public virtual bool SuppressesIncrementalRendering
    {
        [Export("suppressesIncrementalRendering")]
        get
        {
            if (IsDirectBinding)
            {
                return Messaging.bool_objc_msgSend(Handle, selSuppressesIncrementalRenderingHandle);
            }
            return Messaging.bool_objc_msgSendSuper(SuperHandle, selSuppressesIncrementalRenderingHandle);
        }
        [Export("setSuppressesIncrementalRendering:")]
        set
        {
            if (IsDirectBinding)
            {
                Messaging.void_objc_msgSend_bool(Handle, selSetSuppressesIncrementalRendering_Handle, value);
            }
            else
            {
                Messaging.void_objc_msgSendSuper_bool(SuperHandle, selSetSuppressesIncrementalRendering_Handle, value);
            }
        }
    }


    public virtual WKUserContentController UserContentController
    {
        [Export("userContentController", ArgumentSemantic.Retain)]
        get
        {
            if (IsDirectBinding)
            {
                return Runtime.GetNSObjectTx<WKUserContentController>(Messaging.IntPtr_objc_msgSend(Handle, selUserContentControllerHandle));
            }
            return Runtime.GetNSObjectTx<WKUserContentController>(Messaging.IntPtr_objc_msgSendSuper(SuperHandle, selUserContentControllerHandle));
        }
        [Export("setUserContentController:", ArgumentSemantic.Retain)]
        set
        {
            if (value == null)
            {
                throw new ArgumentNullException("value");
            }
            if (IsDirectBinding)
            {
                Messaging.void_objc_msgSend_IntPtr(Handle, selSetUserContentController_Handle, value.Handle);
            }
            else
            {
                Messaging.void_objc_msgSendSuper_IntPtr(SuperHandle, selSetUserContentController_Handle, value.Handle);
            }
        }
    }

    public virtual WKWebsiteDataStore WebsiteDataStore
    {
        [Export("websiteDataStore", ArgumentSemantic.Retain)]
        get
        {
            if (IsDirectBinding)
                return Runtime.GetNSObjectTx<WKWebsiteDataStore>(Messaging.IntPtr_objc_msgSend(Handle, selWebsiteDataStoreHandle));

            return Runtime.GetNSObjectTx<WKWebsiteDataStore>(Messaging.IntPtr_objc_msgSendSuper(SuperHandle, selWebsiteDataStoreHandle));
        }

        [Export("setWebsiteDataStore:", ArgumentSemantic.Retain)]
        set
        {
            if (value == null)
                throw new ArgumentNullException("value");

            if (IsDirectBinding)
                Messaging.void_objc_msgSend_IntPtr(Handle, selSetWebsiteDataStore_Handle, value.Handle);
            else
                Messaging.void_objc_msgSendSuper_IntPtr(SuperHandle, selSetWebsiteDataStore_Handle, value.Handle);
        }
    }


    [Export("copyWithZone:")]
    public virtual NSObject Copy(NSZone? zone)
    {
        NSObject nSObject = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(SuperHandle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(Handle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
        if (nSObject != null)
            Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));

        return nSObject;
    }

    [Export("encodeWithCoder:")]

    public override void EncodeTo(NSCoder encoder)
    {
        if (encoder == null)
            throw new ArgumentNullException("encoder");

        if (IsDirectBinding)
            Messaging.void_objc_msgSend_IntPtr(Handle, selEncodeWithCoder_Handle, encoder.Handle);
        else
            Messaging.void_objc_msgSendSuper_IntPtr(SuperHandle, selEncodeWithCoder_Handle, encoder.Handle);
    }

    [Export("urlSchemeHandlerForURLScheme:")]
    public virtual IWKUrlSchemeHandler? GetUrlSchemeHandler(string urlScheme)
    {
        if (urlScheme == null)
        {
            throw new ArgumentNullException("urlScheme");
        }
        IntPtr arg = NSString.CreateNative(urlScheme);
        IWKUrlSchemeHandler result = ((!IsDirectBinding) ? Runtime.GetNativeObject<IWKUrlSchemeHandler>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(SuperHandle, selUrlSchemeHandlerForURLScheme_Handle, arg)) : Runtime.GetNativeObject<IWKUrlSchemeHandler>(Messaging.IntPtr_objc_msgSend_IntPtr(Handle, selUrlSchemeHandlerForURLScheme_Handle, arg)));
        NSString.ReleaseNative(arg);
        return result;
    }

    [Export("setURLSchemeHandler:forURLScheme:")]
    public virtual void SetUrlSchemeHandler(IWKUrlSchemeHandler? urlSchemeHandler, string urlScheme)
    {
        if (urlScheme == null)
            throw new ArgumentNullException("urlScheme");

        IntPtr arg = NSString.CreateNative(urlScheme);
        if (IsDirectBinding)
            Messaging.void_objc_msgSend_IntPtr_IntPtr(Handle, selSetURLSchemeHandler_ForURLScheme_Handle, urlSchemeHandler?.Handle ?? IntPtr.Zero, arg);
        else
            Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(SuperHandle, selSetURLSchemeHandler_ForURLScheme_Handle, urlSchemeHandler?.Handle ?? IntPtr.Zero, arg);

        NSString.ReleaseNative(arg);
    }
}
