using System;
using Foundation;
using ObjCRuntime;

namespace SceneKit;

public static class SCNNodeRendererDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void Render(this ISCNNodeRendererDelegate This, SCNNode node, SCNRenderer renderer, NSDictionary? arguments)
	{
		if (node == null)
		{
			throw new ArgumentNullException("node");
		}
		if (renderer == null)
		{
			throw new ArgumentNullException("renderer");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("renderNode:renderer:arguments:"), node.Handle, renderer.Handle, arguments?.Handle ?? IntPtr.Zero);
	}
}
