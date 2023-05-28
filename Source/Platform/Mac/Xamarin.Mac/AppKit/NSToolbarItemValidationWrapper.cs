using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSToolbarItemValidationWrapper : BaseWrapper, INSToolbarItemValidation, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSToolbarItemValidationWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("validateToolbarItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public bool ValidateToolbarItem(NSToolbarItem item)
	{
		NSApplication.EnsureUIThread();
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}
		return Messaging.bool_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("validateToolbarItem:"), item.Handle);
	}
}
