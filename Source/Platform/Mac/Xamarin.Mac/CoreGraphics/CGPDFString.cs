using System;
using System.Runtime.InteropServices;
using CoreFoundation;

namespace CoreGraphics;

internal static class CGPDFString
{
	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGPDFStringCopyTextString(IntPtr pdfStr);

	public static string ToString(IntPtr pdfString)
	{
		if (pdfString == IntPtr.Zero)
		{
			return null;
		}
		using CFString cFString = new CFString(CGPDFStringCopyTextString(pdfString), owns: true);
		return cFString.ToString();
	}
}
