using System.Runtime.InteropServices;
using Xamarin.Mac.System.Mac;

namespace CoreFoundation;

public class CFType
{
	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation", EntryPoint = "CFGetTypeID")]
	public static extern nint GetTypeID(IntPtr typeRef);

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

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern bool CFEqual(IntPtr cf1, IntPtr cf2);

	public static bool Equal(IntPtr cf1, IntPtr cf2)
	{
		if (cf1 == IntPtr.Zero)
		{
			return cf2 == IntPtr.Zero;
		}
		if (cf2 == IntPtr.Zero)
		{
			return false;
		}
		return CFEqual(cf1, cf2);
	}
}
