using System;
using Foundation;
using ObjCRuntime;

namespace QuickLookUI;

public static class QLPreviewPanelController
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAcceptsPreviewPanelControl_ = "acceptsPreviewPanelControl:";

	private static readonly IntPtr selAcceptsPreviewPanelControl_Handle = Selector.GetHandle("acceptsPreviewPanelControl:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBeginPreviewPanelControl_ = "beginPreviewPanelControl:";

	private static readonly IntPtr selBeginPreviewPanelControl_Handle = Selector.GetHandle("beginPreviewPanelControl:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEndPreviewPanelControl_ = "endPreviewPanelControl:";

	private static readonly IntPtr selEndPreviewPanelControl_Handle = Selector.GetHandle("endPreviewPanelControl:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = Class.GetHandle("NSObject");

	[Export("acceptsPreviewPanelControl:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool AcceptsPreviewPanelControl(this NSObject This, QLPreviewPanel panel)
	{
		if (panel == null)
		{
			throw new ArgumentNullException("panel");
		}
		return Messaging.bool_objc_msgSend_IntPtr(This.Handle, selAcceptsPreviewPanelControl_Handle, panel.Handle);
	}

	[Export("beginPreviewPanelControl:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void BeginPreviewPanelControl(this NSObject This, QLPreviewPanel panel)
	{
		if (panel == null)
		{
			throw new ArgumentNullException("panel");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, selBeginPreviewPanelControl_Handle, panel.Handle);
	}

	[Export("endPreviewPanelControl:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void EndPreviewPanelControl(this NSObject This, QLPreviewPanel panel)
	{
		if (panel == null)
		{
			throw new ArgumentNullException("panel");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, selEndPreviewPanelControl_Handle, panel.Handle);
	}
}
