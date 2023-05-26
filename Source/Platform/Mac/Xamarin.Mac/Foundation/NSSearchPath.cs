using System;
using System.Runtime.InteropServices;

namespace Foundation;

public static class NSSearchPath
{
	public static string[] GetDirectories(NSSearchPathDirectory directory, NSSearchPathDomain domainMask, bool expandTilde = true)
	{
		return NSArray.StringArrayFromHandle(NSSearchPathForDirectoriesInDomains(directory, domainMask, expandTilde));
	}

	[DllImport("/System/Library/Frameworks/Foundation.framework/Foundation")]
	private static extern IntPtr NSSearchPathForDirectoriesInDomains(NSSearchPathDirectory directory, NSSearchPathDomain domainMask, bool expandTilde);
}
