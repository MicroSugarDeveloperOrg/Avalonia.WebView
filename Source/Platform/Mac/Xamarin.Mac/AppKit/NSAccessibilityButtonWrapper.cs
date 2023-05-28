using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSAccessibilityButtonWrapper : BaseWrapper, INSAccessibilityButton, INativeObject, IDisposable, INSAccessibilityElementProtocol
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public string? AccessibilityLabel
	{
		[Export("accessibilityLabel")]
		get
		{
			NSApplication.EnsureUIThread();
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityLabel")));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
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
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
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
	public NSAccessibilityButtonWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("accessibilityPerformPress")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public bool AccessibilityPerformPress()
	{
		NSApplication.EnsureUIThread();
		return Messaging.bool_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityPerformPress"));
	}
}
