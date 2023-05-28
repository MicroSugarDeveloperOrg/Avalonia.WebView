using System;
using System.Runtime.InteropServices;
using ObjCRuntime;

namespace CoreGraphics;

[Mac(10, 15)]
[iOS(13, 0)]
[TV(13, 0)]
[Watch(6, 0)]
public static class CGPdfTagType_Extensions
{
	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGPDFTagTypeGetName(CGPdfTagType tagType);

	public static string GetName(this CGPdfTagType self)
	{
		return Marshal.PtrToStringAnsi(CGPDFTagTypeGetName(self));
	}
}
