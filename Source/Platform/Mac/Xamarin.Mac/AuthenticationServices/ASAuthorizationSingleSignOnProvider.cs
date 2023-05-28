using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AuthenticationServices;

[Register("ASAuthorizationSingleSignOnProvider", true)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
public class ASAuthorizationSingleSignOnProvider : NSObject, IASAuthorizationProvider, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAuthorizationProviderWithIdentityProviderURL_ = "authorizationProviderWithIdentityProviderURL:";

	private static readonly IntPtr selAuthorizationProviderWithIdentityProviderURL_Handle = Selector.GetHandle("authorizationProviderWithIdentityProviderURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanPerformAuthorization = "canPerformAuthorization";

	private static readonly IntPtr selCanPerformAuthorizationHandle = Selector.GetHandle("canPerformAuthorization");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCreateRequest = "createRequest";

	private static readonly IntPtr selCreateRequestHandle = Selector.GetHandle("createRequest");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUrl = "url";

	private static readonly IntPtr selUrlHandle = Selector.GetHandle("url");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("ASAuthorizationSingleSignOnProvider");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CanPerformAuthorization
	{
		[Export("canPerformAuthorization")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanPerformAuthorizationHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanPerformAuthorizationHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl Url
	{
		[Export("url")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend(base.Handle, selUrlHandle));
			}
			return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUrlHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected ASAuthorizationSingleSignOnProvider(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal ASAuthorizationSingleSignOnProvider(IntPtr handle)
		: base(handle)
	{
	}

	[Export("authorizationProviderWithIdentityProviderURL:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static ASAuthorizationSingleSignOnProvider CreateProvider(NSUrl identityProviderUrl)
	{
		if (identityProviderUrl == null)
		{
			throw new ArgumentNullException("identityProviderUrl");
		}
		return Runtime.GetNSObject<ASAuthorizationSingleSignOnProvider>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selAuthorizationProviderWithIdentityProviderURL_Handle, identityProviderUrl.Handle));
	}

	[Export("createRequest")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual ASAuthorizationSingleSignOnRequest CreateRequest()
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<ASAuthorizationSingleSignOnRequest>(Messaging.IntPtr_objc_msgSend(base.Handle, selCreateRequestHandle));
		}
		return Runtime.GetNSObject<ASAuthorizationSingleSignOnRequest>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCreateRequestHandle));
	}
}
