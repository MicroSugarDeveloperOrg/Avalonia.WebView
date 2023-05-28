using System;
using System.Runtime.InteropServices;

namespace CoreBluetooth;

internal static class CFUUID
{
	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	public static extern IntPtr CFUUIDCreateFromString(IntPtr alloc, IntPtr uuidStr);
}
