using System;
using Foundation;
using ObjCRuntime;

namespace PdfKit;

public static class PdfViewDelegate_Extensions
{
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static nfloat WillChangeScaleFactor(this IPdfViewDelegate This, PdfView sender, nfloat scale)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		return Messaging.nfloat_objc_msgSend_IntPtr_nfloat(This.Handle, Selector.GetHandle("PDFViewWillChangeScaleFactor:toScale:"), sender.Handle, scale);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void WillClickOnLink(this IPdfViewDelegate This, PdfView sender, NSUrl url)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("PDFViewWillClickOnLink:withURL:"), sender.Handle, url.Handle);
	}

	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string TitleOfPrintJob(this IPdfViewDelegate This, PdfView sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("PDFViewPrintJobTitle:"), sender.Handle));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void PerformFind(this IPdfViewDelegate This, PdfView sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("PDFViewPerformFind:"), sender.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void PerformGoToPage(this IPdfViewDelegate This, PdfView sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("PDFViewPerformGoToPage:"), sender.Handle);
	}

	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void PerformPrint(this IPdfViewDelegate This, PdfView sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("PDFViewPerformPrint:"), sender.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void OpenPdf(this IPdfViewDelegate This, PdfView sender, PdfActionRemoteGoTo action)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (action == null)
		{
			throw new ArgumentNullException("action");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("PDFViewOpenPDF:forRemoteGoToAction:"), sender.Handle, action.Handle);
	}
}
