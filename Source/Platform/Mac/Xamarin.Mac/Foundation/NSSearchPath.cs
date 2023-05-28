using System;
using System.Runtime.InteropServices;

namespace Foundation;

public static class NSSearchPath
{
	public static string[] GetDirectories(NSSearchPathDirectory directory, NSSearchPathDomain domainMask, bool expandTilde = true)
	{
		return NSArray.StringArrayFromHandle(NSSearchPathForDirectoriesInDomains((nuint)(ulong)directory, (nuint)(ulong)domainMask, expandTilde));
	}

	[DllImport("/System/Library/Frameworks/Foundation.framework/Foundation")]
	private static extern IntPtr NSSearchPathForDirectoriesInDomains(nuint directory, nuint domainMask, bool expandTilde);
}
