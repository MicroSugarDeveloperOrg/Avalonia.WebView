using System;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

public static class AVAssetResourceLoaderDelegate_Extensions
{
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidCancelLoadingRequest(this IAVAssetResourceLoaderDelegate This, AVAssetResourceLoader resourceLoader, AVAssetResourceLoadingRequest loadingRequest)
	{
		if (resourceLoader == null)
		{
			throw new ArgumentNullException("resourceLoader");
		}
		if (loadingRequest == null)
		{
			throw new ArgumentNullException("loadingRequest");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("resourceLoader:didCancelLoadingRequest:"), resourceLoader.Handle, loadingRequest.Handle);
	}

	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ShouldWaitForResponseToAuthenticationChallenge(this IAVAssetResourceLoaderDelegate This, AVAssetResourceLoader resourceLoader, NSUrlAuthenticationChallenge authenticationChallenge)
	{
		if (resourceLoader == null)
		{
			throw new ArgumentNullException("resourceLoader");
		}
		if (authenticationChallenge == null)
		{
			throw new ArgumentNullException("authenticationChallenge");
		}
		return Messaging.bool_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("resourceLoader:shouldWaitForResponseToAuthenticationChallenge:"), resourceLoader.Handle, authenticationChallenge.Handle);
	}

	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidCancelAuthenticationChallenge(this IAVAssetResourceLoaderDelegate This, AVAssetResourceLoader resourceLoader, NSUrlAuthenticationChallenge authenticationChallenge)
	{
		if (resourceLoader == null)
		{
			throw new ArgumentNullException("resourceLoader");
		}
		if (authenticationChallenge == null)
		{
			throw new ArgumentNullException("authenticationChallenge");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("resourceLoader:didCancelAuthenticationChallenge:"), resourceLoader.Handle, authenticationChallenge.Handle);
	}

	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ShouldWaitForRenewalOfRequestedResource(this IAVAssetResourceLoaderDelegate This, AVAssetResourceLoader resourceLoader, AVAssetResourceRenewalRequest renewalRequest)
	{
		if (resourceLoader == null)
		{
			throw new ArgumentNullException("resourceLoader");
		}
		if (renewalRequest == null)
		{
			throw new ArgumentNullException("renewalRequest");
		}
		return Messaging.bool_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("resourceLoader:shouldWaitForRenewalOfRequestedResource:"), resourceLoader.Handle, renewalRequest.Handle);
	}
}
