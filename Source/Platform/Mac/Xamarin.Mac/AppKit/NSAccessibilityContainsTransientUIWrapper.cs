using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSAccessibilityContainsTransientUIWrapper : BaseWrapper, INSAccessibilityContainsTransientUI, INativeObject, IDisposable, INSAccessibilityElementProtocol
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public bool IsAccessibilityAlternateUIVisible
	{
		[Export("isAccessibilityAlternateUIVisible")]
		get
		{
			NSApplication.EnsureUIThread();
			return Messaging.bool_objc_msgSend(base.Handle, Selector.GetHandle("isAccessibilityAlternateUIVisible"));
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
	public NSAccessibilityContainsTransientUIWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("accessibilityPerformShowAlternateUI")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public bool AccessibilityPerformShowAlternateUI()
	{
		NSApplication.EnsureUIThread();
		return Messaging.bool_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityPerformShowAlternateUI"));
	}

	[Export("accessibilityPerformShowDefaultUI")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public bool AccessibilityPerformShowDefaultUI()
	{
		NSApplication.EnsureUIThread();
		return Messaging.bool_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityPerformShowDefaultUI"));
	}
}
