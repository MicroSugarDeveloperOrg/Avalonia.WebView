using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

public static class NSStackViewDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void WillDetachViews(this INSStackViewDelegate This, NSStackView stackView, NSView[] views)
	{
		NSApplication.EnsureUIThread();
		if (stackView == null)
		{
			throw new ArgumentNullException("stackView");
		}
		if (views == null)
		{
			throw new ArgumentNullException("views");
		}
		NSArray nSArray = NSArray.FromNSObjects(views);
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("stackView:willDetachViews:"), stackView.Handle, nSArray.Handle);
		nSArray.Dispose();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidReattachViews(this INSStackViewDelegate This, NSStackView stackView, NSView[] views)
	{
		NSApplication.EnsureUIThread();
		if (stackView == null)
		{
			throw new ArgumentNullException("stackView");
		}
		if (views == null)
		{
			throw new ArgumentNullException("views");
		}
		NSArray nSArray = NSArray.FromNSObjects(views);
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("stackView:didReattachViews:"), stackView.Handle, nSArray.Handle);
		nSArray.Dispose();
	}
}
