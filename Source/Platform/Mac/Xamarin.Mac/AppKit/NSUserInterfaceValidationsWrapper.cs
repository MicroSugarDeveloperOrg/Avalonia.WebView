using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSUserInterfaceValidationsWrapper : BaseWrapper, INSUserInterfaceValidations, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSUserInterfaceValidationsWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("validateUserInterfaceItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public bool ValidateUserInterfaceItem(INSValidatedUserInterfaceItem item)
	{
		NSApplication.EnsureUIThread();
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}
		return Messaging.bool_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("validateUserInterfaceItem:"), item.Handle);
	}
}
