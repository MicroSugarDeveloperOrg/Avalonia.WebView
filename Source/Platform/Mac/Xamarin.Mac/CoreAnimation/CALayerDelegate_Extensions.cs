using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace CoreAnimation;

public static class CALayerDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DisplayLayer(this ICALayerDelegate This, CALayer layer)
	{
		if (layer == null)
		{
			throw new ArgumentNullException("layer");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("displayLayer:"), layer.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DrawLayer(this ICALayerDelegate This, CALayer layer, CGContext context)
	{
		if (layer == null)
		{
			throw new ArgumentNullException("layer");
		}
		if (context == null)
		{
			throw new ArgumentNullException("context");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("drawLayer:inContext:"), layer.Handle, context.Handle);
	}

	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void WillDrawLayer(this ICALayerDelegate This, CALayer layer)
	{
		if (layer == null)
		{
			throw new ArgumentNullException("layer");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("layerWillDraw:"), layer.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void LayoutSublayersOfLayer(this ICALayerDelegate This, CALayer layer)
	{
		if (layer == null)
		{
			throw new ArgumentNullException("layer");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("layoutSublayersOfLayer:"), layer.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSObject ActionForLayer(this ICALayerDelegate This, CALayer layer, string eventKey)
	{
		if (layer == null)
		{
			throw new ArgumentNullException("layer");
		}
		if (eventKey == null)
		{
			throw new ArgumentNullException("eventKey");
		}
		IntPtr intPtr = NSString.CreateNative(eventKey);
		NSObject nSObject = Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("actionForLayer:forKey:"), layer.Handle, intPtr));
		NSString.ReleaseNative(intPtr);
		return nSObject;
	}
}
