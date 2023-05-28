using System;
using System.ComponentModel;
using AppKit;
using Foundation;
using ObjCRuntime;

namespace PhotosUI;

[Protocol]
[Register("PHLivePhotoViewDelegate", false)]
[Model]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 9, 1, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
public class PHLivePhotoViewDelegate : NSObject, IPHLivePhotoViewDelegate, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public PHLivePhotoViewDelegate()
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected PHLivePhotoViewDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal PHLivePhotoViewDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("livePhotoView:didEndPlaybackWithStyle:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidEndPlayback(PHLivePhotoView livePhotoView, PHLivePhotoViewPlaybackStyle playbackStyle)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("livePhotoView:willBeginPlaybackWithStyle:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WillBeginPlayback(PHLivePhotoView livePhotoView, PHLivePhotoViewPlaybackStyle playbackStyle)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
