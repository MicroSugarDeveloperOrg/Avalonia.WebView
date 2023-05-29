using AppKit;
using Foundation;
using ObjCRuntime;
using Security;
using Xamarin.System;

namespace WebKit;

[Register(nameof(WKWebView), true)]
public class WKWebView : NSView
{

    private const string selUIDelegate = "UIDelegate";
    private static readonly IntPtr selUIDelegateHandle = Selector.GetHandle(selUIDelegate);

    private const string selURL = "URL";
    private static readonly IntPtr selURLHandle = Selector.GetHandle(selURL);

    private const string selAllowsBackForwardNavigationGestures = "allowsBackForwardNavigationGestures";
    private static readonly IntPtr selAllowsBackForwardNavigationGesturesHandle = Selector.GetHandle(selAllowsBackForwardNavigationGestures);

    private const string selAllowsLinkPreview = "allowsLinkPreview";
    private static readonly IntPtr selAllowsLinkPreviewHandle = Selector.GetHandle(selAllowsLinkPreview);

    private const string selAllowsMagnification = "allowsMagnification";
    private static readonly IntPtr selAllowsMagnificationHandle = Selector.GetHandle(selAllowsMagnification);

    private const string selBackForwardList = "backForwardList";
    private static readonly IntPtr selBackForwardListHandle = Selector.GetHandle(selBackForwardList);

    private const string selCanGoBack = "canGoBack";
    private static readonly IntPtr selCanGoBackHandle = Selector.GetHandle(selCanGoBack);

    private const string selCanGoForward = "canGoForward";
    private static readonly IntPtr selCanGoForwardHandle = Selector.GetHandle(selCanGoForward);

    private const string selCertificateChain = "certificateChain";
    private static readonly IntPtr selCertificateChainHandle = Selector.GetHandle(selCertificateChain);

    private const string selConfiguration = "configuration";
    private static readonly IntPtr selConfigurationHandle = Selector.GetHandle(selConfiguration);

    private const string selCustomUserAgent = "customUserAgent";
    private static readonly IntPtr selCustomUserAgentHandle = Selector.GetHandle(selCustomUserAgent);

    private const string selEstimatedProgress = "estimatedProgress";
    private static readonly IntPtr selEstimatedProgressHandle = Selector.GetHandle(selEstimatedProgress);

    private const string selEvaluateJavaScript_CompletionHandler_ = "evaluateJavaScript:completionHandler:";
    private static readonly IntPtr selEvaluateJavaScript_CompletionHandler_Handle = Selector.GetHandle(selEvaluateJavaScript_CompletionHandler_);

    private const string selGoBack = "goBack";
    private static readonly IntPtr selGoBackHandle = Selector.GetHandle(selGoBack);

    private const string selGoForward = "goForward";
    private static readonly IntPtr selGoForwardHandle = Selector.GetHandle(selGoForward);

    private const string selGoToBackForwardListItem_ = "goToBackForwardListItem:";
    private static readonly IntPtr selGoToBackForwardListItem_Handle = Selector.GetHandle(selGoToBackForwardListItem_);

    private const string selHandlesURLScheme_ = "handlesURLScheme:";
    private static readonly IntPtr selHandlesURLScheme_Handle = Selector.GetHandle(selHandlesURLScheme_);

    private const string selHasOnlySecureContent = "hasOnlySecureContent";
    private static readonly IntPtr selHasOnlySecureContentHandle = Selector.GetHandle(selHasOnlySecureContent);

    private const string selInitWithFrame_Configuration_ = "initWithFrame:configuration:";
    private static readonly IntPtr selInitWithFrame_Configuration_Handle = Selector.GetHandle(selInitWithFrame_Configuration_);

    private const string selIsLoading = "isLoading";
    private static readonly IntPtr selIsLoadingHandle = Selector.GetHandle(selIsLoading);

    private const string selLoadData_MIMEType_CharacterEncodingName_BaseURL_ = "loadData:MIMEType:characterEncodingName:baseURL:";
    private static readonly IntPtr selLoadData_MIMEType_CharacterEncodingName_BaseURL_Handle = Selector.GetHandle(selLoadData_MIMEType_CharacterEncodingName_BaseURL_);

    private const string selLoadFileURL_AllowingReadAccessToURL_ = "loadFileURL:allowingReadAccessToURL:";
    private static readonly IntPtr selLoadFileURL_AllowingReadAccessToURL_Handle = Selector.GetHandle(selLoadFileURL_AllowingReadAccessToURL_);

    private const string selLoadHTMLString_BaseURL_ = "loadHTMLString:baseURL:";
    private static readonly IntPtr selLoadHTMLString_BaseURL_Handle = Selector.GetHandle(selLoadHTMLString_BaseURL_);

    private const string selLoadRequest_ = "loadRequest:";
    private static readonly IntPtr selLoadRequest_Handle = Selector.GetHandle(selLoadRequest_);

    private const string selMagnification = "magnification";
    private static readonly IntPtr selMagnificationHandle = Selector.GetHandle(selMagnification);

    private const string selNavigationDelegate = "navigationDelegate";
    private static readonly IntPtr selNavigationDelegateHandle = Selector.GetHandle(selNavigationDelegate);

    private const string selReload = "reload";
    private static readonly IntPtr selReloadHandle = Selector.GetHandle(selReload);

    private const string selReloadFromOrigin = "reloadFromOrigin";
    private static readonly IntPtr selReloadFromOriginHandle = Selector.GetHandle(selReloadFromOrigin);

    private const string selServerTrust = "serverTrust";
    private static readonly IntPtr selServerTrustHandle = Selector.GetHandle(selServerTrust);

    private const string selSetAllowsBackForwardNavigationGestures_ = "setAllowsBackForwardNavigationGestures:";
    private static readonly IntPtr selSetAllowsBackForwardNavigationGestures_Handle = Selector.GetHandle(selSetAllowsBackForwardNavigationGestures_);

    private const string selSetAllowsLinkPreview_ = "setAllowsLinkPreview:";
    private static readonly IntPtr selSetAllowsLinkPreview_Handle = Selector.GetHandle(selSetAllowsLinkPreview_);

    private const string selSetAllowsMagnification_ = "setAllowsMagnification:";
    private static readonly IntPtr selSetAllowsMagnification_Handle = Selector.GetHandle(selSetAllowsMagnification_);

    private const string selSetCustomUserAgent_ = "setCustomUserAgent:";
    private static readonly IntPtr selSetCustomUserAgent_Handle = Selector.GetHandle(selSetCustomUserAgent_);

    private const string selSetMagnification_ = "setMagnification:";
    private static readonly IntPtr selSetMagnification_Handle = Selector.GetHandle(selSetMagnification_);

    private const string selSetMagnification_CenteredAtPoint_ = "setMagnification:centeredAtPoint:";
    private static readonly IntPtr selSetMagnification_CenteredAtPoint_Handle = Selector.GetHandle(selSetMagnification_CenteredAtPoint_);

    private const string selSetNavigationDelegate_ = "setNavigationDelegate:";
    private static readonly IntPtr selSetNavigationDelegate_Handle = Selector.GetHandle(selSetNavigationDelegate_);

    private const string selSetUIDelegate_ = "setUIDelegate:";
    private static readonly IntPtr selSetUIDelegate_Handle = Selector.GetHandle(selSetUIDelegate_);

    private const string selStopLoading = "stopLoading";
    private static readonly IntPtr selStopLoadingHandle = Selector.GetHandle(selStopLoading);

    private const string selTakeSnapshotWithConfiguration_CompletionHandler_ = "takeSnapshotWithConfiguration:completionHandler:";
    private static readonly IntPtr selTakeSnapshotWithConfiguration_CompletionHandler_Handle = Selector.GetHandle(selTakeSnapshotWithConfiguration_CompletionHandler_);

    private const string selTitle = "title";
    private static readonly IntPtr selTitleHandle = Selector.GetHandle(selTitle);

    private const string selValidateUserInterfaceItem_ = "validateUserInterfaceItem:";
    private static readonly IntPtr selValidateUserInterfaceItem_Handle = Selector.GetHandle(selValidateUserInterfaceItem_);

    private static readonly IntPtr class_ptr = Class.GetHandle(nameof(WKWebView));

    private static Type hack = typeof(NSProxy);





    private object? __mt_WeakNavigationDelegate_var;

    private object? __mt_WeakUIDelegate_var;

    public virtual bool AllowsBackForwardNavigationGestures
    {
        [Export(selAllowsBackForwardNavigationGestures)]
        get
        {
            if (IsDirectBinding)
                return Messaging.bool_objc_msgSend(Handle, selAllowsBackForwardNavigationGesturesHandle);

            return Messaging.bool_objc_msgSendSuper(SuperHandle, selAllowsBackForwardNavigationGesturesHandle);
        }
        [Export(selSetAllowsBackForwardNavigationGestures_)]
        set
        {
            if (IsDirectBinding)
                Messaging.void_objc_msgSend_bool(Handle, selSetAllowsBackForwardNavigationGestures_Handle, value);
            else
                Messaging.void_objc_msgSendSuper_bool(SuperHandle, selSetAllowsBackForwardNavigationGestures_Handle, value);
        }
    }

    public virtual bool AllowsLinkPreview
    {
        [Export(selAllowsLinkPreview)]
        get
        {
            if (IsDirectBinding)
                return Messaging.bool_objc_msgSend(Handle, selAllowsLinkPreviewHandle);

            return Messaging.bool_objc_msgSendSuper(SuperHandle, selAllowsLinkPreviewHandle);
        }

        [Export(selSetAllowsLinkPreview_)]
        set
        {
            if (IsDirectBinding)
                Messaging.void_objc_msgSend_bool(Handle, selSetAllowsLinkPreview_Handle, value);
            else
                Messaging.void_objc_msgSendSuper_bool(SuperHandle, selSetAllowsLinkPreview_Handle, value);
        }
    }

    public virtual bool AllowsMagnification
    {
        [Export(selAllowsMagnification)]
        get
        {
            if (IsDirectBinding)
                return Messaging.bool_objc_msgSend(Handle, selAllowsMagnificationHandle);

            return Messaging.bool_objc_msgSendSuper(SuperHandle, selAllowsMagnificationHandle);
        }
        [Export(selSetAllowsMagnification_)]
        set
        {
            if (IsDirectBinding)
                Messaging.void_objc_msgSend_bool(Handle, selSetAllowsMagnification_Handle, value);
            else
                Messaging.void_objc_msgSendSuper_bool(SuperHandle, selSetAllowsMagnification_Handle, value);
        }
    }

    public virtual WKBackForwardList BackForwardList
    {
        [Export(selBackForwardList, ArgumentSemantic.Retain)]
        get
        {
            if (IsDirectBinding)
                return Runtime.GetNSObjectTx<WKBackForwardList>(Messaging.IntPtr_objc_msgSend(Handle, selBackForwardListHandle));

            return Runtime.GetNSObjectTx<WKBackForwardList>(Messaging.IntPtr_objc_msgSendSuper(SuperHandle, selBackForwardListHandle));
        }
    }

    public virtual bool CanGoBack
    {
        [Export(selCanGoBack)]
        get
        {
            if (IsDirectBinding)
                return Messaging.bool_objc_msgSend(Handle, selCanGoBackHandle);

            return Messaging.bool_objc_msgSendSuper(SuperHandle, selCanGoBackHandle);
        }
    }

    public virtual bool CanGoForward
    {
        [Export(selCanGoForward)]
        get
        {
            if (IsDirectBinding)
                return Messaging.bool_objc_msgSend(Handle, selCanGoForwardHandle);

            return Messaging.bool_objc_msgSendSuper(SuperHandle, selCanGoForwardHandle);
        }
    }

    public virtual SecCertificate[] CertificateChain
    {
        [Export(selCertificateChain, ArgumentSemantic.Copy)]
        get
        {
            if (IsDirectBinding)
                return NSArray.ArrayFromNativeHandle<SecCertificate>(Messaging.IntPtr_objc_msgSend(Handle, selCertificateChainHandle));

            return NSArray.ArrayFromNativeHandle<SecCertificate>(Messaging.IntPtr_objc_msgSendSuper(SuperHandle, selCertificateChainHandle));
        }
    }


    public virtual WKWebViewConfiguration Configuration
    {
        [Export(selConfiguration, ArgumentSemantic.Copy)]
        get
        {
            if (IsDirectBinding)
                return Runtime.GetNSObjectTx<WKWebViewConfiguration>(Messaging.IntPtr_objc_msgSend(Handle, selConfigurationHandle));

            return Runtime.GetNSObjectTx<WKWebViewConfiguration>(Messaging.IntPtr_objc_msgSendSuper(SuperHandle, selConfigurationHandle));
        }
    }

    public virtual string CustomUserAgent
    { 
        [Export(selCustomUserAgent)]
        get
        {
            if (IsDirectBinding)
                return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(Handle, selCustomUserAgentHandle));

            return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(SuperHandle, selCustomUserAgentHandle));
        }
 
        [Export(selSetCustomUserAgent_)]
        set
        {
            if (value == null)
                throw new ArgumentNullException("value");

            IntPtr arg = NSString.CreateNative(value);
            if (IsDirectBinding)
                Messaging.void_objc_msgSend_IntPtr(Handle, selSetCustomUserAgent_Handle, arg);
            else
                Messaging.void_objc_msgSendSuper_IntPtr(SuperHandle, selSetCustomUserAgent_Handle, arg);

            NSString.ReleaseNative(arg);
        }
    }

    public virtual double EstimatedProgress
    {
        [Export(selEstimatedProgress)]
        get
        {
            if (IsDirectBinding)
                return Messaging.Double_objc_msgSend(Handle, selEstimatedProgressHandle);

            return Messaging.Double_objc_msgSendSuper(SuperHandle, selEstimatedProgressHandle);
        }
    }

    public virtual bool HasOnlySecureContent
    {
        [Export(selHasOnlySecureContent)]
        get
        {
            if (IsDirectBinding)
                return Messaging.bool_objc_msgSend(Handle, selHasOnlySecureContentHandle);

            return Messaging.bool_objc_msgSendSuper(SuperHandle, selHasOnlySecureContentHandle);
        }
    }

    public virtual bool IsLoading
    {
        [Export(selIsLoading)]
        get
        {
            if (IsDirectBinding)
                return Messaging.bool_objc_msgSend(Handle, selIsLoadingHandle);

            return Messaging.bool_objc_msgSendSuper(SuperHandle, selIsLoadingHandle);
        }
    }

    public virtual nfloat Magnification
    {
        [Export(selMagnification)]
        get
        {
            if (IsDirectBinding)
                return Messaging.nfloat_objc_msgSend(Handle, selMagnificationHandle);

            return Messaging.nfloat_objc_msgSendSuper(SuperHandle, selMagnificationHandle);
        }
        [Export(selSetMagnification_)]
        set
        {
            if (IsDirectBinding)
                Messaging.void_objc_msgSend_nfloat(Handle, selSetMagnification_Handle, value);
            else
                Messaging.void_objc_msgSendSuper_nfloat(SuperHandle, selSetMagnification_Handle, value);
        }
    }

    public IWKNavigationDelegate NavigationDelegate
    {
        get => WeakNavigationDelegate as IWKNavigationDelegate;
        set
        {
            NSObject nSObject = value as NSObject;
            if (value != null && nSObject == null)
                throw new ArgumentException("The object passed of type " + value.GetType()?.ToString() + " does not derive from NSObject");

            WeakNavigationDelegate = nSObject;
        }
    }
     
    public virtual SecTrust? ServerTrust
    {
        [Export(selServerTrust)]
        get
        {
            IntPtr intPtr = ((!IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(SuperHandle, selServerTrustHandle) : Messaging.IntPtr_objc_msgSend(Handle, selServerTrustHandle));
            return (intPtr == IntPtr.Zero) ? null : new SecTrust(intPtr);
        }
    }

    public virtual string Title
    {
        [Export(selTitle)]
        get
        {
            if (IsDirectBinding)
                return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(Handle, selTitleHandle));

            return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(SuperHandle, selTitleHandle));
        }
    }

    public IWKUIDelegate UIDelegate
    {
        get => WeakUIDelegate as IWKUIDelegate;
        set
        {
            NSObject nSObject = value as NSObject;
            if (value != null && nSObject == null)
                throw new ArgumentException("The object passed of type " + value.GetType()?.ToString() + " does not derive from NSObject");

            WeakUIDelegate = nSObject;
        }
    }

    public virtual NSUrl Url
    {
        [Export(selURL, ArgumentSemantic.Copy)]
        get
        {
            if (IsDirectBinding)
                return Runtime.GetNSObjectTx<NSUrl>(Messaging.IntPtr_objc_msgSend(Handle, selURLHandle));

            return Runtime.GetNSObjectTx<NSUrl>(Messaging.IntPtr_objc_msgSendSuper(SuperHandle, selURLHandle));
        }
    }

    public virtual NSObject? WeakNavigationDelegate
    {
        [Export(selNavigationDelegate, ArgumentSemantic.Weak)]
        get
        {
            NSObject nSObject = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(SuperHandle, selNavigationDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(Handle, selNavigationDelegateHandle)));
            
            __mt_WeakNavigationDelegate_var = nSObject;
            return nSObject;
        }
        [Export(selSetNavigationDelegate_, ArgumentSemantic.Weak)]
        set
        {
            if (IsDirectBinding)
                Messaging.void_objc_msgSend_IntPtr(Handle, selSetNavigationDelegate_Handle, value?.Handle ?? IntPtr.Zero);
            else
                Messaging.void_objc_msgSendSuper_IntPtr(SuperHandle, selSetNavigationDelegate_Handle, value?.Handle ?? IntPtr.Zero);

            __mt_WeakNavigationDelegate_var = value;
        }
    }

    public virtual NSObject? WeakUIDelegate
    {
        [Export(selUIDelegate, ArgumentSemantic.Weak)]
        get
        {
            NSObject nSObject = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(SuperHandle, selUIDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(Handle, selUIDelegateHandle)));
       
            __mt_WeakUIDelegate_var = nSObject;
            return nSObject;
        }
        [Export(selSetUIDelegate_, ArgumentSemantic.Weak)]
        set
        {
            if (IsDirectBinding)
                Messaging.void_objc_msgSend_IntPtr(Handle, selSetUIDelegate_Handle, value?.Handle ?? IntPtr.Zero);
            else
                Messaging.void_objc_msgSendSuper_IntPtr(SuperHandle, selSetUIDelegate_Handle, value?.Handle ?? IntPtr.Zero);

            __mt_WeakUIDelegate_var = value;
        }
    }

}
