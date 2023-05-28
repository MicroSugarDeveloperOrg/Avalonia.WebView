using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AVKit;

[Protocol]
[Register("AVPictureInPictureControllerDelegate", false)]
[Model]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
public class AVPictureInPictureControllerDelegate : NSObject, IAVPictureInPictureControllerDelegate, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public AVPictureInPictureControllerDelegate()
		: base(NSObjectFlag.Empty)
	{
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AVPictureInPictureControllerDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVPictureInPictureControllerDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("pictureInPictureControllerDidStartPictureInPicture:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidStartPictureInPicture(AVPictureInPictureController pictureInPictureController)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("pictureInPictureControllerDidStopPictureInPicture:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidStopPictureInPicture(AVPictureInPictureController pictureInPictureController)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("pictureInPictureController:failedToStartPictureInPictureWithError:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void FailedToStartPictureInPicture(AVPictureInPictureController pictureInPictureController, NSError error)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("pictureInPictureController:restoreUserInterfaceForPictureInPictureStopWithCompletionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RestoreUserInterfaceForPictureInPicture(AVPictureInPictureController pictureInPictureController, [BlockProxy(typeof(Trampolines.NIDActionArity1V0))] Action<bool> completionHandler)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("pictureInPictureControllerWillStartPictureInPicture:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WillStartPictureInPicture(AVPictureInPictureController pictureInPictureController)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("pictureInPictureControllerWillStopPictureInPicture:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WillStopPictureInPicture(AVPictureInPictureController pictureInPictureController)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
