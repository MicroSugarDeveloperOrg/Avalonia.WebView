using System;
using System.Runtime.InteropServices;
using Foundation;

namespace CoreGraphics;

public class CGContextPDF : CGContext
{
	private bool closed;

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGPDFContextCreateWithURL(IntPtr url, ref CGRect rect, IntPtr dictionary);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGPDFContextCreateWithURL(IntPtr url, IntPtr rect, IntPtr dictionary);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGPDFContextCreate(IntPtr dataConsumer, ref CGRect rect, IntPtr dictionary);

	public CGContextPDF(CGDataConsumer dataConsumer, CGRect mediaBox, CGPDFInfo info)
	{
		if (dataConsumer == null)
		{
			throw new ArgumentNullException("dataConsumer");
		}
		handle = CGPDFContextCreate(dataConsumer.Handle, ref mediaBox, info?.ToDictionary().Handle ?? IntPtr.Zero);
	}

	public CGContextPDF(NSUrl url, CGRect mediaBox, CGPDFInfo info)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		handle = CGPDFContextCreateWithURL(url.Handle, ref mediaBox, info?.ToDictionary().Handle ?? IntPtr.Zero);
	}

	public CGContextPDF(NSUrl url, CGRect mediaBox)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		handle = CGPDFContextCreateWithURL(url.Handle, ref mediaBox, IntPtr.Zero);
	}

	public CGContextPDF(NSUrl url, CGPDFInfo info)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		handle = CGPDFContextCreateWithURL(url.Handle, IntPtr.Zero, info?.ToDictionary().Handle ?? IntPtr.Zero);
	}

	public CGContextPDF(NSUrl url)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		handle = CGPDFContextCreateWithURL(url.Handle, IntPtr.Zero, IntPtr.Zero);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGPDFContextClose(IntPtr handle);

	public void Close()
	{
		if (!closed)
		{
			CGPDFContextClose(handle);
			closed = true;
		}
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGPDFContextBeginPage(IntPtr handle, IntPtr dict);

	public void BeginPage(CGPDFPageInfo info)
	{
		CGPDFContextBeginPage(handle, info?.ToDictionary().Handle ?? IntPtr.Zero);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGPDFContextEndPage(IntPtr handle);

	public new void EndPage()
	{
		CGPDFContextEndPage(handle);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGPDFContextAddDocumentMetadata(IntPtr handle, IntPtr nsDataHandle);

	public void AddDocumentMetadata(NSData data)
	{
		if (data != null)
		{
			CGPDFContextAddDocumentMetadata(handle, data.Handle);
		}
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGPDFContextSetURLForRect(IntPtr handle, IntPtr urlh, CGRect rect);

	public void SetUrl(NSUrl url, CGRect region)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		CGPDFContextSetURLForRect(handle, url.Handle, region);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGPDFContextAddDestinationAtPoint(IntPtr handle, IntPtr cfstring, CGPoint point);

	public void AddDestination(string name, CGPoint point)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		CGPDFContextAddDestinationAtPoint(handle, new NSString(name).Handle, point);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGPDFContextSetDestinationForRect(IntPtr handle, IntPtr cfstr, CGRect rect);

	public void SetDestination(string name, CGRect rect)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		CGPDFContextSetDestinationForRect(handle, new NSString(name).Handle, rect);
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
