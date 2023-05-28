using System;
using System.Runtime.InteropServices;
using CoreFoundation;
using Foundation;
using ObjCRuntime;

namespace CoreGraphics;

public class CGContextPDF : CGContext
{
	private bool closed;

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private unsafe static extern IntPtr CGPDFContextCreateWithURL(IntPtr url, CGRect* mediaBox, IntPtr auxiliaryInfo);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private unsafe static extern IntPtr CGPDFContextCreate(IntPtr consumer, CGRect* mediaBox, IntPtr auxiliaryInfo);

	private unsafe CGContextPDF(CGDataConsumer dataConsumer, CGRect* mediaBox, CGPDFInfo info)
	{
		using NSMutableDictionary self = info?.ToDictionary();
		base.Handle = CGPDFContextCreate(dataConsumer.GetHandle(), mediaBox, self.GetHandle());
	}

	public unsafe CGContextPDF(CGDataConsumer dataConsumer, CGRect mediaBox, CGPDFInfo info)
		: this(dataConsumer, &mediaBox, info)
	{
	}

	public unsafe CGContextPDF(CGDataConsumer dataConsumer, CGRect mediaBox)
		: this(dataConsumer, &mediaBox, null)
	{
	}

	public unsafe CGContextPDF(CGDataConsumer dataConsumer, CGPDFInfo info)
		: this(dataConsumer, null, info)
	{
	}

	public unsafe CGContextPDF(CGDataConsumer dataConsumer)
		: this(dataConsumer, null, null)
	{
	}

	private unsafe CGContextPDF(NSUrl url, CGRect* mediaBox, CGPDFInfo info)
	{
		using NSMutableDictionary self = info?.ToDictionary();
		base.Handle = CGPDFContextCreateWithURL(url.GetHandle(), mediaBox, self.GetHandle());
	}

	public unsafe CGContextPDF(NSUrl url, CGRect mediaBox, CGPDFInfo info)
		: this(url, &mediaBox, info)
	{
	}

	public unsafe CGContextPDF(NSUrl url, CGRect mediaBox)
		: this(url, &mediaBox, null)
	{
	}

	public unsafe CGContextPDF(NSUrl url, CGPDFInfo info)
		: this(url, null, info)
	{
	}

	public unsafe CGContextPDF(NSUrl url)
		: this(url, null, null)
	{
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGPDFContextClose(IntPtr context);

	public void Close()
	{
		if (!closed)
		{
			CGPDFContextClose(base.Handle);
			closed = true;
		}
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGPDFContextBeginPage(IntPtr context, IntPtr pageInfo);

	public void BeginPage(CGPDFPageInfo info)
	{
		using NSMutableDictionary nSMutableDictionary = info?.ToDictionary();
		CGPDFContextBeginPage(base.Handle, nSMutableDictionary?.Handle ?? IntPtr.Zero);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGPDFContextEndPage(IntPtr context);

	public new void EndPage()
	{
		CGPDFContextEndPage(base.Handle);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGPDFContextAddDocumentMetadata(IntPtr context, IntPtr metadata);

	public void AddDocumentMetadata(NSData data)
	{
		if (data != null)
		{
			CGPDFContextAddDocumentMetadata(base.Handle, data.Handle);
		}
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGPDFContextSetURLForRect(IntPtr context, IntPtr url, CGRect rect);

	public void SetUrl(NSUrl url, CGRect region)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		CGPDFContextSetURLForRect(base.Handle, url.Handle, region);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGPDFContextAddDestinationAtPoint(IntPtr context, IntPtr name, CGPoint point);

	public void AddDestination(string name, CGPoint point)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		using CFString cFString = new CFString(name);
		CGPDFContextAddDestinationAtPoint(base.Handle, cFString.Handle, point);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGPDFContextSetDestinationForRect(IntPtr context, IntPtr name, CGRect rect);

	public void SetDestination(string name, CGRect rect)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		using CFString cFString = new CFString(name);
		CGPDFContextSetDestinationForRect(base.Handle, cFString.Handle, rect);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	[Mac(10, 15)]
	[iOS(13, 0)]
	[TV(13, 0)]
	[Watch(6, 0)]
	private static extern void CGPDFContextBeginTag(IntPtr context, CGPdfTagType tagType, IntPtr tagProperties);

	[Mac(10, 15)]
	[iOS(13, 0)]
	[TV(13, 0)]
	[Watch(6, 0)]
	public void BeginTag(CGPdfTagType tagType, NSDictionary tagProperties)
	{
		CGPDFContextBeginTag(base.Handle, tagType, tagProperties.GetHandle());
	}

	[Mac(10, 15)]
	[iOS(13, 0)]
	[TV(13, 0)]
	[Watch(6, 0)]
	public void BeginTag(CGPdfTagType tagType, CGPdfTagProperties tagProperties)
	{
		NSDictionary self = tagProperties?.Dictionary;
		CGPDFContextBeginTag(base.Handle, tagType, self.GetHandle());
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	[Mac(10, 15)]
	[iOS(13, 0)]
	[TV(13, 0)]
	[Watch(6, 0)]
	private static extern void CGPDFContextEndTag(IntPtr context);

	[Mac(10, 15)]
	[iOS(13, 0)]
	[TV(13, 0)]
	[Watch(6, 0)]
	public void EndTag()
	{
		CGPDFContextEndTag(base.Handle);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing)
		{
			Close();
		}
		base.Dispose(disposing);
	}
}
