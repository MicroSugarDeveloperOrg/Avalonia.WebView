using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSMenuDelegateWrapper : BaseWrapper, INSMenuDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSMenuDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("menu:willHighlightItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void MenuWillHighlightItem(NSMenu menu, NSMenuItem item)
	{
		NSApplication.EnsureUIThread();
		if (menu == null)
		{
			throw new ArgumentNullException("menu");
		}
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, Selector.GetHandle("menu:willHighlightItem:"), menu.Handle, item.Handle);
	}
}
