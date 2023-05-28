using System;
using ObjCRuntime;

namespace AVFoundation;

public static class AVVideoCompositing_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void CancelAllPendingVideoCompositionRequests(this IAVVideoCompositing This)
	{
		Messaging.void_objc_msgSend(This.Handle, Selector.GetHandle("cancelAllPendingVideoCompositionRequests"));
	}

	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void AnticipateRendering(this IAVVideoCompositing This, AVVideoCompositionRenderHint renderHint)
	{
		if (renderHint == null)
		{
			throw new ArgumentNullException("renderHint");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("anticipateRenderingUsingHint:"), renderHint.Handle);
	}

	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void PrerollForRendering(this IAVVideoCompositing This, AVVideoCompositionRenderHint renderHint)
	{
		if (renderHint == null)
		{
			throw new ArgumentNullException("renderHint");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("prerollForRenderingUsingHint:"), renderHint.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool GetSupportsWideColorSourceFrames(this IAVVideoCompositing This)
	{
		return Messaging.bool_objc_msgSend(This.Handle, Selector.GetHandle("supportsWideColorSourceFrames"));
	}
}
