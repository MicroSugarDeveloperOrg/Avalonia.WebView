using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AuthenticationServices;

[Register("ASAuthorizationPasswordProvider", true)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
public class ASAuthorizationPasswordProvider : NSObject, IASAuthorizationProvider, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCreateRequest = "createRequest";

	private static readonly IntPtr selCreateRequestHandle = Selector.GetHandle("createRequest");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("ASAuthorizationPasswordProvider");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public ASAuthorizationPasswordProvider()
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
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected ASAuthorizationPasswordProvider(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal ASAuthorizationPasswordProvider(IntPtr handle)
		: base(handle)
	{
	}

	[Export("createRequest")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual ASAuthorizationPasswordRequest CreateRequest()
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<ASAuthorizationPasswordRequest>(Messaging.IntPtr_objc_msgSend(base.Handle, selCreateRequestHandle));
		}
		return Runtime.GetNSObject<ASAuthorizationPasswordRequest>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCreateRequestHandle));
	}
}
