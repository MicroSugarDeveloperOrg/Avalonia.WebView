using AppKit;
using CoreFoundation;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using Security;
using System.ComponentModel;
using Xamarin.System;
using Xamarin.Utiles;

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

    private const string selCameraCaptureState = "cameraCaptureState";
    private static readonly IntPtr selCameraCaptureStateHandle = Selector.GetHandle(selCameraCaptureState);

    private const string selBackForwardList = "backForwardList";
    private static readonly IntPtr selBackForwardListHandle = Selector.GetHandle(selBackForwardList);

    private const string selFullscreenState = "fullscreenState";
    private static readonly IntPtr selFullscreenStateHandle = Selector.GetHandle(selFullscreenState);

    private const string selInteractionState = "interactionState";
    private static readonly IntPtr selInteractionStateHandle = Selector.GetHandle(selInteractionState);

    private const string selSetInteractionState_ = "setInteractionState:";
    private static readonly IntPtr selSetInteractionStateHandle = Selector.GetHandle(selSetInteractionState_);

    private const string selPageZoom = "pageZoom";
    private static readonly IntPtr selPageZoomHandle = Selector.GetHandle(selPageZoom);

    private const string selSetPageZoom_ = "setPageZoom:";
    private static readonly IntPtr selSetPageZoomHandle = Selector.GetHandle(selSetPageZoom_);

    private const string selCreateWebArchiveDataWithCompletionHandler_ = "createWebArchiveDataWithCompletionHandler:";
    private static readonly IntPtr selCreateWebArchiveDataWithCompletionHandler_Handle = Selector.GetHandle(selCreateWebArchiveDataWithCompletionHandler_);

   
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

    private const string selEvaluateJavaScript_InFrame_InContentWorld_CompletionHandler_ = "evaluateJavaScript:inFrame:inContentWorld:completionHandler:";
    private static readonly IntPtr selEvaluateJavaScript_InFrame_InContentWorld_CompletionHandler_Handle = Selector.GetHandle(selEvaluateJavaScript_InFrame_InContentWorld_CompletionHandler_);

    private const string selCallAsyncJavaScript_Arguments_InFrame_InContentWorld_CompletionHandler_ = "callAsyncJavaScript:arguments:inFrame:inContentWorld:completionHandler:";
    private static readonly IntPtr selCallAsyncJavaScript_Arguments_InFrame_InContentWorld_CompletionHandler_Handle = Selector.GetHandle(selCallAsyncJavaScript_Arguments_InFrame_InContentWorld_CompletionHandler_);

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

    private const string selFindString_WithConfiguration_completionHandler_ = "findString:withConfiguration:completionHandler:";
    private static readonly IntPtr selFindString_WithConfiguration_completionHandler_Handle = Selector.GetHandle(selFindString_WithConfiguration_completionHandler_);

    private const string selIsLoading = "isLoading";
    private static readonly IntPtr selIsLoadingHandle = Selector.GetHandle(selIsLoading);

    private const string selLoadData_MIMEType_CharacterEncodingName_BaseURL_ = "loadData:MIMEType:characterEncodingName:baseURL:";
    private static readonly IntPtr selLoadData_MIMEType_CharacterEncodingName_BaseURL_Handle = Selector.GetHandle(selLoadData_MIMEType_CharacterEncodingName_BaseURL_);

    private const string selLoadFileRequest_AllowingReadAccessToURL_ = "loadFileRequest:allowingReadAccessToURL:";
    private static readonly IntPtr selLoadFileRequest_AllowingReadAccessToURL_Handle = Selector.GetHandle(selLoadFileRequest_AllowingReadAccessToURL_);

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

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [Export("initWithCoder:")]
    public WKWebView(NSCoder coder)
        : base(NSObjectFlag.Empty)
    {
        InitializeHandle(Selector.InitWithCoder, coder);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected WKWebView(NSObjectFlag t)
        : base(t)
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected internal WKWebView(IntPtr handle)
        : base(handle)
    {
    }

    [Export(selInitWithFrame_Configuration_)]
    public WKWebView(CGRect frame, WKWebViewConfiguration configuration)
        : base(NSObjectFlag.Empty)
    {
        if (configuration == null)
            throw new ArgumentNullException("configuration");

        if (IsDirectBinding)
            InitializeWithHandle(Messaging.IntPtr_objc_msgSend_CGRect_IntPtr(Handle, selInitWithFrame_Configuration_Handle, frame, configuration.Handle));
        else
            InitializeWithHandle(Messaging.IntPtr_objc_msgSendSuper_CGRect_IntPtr(SuperHandle, selInitWithFrame_Configuration_Handle, frame, configuration.Handle));
    }

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

    public virtual WKMediaCaptureState CameraCaptureState
    {
        [Export(selCameraCaptureState)]
        get
        {
            if (IsDirectBinding)
                return (WKMediaCaptureState)Messaging.IntPtr_objc_msgSend(Handle, selCameraCaptureStateHandle);

            return (WKMediaCaptureState)Messaging.IntPtr_objc_msgSendSuper(SuperHandle, selCameraCaptureStateHandle);
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
                return CFArray.ArrayFromHandle<SecCertificate>(Messaging.IntPtr_objc_msgSend(Handle, selCertificateChainHandle));

            return CFArray.ArrayFromHandle<SecCertificate>(Messaging.IntPtr_objc_msgSendSuper(SuperHandle, selCertificateChainHandle));
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

    public virtual string? CustomUserAgent
    { 
        [Export(selCustomUserAgent)]
        get
        {
            if (IsDirectBinding)
                return CFString.FromHandle(Messaging.IntPtr_objc_msgSend(Handle, selCustomUserAgentHandle));

            return CFString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(SuperHandle, selCustomUserAgentHandle));
        }
 
        [Export(selSetCustomUserAgent_)]
        set
        {
            if (value == null)
                throw new ArgumentNullException("value");

            IntPtr arg = CFString.CreateNative(value);
            if (IsDirectBinding)
                Messaging.void_objc_msgSend_IntPtr(Handle, selSetCustomUserAgent_Handle, arg);
            else
                Messaging.void_objc_msgSendSuper_IntPtr(SuperHandle, selSetCustomUserAgent_Handle, arg);

            CFString.ReleaseNative(arg);
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

    public virtual WKFullscreenState FullscreenState
    {
        [Export(selFullscreenState)]
        get
        {
            if (IsDirectBinding)
                return (WKFullscreenState)Messaging.IntPtr_objc_msgSend(Handle, selFullscreenStateHandle);

            return (WKFullscreenState)Messaging.IntPtr_objc_msgSendSuper(SuperHandle, selFullscreenStateHandle);
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

    public virtual NSObject? InteractionState
    {
        [Export(selInteractionState, ArgumentSemantic.Copy)]
        get
        {
            if (IsDirectBinding)
                return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(Handle, selInteractionStateHandle));

            return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(SuperHandle, selInteractionStateHandle));
        }

        [Export(selSetInteractionState_, ArgumentSemantic.Copy)]
        set
        {
            IntPtr arg = value.Handle;
            if (IsDirectBinding)
                Messaging.void_objc_msgSend_IntPtr(Handle, selSetInteractionStateHandle, arg);
            else
                Messaging.void_objc_msgSendSuper_IntPtr(SuperHandle, selSetInteractionStateHandle, arg);
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

    public virtual nfloat PageZoom
    {
        [Export(selPageZoom)]
        get
        {
            if (IsDirectBinding)
                return Messaging.nfloat_objc_msgSend(Handle, selPageZoomHandle);

            return Messaging.nfloat_objc_msgSendSuper(SuperHandle, selPageZoomHandle);
        }
        [Export(selSetPageZoom_)]
        set
        {
            if (IsDirectBinding)
                Messaging.void_objc_msgSend_nfloat(Handle, selSetPageZoomHandle, value);
            else
                Messaging.void_objc_msgSendSuper_nfloat(SuperHandle, selSetPageZoomHandle, value);
        }
    }

    public virtual SecTrust ServerTrust
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

    public virtual NSUrl? Url
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

    [Export(selEvaluateJavaScript_CompletionHandler_)]
    public unsafe virtual void EvaluateJavaScript(NSString javascript, [BlockProxy(typeof(Trampolines.NIDWKJavascriptEvaluationResult))] WKJavascriptEvaluationResult? completionHandler)
    {
        if (javascript == null)
            throw new ArgumentNullException("javascript");

        BlockLiteral* ptr;
        if (completionHandler == null)
            ptr = null;
        else
        {
            BlockLiteral blockLiteral = default(BlockLiteral);
            ptr = &blockLiteral;
            blockLiteral.SetupBlock(Trampolines.SDWKJavascriptEvaluationResult.Handler, completionHandler);
        }
        if (IsDirectBinding)
            Messaging.void_objc_msgSend_IntPtr_IntPtr(Handle, selEvaluateJavaScript_CompletionHandler_Handle, javascript.Handle, (IntPtr)ptr);
        else
            Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(SuperHandle, selEvaluateJavaScript_CompletionHandler_Handle, javascript.Handle, (IntPtr)ptr);

        if (ptr != null)
            ptr->CleanupBlock();
    }

    public virtual Task<NSObject> EvaluateJavaScriptAsync(NSString javascript)
    {
        TaskCompletionSource<NSObject> tcs = new TaskCompletionSource<NSObject>();
        EvaluateJavaScript(javascript, delegate (NSObject result_, NSError error_)
        {
            if (error_ != null)
            {
                tcs.SetException(new NSErrorException(error_));
            }
            else
            {
                tcs.SetResult(result_);
            }
        });
        return tcs.Task;
    }

    public void EvaluateJavaScript(string javascript, WKJavascriptEvaluationResult completionHandler) => EvaluateJavaScript((NSString)javascript, completionHandler);

    public Task<NSObject> EvaluateJavaScriptAsync(string javascript)
    {
        TaskCompletionSource<NSObject> tcs = new TaskCompletionSource<NSObject>();
        EvaluateJavaScript(javascript, delegate (NSObject result_, NSError error_)
        {
            if (error_ != null)
                tcs.SetException(new NSErrorException(error_));
            else
                tcs.SetResult(result_);
        });
        return tcs.Task;
    }

    [Export(selEvaluateJavaScript_InFrame_InContentWorld_CompletionHandler_)]
    public unsafe virtual void EvaluateJavaScript(string javaScriptString, WKFrameInfo? frame, WKContentWorld contentWorld, [BlockProxy(typeof(Trampolines.NIDActionArity2V69))] Action<NSObject, NSError>? completionHandler)
    {
        if (javaScriptString == null)
            ThrowHelper.ThrowArgumentNullException("javaScriptString");

        IntPtr arg = frame.Handle;
        IntPtr nonNullHandle = contentWorld.Handle;
        IntPtr arg2 = CFString.CreateNative(javaScriptString);
        BlockLiteral* ptr;
        if (completionHandler == null)
        {
            ptr = null;
        }
        else
        {
            BlockLiteral blockLiteral = default(BlockLiteral);
            ptr = &blockLiteral;
            blockLiteral.SetupBlock(Trampolines.SDActionArity2V69.Handler, completionHandler);
        }
        if (IsDirectBinding)
            Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(Handle, selEvaluateJavaScript_InFrame_InContentWorld_CompletionHandler_Handle, arg2, arg, nonNullHandle, (nint)ptr);
        else
            Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(SuperHandle, selEvaluateJavaScript_InFrame_InContentWorld_CompletionHandler_Handle, arg2, arg, nonNullHandle, (nint)ptr);

        CFString.ReleaseNative(arg2);
        if (ptr != null)
        {
            ptr->CleanupBlock();
        }
    }

    public virtual Task<NSObject> EvaluateJavaScriptAsync(string javaScriptString, WKFrameInfo? frame, WKContentWorld contentWorld)
    {
        TaskCompletionSource<NSObject> tcs = new TaskCompletionSource<NSObject>();
        EvaluateJavaScript(javaScriptString, frame, contentWorld, delegate (NSObject arg1_, NSError arg2_)
        {
            if (arg2_ != null)
            {
                tcs.SetException(new NSErrorException(arg2_));
            }
            else
            {
                tcs.SetResult(arg1_);
            }
        });
        return tcs.Task;
    }

    [Export(selCallAsyncJavaScript_Arguments_InFrame_InContentWorld_CompletionHandler_)]
    public unsafe virtual void CallAsyncJavaScript(string functionBody, NSDictionary<NSString, NSObject>? arguments, WKFrameInfo? frame, WKContentWorld contentWorld, [BlockProxy(typeof(Trampolines.NIDActionArity2V69))] Action<NSObject, NSError>? completionHandler)
    {
        if (functionBody == null)
            ThrowHelper.ThrowArgumentNullException("functionBody");

        IntPtr arg = arguments.Handle;
        IntPtr arg2 = frame.Handle;
        IntPtr nonNullHandle = contentWorld.Handle;
        IntPtr arg3 = CFString.CreateNative(functionBody);
        BlockLiteral* ptr;
        if (completionHandler == null)
            ptr = null;
        else
        {
            BlockLiteral blockLiteral = default(BlockLiteral);
            ptr = &blockLiteral;
            blockLiteral.SetupBlock(Trampolines.SDActionArity2V69.Handler, completionHandler);
        }
        if (IsDirectBinding)
            Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(Handle, selCallAsyncJavaScript_Arguments_InFrame_InContentWorld_CompletionHandler_Handle, arg3, arg, arg2, nonNullHandle, (nint)ptr);
        else
            Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(SuperHandle, selCallAsyncJavaScript_Arguments_InFrame_InContentWorld_CompletionHandler_Handle, arg3, arg, arg2, nonNullHandle, (nint)ptr);

        CFString.ReleaseNative(arg3);
        if (ptr != null)
            ptr->CleanupBlock();
    }

    public virtual Task<NSObject> CallAsyncJavaScriptAsync(string functionBody, NSDictionary<NSString, NSObject>? arguments, WKFrameInfo? frame, WKContentWorld contentWorld)
    {
        TaskCompletionSource<NSObject> tcs = new TaskCompletionSource<NSObject>();
        CallAsyncJavaScript(functionBody, arguments, frame, contentWorld, delegate (NSObject arg1_, NSError arg2_)
        {
            if (arg2_ != null)
                tcs.SetException(new NSErrorException(arg2_));
            else
                tcs.SetResult(arg1_);
        });
        return tcs.Task;
    }

    [Export(selCreateWebArchiveDataWithCompletionHandler_)]
    public unsafe virtual void CreateWebArchive([BlockProxy(typeof(Trampolines.NIDActionArity2V16))] Action<NSData, NSError> completionHandler)
    {
        if (completionHandler == null)
            ThrowHelper.ThrowArgumentNullException("completionHandler");

        BlockLiteral blockLiteral = default(BlockLiteral);
        BlockLiteral* ptr = &blockLiteral;
        blockLiteral.SetupBlock(Trampolines.SDActionArity2V16.Handler, completionHandler);
        if (IsDirectBinding)
            Messaging.void_objc_msgSend_IntPtr(Handle, selCreateWebArchiveDataWithCompletionHandler_Handle, (nint)ptr);
        else
            Messaging.void_objc_msgSendSuper_IntPtr(SuperHandle, selCreateWebArchiveDataWithCompletionHandler_Handle, (nint)ptr);

        ptr->CleanupBlock();
    }

    public virtual Task<NSData> CreateWebArchiveAsync()
    {
        TaskCompletionSource<NSData> tcs = new TaskCompletionSource<NSData>();
        CreateWebArchive(delegate (NSData arg1_, NSError arg2_)
        {
            if (arg2_ != null)
                tcs.SetException(new NSErrorException(arg2_));
            else
                tcs.SetResult(arg1_);
        });
        return tcs.Task;
    }

    [Export(selGoBack)]
    public virtual WKNavigation GoBack()
    {
        if (IsDirectBinding)
            return Runtime.GetNSObjectTx<WKNavigation>(Messaging.IntPtr_objc_msgSend(Handle, selGoBackHandle));

        return Runtime.GetNSObjectTx<WKNavigation>(Messaging.IntPtr_objc_msgSendSuper(SuperHandle, selGoBackHandle));
    }

    [Export(selGoForward)]
    public virtual WKNavigation GoForward()
    {
        if (IsDirectBinding)
            return Runtime.GetNSObjectTx<WKNavigation>(Messaging.IntPtr_objc_msgSend(Handle, selGoForwardHandle));

        return Runtime.GetNSObjectTx<WKNavigation>(Messaging.IntPtr_objc_msgSendSuper(SuperHandle, selGoForwardHandle));
    }

    [Export(selGoToBackForwardListItem_)]
    public virtual WKNavigation GoTo(WKBackForwardListItem item)
    {
        if (item == null)
            throw new ArgumentNullException("item");

        if (IsDirectBinding)
            return Runtime.GetNSObjectTx<WKNavigation>(Messaging.IntPtr_objc_msgSend_IntPtr(Handle, selGoToBackForwardListItem_Handle, item.Handle));

        return Runtime.GetNSObjectTx<WKNavigation>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(SuperHandle, selGoToBackForwardListItem_Handle, item.Handle));
    }

    [Export(selHandlesURLScheme_)]
    public static bool HandlesUrlScheme(string urlScheme)
    {
        if (urlScheme == null)
            throw new ArgumentNullException("urlScheme");

        IntPtr arg = NSString.CreateNative(urlScheme);
        bool result = Messaging.bool_objc_msgSend_IntPtr(class_ptr, selHandlesURLScheme_Handle, arg);
        NSString.ReleaseNative(arg);
        return result;
    }

    [Export(selLoadData_MIMEType_CharacterEncodingName_BaseURL_)]
    public virtual WKNavigation LoadData(NSData data, string mimeType, string characterEncodingName, NSUrl baseUrl)
    {
        if (data == null)
            throw new ArgumentNullException("data");

        if (mimeType == null)
            throw new ArgumentNullException("mimeType");

        if (characterEncodingName == null)
            throw new ArgumentNullException("characterEncodingName");

        if (baseUrl == null)
            throw new ArgumentNullException("baseUrl");

        IntPtr arg = NSString.CreateNative(mimeType);
        IntPtr arg2 = NSString.CreateNative(characterEncodingName);
        WKNavigation result = ((!IsDirectBinding) ? Runtime.GetNSObjectTx<WKNavigation>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(SuperHandle, selLoadData_MIMEType_CharacterEncodingName_BaseURL_Handle, data.Handle, arg, arg2, baseUrl.Handle)) 
            : Runtime.GetNSObjectTx<WKNavigation>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(Handle, selLoadData_MIMEType_CharacterEncodingName_BaseURL_Handle, data.Handle, arg, arg2, baseUrl.Handle)));
        NSString.ReleaseNative(arg);
        NSString.ReleaseNative(arg2);
        return result;
    }

    [Export(selLoadFileRequest_AllowingReadAccessToURL_)]
    public virtual WKNavigation LoadFileRequest(NSUrlRequest request, NSUrl readAccessURL)
    {
        IntPtr nonNullHandle = request.GetNonNullHandle("request");
        IntPtr nonNullHandle2 = readAccessURL.GetNonNullHandle("readAccessURL");
        if (IsDirectBinding)
            return Runtime.GetNSObjectTx<WKNavigation>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(Handle, selLoadFileRequest_AllowingReadAccessToURL_Handle, nonNullHandle, nonNullHandle2));

        return Runtime.GetNSObjectTx<WKNavigation>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(SuperHandle, selLoadFileRequest_AllowingReadAccessToURL_Handle, nonNullHandle, nonNullHandle2));
    }

    [Export(selLoadFileURL_AllowingReadAccessToURL_)]
    public virtual WKNavigation? LoadFileUrl(NSUrl url, NSUrl readAccessUrl)
    {
        if (url == null)
            throw new ArgumentNullException("url");

        if (readAccessUrl == null)
            throw new ArgumentNullException("readAccessUrl");

        if (IsDirectBinding)
            return Runtime.GetNSObjectTx<WKNavigation>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(Handle, selLoadFileURL_AllowingReadAccessToURL_Handle, url.Handle, readAccessUrl.Handle));

        return Runtime.GetNSObjectTx<WKNavigation>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(SuperHandle, selLoadFileURL_AllowingReadAccessToURL_Handle, url.Handle, readAccessUrl.Handle));
    }

    [Export(selLoadHTMLString_BaseURL_)]
    public virtual WKNavigation LoadHtmlString(NSString htmlString, NSUrl? baseUrl)
    {
        if (htmlString == null)
            throw new ArgumentNullException("htmlString");

        if (IsDirectBinding)
            return Runtime.GetNSObjectTx<WKNavigation>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(Handle, selLoadHTMLString_BaseURL_Handle, htmlString.Handle, (baseUrl == null) ? IntPtr.Zero : baseUrl.Handle));

        return Runtime.GetNSObjectTx<WKNavigation>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(SuperHandle, selLoadHTMLString_BaseURL_Handle, htmlString.Handle, (baseUrl == null) ? IntPtr.Zero : baseUrl.Handle));
    }

    public WKNavigation LoadHtmlString(string htmlString, NSUrl baseUrl) => LoadHtmlString((NSString)htmlString, baseUrl);

    [Export(selLoadRequest_)]
    public virtual WKNavigation LoadRequest(NSUrlRequest request)
    {
        if (request == null)
            throw new ArgumentNullException("request");

        if (IsDirectBinding)
            return Runtime.GetNSObjectTx<WKNavigation>(Messaging.IntPtr_objc_msgSend_IntPtr(Handle, selLoadRequest_Handle, request.Handle));

        return Runtime.GetNSObjectTx<WKNavigation>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(SuperHandle, selLoadRequest_Handle, request.Handle));
    }

    [Export(selReload)]
    public virtual WKNavigation Reload()
    {
        if (IsDirectBinding)
            return Runtime.GetNSObjectTx<WKNavigation>(Messaging.IntPtr_objc_msgSend(Handle, selReloadHandle));

        return Runtime.GetNSObjectTx<WKNavigation>(Messaging.IntPtr_objc_msgSendSuper(SuperHandle, selReloadHandle));
    }

    [Export(selReloadFromOrigin)]
    public virtual WKNavigation ReloadFromOrigin()
    {
        if (IsDirectBinding)
            return Runtime.GetNSObjectTx<WKNavigation>(Messaging.IntPtr_objc_msgSend(Handle, selReloadFromOriginHandle));

        return Runtime.GetNSObjectTx<WKNavigation>(Messaging.IntPtr_objc_msgSendSuper(SuperHandle, selReloadFromOriginHandle));
    }

    [Export(selSetMagnification_CenteredAtPoint_)]
    public virtual void SetMagnification(nfloat magnification, CGPoint centerPoint)
    {
        if (IsDirectBinding)
            Messaging.void_objc_msgSend_nfloat_CGPoint(Handle, selSetMagnification_CenteredAtPoint_Handle, magnification, centerPoint);
        else
            Messaging.void_objc_msgSendSuper_nfloat_CGPoint(SuperHandle, selSetMagnification_CenteredAtPoint_Handle, magnification, centerPoint);
    }

    [Export(selStopLoading)]
    public virtual void StopLoading()
    {
        if (IsDirectBinding)
            Messaging.void_objc_msgSend(Handle, selStopLoadingHandle);
        else
            Messaging.void_objc_msgSendSuper(SuperHandle, selStopLoadingHandle);
    }

    [Export(selTakeSnapshotWithConfiguration_CompletionHandler_)]
    public unsafe virtual void TakeSnapshot(WKSnapshotConfiguration? snapshotConfiguration, [BlockProxy(typeof(Trampolines.NIDActionArity2V86))] Action<NSImage, NSError> completionHandler)
    {
        if (completionHandler == null)
        {
            throw new ArgumentNullException("completionHandler");
        }
        BlockLiteral blockLiteral = default(BlockLiteral);
        BlockLiteral* ptr = &blockLiteral;
        blockLiteral.SetupBlock(Trampolines.SDActionArity2V86.Handler, completionHandler);
        if (IsDirectBinding)
            Messaging.void_objc_msgSend_IntPtr_IntPtr(Handle, selTakeSnapshotWithConfiguration_CompletionHandler_Handle, snapshotConfiguration?.Handle ?? IntPtr.Zero, (IntPtr)ptr);
        else
            Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(SuperHandle, selTakeSnapshotWithConfiguration_CompletionHandler_Handle, snapshotConfiguration?.Handle ?? IntPtr.Zero, (IntPtr)ptr);

        ptr->CleanupBlock();
    }

    public virtual Task<NSImage> TakeSnapshotAsync(WKSnapshotConfiguration? snapshotConfiguration)
    {
        TaskCompletionSource<NSImage> tcs = new TaskCompletionSource<NSImage>();
        TakeSnapshot(snapshotConfiguration, delegate (NSImage arg1_, NSError arg2_)
        {
            if (arg2_ != null)
                tcs.SetException(new NSErrorException(arg2_));
            else
                tcs.SetResult(arg1_);
        });
        return tcs.Task;
    }

    [Export(selValidateUserInterfaceItem_)]
    public virtual bool ValidateUserInterfaceItem(INSValidatedUserInterfaceItem item)
    {
        if (item == null)
            throw new ArgumentNullException("item");

        if (IsDirectBinding)
            return Messaging.bool_objc_msgSend_IntPtr(Handle, selValidateUserInterfaceItem_Handle, item.Handle);

        return Messaging.bool_objc_msgSendSuper_IntPtr(SuperHandle, selValidateUserInterfaceItem_Handle, item.Handle);
    }

    [Export(selFindString_WithConfiguration_completionHandler_)]
    public unsafe virtual void Find(string @string, WKFindConfiguration? configuration, [BlockProxy(typeof(Trampolines.NIDActionArity1V256))] Action<WKFindResult> completionHandler)
    {
        if (@string == null)
        {
            ThrowHelper.ThrowArgumentNullException("string");
        }
        IntPtr arg = configuration.Handle;
        if (completionHandler == null)
            ThrowHelper.ThrowArgumentNullException("completionHandler");

        IntPtr arg2 = CFString.CreateNative(@string);
        BlockLiteral blockLiteral = default(BlockLiteral);
        BlockLiteral* ptr = &blockLiteral;
        blockLiteral.SetupBlock(Trampolines.SDActionArity1V256.Handler, completionHandler);
        if (IsDirectBinding)
            Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(Handle, selFindString_WithConfiguration_completionHandler_Handle, arg2, arg, (nint)ptr);
        else
            Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(SuperHandle, selFindString_WithConfiguration_completionHandler_Handle, arg2, arg, (nint)ptr);

        CFString.ReleaseNative(arg2);
        ptr->CleanupBlock();
    }

    public virtual Task<WKFindResult> FindAsync(string @string, WKFindConfiguration? configuration)
    {
        TaskCompletionSource<WKFindResult> tcs = new TaskCompletionSource<WKFindResult>();
        Find(@string, configuration, delegate (WKFindResult obj_)
        {
            tcs.SetResult(obj_);
        });
        return tcs.Task;
    }

    protected override void Dispose(bool disposing)
    {
        base.Dispose(disposing);
        if (Handle == IntPtr.Zero)
        {
            __mt_WeakNavigationDelegate_var = null;
            __mt_WeakUIDelegate_var = null;
        }
    }
}
