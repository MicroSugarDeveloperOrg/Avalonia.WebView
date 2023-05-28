using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace ImageKit;

public static class IKImageEditPanelDataSource_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CGImage GetThumbnail(this IIKImageEditPanelDataSource This, CGSize maximumSize)
	{
		IntPtr intPtr = Messaging.IntPtr_objc_msgSend_CGSize(This.Handle, Selector.GetHandle("thumbnailWithMaximumSize:"), maximumSize);
		return (intPtr == IntPtr.Zero) ? null : new CGImage(intPtr);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSDictionary GetImageProperties(this IIKImageEditPanelDataSource This)
	{
		return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(This.Handle, Selector.GetHandle("imageProperties")));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool GetHasAdjustMode(this IIKImageEditPanelDataSource This)
	{
		return Messaging.bool_objc_msgSend(This.Handle, Selector.GetHandle("hasAdjustMode"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool GetHasEffectsMode(this IIKImageEditPanelDataSource This)
	{
		return Messaging.bool_objc_msgSend(This.Handle, Selector.GetHandle("hasEffectsMode"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool GetHasDetailsMode(this IIKImageEditPanelDataSource This)
	{
		return Messaging.bool_objc_msgSend(This.Handle, Selector.GetHandle("hasDetailsMode"));
	}
}
