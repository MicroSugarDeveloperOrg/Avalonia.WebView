using System;
using System.Runtime.InteropServices;
using CoreFoundation;
using Foundation;
using ObjCRuntime;

namespace CoreGraphics;

public class CGPDFStream : INativeObject
{
	internal IntPtr handle;

	public IntPtr Handle => handle;

	public CGPDFDictionary Dictionary => new CGPDFDictionary(CGPDFStreamGetDictionary(handle));

	public NSData Data
	{
		get
		{
			int format;
			IntPtr obj = CGPDFStreamCopyData(handle, out format);
			NSData result = new NSData(obj);
			CFObject.CFRelease(obj);
			return result;
		}
	}

	internal CGPDFStream(IntPtr handle)
	{
		this.handle = handle;
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGPDFStreamGetDictionary(IntPtr handle);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGPDFStreamCopyData(IntPtr handle, out int format);
}
