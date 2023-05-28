using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

public static class NSStandardKeyBindingMethods
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selQuickLookPreviewItems_ = "quickLookPreviewItems:";

	private static readonly IntPtr selQuickLookPreviewItems_Handle = Selector.GetHandle("quickLookPreviewItems:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = Class.GetHandle("NSResponder");

	[Export("quickLookPreviewItems:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void QuickLookPreviewItems(this NSResponder This, NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, selQuickLookPreviewItems_Handle, sender.Handle);
	}
}
