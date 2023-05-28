using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Protocol]
[Register("AVAssetResourceLoaderDelegate", false)]
[Model]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
public abstract class AVAssetResourceLoaderDelegate : NSObject, IAVAssetResourceLoaderDelegate, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	protected AVAssetResourceLoaderDelegate()
		: base(NSObjectFlag.Empty)
	{
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AVAssetResourceLoaderDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVAssetResourceLoaderDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("resourceLoader:didCancelAuthenticationChallenge:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidCancelAuthenticationChallenge(AVAssetResourceLoader resourceLoader, NSUrlAuthenticationChallenge authenticationChallenge)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("resourceLoader:didCancelLoadingRequest:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidCancelLoadingRequest(AVAssetResourceLoader resourceLoader, AVAssetResourceLoadingRequest loadingRequest)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("resourceLoader:shouldWaitForLoadingOfRequestedResource:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract bool ShouldWaitForLoadingOfRequestedResource(AVAssetResourceLoader resourceLoader, AVAssetResourceLoadingRequest loadingRequest);

	[Export("resourceLoader:shouldWaitForRenewalOfRequestedResource:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldWaitForRenewalOfRequestedResource(AVAssetResourceLoader resourceLoader, AVAssetResourceRenewalRequest renewalRequest)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("resourceLoader:shouldWaitForResponseToAuthenticationChallenge:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldWaitForResponseToAuthenticationChallenge(AVAssetResourceLoader resourceLoader, NSUrlAuthenticationChallenge authenticationChallenge)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
