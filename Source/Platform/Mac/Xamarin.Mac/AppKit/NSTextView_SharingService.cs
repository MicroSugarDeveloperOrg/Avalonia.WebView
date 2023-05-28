using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

public static class NSTextView_SharingService
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOrderFrontSharingServicePicker_ = "orderFrontSharingServicePicker:";

	private static readonly IntPtr selOrderFrontSharingServicePicker_Handle = Selector.GetHandle("orderFrontSharingServicePicker:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = Class.GetHandle("NSTextView");

	[Export("orderFrontSharingServicePicker:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void OrderFrontSharingServicePicker(this NSTextView This, NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, selOrderFrontSharingServicePicker_Handle, sender.Handle);
	}
}
