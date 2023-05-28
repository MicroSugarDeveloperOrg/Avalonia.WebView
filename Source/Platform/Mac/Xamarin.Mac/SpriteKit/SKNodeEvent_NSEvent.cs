using System;
using AppKit;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace SpriteKit;

[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
public static class SKNodeEvent_NSEvent
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLocationInNode_ = "locationInNode:";

	private static readonly IntPtr selLocationInNode_Handle = Selector.GetHandle("locationInNode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = Class.GetHandle("NSEvent");

	[Export("locationInNode:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CGPoint LocationInNode(this NSEvent This, SKNode node)
	{
		if (node == null)
		{
			throw new ArgumentNullException("node");
		}
		return Messaging.CGPoint_objc_msgSend_IntPtr(This.Handle, selLocationInNode_Handle, node.Handle);
	}
}
