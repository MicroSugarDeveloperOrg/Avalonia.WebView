using System;
using ObjCRuntime;

namespace SceneKit;

public static class SCNCameraControllerDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void CameraInertiaWillStart(this ISCNCameraControllerDelegate This, SCNCameraController cameraController)
	{
		if (cameraController == null)
		{
			throw new ArgumentNullException("cameraController");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("cameraInertiaWillStartForController:"), cameraController.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void CameraInertiaDidEnd(this ISCNCameraControllerDelegate This, SCNCameraController cameraController)
	{
		if (cameraController == null)
		{
			throw new ArgumentNullException("cameraController");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("cameraInertiaDidEndForController:"), cameraController.Handle);
	}
}
