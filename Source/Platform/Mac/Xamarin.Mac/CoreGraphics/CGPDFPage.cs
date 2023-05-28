using System;
using System.Runtime.InteropServices;
using ObjCRuntime;

namespace CoreGraphics;

public class CGPDFPage : INativeObject, IDisposable
{
	internal IntPtr handle;

	public IntPtr Handle => handle;

	public CGPDFDocument Document => new CGPDFDocument(CGPDFPageGetDocument(handle));

	public nint PageNumber => CGPDFPageGetPageNumber(handle);

	public int RotationAngle => CGPDFPageGetRotationAngle(handle);

	public CGPDFDictionary Dictionary => new CGPDFDictionary(CGPDFPageGetDictionary(handle));

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
	private static extern IntPtr CGPDFPageRetain(IntPtr page);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGPDFPageRelease(IntPtr page);

	protected virtual void Dispose(bool disposing)
	{
		if (handle != IntPtr.Zero)
		{
			CGPDFPageRelease(handle);
			handle = IntPtr.Zero;
		}
	}

	public CGPDFPage(IntPtr handle)
	{
		if (handle == IntPtr.Zero)
		{
			throw new Exception("Invalid parameters to CGPDFPage creation");
		}
		CGPDFPageRetain(handle);
		this.handle = handle;
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGPDFPageGetDocument(IntPtr page);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern nint CGPDFPageGetPageNumber(IntPtr page);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern CGRect CGPDFPageGetBoxRect(IntPtr page, CGPDFBox box);

	public CGRect GetBoxRect(CGPDFBox box)
	{
		return CGPDFPageGetBoxRect(handle, box);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern int CGPDFPageGetRotationAngle(IntPtr page);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern CGAffineTransform CGPDFPageGetDrawingTransform(IntPtr page, CGPDFBox box, CGRect rect, int rotate, bool preserveAspectRatio);

	public CGAffineTransform GetDrawingTransform(CGPDFBox box, CGRect rect, int rotate, bool preserveAspectRatio)
	{
		return CGPDFPageGetDrawingTransform(handle, box, rect, rotate, preserveAspectRatio);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGPDFPageGetDictionary(IntPtr page);
}
