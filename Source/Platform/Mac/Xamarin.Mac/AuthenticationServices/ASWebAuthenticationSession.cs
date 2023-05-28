using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AuthenticationServices;

[Register("ASWebAuthenticationSession", true)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 6, 2, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
public class ASWebAuthenticationSession : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanStart = "canStart";

	private static readonly IntPtr selCanStartHandle = Selector.GetHandle("canStart");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCancel = "cancel";

	private static readonly IntPtr selCancelHandle = Selector.GetHandle("cancel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithURL_CallbackURLScheme_CompletionHandler_ = "initWithURL:callbackURLScheme:completionHandler:";

	private static readonly IntPtr selInitWithURL_CallbackURLScheme_CompletionHandler_Handle = Selector.GetHandle("initWithURL:callbackURLScheme:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrefersEphemeralWebBrowserSession = "prefersEphemeralWebBrowserSession";

	private static readonly IntPtr selPrefersEphemeralWebBrowserSessionHandle = Selector.GetHandle("prefersEphemeralWebBrowserSession");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPresentationContextProvider = "presentationContextProvider";

	private static readonly IntPtr selPresentationContextProviderHandle = Selector.GetHandle("presentationContextProvider");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPrefersEphemeralWebBrowserSession_ = "setPrefersEphemeralWebBrowserSession:";

	private static readonly IntPtr selSetPrefersEphemeralWebBrowserSession_Handle = Selector.GetHandle("setPrefersEphemeralWebBrowserSession:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPresentationContextProvider_ = "setPresentationContextProvider:";

	private static readonly IntPtr selSetPresentationContextProvider_Handle = Selector.GetHandle("setPresentationContextProvider:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStart = "start";

	private static readonly IntPtr selStartHandle = Selector.GetHandle("start");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("ASWebAuthenticationSession");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_PresentationContextProvider_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 15, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 4, PlatformArchitecture.All, null)]
	public virtual bool CanStart
	{
		[Introduced(PlatformName.MacOSX, 10, 15, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 4, PlatformArchitecture.All, null)]
		[Export("canStart")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanStartHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanStartHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	public virtual bool PrefersEphemeralWebBrowserSession
	{
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("prefersEphemeralWebBrowserSession")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selPrefersEphemeralWebBrowserSessionHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selPrefersEphemeralWebBrowserSessionHandle);
		}
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("setPrefersEphemeralWebBrowserSession:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetPrefersEphemeralWebBrowserSession_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetPrefersEphemeralWebBrowserSession_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	public virtual IASWebAuthenticationPresentationContextProviding? PresentationContextProvider
	{
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Export("presentationContextProvider", ArgumentSemantic.Weak)]
		get
		{
			IASWebAuthenticationPresentationContextProviding iASWebAuthenticationPresentationContextProviding = ((!base.IsDirectBinding) ? Runtime.GetINativeObject<IASWebAuthenticationPresentationContextProviding>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPresentationContextProviderHandle), owns: false) : Runtime.GetINativeObject<IASWebAuthenticationPresentationContextProviding>(Messaging.IntPtr_objc_msgSend(base.Handle, selPresentationContextProviderHandle), owns: false));
			MarkDirty();
			__mt_PresentationContextProvider_var = iASWebAuthenticationPresentationContextProviding;
			return iASWebAuthenticationPresentationContextProviding;
		}
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Export("setPresentationContextProvider:", ArgumentSemantic.Weak)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPresentationContextProvider_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPresentationContextProvider_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_PresentationContextProvider_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected ASWebAuthenticationSession(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal ASWebAuthenticationSession(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithURL:callbackURLScheme:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe ASWebAuthenticationSession(NSUrl url, string? callbackUrlScheme, [BlockProxy(typeof(Trampolines.NIDASWebAuthenticationSessionCompletionHandler))] ASWebAuthenticationSessionCompletionHandler completionHandler)
		: base(NSObjectFlag.Empty)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		IntPtr arg = NSString.CreateNative(callbackUrlScheme);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDASWebAuthenticationSessionCompletionHandler.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selInitWithURL_CallbackURLScheme_CompletionHandler_Handle, url.Handle, arg, (IntPtr)ptr), "initWithURL:callbackURLScheme:completionHandler:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selInitWithURL_CallbackURLScheme_CompletionHandler_Handle, url.Handle, arg, (IntPtr)ptr), "initWithURL:callbackURLScheme:completionHandler:");
		}
		NSString.ReleaseNative(arg);
		ptr->CleanupBlock();
	}

	[Export("cancel")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Cancel()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selCancelHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selCancelHandle);
		}
	}

	[Export("start")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Start()
	{
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selStartHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selStartHandle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_PresentationContextProvider_var = null;
		}
	}
}
