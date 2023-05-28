using System;
using AppKit;
using ObjCRuntime;

namespace PhotosUI;

public static class PHLivePhotoViewDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void WillBeginPlayback(this IPHLivePhotoViewDelegate This, PHLivePhotoView livePhotoView, PHLivePhotoViewPlaybackStyle playbackStyle)
	{
		NSApplication.EnsureUIThread();
		if (livePhotoView == null)
		{
			throw new ArgumentNullException("livePhotoView");
		}
		Messaging.void_objc_msgSend_IntPtr_Int64(This.Handle, Selector.GetHandle("livePhotoView:willBeginPlaybackWithStyle:"), livePhotoView.Handle, (long)playbackStyle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidEndPlayback(this IPHLivePhotoViewDelegate This, PHLivePhotoView livePhotoView, PHLivePhotoViewPlaybackStyle playbackStyle)
	{
		NSApplication.EnsureUIThread();
		if (livePhotoView == null)
		{
			throw new ArgumentNullException("livePhotoView");
		}
		Messaging.void_objc_msgSend_IntPtr_Int64(This.Handle, Selector.GetHandle("livePhotoView:didEndPlaybackWithStyle:"), livePhotoView.Handle, (long)playbackStyle);
	}
}
