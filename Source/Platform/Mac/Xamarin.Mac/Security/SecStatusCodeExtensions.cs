using System;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace Security;

public static class SecStatusCodeExtensions
{
	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	[iOS(11, 3)]
	[TV(11, 3)]
	[Watch(4, 3)]
	private static extern IntPtr SecCopyErrorMessageString(SecStatusCode status, IntPtr reserved);

	[iOS(11, 3)]
	[TV(11, 3)]
	[Watch(4, 3)]
	public static string GetStatusDescription(this SecStatusCode status)
	{
		IntPtr ptr = SecCopyErrorMessageString(status, IntPtr.Zero);
		return Runtime.GetNSObject<NSString>(ptr, owns: true);
	}
}
