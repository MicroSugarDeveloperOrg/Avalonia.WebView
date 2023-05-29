using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace PdfKit;

[Register("PdfViewDelegate", true)]
[Model]
public class PdfViewDelegate : NSObject
{
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public PdfViewDelegate()
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public PdfViewDelegate(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public PdfViewDelegate(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public PdfViewDelegate(IntPtr handle)
		: base(handle)
	{
	}

	[Export("PDFViewWillChangeScaleFactor:toScale:")]
	public virtual float WillChangeScaleFactor(PdfView sender, float scale)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("PDFViewWillClickOnLink:withURL:")]
	public virtual void WillClickOnLink(PdfView sender, NSUrl url)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("PDFViewPrintJobTitle:")]
	public virtual string TitleOfPrintJob(PdfView sender)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("PDFViewPerformFind:")]
	public virtual void PerformFind(PdfView sender)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("PDFViewPerformGoToPage:")]
	public virtual void PerformGoToPage(PdfView sender)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("PDFViewPerformPrint:")]
	public virtual void PerformPrint(PdfView sender)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("PDFViewOpenPDF:forRemoteGoToAction:")]
	public virtual void OpenPdf(PdfView sender, PdfActionRemoteGoTo action)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
