using System;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
public static class AVPlayerItem_AVPlayerItemProtectedContent
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCancelContentAuthorizationRequest = "cancelContentAuthorizationRequest";

	private static readonly IntPtr selCancelContentAuthorizationRequestHandle = Selector.GetHandle("cancelContentAuthorizationRequest");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContentAuthorizationRequestStatus = "contentAuthorizationRequestStatus";

	private static readonly IntPtr selContentAuthorizationRequestStatusHandle = Selector.GetHandle("contentAuthorizationRequestStatus");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsApplicationAuthorizedForPlayback = "isApplicationAuthorizedForPlayback";

	private static readonly IntPtr selIsApplicationAuthorizedForPlaybackHandle = Selector.GetHandle("isApplicationAuthorizedForPlayback");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAuthorizationRequiredForPlayback = "isAuthorizationRequiredForPlayback";

	private static readonly IntPtr selIsAuthorizationRequiredForPlaybackHandle = Selector.GetHandle("isAuthorizationRequiredForPlayback");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsContentAuthorizedForPlayback = "isContentAuthorizedForPlayback";

	private static readonly IntPtr selIsContentAuthorizedForPlaybackHandle = Selector.GetHandle("isContentAuthorizedForPlayback");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRequestContentAuthorizationAsynchronouslyWithTimeoutInterval_CompletionHandler_ = "requestContentAuthorizationAsynchronouslyWithTimeoutInterval:completionHandler:";

	private static readonly IntPtr selRequestContentAuthorizationAsynchronouslyWithTimeoutInterval_CompletionHandler_Handle = Selector.GetHandle("requestContentAuthorizationAsynchronouslyWithTimeoutInterval:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = Class.GetHandle("AVPlayerItem");

	[Export("cancelContentAuthorizationRequest")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void CancelContentAuthorizationRequest(this AVPlayerItem This)
	{
		Messaging.void_objc_msgSend(This.Handle, selCancelContentAuthorizationRequestHandle);
	}

	[Export("contentAuthorizationRequestStatus")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVContentAuthorizationStatus GetContentAuthorizationRequestStatus(this AVPlayerItem This)
	{
		return (AVContentAuthorizationStatus)Messaging.Int64_objc_msgSend(This.Handle, selContentAuthorizationRequestStatusHandle);
	}

	[Export("isApplicationAuthorizedForPlayback")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool IsApplicationAuthorizedForPlayback(this AVPlayerItem This)
	{
		return Messaging.bool_objc_msgSend(This.Handle, selIsApplicationAuthorizedForPlaybackHandle);
	}

	[Export("isAuthorizationRequiredForPlayback")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool IsAuthorizationRequiredForPlayback(this AVPlayerItem This)
	{
		return Messaging.bool_objc_msgSend(This.Handle, selIsAuthorizationRequiredForPlaybackHandle);
	}

	[Export("isContentAuthorizedForPlayback")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool IsContentAuthorizedForPlayback(this AVPlayerItem This)
	{
		return Messaging.bool_objc_msgSend(This.Handle, selIsContentAuthorizedForPlaybackHandle);
	}

	[Export("requestContentAuthorizationAsynchronouslyWithTimeoutInterval:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void RequestContentAuthorizationAsynchronously(this AVPlayerItem This, double timeoutInterval, [BlockProxy(typeof(Trampolines.NIDAction))] Action handler)
	{
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDAction.Handler, handler);
		Messaging.void_objc_msgSend_Double_IntPtr(This.Handle, selRequestContentAuthorizationAsynchronouslyWithTimeoutInterval_CompletionHandler_Handle, timeoutInterval, (IntPtr)ptr);
		ptr->CleanupBlock();
	}
}
