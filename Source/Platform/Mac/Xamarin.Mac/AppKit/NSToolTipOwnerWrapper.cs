using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSToolTipOwnerWrapper : BaseWrapper, INSToolTipOwner, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSToolTipOwnerWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("view:stringForToolTip:point:userData:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public string GetStringForToolTip(NSView view, nint tag, CGPoint point, IntPtr data)
	{
		NSApplication.EnsureUIThread();
		if (view == null)
		{
			throw new ArgumentNullException("view");
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr_nint_CGPoint_IntPtr(base.Handle, Selector.GetHandle("view:stringForToolTip:point:userData:"), view.Handle, tag, point, data));
	}
}
