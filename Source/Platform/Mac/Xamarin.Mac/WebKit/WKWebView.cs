using System;
using System.ComponentModel;
using System.Threading.Tasks;
using AppKit;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using Security;

namespace WebKit;

[Register("WKWebView", true)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
public class WKWebView : NSView, INSUserInterfaceValidations, INativeObject, IDisposable
{
	private static Type hack = typeof(NSProxy);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUIDelegate = "UIDelegate";

	private static readonly IntPtr selUIDelegateHandle = Selector.GetHandle("UIDelegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selURL = "URL";

	private static readonly IntPtr selURLHandle = Selector.GetHandle("URL");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllowsBackForwardNavigationGestures = "allowsBackForwardNavigationGestures";

	private static readonly IntPtr selAllowsBackForwardNavigationGesturesHandle = Selector.GetHandle("allowsBackForwardNavigationGestures");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllowsLinkPreview = "allowsLinkPreview";

	private static readonly IntPtr selAllowsLinkPreviewHandle = Selector.GetHandle("allowsLinkPreview");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllowsMagnification = "allowsMagnification";

	private static readonly IntPtr selAllowsMagnificationHandle = Selector.GetHandle("allowsMagnification");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBackForwardList = "backForwardList";

	private static readonly IntPtr selBackForwardListHandle = Selector.GetHandle("backForwardList");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanGoBack = "canGoBack";

	private static readonly IntPtr selCanGoBackHandle = Selector.GetHandle("canGoBack");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanGoForward = "canGoForward";

	private static readonly IntPtr selCanGoForwardHandle = Selector.GetHandle("canGoForward");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCertificateChain = "certificateChain";

	private static readonly IntPtr selCertificateChainHandle = Selector.GetHandle("certificateChain");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConfiguration = "configuration";

	private static readonly IntPtr selConfigurationHandle = Selector.GetHandle("configuration");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCustomUserAgent = "customUserAgent";

	private static readonly IntPtr selCustomUserAgentHandle = Selector.GetHandle("customUserAgent");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEstimatedProgress = "estimatedProgress";

	private static readonly IntPtr selEstimatedProgressHandle = Selector.GetHandle("estimatedProgress");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEvaluateJavaScript_CompletionHandler_ = "evaluateJavaScript:completionHandler:";

	private static readonly IntPtr selEvaluateJavaScript_CompletionHandler_Handle = Selector.GetHandle("evaluateJavaScript:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGoBack = "goBack";

	private static readonly IntPtr selGoBackHandle = Selector.GetHandle("goBack");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGoForward = "goForward";

	private static readonly IntPtr selGoForwardHandle = Selector.GetHandle("goForward");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGoToBackForwardListItem_ = "goToBackForwardListItem:";

	private static readonly IntPtr selGoToBackForwardListItem_Handle = Selector.GetHandle("goToBackForwardListItem:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHandlesURLScheme_ = "handlesURLScheme:";

	private static readonly IntPtr selHandlesURLScheme_Handle = Selector.GetHandle("handlesURLScheme:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHasOnlySecureContent = "hasOnlySecureContent";

	private static readonly IntPtr selHasOnlySecureContentHandle = Selector.GetHandle("hasOnlySecureContent");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithFrame_Configuration_ = "initWithFrame:configuration:";

	private static readonly IntPtr selInitWithFrame_Configuration_Handle = Selector.GetHandle("initWithFrame:configuration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsLoading = "isLoading";

	private static readonly IntPtr selIsLoadingHandle = Selector.GetHandle("isLoading");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLoadData_MIMEType_CharacterEncodingName_BaseURL_ = "loadData:MIMEType:characterEncodingName:baseURL:";

	private static readonly IntPtr selLoadData_MIMEType_CharacterEncodingName_BaseURL_Handle = Selector.GetHandle("loadData:MIMEType:characterEncodingName:baseURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLoadFileURL_AllowingReadAccessToURL_ = "loadFileURL:allowingReadAccessToURL:";

	private static readonly IntPtr selLoadFileURL_AllowingReadAccessToURL_Handle = Selector.GetHandle("loadFileURL:allowingReadAccessToURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLoadHTMLString_BaseURL_ = "loadHTMLString:baseURL:";

	private static readonly IntPtr selLoadHTMLString_BaseURL_Handle = Selector.GetHandle("loadHTMLString:baseURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLoadRequest_ = "loadRequest:";

	private static readonly IntPtr selLoadRequest_Handle = Selector.GetHandle("loadRequest:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMagnification = "magnification";

	private static readonly IntPtr selMagnificationHandle = Selector.GetHandle("magnification");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNavigationDelegate = "navigationDelegate";

	private static readonly IntPtr selNavigationDelegateHandle = Selector.GetHandle("navigationDelegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReload = "reload";

	private static readonly IntPtr selReloadHandle = Selector.GetHandle("reload");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReloadFromOrigin = "reloadFromOrigin";

	private static readonly IntPtr selReloadFromOriginHandle = Selector.GetHandle("reloadFromOrigin");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selServerTrust = "serverTrust";

	private static readonly IntPtr selServerTrustHandle = Selector.GetHandle("serverTrust");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAllowsBackForwardNavigationGestures_ = "setAllowsBackForwardNavigationGestures:";

	private static readonly IntPtr selSetAllowsBackForwardNavigationGestures_Handle = Selector.GetHandle("setAllowsBackForwardNavigationGestures:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAllowsLinkPreview_ = "setAllowsLinkPreview:";

	private static readonly IntPtr selSetAllowsLinkPreview_Handle = Selector.GetHandle("setAllowsLinkPreview:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAllowsMagnification_ = "setAllowsMagnification:";

	private static readonly IntPtr selSetAllowsMagnification_Handle = Selector.GetHandle("setAllowsMagnification:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCustomUserAgent_ = "setCustomUserAgent:";

	private static readonly IntPtr selSetCustomUserAgent_Handle = Selector.GetHandle("setCustomUserAgent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMagnification_ = "setMagnification:";

	private static readonly IntPtr selSetMagnification_Handle = Selector.GetHandle("setMagnification:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMagnification_CenteredAtPoint_ = "setMagnification:centeredAtPoint:";

	private static readonly IntPtr selSetMagnification_CenteredAtPoint_Handle = Selector.GetHandle("setMagnification:centeredAtPoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetNavigationDelegate_ = "setNavigationDelegate:";

	private static readonly IntPtr selSetNavigationDelegate_Handle = Selector.GetHandle("setNavigationDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetUIDelegate_ = "setUIDelegate:";

	private static readonly IntPtr selSetUIDelegate_Handle = Selector.GetHandle("setUIDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStopLoading = "stopLoading";

	private static readonly IntPtr selStopLoadingHandle = Selector.GetHandle("stopLoading");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTakeSnapshotWithConfiguration_CompletionHandler_ = "takeSnapshotWithConfiguration:completionHandler:";

	private static readonly IntPtr selTakeSnapshotWithConfiguration_CompletionHandler_Handle = Selector.GetHandle("takeSnapshotWithConfiguration:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTitle = "title";

	private static readonly IntPtr selTitleHandle = Selector.GetHandle("title");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValidateUserInterfaceItem_ = "validateUserInterfaceItem:";

	private static readonly IntPtr selValidateUserInterfaceItem_Handle = Selector.GetHandle("validateUserInterfaceItem:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("WKWebView");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakNavigationDelegate_var;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakUIDelegate_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AllowsBackForwardNavigationGestures
	{
		[Export("allowsBackForwardNavigationGestures")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsBackForwardNavigationGesturesHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsBackForwardNavigationGesturesHandle);
		}
		[Export("setAllowsBackForwardNavigationGestures:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAllowsBackForwardNavigationGestures_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAllowsBackForwardNavigationGestures_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual bool AllowsLinkPreview
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("allowsLinkPreview")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsLinkPreviewHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsLinkPreviewHandle);
		}
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("setAllowsLinkPreview:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAllowsLinkPreview_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAllowsLinkPreview_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AllowsMagnification
	{
		[Export("allowsMagnification")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsMagnificationHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsMagnificationHandle);
		}
		[Export("setAllowsMagnification:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAllowsMagnification_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAllowsMagnification_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual WKBackForwardList BackForwardList
	{
		[Export("backForwardList", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<WKBackForwardList>(Messaging.IntPtr_objc_msgSend(base.Handle, selBackForwardListHandle));
			}
			return Runtime.GetNSObject<WKBackForwardList>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBackForwardListHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CanGoBack
	{
		[Export("canGoBack")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanGoBackHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanGoBackHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CanGoForward
	{
		[Export("canGoForward")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanGoForwardHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanGoForwardHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 10, 0, PlatformArchitecture.None, "Use 'ServerTrust' property.")]
	[Deprecated(PlatformName.MacOSX, 10, 12, PlatformArchitecture.None, "Use 'ServerTrust' property.")]
	public virtual SecCertificate[] CertificateChain
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Deprecated(PlatformName.iOS, 10, 0, PlatformArchitecture.None, "Use 'ServerTrust' property.")]
		[Deprecated(PlatformName.MacOSX, 10, 12, PlatformArchitecture.None, "Use 'ServerTrust' property.")]
		[Export("certificateChain", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<SecCertificate>(Messaging.IntPtr_objc_msgSend(base.Handle, selCertificateChainHandle));
			}
			return NSArray.ArrayFromHandle<SecCertificate>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCertificateChainHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual WKWebViewConfiguration Configuration
	{
		[Export("configuration", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<WKWebViewConfiguration>(Messaging.IntPtr_objc_msgSend(base.Handle, selConfigurationHandle));
			}
			return Runtime.GetNSObject<WKWebViewConfiguration>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selConfigurationHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual string CustomUserAgent
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("customUserAgent")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selCustomUserAgentHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCustomUserAgentHandle));
		}
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("setCustomUserAgent:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetCustomUserAgent_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetCustomUserAgent_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double EstimatedProgress
	{
		[Export("estimatedProgress")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selEstimatedProgressHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selEstimatedProgressHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool HasOnlySecureContent
	{
		[Export("hasOnlySecureContent")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHasOnlySecureContentHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHasOnlySecureContentHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsLoading
	{
		[Export("isLoading")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsLoadingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsLoadingHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat Magnification
	{
		[Export("magnification")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selMagnificationHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selMagnificationHandle);
		}
		[Export("setMagnification:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetMagnification_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetMagnification_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public IWKNavigationDelegate NavigationDelegate
	{
		get
		{
			return WeakNavigationDelegate as IWKNavigationDelegate;
		}
		set
		{
			NSObject nSObject = value as NSObject;
			if (value != null && nSObject == null)
			{
				throw new ArgumentException("The object passed of type " + value.GetType()?.ToString() + " does not derive from NSObject");
			}
			WeakNavigationDelegate = nSObject;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public virtual SecTrust? ServerTrust
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Export("serverTrust")]
		get
		{
			IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selServerTrustHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selServerTrustHandle));
			return (intPtr == IntPtr.Zero) ? null : new SecTrust(intPtr);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Title
	{
		[Export("title")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selTitleHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTitleHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public IWKUIDelegate UIDelegate
	{
		get
		{
			return WeakUIDelegate as IWKUIDelegate;
		}
		set
		{
			NSObject nSObject = value as NSObject;
			if (value != null && nSObject == null)
			{
				throw new ArgumentException("The object passed of type " + value.GetType()?.ToString() + " does not derive from NSObject");
			}
			WeakUIDelegate = nSObject;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl Url
	{
		[Export("URL", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend(base.Handle, selURLHandle));
			}
			return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selURLHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject? WeakNavigationDelegate
	{
		[Export("navigationDelegate", ArgumentSemantic.Weak)]
		get
		{
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNavigationDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selNavigationDelegateHandle)));
			MarkDirty();
			__mt_WeakNavigationDelegate_var = nSObject;
			return nSObject;
		}
		[Export("setNavigationDelegate:", ArgumentSemantic.Weak)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetNavigationDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetNavigationDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_WeakNavigationDelegate_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject? WeakUIDelegate
	{
		[Export("UIDelegate", ArgumentSemantic.Weak)]
		get
		{
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUIDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selUIDelegateHandle)));
			MarkDirty();
			__mt_WeakUIDelegate_var = nSObject;
			return nSObject;
		}
		[Export("setUIDelegate:", ArgumentSemantic.Weak)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetUIDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetUIDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_WeakUIDelegate_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public WKWebView(NSCoder coder)
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
	protected WKWebView(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal WKWebView(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithFrame:configuration:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public WKWebView(CGRect frame, WKWebViewConfiguration configuration)
		: base(NSObjectFlag.Empty)
	{
		if (configuration == null)
		{
			throw new ArgumentNullException("configuration");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_CGRect_IntPtr(base.Handle, selInitWithFrame_Configuration_Handle, frame, configuration.Handle), "initWithFrame:configuration:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_CGRect_IntPtr(base.SuperHandle, selInitWithFrame_Configuration_Handle, frame, configuration.Handle), "initWithFrame:configuration:");
		}
	}

	[Export("evaluateJavaScript:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void EvaluateJavaScript(NSString javascript, [BlockProxy(typeof(Trampolines.NIDWKJavascriptEvaluationResult))] WKJavascriptEvaluationResult? completionHandler)
	{
		if (javascript == null)
		{
			throw new ArgumentNullException("javascript");
		}
		BlockLiteral* ptr;
		if (completionHandler == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDWKJavascriptEvaluationResult.Handler, completionHandler);
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selEvaluateJavaScript_CompletionHandler_Handle, javascript.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selEvaluateJavaScript_CompletionHandler_Handle, javascript.Handle, (IntPtr)ptr);
		}
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<NSObject> EvaluateJavaScriptAsync(NSString javascript)
	{
		TaskCompletionSource<NSObject> tcs = new TaskCompletionSource<NSObject>();
		EvaluateJavaScript(javascript, delegate(NSObject result_, NSError error_)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void EvaluateJavaScript(string javascript, [BlockProxy(typeof(Trampolines.NIDWKJavascriptEvaluationResult))] WKJavascriptEvaluationResult completionHandler)
	{
		EvaluateJavaScript((NSString)javascript, completionHandler);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public Task<NSObject> EvaluateJavaScriptAsync(string javascript)
	{
		TaskCompletionSource<NSObject> tcs = new TaskCompletionSource<NSObject>();
		EvaluateJavaScript(javascript, delegate(NSObject result_, NSError error_)
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

	[Export("goBack")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual WKNavigation GoBack()
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<WKNavigation>(Messaging.IntPtr_objc_msgSend(base.Handle, selGoBackHandle));
		}
		return Runtime.GetNSObject<WKNavigation>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selGoBackHandle));
	}

	[Export("goForward")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual WKNavigation GoForward()
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<WKNavigation>(Messaging.IntPtr_objc_msgSend(base.Handle, selGoForwardHandle));
		}
		return Runtime.GetNSObject<WKNavigation>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selGoForwardHandle));
	}

	[Export("goToBackForwardListItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual WKNavigation GoTo(WKBackForwardListItem item)
	{
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<WKNavigation>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selGoToBackForwardListItem_Handle, item.Handle));
		}
		return Runtime.GetNSObject<WKNavigation>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selGoToBackForwardListItem_Handle, item.Handle));
	}

	[Export("handlesURLScheme:")]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool HandlesUrlScheme(string urlScheme)
	{
		if (urlScheme == null)
		{
			throw new ArgumentNullException("urlScheme");
		}
		IntPtr arg = NSString.CreateNative(urlScheme);
		bool result = Messaging.bool_objc_msgSend_IntPtr(class_ptr, selHandlesURLScheme_Handle, arg);
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("loadData:MIMEType:characterEncodingName:baseURL:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual WKNavigation? LoadData(NSData data, string mimeType, string characterEncodingName, NSUrl baseUrl)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (mimeType == null)
		{
			throw new ArgumentNullException("mimeType");
		}
		if (characterEncodingName == null)
		{
			throw new ArgumentNullException("characterEncodingName");
		}
		if (baseUrl == null)
		{
			throw new ArgumentNullException("baseUrl");
		}
		IntPtr arg = NSString.CreateNative(mimeType);
		IntPtr arg2 = NSString.CreateNative(characterEncodingName);
		WKNavigation result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<WKNavigation>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selLoadData_MIMEType_CharacterEncodingName_BaseURL_Handle, data.Handle, arg, arg2, baseUrl.Handle)) : Runtime.GetNSObject<WKNavigation>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selLoadData_MIMEType_CharacterEncodingName_BaseURL_Handle, data.Handle, arg, arg2, baseUrl.Handle)));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	[Export("loadFileURL:allowingReadAccessToURL:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual WKNavigation? LoadFileUrl(NSUrl url, NSUrl readAccessUrl)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (readAccessUrl == null)
		{
			throw new ArgumentNullException("readAccessUrl");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<WKNavigation>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selLoadFileURL_AllowingReadAccessToURL_Handle, url.Handle, readAccessUrl.Handle));
		}
		return Runtime.GetNSObject<WKNavigation>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selLoadFileURL_AllowingReadAccessToURL_Handle, url.Handle, readAccessUrl.Handle));
	}

	[Export("loadHTMLString:baseURL:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual WKNavigation LoadHtmlString(NSString htmlString, NSUrl? baseUrl)
	{
		if (htmlString == null)
		{
			throw new ArgumentNullException("htmlString");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<WKNavigation>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selLoadHTMLString_BaseURL_Handle, htmlString.Handle, (baseUrl == null) ? IntPtr.Zero : baseUrl.Handle));
		}
		return Runtime.GetNSObject<WKNavigation>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selLoadHTMLString_BaseURL_Handle, htmlString.Handle, (baseUrl == null) ? IntPtr.Zero : baseUrl.Handle));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public WKNavigation LoadHtmlString(string htmlString, NSUrl baseUrl)
	{
		return LoadHtmlString((NSString)htmlString, baseUrl);
	}

	[Export("loadRequest:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual WKNavigation LoadRequest(NSUrlRequest request)
	{
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<WKNavigation>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selLoadRequest_Handle, request.Handle));
		}
		return Runtime.GetNSObject<WKNavigation>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selLoadRequest_Handle, request.Handle));
	}

	[Export("reload")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual WKNavigation Reload()
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<WKNavigation>(Messaging.IntPtr_objc_msgSend(base.Handle, selReloadHandle));
		}
		return Runtime.GetNSObject<WKNavigation>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selReloadHandle));
	}

	[Export("reloadFromOrigin")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual WKNavigation ReloadFromOrigin()
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<WKNavigation>(Messaging.IntPtr_objc_msgSend(base.Handle, selReloadFromOriginHandle));
		}
		return Runtime.GetNSObject<WKNavigation>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selReloadFromOriginHandle));
	}

	[Export("setMagnification:centeredAtPoint:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetMagnification(nfloat magnification, CGPoint centerPoint)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nfloat_CGPoint(base.Handle, selSetMagnification_CenteredAtPoint_Handle, magnification, centerPoint);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nfloat_CGPoint(base.SuperHandle, selSetMagnification_CenteredAtPoint_Handle, magnification, centerPoint);
		}
	}

	[Export("stopLoading")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void StopLoading()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selStopLoadingHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selStopLoadingHandle);
		}
	}

	[Export("takeSnapshotWithConfiguration:completionHandler:")]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void TakeSnapshot(WKSnapshotConfiguration? snapshotConfiguration, [BlockProxy(typeof(Trampolines.NIDActionArity2V86))] Action<NSImage, NSError> completionHandler)
	{
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V86.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selTakeSnapshotWithConfiguration_CompletionHandler_Handle, snapshotConfiguration?.Handle ?? IntPtr.Zero, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selTakeSnapshotWithConfiguration_CompletionHandler_Handle, snapshotConfiguration?.Handle ?? IntPtr.Zero, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<NSImage> TakeSnapshotAsync(WKSnapshotConfiguration? snapshotConfiguration)
	{
		TaskCompletionSource<NSImage> tcs = new TaskCompletionSource<NSImage>();
		TakeSnapshot(snapshotConfiguration, delegate(NSImage arg1_, NSError arg2_)
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

	[Export("validateUserInterfaceItem:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ValidateUserInterfaceItem(INSValidatedUserInterfaceItem item)
	{
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selValidateUserInterfaceItem_Handle, item.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selValidateUserInterfaceItem_Handle, item.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_WeakNavigationDelegate_var = null;
			__mt_WeakUIDelegate_var = null;
		}
	}
}
