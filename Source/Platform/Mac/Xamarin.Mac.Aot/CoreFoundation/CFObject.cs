using System;
using System.Runtime.InteropServices;

namespace CoreFoundation;

public static class CFObject
{
	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	internal static extern void CFRelease(IntPtr obj);

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	internal static extern IntPtr CFRetain(IntPtr obj);
}
