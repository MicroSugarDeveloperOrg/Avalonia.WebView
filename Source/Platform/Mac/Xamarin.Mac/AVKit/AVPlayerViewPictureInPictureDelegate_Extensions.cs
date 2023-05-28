using System;
using Foundation;
using ObjCRuntime;

namespace AVKit;

public static class AVPlayerViewPictureInPictureDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void WillStart(this IAVPlayerViewPictureInPictureDelegate This, AVPlayerView playerView)
	{
		if (playerView == null)
		{
			throw new ArgumentNullException("playerView");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("playerViewWillStartPictureInPicture:"), playerView.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidStart(this IAVPlayerViewPictureInPictureDelegate This, AVPlayerView playerView)
	{
		if (playerView == null)
		{
			throw new ArgumentNullException("playerView");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("playerViewDidStartPictureInPicture:"), playerView.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void FailedToStart(this IAVPlayerViewPictureInPictureDelegate This, AVPlayerView playerView, NSError error)
	{
		if (playerView == null)
		{
			throw new ArgumentNullException("playerView");
		}
		if (error == null)
		{
			throw new ArgumentNullException("error");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("playerView:failedToStartPictureInPictureWithError:"), playerView.Handle, error.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void WillStop(this IAVPlayerViewPictureInPictureDelegate This, AVPlayerView playerView)
	{
		if (playerView == null)
		{
			throw new ArgumentNullException("playerView");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("playerViewWillStopPictureInPicture:"), playerView.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidStop(this IAVPlayerViewPictureInPictureDelegate This, AVPlayerView playerView)
	{
		if (playerView == null)
		{
			throw new ArgumentNullException("playerView");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("playerViewDidStopPictureInPicture:"), playerView.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void RestoreUserInterface(this IAVPlayerViewPictureInPictureDelegate This, AVPlayerView playerView, [BlockProxy(typeof(Trampolines.NIDActionArity1V0))] Action<bool> completionHandler)
	{
		if (playerView == null)
		{
			throw new ArgumentNullException("playerView");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V0.Handler, completionHandler);
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("playerView:restoreUserInterfaceForPictureInPictureStopWithCompletionHandler:"), playerView.Handle, (IntPtr)ptr);
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ShouldAutomaticallyDismiss(this IAVPlayerViewPictureInPictureDelegate This, AVPlayerView playerView)
	{
		if (playerView == null)
		{
			throw new ArgumentNullException("playerView");
		}
		return Messaging.bool_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("playerViewShouldAutomaticallyDismissAtPictureInPictureStart:"), playerView.Handle);
	}
}
