using System;
using Foundation;
using ObjCRuntime;

namespace AVKit;

public static class AVPictureInPictureControllerDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void WillStartPictureInPicture(this IAVPictureInPictureControllerDelegate This, AVPictureInPictureController pictureInPictureController)
	{
		if (pictureInPictureController == null)
		{
			throw new ArgumentNullException("pictureInPictureController");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("pictureInPictureControllerWillStartPictureInPicture:"), pictureInPictureController.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidStartPictureInPicture(this IAVPictureInPictureControllerDelegate This, AVPictureInPictureController pictureInPictureController)
	{
		if (pictureInPictureController == null)
		{
			throw new ArgumentNullException("pictureInPictureController");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("pictureInPictureControllerDidStartPictureInPicture:"), pictureInPictureController.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void FailedToStartPictureInPicture(this IAVPictureInPictureControllerDelegate This, AVPictureInPictureController pictureInPictureController, NSError error)
	{
		if (pictureInPictureController == null)
		{
			throw new ArgumentNullException("pictureInPictureController");
		}
		if (error == null)
		{
			throw new ArgumentNullException("error");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("pictureInPictureController:failedToStartPictureInPictureWithError:"), pictureInPictureController.Handle, error.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void WillStopPictureInPicture(this IAVPictureInPictureControllerDelegate This, AVPictureInPictureController pictureInPictureController)
	{
		if (pictureInPictureController == null)
		{
			throw new ArgumentNullException("pictureInPictureController");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("pictureInPictureControllerWillStopPictureInPicture:"), pictureInPictureController.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidStopPictureInPicture(this IAVPictureInPictureControllerDelegate This, AVPictureInPictureController pictureInPictureController)
	{
		if (pictureInPictureController == null)
		{
			throw new ArgumentNullException("pictureInPictureController");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("pictureInPictureControllerDidStopPictureInPicture:"), pictureInPictureController.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void RestoreUserInterfaceForPictureInPicture(this IAVPictureInPictureControllerDelegate This, AVPictureInPictureController pictureInPictureController, [BlockProxy(typeof(Trampolines.NIDActionArity1V0))] Action<bool> completionHandler)
	{
		if (pictureInPictureController == null)
		{
			throw new ArgumentNullException("pictureInPictureController");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V0.Handler, completionHandler);
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("pictureInPictureController:restoreUserInterfaceForPictureInPictureStopWithCompletionHandler:"), pictureInPictureController.Handle, (IntPtr)ptr);
		ptr->CleanupBlock();
	}
}
