using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSMenuValidationWrapper : BaseWrapper, INSMenuValidation, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSMenuValidationWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("validateMenuItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public bool ValidateMenuItem(NSMenuItem menuItem)
	{
		NSApplication.EnsureUIThread();
		if (menuItem == null)
		{
			throw new ArgumentNullException("menuItem");
		}
		return Messaging.bool_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("validateMenuItem:"), menuItem.Handle);
	}
}
