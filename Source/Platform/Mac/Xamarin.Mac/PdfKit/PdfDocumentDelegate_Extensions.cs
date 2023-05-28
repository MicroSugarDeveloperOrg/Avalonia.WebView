using System;
using Foundation;
using ObjCRuntime;

namespace PdfKit;

public static class PdfDocumentDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidUnlock(this IPdfDocumentDelegate This, NSNotification notification)
	{
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("documentDidUnlock:"), notification.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidBeginDocumentFind(this IPdfDocumentDelegate This, NSNotification notification)
	{
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("documentDidBeginDocumentFind:"), notification.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidMatchString(this IPdfDocumentDelegate This, PdfSelection sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("didMatchString:"), sender.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static Class GetClassForPage(this IPdfDocumentDelegate This)
	{
		IntPtr intPtr = Messaging.IntPtr_objc_msgSend(This.Handle, Selector.GetHandle("classForPage"));
		return (intPtr == IntPtr.Zero) ? null : new Class(intPtr);
	}

	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static Class GetClassForAnnotationType(this IPdfDocumentDelegate This, string annotationType)
	{
		if (annotationType == null)
		{
			throw new ArgumentNullException("annotationType");
		}
		IntPtr intPtr = NSString.CreateNative(annotationType);
		IntPtr intPtr2 = Messaging.IntPtr_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("classForAnnotationType:"), intPtr);
		NSString.ReleaseNative(intPtr);
		return (intPtr2 == IntPtr.Zero) ? null : new Class(intPtr2);
	}

	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.MacOSX, 10, 12, PlatformArchitecture.None, "Use 'GetClassForAnnotationType' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static Class ClassForAnnotationClass(this IPdfDocumentDelegate This, Class sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		IntPtr intPtr = Messaging.IntPtr_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("classForAnnotationClass:"), sender.Handle);
		return (intPtr == IntPtr.Zero) ? null : new Class(intPtr);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void FindFinished(this IPdfDocumentDelegate This, NSNotification notification)
	{
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("documentDidEndDocumentFind:"), notification.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void PageFindStarted(this IPdfDocumentDelegate This, NSNotification notification)
	{
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("documentDidBeginPageFind:"), notification.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void PageFindFinished(this IPdfDocumentDelegate This, NSNotification notification)
	{
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("documentDidEndPageFind:"), notification.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void MatchFound(this IPdfDocumentDelegate This, NSNotification notification)
	{
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("documentDidFindMatch:"), notification.Handle);
	}
}
