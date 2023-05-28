using System;
using Foundation;
using ObjCRuntime;

namespace SceneKit;

public static class SCNSceneRendererDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void WillRenderScene(this ISCNSceneRendererDelegate This, ISCNSceneRenderer renderer, SCNScene scene, double timeInSeconds)
	{
		if (renderer != null)
		{
			if (!(renderer is NSObject))
			{
				throw new ArgumentException("The object passed of type " + renderer.GetType()?.ToString() + " does not derive from NSObject");
			}
			if (scene == null)
			{
				throw new ArgumentNullException("scene");
			}
			Messaging.void_objc_msgSend_IntPtr_IntPtr_Double(This.Handle, Selector.GetHandle("renderer:willRenderScene:atTime:"), renderer.Handle, scene.Handle, timeInSeconds);
			return;
		}
		throw new ArgumentNullException("renderer");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidRenderScene(this ISCNSceneRendererDelegate This, ISCNSceneRenderer renderer, SCNScene scene, double timeInSeconds)
	{
		if (renderer != null)
		{
			if (!(renderer is NSObject))
			{
				throw new ArgumentException("The object passed of type " + renderer.GetType()?.ToString() + " does not derive from NSObject");
			}
			if (scene == null)
			{
				throw new ArgumentNullException("scene");
			}
			Messaging.void_objc_msgSend_IntPtr_IntPtr_Double(This.Handle, Selector.GetHandle("renderer:didRenderScene:atTime:"), renderer.Handle, scene.Handle, timeInSeconds);
			return;
		}
		throw new ArgumentNullException("renderer");
	}

	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void Update(this ISCNSceneRendererDelegate This, ISCNSceneRenderer renderer, double timeInSeconds)
	{
		if (renderer != null)
		{
			if (!(renderer is NSObject))
			{
				throw new ArgumentException("The object passed of type " + renderer.GetType()?.ToString() + " does not derive from NSObject");
			}
			Messaging.void_objc_msgSend_IntPtr_Double(This.Handle, Selector.GetHandle("renderer:updateAtTime:"), renderer.Handle, timeInSeconds);
			return;
		}
		throw new ArgumentNullException("renderer");
	}

	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidApplyAnimations(this ISCNSceneRendererDelegate This, ISCNSceneRenderer renderer, double timeInSeconds)
	{
		if (renderer != null)
		{
			if (!(renderer is NSObject))
			{
				throw new ArgumentException("The object passed of type " + renderer.GetType()?.ToString() + " does not derive from NSObject");
			}
			Messaging.void_objc_msgSend_IntPtr_Double(This.Handle, Selector.GetHandle("renderer:didApplyAnimationsAtTime:"), renderer.Handle, timeInSeconds);
			return;
		}
		throw new ArgumentNullException("renderer");
	}

	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidSimulatePhysics(this ISCNSceneRendererDelegate This, ISCNSceneRenderer renderer, double timeInSeconds)
	{
		if (renderer != null)
		{
			if (!(renderer is NSObject))
			{
				throw new ArgumentException("The object passed of type " + renderer.GetType()?.ToString() + " does not derive from NSObject");
			}
			Messaging.void_objc_msgSend_IntPtr_Double(This.Handle, Selector.GetHandle("renderer:didSimulatePhysicsAtTime:"), renderer.Handle, timeInSeconds);
			return;
		}
		throw new ArgumentNullException("renderer");
	}

	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidApplyConstraints(this ISCNSceneRendererDelegate This, ISCNSceneRenderer renderer, double atTime)
	{
		if (renderer != null)
		{
			if (!(renderer is NSObject))
			{
				throw new ArgumentException("The object passed of type " + renderer.GetType()?.ToString() + " does not derive from NSObject");
			}
			Messaging.void_objc_msgSend_IntPtr_Double(This.Handle, Selector.GetHandle("renderer:didApplyConstraintsAtTime:"), renderer.Handle, atTime);
			return;
		}
		throw new ArgumentNullException("renderer");
	}
}
