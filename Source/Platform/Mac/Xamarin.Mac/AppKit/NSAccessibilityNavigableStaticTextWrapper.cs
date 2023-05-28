using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSAccessibilityNavigableStaticTextWrapper : BaseWrapper, INSAccessibilityNavigableStaticText, INativeObject, IDisposable, INSAccessibilityElementProtocol, INSAccessibilityStaticText
{
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public string? AccessibilityValue
	{
		[Export("accessibilityValue")]
		get
		{
			NSApplication.EnsureUIThread();
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityValue")));
		}
	}

	[Preserve(Conditional = true)]
	public NSAccessibilityNavigableStaticTextWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("accessibilityStringForRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public string? GetAccessibilityString(NSRange range)
	{
		NSApplication.EnsureUIThread();
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_NSRange(base.Handle, Selector.GetHandle("accessibilityStringForRange:"), range));
	}

	[Export("accessibilityLineForIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public nint GetAccessibilityLine(nint index)
	{
		NSApplication.EnsureUIThread();
		return Messaging.nint_objc_msgSend_nint(base.Handle, Selector.GetHandle("accessibilityLineForIndex:"), index);
	}

	[Export("accessibilityRangeForLine:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSRange GetAccessibilityRangeForLine(nint lineNumber)
	{
		NSApplication.EnsureUIThread();
		return Messaging.NSRange_objc_msgSend_nint(base.Handle, Selector.GetHandle("accessibilityRangeForLine:"), lineNumber);
	}

	[Export("accessibilityFrameForRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CGRect GetAccessibilityFrame(NSRange range)
	{
		NSApplication.EnsureUIThread();
		Messaging.CGRect_objc_msgSend_stret_NSRange(out var retval, base.Handle, Selector.GetHandle("accessibilityFrameForRange:"), range);
		return retval;
	}
}
