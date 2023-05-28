using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AVKit;

[Protocol]
[Register("Xamarin_Mac__AVKit_AVPlayerViewPictureInPictureDelegate", false)]
[Model]
[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
public class AVPlayerViewPictureInPictureDelegate : NSObject, IAVPlayerViewPictureInPictureDelegate, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public AVPlayerViewPictureInPictureDelegate()
		: base(NSObjectFlag.Empty)
	{
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AVPlayerViewPictureInPictureDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVPlayerViewPictureInPictureDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("playerViewDidStartPictureInPicture:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidStart(AVPlayerView playerView)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("playerViewDidStopPictureInPicture:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidStop(AVPlayerView playerView)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("playerView:failedToStartPictureInPictureWithError:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void FailedToStart(AVPlayerView playerView, NSError error)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("playerView:restoreUserInterfaceForPictureInPictureStopWithCompletionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RestoreUserInterface(AVPlayerView playerView, [BlockProxy(typeof(Trampolines.NIDActionArity1V0))] Action<bool> completionHandler)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("playerViewShouldAutomaticallyDismissAtPictureInPictureStart:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldAutomaticallyDismiss(AVPlayerView playerView)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("playerViewWillStartPictureInPicture:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WillStart(AVPlayerView playerView)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("playerViewWillStopPictureInPicture:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WillStop(AVPlayerView playerView)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
