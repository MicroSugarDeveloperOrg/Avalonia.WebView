using System;
using System.Runtime.InteropServices;

namespace PrintCore;

internal class NativeInvoke
{
	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/PrintCore.framework/PrintCore")]
	internal static extern int PMRetain(IntPtr obj);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/PrintCore.framework/PrintCore")]
	internal static extern int PMRelease(IntPtr obj);
}
