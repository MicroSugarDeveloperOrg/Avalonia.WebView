using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AuthenticationServices;

[Register("ASAuthorization", true)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
public class ASAuthorization : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCredential = "credential";

	private static readonly IntPtr selCredentialHandle = Selector.GetHandle("credential");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selProvider = "provider";

	private static readonly IntPtr selProviderHandle = Selector.GetHandle("provider");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("ASAuthorization");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual IntPtr _Credential
	{
		[Export("credential", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.IntPtr_objc_msgSend(base.Handle, selCredentialHandle);
			}
			return Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCredentialHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual IntPtr _Provider
	{
		[Export("provider", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.IntPtr_objc_msgSend(base.Handle, selProviderHandle);
			}
			return Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selProviderHandle);
		}
	}

	public T GetProvider<T>() where T : NSObject, IASAuthorizationProvider
	{
		return Runtime.GetINativeObject<T>(_Provider, owns: false);
	}

	public T GetCredential<T>() where T : NSObject, IASAuthorizationCredential
	{
		return Runtime.GetINativeObject<T>(_Credential, owns: false);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected ASAuthorization(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal ASAuthorization(IntPtr handle)
		: base(handle)
	{
	}
}
