using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace PdfKit;

[Protocol(Name = "PDFViewDelegate")]
[Register("PDFViewDelegate", false)]
[Model]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public class PdfViewDelegate : NSObject, IPdfViewDelegate, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public PdfViewDelegate()
		: base(NSObjectFlag.Empty)
	{
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected PdfViewDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal PdfViewDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("PDFViewOpenPDF:forRemoteGoToAction:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void OpenPdf(PdfView sender, PdfActionRemoteGoTo action)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("PDFViewPerformFind:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PerformFind(PdfView sender)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("PDFViewPerformGoToPage:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PerformGoToPage(PdfView sender)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("PDFViewPerformPrint:")]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PerformPrint(PdfView sender)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("PDFViewPrintJobTitle:")]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string TitleOfPrintJob(PdfView sender)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("PDFViewWillChangeScaleFactor:toScale:")]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat WillChangeScaleFactor(PdfView sender, nfloat scale)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("PDFViewWillClickOnLink:withURL:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WillClickOnLink(PdfView sender, NSUrl url)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
