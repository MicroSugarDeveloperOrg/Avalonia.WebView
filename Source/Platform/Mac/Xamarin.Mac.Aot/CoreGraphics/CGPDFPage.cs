using System;
using System.Runtime.InteropServices;
using ObjCRuntime;

namespace CoreGraphics;

public class CGPDFPage : INativeObject, IDisposable
{
	private CGPDFDocument doc;

	internal IntPtr handle;

	public CGPDFDocument Document => doc;

	public int PageNumber => CGPDFPageGetPageNumber(handle);

	public int RotationAngle => CGPDFPageGetRotationAngle(handle);

	public CGPDFDictionary Dictionary => new CGPDFDictionary(CGPDFPageGetDictionary(handle));

	public IntPtr Handle => handle;

	public CGPDFPage(IntPtr handle)
	{
		if (handle == IntPtr.Zero)
		{
			throw new Exception("Invalid parameters to CGPDFPage creation");
		}
		CGPDFPageRetain(handle);
		this.handle = handle;
	}

	internal CGPDFPage(CGPDFDocument doc, IntPtr handle)
	{
		this.doc = doc;
		this.handle = handle;
		CGPDFPageRetain(handle);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern int CGPDFPageGetPageNumber(IntPtr handle);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern CGRect CGPDFPageGetBoxRect(IntPtr handle, CGPDFBox box);

	public CGRect GetBoxRect(CGPDFBox box)
	{
		return CGPDFPageGetBoxRect(handle, box);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern int CGPDFPageGetRotationAngle(IntPtr handle);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern CGAffineTransform CGPDFPageGetDrawingTransform(IntPtr handle, CGPDFBox box, CGRect rect, int rotate, int preserveAspectRatio);

	public CGAffineTransform GetDrawingTransform(CGPDFBox box, CGRect rect, int rotate, bool preserveAspectRatio)
	{
		return CGPDFPageGetDrawingTransform(handle, box, rect, rotate, preserveAspectRatio ? 1 : 0);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGPDFPageGetDictionary(IntPtr pageHandle);

	~CGPDFPage()
	{
		Dispose(disposing: false);
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGPDFPageRetain(IntPtr handle);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGPDFPageRelease(IntPtr handle);

	protected virtual void Dispose(bool disposing)
	{
		if (handle != IntPtr.Zero)
		{
			CGPDFPageRelease(handle);
			handle = IntPtr.Zero;
		}
	}
}
