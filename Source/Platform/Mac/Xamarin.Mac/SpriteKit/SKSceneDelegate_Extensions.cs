using System;
using ObjCRuntime;

namespace SpriteKit;

public static class SKSceneDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void Update(this ISKSceneDelegate This, double currentTime, SKScene scene)
	{
		if (scene == null)
		{
			throw new ArgumentNullException("scene");
		}
		Messaging.void_objc_msgSend_Double_IntPtr(This.Handle, Selector.GetHandle("update:forScene:"), currentTime, scene.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidEvaluateActions(this ISKSceneDelegate This, SKScene scene)
	{
		if (scene == null)
		{
			throw new ArgumentNullException("scene");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("didEvaluateActionsForScene:"), scene.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidSimulatePhysics(this ISKSceneDelegate This, SKScene scene)
	{
		if (scene == null)
		{
			throw new ArgumentNullException("scene");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("didSimulatePhysicsForScene:"), scene.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidApplyConstraints(this ISKSceneDelegate This, SKScene scene)
	{
		if (scene == null)
		{
			throw new ArgumentNullException("scene");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("didApplyConstraintsForScene:"), scene.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidFinishUpdate(this ISKSceneDelegate This, SKScene scene)
	{
		if (scene == null)
		{
			throw new ArgumentNullException("scene");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("didFinishUpdateForScene:"), scene.Handle);
	}
}
