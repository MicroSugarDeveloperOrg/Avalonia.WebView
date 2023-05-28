using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AuthenticationServices;

[Register("ASWebAuthenticationSessionWebBrowserSessionManager", true)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
public class ASWebAuthenticationSessionWebBrowserSessionManager : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSessionHandler = "sessionHandler";

	private static readonly IntPtr selSessionHandlerHandle = Selector.GetHandle("sessionHandler");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSessionHandler_ = "setSessionHandler:";

	private static readonly IntPtr selSetSessionHandler_Handle = Selector.GetHandle("setSessionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSharedManager = "sharedManager";

	private static readonly IntPtr selSharedManagerHandle = Selector.GetHandle("sharedManager");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWasLaunchedByAuthenticationServices = "wasLaunchedByAuthenticationServices";

	private static readonly IntPtr selWasLaunchedByAuthenticationServicesHandle = Selector.GetHandle("wasLaunchedByAuthenticationServices");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("ASWebAuthenticationSessionWebBrowserSessionManager");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_SessionHandler_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IASWebAuthenticationSessionWebBrowserSessionHandling SessionHandler
	{
		[Export("sessionHandler", ArgumentSemantic.Assign)]
		get
		{
			IASWebAuthenticationSessionWebBrowserSessionHandling iASWebAuthenticationSessionWebBrowserSessionHandling = ((!base.IsDirectBinding) ? Runtime.GetINativeObject<IASWebAuthenticationSessionWebBrowserSessionHandling>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSessionHandlerHandle), owns: false) : Runtime.GetINativeObject<IASWebAuthenticationSessionWebBrowserSessionHandling>(Messaging.IntPtr_objc_msgSend(base.Handle, selSessionHandlerHandle), owns: false));
			MarkDirty();
			__mt_SessionHandler_var = iASWebAuthenticationSessionWebBrowserSessionHandling;
			return iASWebAuthenticationSessionWebBrowserSessionHandling;
		}
		[Export("setSessionHandler:", ArgumentSemantic.Assign)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSessionHandler_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSessionHandler_Handle, value.Handle);
			}
			MarkDirty();
			__mt_SessionHandler_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static ASWebAuthenticationSessionWebBrowserSessionManager SharedManager
	{
		[Export("sharedManager")]
		get
		{
			return Runtime.GetNSObject<ASWebAuthenticationSessionWebBrowserSessionManager>(Messaging.IntPtr_objc_msgSend(class_ptr, selSharedManagerHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool WasLaunchedByAuthenticationServices
	{
		[Export("wasLaunchedByAuthenticationServices")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selWasLaunchedByAuthenticationServicesHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selWasLaunchedByAuthenticationServicesHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected ASWebAuthenticationSessionWebBrowserSessionManager(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal ASWebAuthenticationSessionWebBrowserSessionManager(IntPtr handle)
		: base(handle)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_SessionHandler_var = null;
		}
	}
}
