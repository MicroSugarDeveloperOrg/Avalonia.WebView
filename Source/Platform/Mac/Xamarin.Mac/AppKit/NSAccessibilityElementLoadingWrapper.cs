using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSAccessibilityElementLoadingWrapper : BaseWrapper, INSAccessibilityElementLoading, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSAccessibilityElementLoadingWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("accessibilityElementWithToken:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSAccessibilityElement? GetAccessibilityElement(INSSecureCoding token)
	{
		NSApplication.EnsureUIThread();
		if (token == null)
		{
			throw new ArgumentNullException("token");
		}
		return Runtime.GetNSObject<NSAccessibilityElement>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("accessibilityElementWithToken:"), token.Handle));
	}
}
