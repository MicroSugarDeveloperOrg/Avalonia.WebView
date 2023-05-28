using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Protocol]
[Register("AVContentKeySessionDelegate", false)]
[Model]
[Introduced(PlatformName.TvOS, 10, 2, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, 4, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 10, 3, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
public abstract class AVContentKeySessionDelegate : NSObject, IAVContentKeySessionDelegate, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	protected AVContentKeySessionDelegate()
		: base(NSObjectFlag.Empty)
	{
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AVContentKeySessionDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVContentKeySessionDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("contentKeySessionContentProtectionSessionIdentifierDidChange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidChange(AVContentKeySession session)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("contentKeySession:contentKeyRequest:didFailWithError:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidFail(AVContentKeySession session, AVContentKeyRequest keyRequest, NSError err)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("contentKeySessionDidGenerateExpiredSessionReport:")]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidGenerateExpiredSessionReport(AVContentKeySession session)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("contentKeySession:didProvideContentKeyRequest:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract void DidProvideContentKeyRequest(AVContentKeySession session, AVContentKeyRequest keyRequest);

	[Export("contentKeySession:didProvidePersistableContentKeyRequest:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidProvidePersistableContentKeyRequest(AVContentKeySession session, AVPersistableContentKeyRequest keyRequest)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("contentKeySession:didProvideRenewingContentKeyRequest:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidProvideRenewingContentKeyRequest(AVContentKeySession session, AVContentKeyRequest keyRequest)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("contentKeySession:contentKeyRequestDidSucceed:")]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidSucceed(AVContentKeySession session, AVContentKeyRequest keyRequest)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("contentKeySession:didUpdatePersistableContentKey:forContentKeyIdentifier:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidUpdate(AVContentKeySession session, NSData persistableContentKey, NSObject keyIdentifier)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("contentKeySession:shouldRetryContentKeyRequest:reason:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldRetryContentKeyRequest(AVContentKeySession session, AVContentKeyRequest keyRequest, string retryReason)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
