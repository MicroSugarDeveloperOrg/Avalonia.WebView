using System;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace CoreGraphics;

public class CGPDFStream : INativeObject
{
	internal IntPtr handle;

	public IntPtr Handle => handle;

	public CGPDFDictionary Dictionary => new CGPDFDictionary(CGPDFStreamGetDictionary(handle));

	internal CGPDFStream(IntPtr handle)
	{
		this.handle = handle;
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGPDFStreamGetDictionary(IntPtr stream);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGPDFStreamCopyData(IntPtr stream, out CGPDFDataFormat format);

	public NSData GetData(out CGPDFDataFormat format)
	{
		IntPtr ptr = CGPDFStreamCopyData(handle, out format);
		return Runtime.GetNSObject<NSData>(ptr, owns: true);
	}
}
