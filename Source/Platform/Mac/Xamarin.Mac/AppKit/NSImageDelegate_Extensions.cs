using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

public static class NSImageDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSImage ImageDidNotDraw(this INSImageDelegate This, NSObject sender, CGRect aRect)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		return Runtime.GetNSObject<NSImage>(Messaging.IntPtr_objc_msgSend_IntPtr_CGRect(This.Handle, Selector.GetHandle("imageDidNotDraw:inRect:"), sender.Handle, aRect));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void WillLoadRepresentation(this INSImageDelegate This, NSImage image, NSImageRep rep)
	{
		NSApplication.EnsureUIThread();
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		if (rep == null)
		{
			throw new ArgumentNullException("rep");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("image:willLoadRepresentation:"), image.Handle, rep.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidLoadRepresentationHeader(this INSImageDelegate This, NSImage image, NSImageRep rep)
	{
		NSApplication.EnsureUIThread();
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		if (rep == null)
		{
			throw new ArgumentNullException("rep");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("image:didLoadRepresentationHeader:"), image.Handle, rep.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidLoadPartOfRepresentation(this INSImageDelegate This, NSImage image, NSImageRep rep, nint rows)
	{
		NSApplication.EnsureUIThread();
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		if (rep == null)
		{
			throw new ArgumentNullException("rep");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_nint(This.Handle, Selector.GetHandle("image:didLoadPartOfRepresentation:withValidRows:"), image.Handle, rep.Handle, rows);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidLoadRepresentation(this INSImageDelegate This, NSImage image, NSImageRep rep, NSImageLoadStatus status)
	{
		NSApplication.EnsureUIThread();
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		if (rep == null)
		{
			throw new ArgumentNullException("rep");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_UInt64(This.Handle, Selector.GetHandle("image:didLoadRepresentation:withStatus:"), image.Handle, rep.Handle, (ulong)status);
	}
}
