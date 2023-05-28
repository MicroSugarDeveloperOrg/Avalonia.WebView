using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
public static class NSObject_NSToolbarItemValidation
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValidateToolbarItem_ = "validateToolbarItem:";

	private static readonly IntPtr selValidateToolbarItem_Handle = Selector.GetHandle("validateToolbarItem:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = Class.GetHandle("NSObject");

	[Export("validateToolbarItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ValidateToolbarItem(this NSObject This, NSToolbarItem item)
	{
		NSApplication.EnsureUIThread();
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}
		return Messaging.bool_objc_msgSend_IntPtr(This.Handle, selValidateToolbarItem_Handle, item.Handle);
	}
}
