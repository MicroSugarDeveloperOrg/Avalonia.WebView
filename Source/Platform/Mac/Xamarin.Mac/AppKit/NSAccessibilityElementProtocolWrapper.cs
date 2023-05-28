using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSAccessibilityElementProtocolWrapper : BaseWrapper, INSAccessibilityElementProtocol, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CGRect AccessibilityFrame
	{
		[Export("accessibilityFrame")]
		get
		{
			NSApplication.EnsureUIThread();
			Messaging.CGRect_objc_msgSend_stret(out var retval, base.Handle, Selector.GetHandle("accessibilityFrame"));
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSObject? AccessibilityParent
	{
		[Export("accessibilityParent")]
		get
		{
			NSApplication.EnsureUIThread();
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityParent")));
		}
	}

	[Preserve(Conditional = true)]
	public NSAccessibilityElementProtocolWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
