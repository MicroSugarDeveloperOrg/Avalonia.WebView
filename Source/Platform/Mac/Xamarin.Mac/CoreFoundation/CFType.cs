using System;
using System.Runtime.InteropServices;

namespace CoreFoundation;

public class CFType
{
	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation", EntryPoint = "CFGetTypeID")]
	public static extern int GetTypeID(IntPtr typeRef);

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern IntPtr CFCopyDescription(IntPtr ptr);

	public string GetDescription(IntPtr handle)
	{
		if (handle == IntPtr.Zero)
		{
			throw new ArgumentNullException("handle");
		}
		using CFString cFString = new CFString(CFCopyDescription(handle));
		return cFString.ToString();
	}
}
